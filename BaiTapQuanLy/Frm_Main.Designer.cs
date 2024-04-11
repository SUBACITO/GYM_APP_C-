﻿namespace BaiTapQuanLy
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.homePageBTN = new Guna.UI2.WinForms.Guna2Button();
            this.privateTrainerBTN = new Guna.UI2.WinForms.Guna2Button();
            this.memberManagerBTN = new Guna.UI2.WinForms.Guna2Button();
            this.dashBoardBTN = new Guna.UI2.WinForms.Guna2Button();
            this.searchBarTxT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuSidebarIcon = new System.Windows.Forms.PictureBox();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarTransistion = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSidebarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePageBTN
            // 
            this.homePageBTN.AutoRoundedCorners = true;
            this.homePageBTN.BorderRadius = 21;
            this.homePageBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePageBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePageBTN.FillColor = System.Drawing.Color.Transparent;
            this.homePageBTN.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageBTN.ForeColor = System.Drawing.Color.Black;
            this.homePageBTN.Image = ((System.Drawing.Image)(resources.GetObject("homePageBTN.Image")));
            this.homePageBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homePageBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.homePageBTN.Location = new System.Drawing.Point(3, 20);
            this.homePageBTN.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.homePageBTN.Name = "homePageBTN";
            this.homePageBTN.Size = new System.Drawing.Size(260, 45);
            this.homePageBTN.TabIndex = 10;
            this.homePageBTN.Text = "Home";
            this.homePageBTN.Click += new System.EventHandler(this.homePageBTN_Click);
            // 
            // privateTrainerBTN
            // 
            this.privateTrainerBTN.AutoRoundedCorners = true;
            this.privateTrainerBTN.BorderRadius = 21;
            this.privateTrainerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privateTrainerBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.privateTrainerBTN.FillColor = System.Drawing.Color.Transparent;
            this.privateTrainerBTN.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateTrainerBTN.ForeColor = System.Drawing.Color.Black;
            this.privateTrainerBTN.Image = ((System.Drawing.Image)(resources.GetObject("privateTrainerBTN.Image")));
            this.privateTrainerBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.privateTrainerBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.privateTrainerBTN.Location = new System.Drawing.Point(3, 173);
            this.privateTrainerBTN.Name = "privateTrainerBTN";
            this.privateTrainerBTN.Size = new System.Drawing.Size(260, 45);
            this.privateTrainerBTN.TabIndex = 8;
            this.privateTrainerBTN.Text = "Personal Trainer";
            this.privateTrainerBTN.Click += new System.EventHandler(this.privateTrainerBTN_Click);
            // 
            // memberManagerBTN
            // 
            this.memberManagerBTN.AutoRoundedCorners = true;
            this.memberManagerBTN.BorderRadius = 21;
            this.memberManagerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberManagerBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberManagerBTN.FillColor = System.Drawing.Color.Transparent;
            this.memberManagerBTN.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberManagerBTN.ForeColor = System.Drawing.Color.Black;
            this.memberManagerBTN.Image = ((System.Drawing.Image)(resources.GetObject("memberManagerBTN.Image")));
            this.memberManagerBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.memberManagerBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.memberManagerBTN.Location = new System.Drawing.Point(3, 122);
            this.memberManagerBTN.Name = "memberManagerBTN";
            this.memberManagerBTN.Size = new System.Drawing.Size(260, 45);
            this.memberManagerBTN.TabIndex = 7;
            this.memberManagerBTN.Text = "Members Manager";
            this.memberManagerBTN.Click += new System.EventHandler(this.memberManagerBTN_Click);
            // 
            // dashBoardBTN
            // 
            this.dashBoardBTN.AutoRoundedCorners = true;
            this.dashBoardBTN.BorderRadius = 21;
            this.dashBoardBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBoardBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashBoardBTN.FillColor = System.Drawing.Color.Transparent;
            this.dashBoardBTN.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardBTN.ForeColor = System.Drawing.Color.Black;
            this.dashBoardBTN.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardBTN.Image")));
            this.dashBoardBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashBoardBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.dashBoardBTN.Location = new System.Drawing.Point(3, 71);
            this.dashBoardBTN.Name = "dashBoardBTN";
            this.dashBoardBTN.Size = new System.Drawing.Size(260, 45);
            this.dashBoardBTN.TabIndex = 6;
            this.dashBoardBTN.Text = "Dashboard";
            this.dashBoardBTN.Click += new System.EventHandler(this.dashBoardBTN_Click);
            // 
            // searchBarTxT
            // 
            this.searchBarTxT.AutoRoundedCorners = true;
            this.searchBarTxT.BorderRadius = 16;
            this.searchBarTxT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBarTxT.DefaultText = "";
            this.searchBarTxT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBarTxT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBarTxT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTxT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTxT.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBarTxT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTxT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.searchBarTxT.ForeColor = System.Drawing.Color.Black;
            this.searchBarTxT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTxT.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBarTxT.IconLeft")));
            this.searchBarTxT.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchBarTxT.Location = new System.Drawing.Point(270, 7);
            this.searchBarTxT.Margin = new System.Windows.Forms.Padding(4);
            this.searchBarTxT.Name = "searchBarTxT";
            this.searchBarTxT.PasswordChar = '\0';
            this.searchBarTxT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.searchBarTxT.PlaceholderText = "Search";
            this.searchBarTxT.SelectedText = "";
            this.searchBarTxT.Size = new System.Drawing.Size(374, 34);
            this.searchBarTxT.TabIndex = 9;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Red;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1097, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1055, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1013, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Location = new System.Drawing.Point(270, 48);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(872, 521);
            this.panelDesktop.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.usernameLabel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.searchBarTxT);
            this.topPanel.Controls.Add(this.menuSidebarIcon);
            this.topPanel.Controls.Add(this.guna2ControlBox3);
            this.topPanel.Controls.Add(this.userProfile);
            this.topPanel.Controls.Add(this.guna2ControlBox1);
            this.topPanel.Controls.Add(this.guna2ControlBox2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1142, 48);
            this.topPanel.TabIndex = 6;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(808, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(136, 18);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Nguyễn Hào Quang";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gym Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuSidebarIcon
            // 
            this.menuSidebarIcon.BackColor = System.Drawing.Color.White;
            this.menuSidebarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSidebarIcon.Image = ((System.Drawing.Image)(resources.GetObject("menuSidebarIcon.Image")));
            this.menuSidebarIcon.Location = new System.Drawing.Point(12, 12);
            this.menuSidebarIcon.Name = "menuSidebarIcon";
            this.menuSidebarIcon.Size = new System.Drawing.Size(32, 28);
            this.menuSidebarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuSidebarIcon.TabIndex = 7;
            this.menuSidebarIcon.TabStop = false;
            this.menuSidebarIcon.Click += new System.EventHandler(this.menuSidebarIcon_Click);
            // 
            // userProfile
            // 
            this.userProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userProfile.Image = ((System.Drawing.Image)(resources.GetObject("userProfile.Image")));
            this.userProfile.Location = new System.Drawing.Point(764, 5);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(38, 37);
            this.userProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfile.TabIndex = 0;
            this.userProfile.TabStop = false;
            this.userProfile.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebarPanel.BackColor = System.Drawing.Color.White;
            this.sidebarPanel.Controls.Add(this.homePageBTN);
            this.sidebarPanel.Controls.Add(this.dashBoardBTN);
            this.sidebarPanel.Controls.Add(this.memberManagerBTN);
            this.sidebarPanel.Controls.Add(this.privateTrainerBTN);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 48);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(270, 521);
            this.sidebarPanel.TabIndex = 7;
            // 
            // sidebarTransistion
            // 
            this.sidebarTransistion.Interval = 10;
            this.sidebarTransistion.Tick += new System.EventHandler(this.sidebarTransistion_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 569);
            this.ControlBox = false;
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panelDesktop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Membership Management";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSidebarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button dashBoardBTN;
        private Guna.UI2.WinForms.Guna2Button privateTrainerBTN;
        private Guna.UI2.WinForms.Guna2Button memberManagerBTN;
        private Guna.UI2.WinForms.Guna2Button homePageBTN;
        private Guna.UI2.WinForms.Guna2TextBox searchBarTxT;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox menuSidebarIcon;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.Timer sidebarTransistion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userProfile;
        private System.Windows.Forms.Label usernameLabel;
    }
}