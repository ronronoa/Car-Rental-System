using PL_VehicleRental.DAL.Repositories;
using PL_VehicleRental.Services;
using PL_VehicleRental.Services.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Forms
{
    public partial class frmProfile : Form
    {
        private const long MaxFileSize = 2 * 1024 * 1024;
        private bool _isSubmitting;
        private bool _isImageChanged;
        private readonly userRepository _repository;
        private string _originalUserName;
        private string _originalImagePath;
        
        public frmProfile()
        {
            InitializeComponent();
            _repository = new userRepository();
            _isImageChanged = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();
            UpdateEditButtonState();

            txtUsername.TextChanged += OnUserDataChanged;
        }

        private void LoadUserImage()
        {
            try
            {
                if (Session.User == null) return;

                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    AppDomain.CurrentDomain.BaseDirectory, "UserImages");

                string fullPath = Path.Combine(folder, Session.User.UserImagePath ?? "");

                if (!string.IsNullOrWhiteSpace(Session.User.UserImagePath) && File.Exists(fullPath))
                {
                    userImage.Image = Image.FromFile(fullPath);
                }
                else
                {
                    userImage.Image = Properties.Resources.avatar_default;
                }
            }
            catch
            {
                userImage.Image = Properties.Resources.avatar_default;
            }
        }

        private void LoadCurrentUser()
        {
            if (Session.User != null)
            {
                txtFullName.Text = $"{Session.User.FullName}";
                txtUsername.Text = $"{Session.User.UserName}";
                lblRole.Text = $"{Session.User.Role}";
                lblStatus.Text = $"{Session.User.Status}";
                LoadUserImage();

                _originalUserName = Session.User.UserName;
                _originalImagePath = Session.User.UserImagePath;
            }

        }

        private void UpdateEditButtonState()
        {
            if (btnSave == null) return;

            bool hasChanges = HasUserDataChanged();

            btnSave.Enabled = hasChanges;
            userImage.Enabled = true;
            txtFullName.ReadOnly = true;
            txtFullName.Enabled = false;
        }

        private bool HasUserDataChanged()
        {
            return txtUsername.Text.Trim() != (_originalUserName ?? "").Trim()
                   || _isImageChanged;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_isSubmitting) return;

            if (!HasUserDataChanged())
            {
                MessageBox.Show(
                    "No changes were made.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            btnSave.Enabled = false;

            try
            {
                _isSubmitting = true;

                var user = new UserInfoDto
                {
                    Id = Session.User.Id,
                    UserName = txtUsername.Text,
                    FullName = txtFullName.Text,
                    Role = lblRole.Text,
                    Status = lblStatus.Text,
                    isImageChanged = _isImageChanged
                };

                bool success = await _repository.UpdateUserProfileAsync(user, userImage.Image);

                if (success)
                {
                    await AuditService.LogAsync(new AuditLog
                    {
                        UserId = Session.User.Id,
                        ActionType = "UPDATE",
                        Description = $"Updated own profile: {user.UserName}",
                        TableAffected = "users",
                        RecordId = user.Id
                    });

                    Session.User.UserName = user.UserName;
                    Session.User.FullName = user.FullName;
                    
                    if (_isImageChanged && !string.IsNullOrWhiteSpace(user.ImagePath))
                    {
                        Session.User.UserImagePath = user.ImagePath;
                    }

                    MessageBox.Show(
                        "Profile updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _originalUserName = txtUsername.Text;
                    _originalImagePath = Session.User.UserImagePath;
                    _isImageChanged = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update profile. Please try again.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (InvalidOperationException iopEx)
            {
                MessageBox.Show(
                    iopEx.Message,
                    "Error Updating Profile",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred:\n\n{ex.Message}\n\nPlease contact support if the problem persists.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _isSubmitting = false;
                btnSave.Enabled = true;
            }
        }

        private void userImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(ofd.FileName);

                    if (fileInfo.Length > MaxFileSize)
                    {
                        MessageBox.Show("Image is too large. Maximum allowed size is 2MB.",
                                 "File Too Large",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                        return;
                    }

                    Image img = Image.FromFile(ofd.FileName);

                    if (img.Width > 3000 || img.Height > 3000)
                    {
                        MessageBox.Show("Image resolution is too high. Max 3000x3000 allowed.",
                                "Image Too Large",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }

                    userImage.Image = Image.FromFile(ofd.FileName);
                    _isImageChanged = true;
                    UpdateEditButtonState();
                }
            }
        }

        private void OnUserDataChanged(object sender, EventArgs e)
        {
            UpdateEditButtonState();
        }
    }
}
