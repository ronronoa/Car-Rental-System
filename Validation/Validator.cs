using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VehicleRental.Validation
{
    public class Validator
    {
        private readonly List<Func<bool>> _rules = new List<Func<bool>>();
        
        private readonly Dictionary<Guna2TextBox, Color> _originalBorderColors = new Dictionary<Guna2TextBox, Color>();
        private readonly Dictionary<Guna2ComboBox, Color> _originalComboColors = new Dictionary<Guna2ComboBox, Color>();

        private readonly ToolTip _toolTip;
        private readonly Color _errorBorderColor = Color.Red;

        public Validator()
        {
            _toolTip = new ToolTip
            {
                InitialDelay = 100,
                ReshowDelay = 100,
                AutoPopDelay = 5000,
                ShowAlways = true,
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Warning,
                ToolTipTitle = "Validation Error"
            };
        }

        public void Clear()
        {
            foreach (var kvp in _originalBorderColors)
            {
                kvp.Key.BorderColor = kvp.Value;
                kvp.Key.HoverState.BorderColor = kvp.Value;
                kvp.Key.FocusedState.BorderColor = kvp.Value;
                _toolTip.SetToolTip(kvp.Key, null);
            }

            foreach (var kvp in _originalComboColors)
            {
                kvp.Key.BorderColor = kvp.Value;
                kvp.Key.HoverState.BorderColor = kvp.Value;
                kvp.Key.FocusedState.BorderColor = kvp.Value;
                _toolTip.SetToolTip(kvp.Key, null);
            }

            _originalBorderColors.Clear();
            _originalComboColors.Clear();
            _rules.Clear();
        }

        private void SetError(Control control, bool isValid, string message)
        {
            if (control is Guna2TextBox gunaTxt)
            {
                if (!_originalBorderColors.ContainsKey(gunaTxt))
                {
                    _originalBorderColors[gunaTxt] = gunaTxt.BorderColor;
                }

                if (isValid)
                {
                    if (gunaTxt.BorderColor == _errorBorderColor)
                    {
                        gunaTxt.BorderColor = _originalBorderColors[gunaTxt];
                        gunaTxt.HoverState.BorderColor = _originalBorderColors[gunaTxt];
                        gunaTxt.FocusedState.BorderColor = _originalBorderColors[gunaTxt];
                    }
                    _toolTip.SetToolTip(gunaTxt, null);
                }
                else
                {
                    gunaTxt.BorderColor = _errorBorderColor;
                    gunaTxt.HoverState.BorderColor = _errorBorderColor;
                    gunaTxt.FocusedState.BorderColor = _errorBorderColor;
                    _toolTip.SetToolTip(gunaTxt, message);
                }
            }
            else if (control is Guna2ComboBox gunaCmb)
            {
                if (!_originalComboColors.ContainsKey(gunaCmb))
                {
                    _originalComboColors[gunaCmb] = gunaCmb.BorderColor;
                }

                if (isValid)
                {
                    if (gunaCmb.BorderColor == _errorBorderColor)
                    {
                        gunaCmb.BorderColor = _originalComboColors[gunaCmb];
                        gunaCmb.HoverState.BorderColor = _originalComboColors[gunaCmb];
                        gunaCmb.FocusedState.BorderColor = _originalComboColors[gunaCmb];
                    }
                    _toolTip.SetToolTip(gunaCmb, null);
                }
                else
                {
                    gunaCmb.BorderColor = _errorBorderColor;
                    gunaCmb.HoverState.BorderColor = _errorBorderColor;
                    gunaCmb.FocusedState.BorderColor = _errorBorderColor;
                    _toolTip.SetToolTip(gunaCmb, message);
                }
            }
        }

        public void Required(Control control, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = !string.IsNullOrWhiteSpace(control.Text);
                SetError(control, isValid, message);
                return isValid;
            });
        }

        public void Required(ComboBox comboBox, string message)
        {
            if (comboBox is Guna2ComboBox gunaCmb)
            {
                _rules.Add(() =>
                {
                    bool isValid = gunaCmb.SelectedIndex > -1;
                    SetError(gunaCmb, isValid, message);
                    return isValid;
                });
            }
            else
            {
                _rules.Add(() =>
                {
                    bool isValid = comboBox.SelectedIndex > -1;
                    return isValid;
                });
            }
        }
        
        public void Required(Guna2ComboBox comboBox, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = comboBox.SelectedIndex > -1;
                SetError(comboBox, isValid, message);
                return isValid;
            });
        }

        public void IsInteger(Control control, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = int.TryParse(control.Text, out _);
                SetError(control, isValid, message);
                return isValid;
            });
        }

        public void IsPhoneNumber(Control control, string message)
        {
            _rules.Add(() =>
            {
                string input = control.Text;

                if (string.IsNullOrWhiteSpace(input))
                {
                    SetError(control, true, message);
                    return true;
                }

                string cleaned = Regex.Replace(input, @"[^\d+]", "");

                if (cleaned.StartsWith("09") && cleaned.Length == 11)
                {
                    cleaned = "+63" + cleaned.Substring(1);
                }
                else if (cleaned.StartsWith("9") && cleaned.Length == 10)
                {
                    cleaned = "+63" + cleaned;
                }
                else if (cleaned.StartsWith("639") && cleaned.Length == 12)
                {
                    cleaned = "+" + cleaned;
                }

                bool isValid = Regex.IsMatch(cleaned, @"^\+639\d{9}$");

                if (isValid && control.Text != cleaned)
                {
                    control.Text = cleaned;
                }

                SetError(control, isValid, message);
                return isValid;
            });
        }

        public void IsEmail(Control control, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = Regex.IsMatch(control.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                SetError(control, isValid, message);
                return isValid;
            });
        }

        public void Custom(Control control, Func<bool> validationFunc, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = validationFunc();
                SetError(control, isValid, message);
                return isValid;
            });
        }

        public bool Validate()
        {
            bool isValid = true;

            foreach (var rule in _rules)
            {
                if (!rule())
                {
                    isValid = false;
                }
            }

            return isValid; 
        }
    }
}
