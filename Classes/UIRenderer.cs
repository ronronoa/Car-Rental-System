using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleManagementSystem.Classes {
    public class UIRenderer {
        private IconButton currentBtn;
        private Guna2GradientPanel leftBorder;

        public UIRenderer(Panel menuPanel) {
            leftBorder = new Guna2GradientPanel {
                Size = new Size(10, 85),
                BorderRadius = 10,
                FillColor = AppConfig.Theme.Primary,
                FillColor2 = AppConfig.Theme.Primary,
                BackColor = Color.Transparent
            };
            leftBorder.CustomizableEdges.TopLeft = false;
            leftBorder.CustomizableEdges.BottomLeft = false;
            menuPanel.Controls.Add(leftBorder);
            leftBorder.Visible = false;
        }

        public void ActivateButton(object senderBtn) {
            if (senderBtn != null) {
                DeactiveButton();
                currentBtn = senderBtn as IconButton;
                currentBtn.IconSize = 60;
                currentBtn.ForeColor = AppConfig.Theme.Primary;
                currentBtn.IconColor = AppConfig.Theme.Primary;

                leftBorder.Location = new Point(0, currentBtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
            }
        }

        private void DeactiveButton() {
            if (currentBtn != null) {
                //RemoveHeaderLabel();
                currentBtn.IconSize = 50;
                currentBtn.ForeColor = AppConfig.Theme.SecondaryText;
                currentBtn.IconColor = AppConfig.Theme.SecondaryText;
            }
        }
    }
}
