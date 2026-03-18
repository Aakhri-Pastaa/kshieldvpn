namespace KshieldVPN
{
    partial class dnsleakform
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.menupanel = new Guna.UI2.WinForms.Guna2Panel();
            this.stbtn = new Guna.UI2.WinForms.Guna2Button();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.menu_icon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lstDnsServers = new System.Windows.Forms.ListView();
            this.lblstatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btngo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1293, 49);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1240, 6);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(43, 39);
            this.guna2ControlBox1.TabIndex = 2;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1189, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(43, 39);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DNS Leak Test";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BackgroundImage = global::KshieldVPN.Properties.Resources._5630939;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Controls.Add(this.menupanel);
            this.guna2Panel2.Controls.Add(this.menu_icon);
            this.guna2Panel2.Controls.Add(this.lstDnsServers);
            this.guna2Panel2.Controls.Add(this.lblstatus);
            this.guna2Panel2.Controls.Add(this.progressBar);
            this.guna2Panel2.Controls.Add(this.btngo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 49);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1293, 598);
            this.guna2Panel2.TabIndex = 1;
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.menupanel.BorderRadius = 10;
            this.menupanel.Controls.Add(this.stbtn);
            this.menupanel.Controls.Add(this.homebtn);
            this.menupanel.Controls.Add(this.logoutbtn);
            this.menupanel.Location = new System.Drawing.Point(0, 46);
            this.menupanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(220, 564);
            this.menupanel.TabIndex = 10;
            this.menupanel.Visible = false;
            // 
            // stbtn
            // 
            this.stbtn.BorderRadius = 10;
            this.stbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stbtn.FillColor = System.Drawing.Color.Transparent;
            this.stbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stbtn.ForeColor = System.Drawing.Color.White;
            this.stbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.stbtn.Location = new System.Drawing.Point(0, 126);
            this.stbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stbtn.Name = "stbtn";
            this.stbtn.Size = new System.Drawing.Size(216, 55);
            this.stbtn.TabIndex = 2;
            this.stbtn.Text = "Speed Test";
            this.stbtn.Click += new System.EventHandler(this.stbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BorderRadius = 10;
            this.homebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebtn.FillColor = System.Drawing.Color.Transparent;
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.homebtn.Location = new System.Drawing.Point(4, 63);
            this.homebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(207, 55);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "Home";
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // logoutbtn
            // 
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
            // 
            // menu_icon
            // 
            this.menu_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_icon.BackColor = System.Drawing.Color.Transparent;
            this.menu_icon.BackgroundImage = global::KshieldVPN.Properties.Resources.hmbmen_2;
            this.menu_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_icon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menu_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_icon.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.menu_icon.Image = global::KshieldVPN.Properties.Resources.hmbmen_2;
            this.menu_icon.ImageOffset = new System.Drawing.Point(0, 0);
            this.menu_icon.ImageRotate = 0F;
            this.menu_icon.ImageSize = new System.Drawing.Size(31, 32);
            this.menu_icon.Location = new System.Drawing.Point(0, 7);
            this.menu_icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu_icon.Name = "menu_icon";
            this.menu_icon.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.menu_icon.Size = new System.Drawing.Size(41, 39);
            this.menu_icon.TabIndex = 9;
            this.menu_icon.UseTransparentBackground = true;
            this.menu_icon.Click += new System.EventHandler(this.menu_icon_Click);
            // 
            // lstDnsServers
            // 
            this.lstDnsServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDnsServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lstDnsServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDnsServers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDnsServers.ForeColor = System.Drawing.Color.White;
            this.lstDnsServers.FullRowSelect = true;
            this.lstDnsServers.GridLines = true;
            this.lstDnsServers.HideSelection = false;
            this.lstDnsServers.Location = new System.Drawing.Point(296, 268);
            this.lstDnsServers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDnsServers.Name = "lstDnsServers";
            this.lstDnsServers.Size = new System.Drawing.Size(839, 260);
            this.lstDnsServers.TabIndex = 5;
            this.lstDnsServers.UseCompatibleStateImageBehavior = false;
            this.lstDnsServers.View = System.Windows.Forms.View.Details;
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.White;
            this.lblstatus.Location = new System.Drawing.Point(315, 214);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(208, 24);
            this.lblstatus.TabIndex = 6;
            this.lblstatus.Text = "Ready to run DNS leak test";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BorderRadius = 5;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar.Location = new System.Drawing.Point(315, 163);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(79)))));
            this.progressBar.Size = new System.Drawing.Size(820, 18);
            this.progressBar.TabIndex = 3;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btngo
            // 
            this.btngo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btngo.Animated = true;
            this.btngo.BorderRadius = 8;
            this.btngo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btngo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btngo.ForeColor = System.Drawing.Color.White;
            this.btngo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            this.btngo.Location = new System.Drawing.Point(416, 79);
            this.btngo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(493, 55);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "Run DNS Leak Test";
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dnsleakform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = global::KshieldVPN.Properties.Resources._5630939;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 647);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dnsleakform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS Leak Test";
            this.Load += new System.EventHandler(this.dnsleakform_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btngo;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblstatus;
        private System.Windows.Forms.ListView lstDnsServers;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton menu_icon;
        private Guna.UI2.WinForms.Guna2Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button stbtn;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
    }
}