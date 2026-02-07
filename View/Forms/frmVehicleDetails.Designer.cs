using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.View.Forms {
    partial class frmVehicleDetails {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleDetails));
            this.labelSubHeader = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iconTireBackRight = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTireBackRight = new System.Windows.Forms.Label();
            this.iconTireBackLeft = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTireBackLeft = new System.Windows.Forms.Label();
            this.iconTireFrontRight = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTireFrontRight = new System.Windows.Forms.Label();
            this.iconTireFrontLeft = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTireFrontLeft = new System.Windows.Forms.Label();
            this.pictureVehicle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTopRight = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBreakCondition = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressTillChangeOil = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressFuelTank = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMain.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireBackRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireBackLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireFrontRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireFrontLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).BeginInit();
            this.panelTopRight.SuspendLayout();
            this.progressBreakCondition.SuspendLayout();
            this.progressTillChangeOil.SuspendLayout();
            this.progressFuelTank.SuspendLayout();
            this.panelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSubHeader
            // 
            this.labelSubHeader.AutoSize = true;
            this.labelSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelSubHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubHeader.Location = new System.Drawing.Point(85, 26);
            this.labelSubHeader.Name = "labelSubHeader";
            this.labelSubHeader.Size = new System.Drawing.Size(119, 37);
            this.labelSubHeader.TabIndex = 0;
            this.labelSubHeader.Text = "Toyota";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.tableTop);
            this.panelMain.Controls.Add(this.labelStatus);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.backBtn);
            this.panelMain.Controls.Add(this.labelSubHeader);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(25, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1249, 680);
            this.panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(662, 1076);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 81);
            this.panel1.TabIndex = 23;
            // 
            // tableTop
            // 
            this.tableTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableTop.BackColor = System.Drawing.Color.Transparent;
            this.tableTop.ColumnCount = 2;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableTop.Controls.Add(this.panelTopLeft, 0, 0);
            this.tableTop.Controls.Add(this.panelTopRight, 1, 0);
            this.tableTop.Location = new System.Drawing.Point(38, 114);
            this.tableTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(1156, 601);
            this.tableTop.TabIndex = 22;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BorderRadius = 15;
            this.panelTopLeft.Controls.Add(this.panel2);
            this.panelTopLeft.Controls.Add(this.pictureVehicle);
            this.panelTopLeft.CustomizableEdges.BottomRight = false;
            this.panelTopLeft.CustomizableEdges.TopRight = false;
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.FillColor = System.Drawing.Color.Transparent;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(931, 601);
            this.panelTopLeft.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.iconTireBackRight);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelTireBackRight);
            this.panel2.Controls.Add(this.iconTireBackLeft);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelTireBackLeft);
            this.panel2.Controls.Add(this.iconTireFrontRight);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelTireFrontRight);
            this.panel2.Controls.Add(this.iconTireFrontLeft);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelTireFrontLeft);
            this.panel2.Location = new System.Drawing.Point(86, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 181);
            this.panel2.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(51, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(671, 28);
            this.label13.TabIndex = 16;
            this.label13.Text = "|___________|______________|_____________|__________|";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(335, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 56);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tire \r\nPressure";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconTireBackRight
            // 
            this.iconTireBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTireBackRight.BackColor = System.Drawing.Color.Transparent;
            this.iconTireBackRight.ForeColor = System.Drawing.Color.DarkGray;
            this.iconTireBackRight.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconTireBackRight.IconColor = System.Drawing.Color.DarkGray;
            this.iconTireBackRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTireBackRight.IconSize = 54;
            this.iconTireBackRight.Location = new System.Drawing.Point(636, 20);
            this.iconTireBackRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconTireBackRight.Name = "iconTireBackRight";
            this.iconTireBackRight.Size = new System.Drawing.Size(54, 61);
            this.iconTireBackRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTireBackRight.TabIndex = 12;
            this.iconTireBackRight.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(644, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "23 psi";
            // 
            // labelTireBackRight
            // 
            this.labelTireBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTireBackRight.AutoSize = true;
            this.labelTireBackRight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTireBackRight.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTireBackRight.Location = new System.Drawing.Point(686, 31);
            this.labelTireBackRight.Name = "labelTireBackRight";
            this.labelTireBackRight.Size = new System.Drawing.Size(57, 29);
            this.labelTireBackRight.TabIndex = 13;
            this.labelTireBackRight.Text = "Left";
            // 
            // iconTireBackLeft
            // 
            this.iconTireBackLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTireBackLeft.BackColor = System.Drawing.Color.Transparent;
            this.iconTireBackLeft.ForeColor = System.Drawing.Color.Red;
            this.iconTireBackLeft.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconTireBackLeft.IconColor = System.Drawing.Color.Red;
            this.iconTireBackLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTireBackLeft.IconSize = 54;
            this.iconTireBackLeft.Location = new System.Drawing.Point(501, 20);
            this.iconTireBackLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconTireBackLeft.Name = "iconTireBackLeft";
            this.iconTireBackLeft.Size = new System.Drawing.Size(54, 61);
            this.iconTireBackLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTireBackLeft.TabIndex = 9;
            this.iconTireBackLeft.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(508, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.TabIndex = 11;
            this.label8.Text = "16 psi";
            // 
            // labelTireBackLeft
            // 
            this.labelTireBackLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTireBackLeft.AutoSize = true;
            this.labelTireBackLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTireBackLeft.ForeColor = System.Drawing.Color.Red;
            this.labelTireBackLeft.Location = new System.Drawing.Point(551, 31);
            this.labelTireBackLeft.Name = "labelTireBackLeft";
            this.labelTireBackLeft.Size = new System.Drawing.Size(57, 29);
            this.labelTireBackLeft.TabIndex = 10;
            this.labelTireBackLeft.Text = "Left";
            // 
            // iconTireFrontRight
            // 
            this.iconTireFrontRight.BackColor = System.Drawing.Color.Transparent;
            this.iconTireFrontRight.ForeColor = System.Drawing.Color.DarkGray;
            this.iconTireFrontRight.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconTireFrontRight.IconColor = System.Drawing.Color.DarkGray;
            this.iconTireFrontRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTireFrontRight.IconSize = 54;
            this.iconTireFrontRight.Location = new System.Drawing.Point(155, 20);
            this.iconTireFrontRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconTireFrontRight.Name = "iconTireFrontRight";
            this.iconTireFrontRight.Size = new System.Drawing.Size(54, 61);
            this.iconTireFrontRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTireFrontRight.TabIndex = 6;
            this.iconTireFrontRight.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(163, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "24 psi";
            // 
            // labelTireFrontRight
            // 
            this.labelTireFrontRight.AutoSize = true;
            this.labelTireFrontRight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTireFrontRight.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTireFrontRight.Location = new System.Drawing.Point(206, 31);
            this.labelTireFrontRight.Name = "labelTireFrontRight";
            this.labelTireFrontRight.Size = new System.Drawing.Size(75, 29);
            this.labelTireFrontRight.TabIndex = 7;
            this.labelTireFrontRight.Text = "Right";
            // 
            // iconTireFrontLeft
            // 
            this.iconTireFrontLeft.BackColor = System.Drawing.Color.Transparent;
            this.iconTireFrontLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.iconTireFrontLeft.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconTireFrontLeft.IconColor = System.Drawing.Color.DarkGray;
            this.iconTireFrontLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTireFrontLeft.IconSize = 54;
            this.iconTireFrontLeft.Location = new System.Drawing.Point(20, 20);
            this.iconTireFrontLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconTireFrontLeft.Name = "iconTireFrontLeft";
            this.iconTireFrontLeft.Size = new System.Drawing.Size(54, 61);
            this.iconTireFrontLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTireFrontLeft.TabIndex = 3;
            this.iconTireFrontLeft.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "24 psi";
            // 
            // labelTireFrontLeft
            // 
            this.labelTireFrontLeft.AutoSize = true;
            this.labelTireFrontLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTireFrontLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTireFrontLeft.Location = new System.Drawing.Point(71, 31);
            this.labelTireFrontLeft.Name = "labelTireFrontLeft";
            this.labelTireFrontLeft.Size = new System.Drawing.Size(57, 29);
            this.labelTireFrontLeft.TabIndex = 4;
            this.labelTireFrontLeft.Text = "Left";
            // 
            // pictureVehicle
            // 
            this.pictureVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pictureVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureVehicle.FillColor = System.Drawing.Color.Transparent;
            this.pictureVehicle.Image = ((System.Drawing.Image)(resources.GetObject("pictureVehicle.Image")));
            this.pictureVehicle.ImageRotate = 0F;
            this.pictureVehicle.Location = new System.Drawing.Point(106, 39);
            this.pictureVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureVehicle.Name = "pictureVehicle";
            this.pictureVehicle.Size = new System.Drawing.Size(724, 382);
            this.pictureVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVehicle.TabIndex = 2;
            this.pictureVehicle.TabStop = false;
            // 
            // panelTopRight
            // 
            this.panelTopRight.BorderRadius = 15;
            this.panelTopRight.Controls.Add(this.progressBreakCondition);
            this.panelTopRight.Controls.Add(this.progressTillChangeOil);
            this.panelTopRight.Controls.Add(this.progressFuelTank);
            this.panelTopRight.CustomizableEdges.BottomLeft = false;
            this.panelTopRight.CustomizableEdges.TopLeft = false;
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.FillColor = System.Drawing.Color.Transparent;
            this.panelTopRight.Location = new System.Drawing.Point(931, 0);
            this.panelTopRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(225, 601);
            this.panelTopRight.TabIndex = 1;
            // 
            // progressBreakCondition
            // 
            this.progressBreakCondition.Controls.Add(this.label11);
            this.progressBreakCondition.Controls.Add(this.label7);
            this.progressBreakCondition.FillColor = System.Drawing.Color.DarkGray;
            this.progressBreakCondition.FillThickness = 5;
            this.progressBreakCondition.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBreakCondition.ForeColor = System.Drawing.Color.DimGray;
            this.progressBreakCondition.Location = new System.Drawing.Point(27, 394);
            this.progressBreakCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBreakCondition.Minimum = 0;
            this.progressBreakCondition.Name = "progressBreakCondition";
            this.progressBreakCondition.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.progressBreakCondition.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBreakCondition.ProgressThickness = 8;
            this.progressBreakCondition.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBreakCondition.Size = new System.Drawing.Size(170, 170);
            this.progressBreakCondition.TabIndex = 2;
            this.progressBreakCondition.Text = "guna2CircleProgressBar3";
            this.progressBreakCondition.Value = 50;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(49, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 38);
            this.label11.TabIndex = 17;
            this.label11.Text = "50%";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(34, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Break \r\nCondition";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressTillChangeOil
            // 
            this.progressTillChangeOil.Controls.Add(this.label10);
            this.progressTillChangeOil.Controls.Add(this.label5);
            this.progressTillChangeOil.FillColor = System.Drawing.Color.DarkGray;
            this.progressTillChangeOil.FillThickness = 5;
            this.progressTillChangeOil.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressTillChangeOil.ForeColor = System.Drawing.Color.DimGray;
            this.progressTillChangeOil.Location = new System.Drawing.Point(27, 206);
            this.progressTillChangeOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressTillChangeOil.Minimum = 0;
            this.progressTillChangeOil.Name = "progressTillChangeOil";
            this.progressTillChangeOil.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.progressTillChangeOil.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressTillChangeOil.ProgressThickness = 8;
            this.progressTillChangeOil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressTillChangeOil.Size = new System.Drawing.Size(168, 168);
            this.progressTillChangeOil.TabIndex = 1;
            this.progressTillChangeOil.Text = "guna2CircleProgressBar2";
            this.progressTillChangeOil.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.progressTillChangeOil.Value = 90;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(28, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "5249 km";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(22, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "Until change \r\noil";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressFuelTank
            // 
            this.progressFuelTank.Controls.Add(this.label9);
            this.progressFuelTank.Controls.Add(this.label1);
            this.progressFuelTank.FillColor = System.Drawing.Color.DarkGray;
            this.progressFuelTank.FillThickness = 5;
            this.progressFuelTank.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressFuelTank.ForeColor = System.Drawing.Color.DimGray;
            this.progressFuelTank.Location = new System.Drawing.Point(27, 10);
            this.progressFuelTank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressFuelTank.Minimum = 0;
            this.progressFuelTank.Name = "progressFuelTank";
            this.progressFuelTank.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.progressFuelTank.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressFuelTank.ProgressThickness = 8;
            this.progressFuelTank.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressFuelTank.Size = new System.Drawing.Size(175, 175);
            this.progressFuelTank.TabIndex = 0;
            this.progressFuelTank.Text = "guna2CircleProgressBar1";
            this.progressFuelTank.Value = 50;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(49, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 38);
            this.label9.TabIndex = 16;
            this.label9.Text = "50%";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(60, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fuel";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.BorderRadius = 15;
            this.labelStatus.BorderThickness = 0;
            this.labelStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelStatus.DefaultText = "inMaintenance";
            this.labelStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.labelStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.labelStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelStatus.FillColor = System.Drawing.Color.Thistle;
            this.labelStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelStatus.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelStatus.Location = new System.Drawing.Point(208, 22);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelStatus.PlaceholderForeColor = System.Drawing.Color.Black;
            this.labelStatus.PlaceholderText = "";
            this.labelStatus.ReadOnly = true;
            this.labelStatus.SelectedText = "";
            this.labelStatus.Size = new System.Drawing.Size(162, 44);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelStatus.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(88, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "vehicles status and specifications,";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.BorderThickness = 4;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::VehicleManagementSystem.Properties.Resources.chevron_backward_icon;
            this.backBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Location = new System.Drawing.Point(25, 33);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(54, 54);
            this.backBtn.TabIndex = 18;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panelBg
            // 
            this.panelBg.BorderRadius = 25;
            this.panelBg.Controls.Add(this.panelMain);
            this.panelBg.CustomizableEdges.BottomLeft = false;
            this.panelBg.CustomizableEdges.BottomRight = false;
            this.panelBg.CustomizableEdges.TopRight = false;
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1274, 682);
            this.panelBg.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(18, 718);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1190, 239);
            this.guna2Panel1.TabIndex = 24;
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 682);
            this.Controls.Add(this.panelBg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableTop.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireBackRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireBackLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireFrontRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTireFrontLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).EndInit();
            this.panelTopRight.ResumeLayout(false);
            this.progressBreakCondition.ResumeLayout(false);
            this.progressBreakCondition.PerformLayout();
            this.progressTillChangeOil.ResumeLayout(false);
            this.progressTillChangeOil.PerformLayout();
            this.progressFuelTank.ResumeLayout(false);
            this.progressFuelTank.PerformLayout();
            this.panelBg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSubHeader;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private Guna.UI2.WinForms.Guna2PictureBox pictureVehicle;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox labelStatus;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private Guna.UI2.WinForms.Guna2Panel panelTopLeft;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel panelTopRight;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressFuelTank;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBreakCondition;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressTillChangeOil;
        private FontAwesome.Sharp.IconPictureBox iconTireFrontLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTireFrontLeft;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconTireFrontRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTireFrontRight;
        private FontAwesome.Sharp.IconPictureBox iconTireBackRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTireBackRight;
        private FontAwesome.Sharp.IconPictureBox iconTireBackLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTireBackLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}