namespace KshieldVPN
{
    partial class stform
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stform));
            this.pbdwn = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pbup = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.stgobtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtdwnspeed = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtupspeed = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtping = new Guna.UI2.WinForms.Guna2TextBox();
            this.speedGauge = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.menupanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.dnsleak = new Guna.UI2.WinForms.Guna2Button();
            this.vpnhome = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.menu_icon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.menupanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbdwn
            // 
            this.pbdwn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbdwn.BorderRadius = 5;
            this.guna2Transition1.SetDecoration(this.pbdwn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbdwn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbdwn.Location = new System.Drawing.Point(320, 414);
            this.pbdwn.Name = "pbdwn";
            this.pbdwn.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbdwn.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbdwn.Size = new System.Drawing.Size(280, 15);
            this.pbdwn.TabIndex = 0;
            this.pbdwn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pbup
            // 
            this.pbup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbup.BorderRadius = 5;
            this.guna2Transition1.SetDecoration(this.pbup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbup.Location = new System.Drawing.Point(320, 453);
            this.pbup.Name = "pbup";
            this.pbup.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbup.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbup.Size = new System.Drawing.Size(280, 15);
            this.pbup.TabIndex = 1;
            this.pbup.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // stgobtn
            // 
            this.stgobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stgobtn.Animated = true;
            this.stgobtn.BackColor = System.Drawing.Color.Transparent;
            this.stgobtn.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.stgobtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.stgobtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stgobtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stgobtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stgobtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stgobtn.FillColor = System.Drawing.Color.SlateBlue;
            this.stgobtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.stgobtn.ForeColor = System.Drawing.Color.White;
            this.stgobtn.Location = new System.Drawing.Point(365, 474);
            this.stgobtn.Name = "stgobtn";
            this.stgobtn.Size = new System.Drawing.Size(180, 45);
            this.stgobtn.TabIndex = 2;
            this.stgobtn.Text = "START TEST";
            this.stgobtn.UseTransparentBackground = true;
            this.stgobtn.Click += new System.EventHandler(this.stgobtn_Click);
            // 
            // txtdwnspeed
            // 
            this.txtdwnspeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdwnspeed.BackColor = System.Drawing.Color.Transparent;
            this.txtdwnspeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtdwnspeed.BorderRadius = 10;
            this.txtdwnspeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtdwnspeed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtdwnspeed.DefaultText = "";
            this.txtdwnspeed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdwnspeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdwnspeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdwnspeed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdwnspeed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtdwnspeed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdwnspeed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtdwnspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtdwnspeed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdwnspeed.Location = new System.Drawing.Point(607, 400);
            this.txtdwnspeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdwnspeed.Name = "txtdwnspeed";
            this.txtdwnspeed.PlaceholderText = "";
            this.txtdwnspeed.ReadOnly = true;
            this.txtdwnspeed.SelectedText = "";
            this.txtdwnspeed.Size = new System.Drawing.Size(160, 36);
            this.txtdwnspeed.TabIndex = 3;
            this.txtdwnspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtupspeed
            // 
            this.txtupspeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtupspeed.BackColor = System.Drawing.Color.Transparent;
            this.txtupspeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtupspeed.BorderRadius = 10;
            this.txtupspeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtupspeed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtupspeed.DefaultText = "";
            this.txtupspeed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtupspeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtupspeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtupspeed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtupspeed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtupspeed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtupspeed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtupspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtupspeed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtupspeed.Location = new System.Drawing.Point(607, 444);
            this.txtupspeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtupspeed.Name = "txtupspeed";
            this.txtupspeed.PlaceholderText = "";
            this.txtupspeed.ReadOnly = true;
            this.txtupspeed.SelectedText = "";
            this.txtupspeed.Size = new System.Drawing.Size(160, 36);
            this.txtupspeed.TabIndex = 4;
            this.txtupspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtping
            // 
            this.txtping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtping.BackColor = System.Drawing.Color.Transparent;
            this.txtping.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtping.BorderRadius = 10;
            this.txtping.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtping, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtping.DefaultText = "";
            this.txtping.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtping.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtping.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtping.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtping.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtping.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtping.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtping.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtping.Location = new System.Drawing.Point(607, 355);
            this.txtping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtping.Name = "txtping";
            this.txtping.PlaceholderText = "";
            this.txtping.ReadOnly = true;
            this.txtping.SelectedText = "";
            this.txtping.Size = new System.Drawing.Size(160, 36);
            this.txtping.TabIndex = 5;
            this.txtping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedGauge
            // 
            this.speedGauge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedGauge.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.speedGauge, Guna.UI2.AnimatorNS.DecorationType.None);
            this.speedGauge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.speedGauge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.speedGauge.ForeColor = System.Drawing.Color.White;
            this.speedGauge.Location = new System.Drawing.Point(310, 101);
            this.speedGauge.MinimumSize = new System.Drawing.Size(30, 30);
            this.speedGauge.Name = "speedGauge";
            this.speedGauge.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.speedGauge.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.speedGauge.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.speedGauge.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.speedGauge.Size = new System.Drawing.Size(310, 310);
            this.speedGauge.TabIndex = 6;
            this.speedGauge.UseTransparentBackground = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
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
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // menupanel
            // 
            this.menupanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menupanel.BackColor = System.Drawing.Color.Transparent;
            this.menupanel.Controls.Add(this.logoutbtn);
            this.menupanel.Controls.Add(this.dnsleak);
            this.menupanel.Controls.Add(this.vpnhome);
            this.guna2Transition1.SetDecoration(this.menupanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.menupanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.menupanel.ForeColor = System.Drawing.Color.Transparent;
            this.menupanel.Location = new System.Drawing.Point(0, 76);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(165, 464);
            this.menupanel.TabIndex = 7;
            this.menupanel.UseTransparentBackground = true;
            this.menupanel.Visible = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Animated = true;
            this.logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.logoutbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbtn.FillColor = System.Drawing.Color.SlateBlue;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.logoutbtn.Location = new System.Drawing.Point(3, 390);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(162, 45);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // dnsleak
            // 
            this.dnsleak.Animated = true;
            this.dnsleak.BackColor = System.Drawing.Color.Transparent;
            this.dnsleak.BorderRadius = 8;
            this.guna2Transition1.SetDecoration(this.dnsleak, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dnsleak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dnsleak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dnsleak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dnsleak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dnsleak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.dnsleak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsleak.ForeColor = System.Drawing.Color.White;
            this.dnsleak.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dnsleak.ImageSize = new System.Drawing.Size(24, 24);
            this.dnsleak.Location = new System.Drawing.Point(0, 102);
            this.dnsleak.Name = "dnsleak";
            this.dnsleak.Size = new System.Drawing.Size(162, 45);
            this.dnsleak.TabIndex = 1;
            this.dnsleak.Text = "DNS Leak";
            this.dnsleak.Click += new System.EventHandler(this.dnsleak_Click);
            // 
            // vpnhome
            // 
            this.vpnhome.Animated = true;
            this.vpnhome.BackColor = System.Drawing.Color.Transparent;
            this.vpnhome.BorderRadius = 8;
            this.guna2Transition1.SetDecoration(this.vpnhome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.vpnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.vpnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.vpnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.vpnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.vpnhome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.vpnhome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpnhome.ForeColor = System.Drawing.Color.White;
            this.vpnhome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vpnhome.ImageSize = new System.Drawing.Size(24, 24);
            this.vpnhome.Location = new System.Drawing.Point(0, 50);
            this.vpnhome.Name = "vpnhome";
            this.vpnhome.Size = new System.Drawing.Size(162, 45);
            this.vpnhome.TabIndex = 0;
            this.vpnhome.Text = "Home";
            this.vpnhome.Click += new System.EventHandler(this.vpnhome_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "DOWNLOAD";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "UPLOAD";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "PING";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(396, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "SPEED TEST";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(926, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(887, 11);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox2.TabIndex = 14;
            // 
            // menu_icon
            // 
            this.menu_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_icon.BackColor = System.Drawing.Color.Transparent;
            this.menu_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_icon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menu_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.menu_icon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.menu_icon.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.menu_icon.Image = global::KshieldVPN.Properties.Resources.hmbmen_2;
            this.menu_icon.ImageOffset = new System.Drawing.Point(0, 0);
            this.menu_icon.ImageRotate = 0F;
            this.menu_icon.ImageSize = new System.Drawing.Size(31, 32);
            this.menu_icon.Location = new System.Drawing.Point(0, 46);
            this.menu_icon.Name = "menu_icon";
            this.menu_icon.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.menu_icon.Size = new System.Drawing.Size(31, 32);
            this.menu_icon.TabIndex = 8;
            this.menu_icon.UseTransparentBackground = true;
            this.menu_icon.Click += new System.EventHandler(this.menu_icon_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox4);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(970, 40);
            this.guna2Panel1.TabIndex = 15;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(930, 5);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.Animated = true;
            this.guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(892, 5);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox4.TabIndex = 3;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // stform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = global::KshieldVPN.Properties.Resources._5630939;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 526);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_icon);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.speedGauge);
            this.Controls.Add(this.txtping);
            this.Controls.Add(this.txtupspeed);
            this.Controls.Add(this.txtdwnspeed);
            this.Controls.Add(this.stgobtn);
            this.Controls.Add(this.pbup);
            this.Controls.Add(this.pbdwn);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Test - KshieldVPN";
            this.Load += new System.EventHandler(this.stform_Load);
            this.menupanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar pbdwn;
        private Guna.UI2.WinForms.Guna2ProgressBar pbup;
        private Guna.UI2.WinForms.Guna2Button stgobtn;
        private Guna.UI2.WinForms.Guna2TextBox txtdwnspeed;
        private Guna.UI2.WinForms.Guna2TextBox txtupspeed;
        private Guna.UI2.WinForms.Guna2TextBox txtping;
        private Guna.UI2.WinForms.Guna2RadialGauge speedGauge;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private Guna.UI2.WinForms.Guna2Button dnsleak;
        private Guna.UI2.WinForms.Guna2Button vpnhome;
        private Guna.UI2.WinForms.Guna2ImageButton menu_icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
    }
}