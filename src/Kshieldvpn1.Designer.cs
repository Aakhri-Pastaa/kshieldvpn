

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.AnimatorNS;

namespace KshieldVPN
{
    partial class Kshieldvpn1
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kshieldvpn1));
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.button3 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.menu_icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menupanel = new Guna.UI2.WinForms.Guna2Panel();
            this.premium = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.sptestbtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_icon)).BeginInit();
            this.menupanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoRoundedCorners = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderRadius = 23;
            this.guna2Transition1.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.button2.Location = new System.Drawing.Point(460, 468);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "Connect";
            this.button2.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // button3
            // 
            this.button3.AutoRoundedCorners = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BorderRadius = 23;
            this.guna2Transition1.SetDecoration(this.button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(50)))), ((int)(((byte)(38)))));
            this.button3.Location = new System.Drawing.Point(687, 468);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "Disconnect";
            this.button3.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.AutoRoundedCorners = true;
            this.comboBox.BackColor = System.Drawing.Color.Transparent;
            this.comboBox.BorderRadius = 17;
            this.guna2Transition1.SetDecoration(this.comboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox.ForeColor = System.Drawing.Color.Black;
            this.comboBox.ItemHeight = 30;
            this.comboBox.Items.AddRange(new object[] {
            "California",
            "Paris",
            "Seoul",
            "Dublin",
            "Tokyo"});
            this.comboBox.Location = new System.Drawing.Point(540, 375);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(265, 36);
            this.comboBox.StartIndex = 0;
            this.comboBox.TabIndex = 3;
            // 
            // menu_icon
            // 
            this.menu_icon.BackColor = System.Drawing.Color.Transparent;
            this.menu_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.menu_icon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.menu_icon.Image = global::KshieldVPN.Properties.Resources.hmbmen_2;
            this.menu_icon.ImageRotate = 0F;
            this.menu_icon.Location = new System.Drawing.Point(0, 49);
            this.menu_icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu_icon.Name = "menu_icon";
            this.menu_icon.Size = new System.Drawing.Size(43, 39);
            this.menu_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_icon.TabIndex = 4;
            this.menu_icon.TabStop = false;
            this.menu_icon.Click += new System.EventHandler(this.menu_icon_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.menupanel.BorderRadius = 10;
            this.menupanel.Controls.Add(this.premium);
            this.menupanel.Controls.Add(this.guna2Button1);
            this.menupanel.Controls.Add(this.sptestbtn);
            this.menupanel.Controls.Add(this.logoutbtn);
            this.guna2Transition1.SetDecoration(this.menupanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.menupanel.Location = new System.Drawing.Point(0, 86);
            this.menupanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(220, 514);
            this.menupanel.TabIndex = 5;
            this.menupanel.Visible = false;
            // 
            // premium
            // 
            this.premium.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.premium, Guna.UI2.AnimatorNS.DecorationType.None);
            this.premium.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.premium.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.premium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.premium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.premium.FillColor = System.Drawing.Color.Transparent;
            this.premium.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.premium.ForeColor = System.Drawing.Color.White;
            this.premium.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.premium.Location = new System.Drawing.Point(4, 190);
            this.premium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(212, 55);
            this.premium.TabIndex = 3;
            this.premium.Text = "Premium Access";
            this.premium.Click += new System.EventHandler(this.premium_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2Button1.Location = new System.Drawing.Point(0, 126);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(216, 55);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "DNS Leak Test";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // sptestbtn
            // 
            this.sptestbtn.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.sptestbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sptestbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sptestbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sptestbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sptestbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sptestbtn.FillColor = System.Drawing.Color.Transparent;
            this.sptestbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sptestbtn.ForeColor = System.Drawing.Color.White;
            this.sptestbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sptestbtn.Location = new System.Drawing.Point(4, 63);
            this.sptestbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sptestbtn.Name = "sptestbtn";
            this.sptestbtn.Size = new System.Drawing.Size(207, 55);
            this.sptestbtn.TabIndex = 1;
            this.sptestbtn.Text = "Speed Test";
            this.sptestbtn.Click += new System.EventHandler(this.sptestbtn_Click);
            // 
            // logoutbtn
            // 
            this.guna2Transition1.SetDecoration(this.logoutbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbtn.FillColor = System.Drawing.Color.SlateBlue;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.logoutbtn.Location = new System.Drawing.Point(0, 464);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(220, 55);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1293, 49);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1240, 6);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(43, 39);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1189, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(43, 39);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // Kshieldvpn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 647);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.menu_icon);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Kshieldvpn1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KshieldVPN";
            this.Load += new System.EventHandler(this.Kshieldvpn1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_icon)).EndInit();
            this.menupanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
        private Guna.UI2.WinForms.Guna2PictureBox menu_icon;
        private Guna.UI2.WinForms.Guna2Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private Guna.UI2.WinForms.Guna2Button sptestbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button premium;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna2Panel guna2Panel1;
        private Guna2ControlBox guna2ControlBox1;
        private Guna2ControlBox guna2ControlBox2;
    }
}