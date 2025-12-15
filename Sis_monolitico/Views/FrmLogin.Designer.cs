using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Sis_monolitico.Views
{
    partial class FrmLogin
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2ShadowForm1 = new Guna2ShadowForm(components);
            pnlMain = new Guna2Panel();
            pnlCard = new Guna2Panel();
            picAvatar = new Guna2PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtUser = new Guna2TextBox();
            txtPassword = new Guna2TextBox();
            btnLogin = new Guna2Button();
            lblHint = new Label();
            btnClose = new Guna2ControlBox();
            btnMin = new Guna2ControlBox();
            pnlMain.SuspendLayout();
            pnlCard.SuspendLayout();
            ((ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 16;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.TargetForm = this;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlCard);
            pnlMain.Controls.Add(btnClose);
            pnlMain.Controls.Add(btnMin);
            pnlMain.CustomizableEdges = customizableEdges15;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.FillColor = Color.FromArgb(12, 12, 22);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlMain.Size = new Size(980, 560);
            pnlMain.TabIndex = 0;
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.None;
            pnlCard.BackColor = Color.Transparent;
            pnlCard.BorderRadius = 18;
            pnlCard.Controls.Add(picAvatar);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblHint);
            pnlCard.CustomizableEdges = customizableEdges9;
            pnlCard.FillColor = Color.FromArgb(22, 22, 36);
            pnlCard.Location = new Point(524, 44);
            pnlCard.Name = "pnlCard";
            pnlCard.ShadowDecoration.BorderRadius = 18;
            pnlCard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlCard.ShadowDecoration.Depth = 18;
            pnlCard.ShadowDecoration.Enabled = true;
            pnlCard.ShadowDecoration.Shadow = new Padding(6);
            pnlCard.Size = new Size(430, 460);
            pnlCard.TabIndex = 0;
            // 
            // picAvatar
            // 
            picAvatar.BorderRadius = 14;
            picAvatar.CustomizableEdges = customizableEdges1;
            picAvatar.FillColor = Color.FromArgb(35, 35, 55);
            picAvatar.ImageRotate = 0F;
            picAvatar.Location = new Point(175, 35);
            picAvatar.Name = "picAvatar";
            picAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picAvatar.Size = new Size(80, 80);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(150, 130);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(141, 46);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "INICIAR";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gainsboro;
            lblSubtitle.Location = new Point(88, 175);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(265, 23);
            lblSubtitle.TabIndex = 11;
            lblSubtitle.Text = "Accede para entrar al chat grupal";
            // 
            // txtUser
            // 
            txtUser.BorderRadius = 12;
            txtUser.Cursor = Cursors.IBeam;
            txtUser.CustomizableEdges = customizableEdges3;
            txtUser.DefaultText = "";
            txtUser.FillColor = Color.FromArgb(30, 30, 48);
            txtUser.FocusedState.BorderColor = Color.FromArgb(120, 90, 255);
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.ForeColor = Color.White;
            txtUser.HoverState.BorderColor = Color.FromArgb(120, 90, 255);
            txtUser.Location = new Point(55, 230);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderForeColor = Color.Silver;
            txtUser.PlaceholderText = "Usuario / Email";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUser.Size = new Size(320, 44);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 12;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.FromArgb(30, 30, 48);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(120, 90, 255);
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.White;
            txtPassword.HoverState.BorderColor = Color.FromArgb(120, 90, 255);
            txtPassword.Location = new Point(55, 285);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderForeColor = Color.Silver;
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(320, 44);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 12;
            btnLogin.CustomizableEdges = customizableEdges7;
            btnLogin.FillColor = Color.FromArgb(120, 90, 255);
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(55, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLogin.Size = new Size(320, 48);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ENTRAR";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.Silver;
            lblHint.Location = new Point(88, 410);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(325, 20);
            lblHint.TabIndex = 12;
            lblHint.Text = "Tip: luego podrás unirte a salas y chats grupales";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges11;
            btnClose.FillColor = Color.Transparent;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1710, 10);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnClose.Size = new Size(40, 30);
            btnClose.TabIndex = 50;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMin.CustomizableEdges = customizableEdges13;
            btnMin.FillColor = Color.Transparent;
            btnMin.IconColor = Color.White;
            btnMin.Location = new Point(1665, 10);
            btnMin.Name = "btnMin";
            btnMin.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMin.Size = new Size(40, 30);
            btnMin.TabIndex = 49;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 18);
            ClientSize = new Size(980, 560);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnlMain.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2ShadowForm guna2ShadowForm1;

        private Guna2Panel pnlMain;
        private Guna2Panel pnlCard;

        private Guna2ControlBox btnClose;
        private Guna2ControlBox btnMin;

        private Guna2PictureBox picAvatar;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblHint;

        public Guna2TextBox txtUser;
        public Guna2TextBox txtPassword;
        public Guna2Button btnLogin;
    }
}
