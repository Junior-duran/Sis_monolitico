using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Sis_monolitico.Views
{
    partial class FrmGroupChat
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer

        private void InitializeComponent()
        {
            components = new Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            pnlMain = new Guna2Panel();
            pnlCenter = new Guna2Panel();
            pnlMessages = new Guna2Panel();
            pnlBottom = new Guna2Panel();
            txtMessage = new Guna2TextBox();
            btnSend = new Guna2Button();
            pnlRight = new Guna2Panel();
            lstUsers = new ListBox();
            pnlLeft = new Guna2Panel();
            lstRooms = new ListBox();
            pnlTop = new Guna2Panel();
            lblRoom = new Label();
            txtRoomId = new Guna2TextBox();
            this.btnConnect = new Guna2Button();
            pnlMain.SuspendLayout();
            pnlCenter.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 14;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlCenter);
            pnlMain.Controls.Add(pnlRight);
            pnlMain.Controls.Add(pnlLeft);
            pnlMain.Controls.Add(pnlTop);
            pnlMain.CustomizableEdges = customizableEdges21;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.FillColor = Color.FromArgb(12, 12, 22);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.ShadowDecoration.CustomizableEdges = customizableEdges22;
            pnlMain.Size = new Size(1373, 700);
            pnlMain.TabIndex = 0;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(pnlMessages);
            pnlCenter.Controls.Add(pnlBottom);
            pnlCenter.CustomizableEdges = customizableEdges9;
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.FillColor = Color.FromArgb(12, 12, 22);
            pnlCenter.Location = new Point(220, 70);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlCenter.Size = new Size(933, 630);
            pnlCenter.TabIndex = 0;
            // 
            // pnlMessages
            // 
            pnlMessages.AutoScroll = true;
            pnlMessages.BorderRadius = 12;
            pnlMessages.CustomizableEdges = customizableEdges1;
            pnlMessages.Dock = DockStyle.Fill;
            pnlMessages.FillColor = Color.FromArgb(18, 18, 32);
            pnlMessages.Location = new Point(0, 0);
            pnlMessages.Margin = new Padding(10);
            pnlMessages.Name = "pnlMessages";
            pnlMessages.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlMessages.Size = new Size(933, 550);
            pnlMessages.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(txtMessage);
            pnlBottom.Controls.Add(btnSend);
            pnlBottom.CustomizableEdges = customizableEdges7;
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.FillColor = Color.FromArgb(18, 18, 32);
            pnlBottom.Location = new Point(0, 550);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlBottom.Size = new Size(933, 80);
            pnlBottom.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.BorderRadius = 12;
            txtMessage.CustomizableEdges = customizableEdges3;
            txtMessage.DefaultText = "";
            txtMessage.Font = new Font("Segoe UI", 9F);
            txtMessage.Location = new Point(20, 18);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Escribe un mensaje...";
            txtMessage.SelectedText = "";
            txtMessage.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMessage.Size = new Size(750, 44);
            txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.BorderRadius = 12;
            btnSend.CustomizableEdges = customizableEdges5;
            btnSend.FillColor = Color.FromArgb(120, 90, 255);
            btnSend.Font = new Font("Segoe UI", 9F);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(780, 18);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSend.Size = new Size(100, 44);
            btnSend.TabIndex = 1;
            btnSend.Text = "Enviar";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(lstUsers);
            pnlRight.CustomizableEdges = customizableEdges11;
            pnlRight.Dock = DockStyle.Right;
            pnlRight.FillColor = Color.FromArgb(16, 16, 28);
            pnlRight.Location = new Point(1153, 70);
            pnlRight.Name = "pnlRight";
            pnlRight.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlRight.Size = new Size(220, 630);
            pnlRight.TabIndex = 1;
            // 
            // lstUsers
            // 
            lstUsers.BackColor = Color.FromArgb(22, 22, 36);
            lstUsers.BorderStyle = BorderStyle.None;
            lstUsers.Dock = DockStyle.Fill;
            lstUsers.ForeColor = Color.White;
            lstUsers.Location = new Point(0, 0);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(220, 630);
            lstUsers.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(lstRooms);
            pnlLeft.CustomizableEdges = customizableEdges13;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.FillColor = Color.FromArgb(16, 16, 28);
            pnlLeft.Location = new Point(0, 70);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlLeft.Size = new Size(220, 630);
            pnlLeft.TabIndex = 2;
            // 
            // lstRooms
            // 
            lstRooms.BackColor = Color.FromArgb(22, 22, 36);
            lstRooms.BorderStyle = BorderStyle.None;
            lstRooms.Dock = DockStyle.Fill;
            lstRooms.ForeColor = Color.White;
            lstRooms.Items.AddRange(new object[] { "room-1", "soporte", "proyecto", "general" });
            lstRooms.Location = new Point(0, 0);
            lstRooms.Name = "lstRooms";
            lstRooms.Size = new Size(220, 630);
            lstRooms.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblRoom);
            pnlTop.Controls.Add(txtRoomId);
            pnlTop.Controls.Add(this.btnConnect);
            pnlTop.CustomizableEdges = customizableEdges19;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.FillColor = Color.FromArgb(18, 18, 32);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.ShadowDecoration.CustomizableEdges = customizableEdges20;
            pnlTop.Size = new Size(1373, 70);
            pnlTop.TabIndex = 3;
            // 
            // lblRoom
            // 
            lblRoom.ForeColor = Color.White;
            lblRoom.Location = new Point(20, 12);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(100, 36);
            lblRoom.TabIndex = 0;
            lblRoom.Text = "Sala:";
            // 
            // txtRoomId
            // 
            txtRoomId.BorderRadius = 10;
            txtRoomId.CustomizableEdges = customizableEdges15;
            txtRoomId.DefaultText = "room-1";
            txtRoomId.Font = new Font("Segoe UI", 9F);
            txtRoomId.Location = new Point(126, 12);
            txtRoomId.Margin = new Padding(3, 4, 3, 4);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.PlaceholderText = "";
            txtRoomId.SelectedText = "";
            txtRoomId.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtRoomId.Size = new Size(120, 36);
            txtRoomId.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.BorderRadius = 10;
            this.btnConnect.CustomizableEdges = customizableEdges17;
            this.btnConnect.Font = new Font("Segoe UI", 9F);
            this.btnConnect.ForeColor = Color.White;
            this.btnConnect.Location = new Point(275, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.ShadowDecoration.CustomizableEdges = customizableEdges18;
            this.btnConnect.Size = new Size(90, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conectar";
            // 
            // FrmGroupChat
            // 
            BackColor = Color.FromArgb(10, 10, 18);
            ClientSize = new Size(1373, 700);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGroupChat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat Grupal";
            pnlMain.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna2BorderlessForm guna2BorderlessForm1;

        private Guna2Panel pnlMain, pnlTop, pnlLeft, pnlRight, pnlCenter, pnlBottom;
        private Label lblRoom;

        public Guna2TextBox txtRoomId;

        public ListBox lstRooms;
        public ListBox lstUsers;

        public Guna2Panel pnlMessages;
        public Guna2TextBox txtMessage;
        public Guna2Button btnSend;
    }
}
