using System.Drawing;

namespace userForm
{
    partial class form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnSpam = new System.Windows.Forms.Button();
            this.btnSent = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnCompose = new System.Windows.Forms.Button();
            this.labelNiv = new System.Windows.Forms.Label();
            this.labelnav = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelMsgContaioner = new System.Windows.Forms.Panel();
            this.buttonReply = new System.Windows.Forms.Button();
            this.labelPdf = new System.Windows.Forms.Label();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelAttachment = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMsgTitle = new System.Windows.Forms.Label();
            this.labelSenderIcon = new System.Windows.Forms.Label();
            this.labelMsg5 = new System.Windows.Forms.Label();
            this.labelMsg4 = new System.Windows.Forms.Label();
            this.labelSender5 = new System.Windows.Forms.Label();
            this.labelSender4 = new System.Windows.Forms.Label();
            this.buttonMsg5 = new System.Windows.Forms.Button();
            this.buttonMsg4 = new System.Windows.Forms.Button();
            this.labelMsg3 = new System.Windows.Forms.Label();
            this.labelSender3 = new System.Windows.Forms.Label();
            this.buttonMsg3 = new System.Windows.Forms.Button();
            this.labelMsg2 = new System.Windows.Forms.Label();
            this.labelSender2 = new System.Windows.Forms.Label();
            this.buttonMsg2 = new System.Windows.Forms.Button();
            this.labelMsg1 = new System.Windows.Forms.Label();
            this.labelSender1 = new System.Windows.Forms.Label();
            this.buttonMsg1 = new System.Windows.Forms.Button();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buttonRightIcon = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.panelNav.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelMsgContaioner.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.panelNav.Controls.Add(this.btnTrash);
            this.panelNav.Controls.Add(this.btnDraft);
            this.panelNav.Controls.Add(this.btnSpam);
            this.panelNav.Controls.Add(this.btnSent);
            this.panelNav.Controls.Add(this.btnInbox);
            this.panelNav.Controls.Add(this.btnCompose);
            this.panelNav.Controls.Add(this.labelNiv);
            this.panelNav.Controls.Add(this.labelnav);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(170, 676);
            this.panelNav.TabIndex = 0;
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.Image")));
            this.btnTrash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrash.Location = new System.Drawing.Point(0, 376);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btnTrash.Size = new System.Drawing.Size(170, 41);
            this.btnTrash.TabIndex = 7;
            this.btnTrash.Text = "  Trash";
            this.btnTrash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.MouseEnter += new System.EventHandler(this.btnTrash_MouseEnter);
            this.btnTrash.MouseLeave += new System.EventHandler(this.btnTrash_MouseLeave);
            // 
            // btnDraft
            // 
            this.btnDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.btnDraft.FlatAppearance.BorderSize = 0;
            this.btnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraft.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDraft.Image = ((System.Drawing.Image)(resources.GetObject("btnDraft.Image")));
            this.btnDraft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDraft.Location = new System.Drawing.Point(0, 249);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btnDraft.Size = new System.Drawing.Size(170, 41);
            this.btnDraft.TabIndex = 6;
            this.btnDraft.Text = "  Draft";
            this.btnDraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDraft.UseVisualStyleBackColor = false;
            this.btnDraft.MouseEnter += new System.EventHandler(this.btnDraft_MouseEnter);
            this.btnDraft.MouseLeave += new System.EventHandler(this.btnDraft_MouseLeave);
            // 
            // btnSpam
            // 
            this.btnSpam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.btnSpam.FlatAppearance.BorderSize = 0;
            this.btnSpam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpam.Image = ((System.Drawing.Image)(resources.GetObject("btnSpam.Image")));
            this.btnSpam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSpam.Location = new System.Drawing.Point(0, 311);
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btnSpam.Size = new System.Drawing.Size(170, 41);
            this.btnSpam.TabIndex = 5;
            this.btnSpam.Text = "  Spam";
            this.btnSpam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpam.UseVisualStyleBackColor = false;
            this.btnSpam.MouseEnter += new System.EventHandler(this.btnSpam_MouseEnter);
            this.btnSpam.MouseLeave += new System.EventHandler(this.btnSpam_MouseLeave);
            // 
            // btnSent
            // 
            this.btnSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.btnSent.FlatAppearance.BorderSize = 0;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSent.Image = ((System.Drawing.Image)(resources.GetObject("btnSent.Image")));
            this.btnSent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSent.Location = new System.Drawing.Point(0, 185);
            this.btnSent.Name = "btnSent";
            this.btnSent.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.btnSent.Size = new System.Drawing.Size(170, 41);
            this.btnSent.TabIndex = 4;
            this.btnSent.Text = "  Sent";
            this.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSent.UseVisualStyleBackColor = false;
            this.btnSent.MouseEnter += new System.EventHandler(this.btnSent_MouseEnter);
            this.btnSent.MouseLeave += new System.EventHandler(this.btnSent_MouseLeave);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInbox.Image = ((System.Drawing.Image)(resources.GetObject("btnInbox.Image")));
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInbox.Location = new System.Drawing.Point(0, 118);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btnInbox.Size = new System.Drawing.Size(170, 41);
            this.btnInbox.TabIndex = 3;
            this.btnInbox.Text = "  Inbox";
            this.btnInbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.MouseEnter += new System.EventHandler(this.btnInbox_MouseEnter);
            this.btnInbox.MouseLeave += new System.EventHandler(this.btnInbox_MouseLeave);
            // 
            // btnCompose
            // 
            this.btnCompose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompose.Image = ((System.Drawing.Image)(resources.GetObject("btnCompose.Image")));
            this.btnCompose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCompose.Location = new System.Drawing.Point(22, 56);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(117, 37);
            this.btnCompose.TabIndex = 0;
            this.btnCompose.Text = "Compose";
            this.btnCompose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompose.UseVisualStyleBackColor = true;
            this.btnCompose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNiv
            // 
            this.labelNiv.Image = ((System.Drawing.Image)(resources.GetObject("labelNiv.Image")));
            this.labelNiv.Location = new System.Drawing.Point(12, 9);
            this.labelNiv.Name = "labelNiv";
            this.labelNiv.Size = new System.Drawing.Size(41, 26);
            this.labelNiv.TabIndex = 1;
            // 
            // labelnav
            // 
            this.labelnav.Location = new System.Drawing.Point(0, 0);
            this.labelnav.Name = "labelnav";
            this.labelnav.Size = new System.Drawing.Size(100, 23);
            this.labelnav.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panelRight.Controls.Add(this.panelMsgContaioner);
            this.panelRight.Controls.Add(this.labelMsg5);
            this.panelRight.Controls.Add(this.labelMsg4);
            this.panelRight.Controls.Add(this.labelSender5);
            this.panelRight.Controls.Add(this.labelSender4);
            this.panelRight.Controls.Add(this.buttonMsg5);
            this.panelRight.Controls.Add(this.buttonMsg4);
            this.panelRight.Controls.Add(this.labelMsg3);
            this.panelRight.Controls.Add(this.labelSender3);
            this.panelRight.Controls.Add(this.buttonMsg3);
            this.panelRight.Controls.Add(this.labelMsg2);
            this.panelRight.Controls.Add(this.labelSender2);
            this.panelRight.Controls.Add(this.buttonMsg2);
            this.panelRight.Controls.Add(this.labelMsg1);
            this.panelRight.Controls.Add(this.labelSender1);
            this.panelRight.Controls.Add(this.buttonMsg1);
            this.panelRight.Controls.Add(this.labelLine);
            this.panelRight.Controls.Add(this.labelSearchIcon);
            this.panelRight.Controls.Add(this.txtSearch);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelRight.Location = new System.Drawing.Point(170, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(736, 676);
            this.panelRight.TabIndex = 1;
            // 
            // panelMsgContaioner
            // 
            this.panelMsgContaioner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMsgContaioner.BackColor = System.Drawing.Color.White;
            this.panelMsgContaioner.Controls.Add(this.buttonRightIcon);
            this.panelMsgContaioner.Controls.Add(this.buttonReply);
            this.panelMsgContaioner.Controls.Add(this.labelPdf);
            this.panelMsgContaioner.Controls.Add(this.labelDoc);
            this.panelMsgContaioner.Controls.Add(this.labelAttachment);
            this.panelMsgContaioner.Controls.Add(this.richTextBox1);
            this.panelMsgContaioner.Controls.Add(this.labelDate);
            this.panelMsgContaioner.Controls.Add(this.labelMsgTitle);
            this.panelMsgContaioner.Controls.Add(this.labelSenderIcon);
            this.panelMsgContaioner.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelMsgContaioner.Location = new System.Drawing.Point(323, 96);
            this.panelMsgContaioner.Name = "panelMsgContaioner";
            this.panelMsgContaioner.Size = new System.Drawing.Size(401, 569);
            this.panelMsgContaioner.TabIndex = 17;
            // 
            // buttonReply
            // 
            this.buttonReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.buttonReply.FlatAppearance.BorderSize = 0;
            this.buttonReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReply.Location = new System.Drawing.Point(295, 517);
            this.buttonReply.Name = "buttonReply";
            this.buttonReply.Size = new System.Drawing.Size(87, 39);
            this.buttonReply.TabIndex = 8;
            this.buttonReply.Text = "Reply";
            this.buttonReply.UseVisualStyleBackColor = false;
            // 
            // labelPdf
            // 
            this.labelPdf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPdf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPdf.Image = ((System.Drawing.Image)(resources.GetObject("labelPdf.Image")));
            this.labelPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPdf.Location = new System.Drawing.Point(213, 461);
            this.labelPdf.Name = "labelPdf";
            this.labelPdf.Size = new System.Drawing.Size(141, 34);
            this.labelPdf.TabIndex = 7;
            this.labelPdf.Text = "   Guide.pdf";
            this.labelPdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDoc
            // 
            this.labelDoc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDoc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDoc.Image = ((System.Drawing.Image)(resources.GetObject("labelDoc.Image")));
            this.labelDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDoc.Location = new System.Drawing.Point(32, 458);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(151, 38);
            this.labelDoc.TabIndex = 6;
            this.labelDoc.Text = "   summary.doc";
            this.labelDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAttachment
            // 
            this.labelAttachment.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAttachment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAttachment.Image = ((System.Drawing.Image)(resources.GetObject("labelAttachment.Image")));
            this.labelAttachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAttachment.Location = new System.Drawing.Point(30, 410);
            this.labelAttachment.Name = "labelAttachment";
            this.labelAttachment.Size = new System.Drawing.Size(141, 34);
            this.labelAttachment.TabIndex = 5;
            this.labelAttachment.Text = "   attachment";
            this.labelAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.richTextBox1.Location = new System.Drawing.Point(31, 161);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 240);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Dear all\n\nThe metting scheduled on tomorrow will be post-phoned due to heavy rain" +
    "s recent happening in our area.\n\n\nThe metting summary last week in attachment.";
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(32, 109);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(133, 19);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "8-22 10:00";
            // 
            // labelMsgTitle
            // 
            this.labelMsgTitle.AutoSize = true;
            this.labelMsgTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.labelMsgTitle.Location = new System.Drawing.Point(26, 65);
            this.labelMsgTitle.Name = "labelMsgTitle";
            this.labelMsgTitle.Size = new System.Drawing.Size(224, 26);
            this.labelMsgTitle.TabIndex = 2;
            this.labelMsgTitle.Text = "Meeting Notification";
            // 
            // labelSenderIcon
            // 
            this.labelSenderIcon.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSenderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.labelSenderIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelSenderIcon.Image")));
            this.labelSenderIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSenderIcon.Location = new System.Drawing.Point(23, 13);
            this.labelSenderIcon.Name = "labelSenderIcon";
            this.labelSenderIcon.Size = new System.Drawing.Size(141, 34);
            this.labelSenderIcon.TabIndex = 0;
            this.labelSenderIcon.Text = "Matthew";
            this.labelSenderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMsg5
            // 
            this.labelMsg5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg5.BackColor = System.Drawing.Color.White;
            this.labelMsg5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMsg5.Location = new System.Drawing.Point(30, 554);
            this.labelMsg5.Name = "labelMsg5";
            this.labelMsg5.Size = new System.Drawing.Size(258, 38);
            this.labelMsg5.TabIndex = 10;
            this.labelMsg5.Text = "New Follower Noticication";
            // 
            // labelMsg4
            // 
            this.labelMsg4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg4.BackColor = System.Drawing.Color.White;
            this.labelMsg4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMsg4.Location = new System.Drawing.Point(29, 447);
            this.labelMsg4.Name = "labelMsg4";
            this.labelMsg4.Size = new System.Drawing.Size(259, 30);
            this.labelMsg4.TabIndex = 16;
            this.labelMsg4.Text = "New Follower Noticication";
            // 
            // labelSender5
            // 
            this.labelSender5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSender5.BackColor = System.Drawing.Color.White;
            this.labelSender5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSender5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSender5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.labelSender5.Image = ((System.Drawing.Image)(resources.GetObject("labelSender5.Image")));
            this.labelSender5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSender5.Location = new System.Drawing.Point(28, 525);
            this.labelSender5.Name = "labelSender5";
            this.labelSender5.Size = new System.Drawing.Size(141, 22);
            this.labelSender5.TabIndex = 9;
            this.labelSender5.Text = "Andrew Chen  ";
            this.labelSender5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSender4
            // 
            this.labelSender4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSender4.BackColor = System.Drawing.Color.White;
            this.labelSender4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSender4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSender4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.labelSender4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSender4.Location = new System.Drawing.Point(23, 413);
            this.labelSender4.Name = "labelSender4";
            this.labelSender4.Size = new System.Drawing.Size(173, 28);
            this.labelSender4.TabIndex = 15;
            this.labelSender4.Text = "Marry Anderson";
            this.labelSender4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonMsg5
            // 
            this.buttonMsg5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMsg5.BackColor = System.Drawing.Color.White;
            this.buttonMsg5.Location = new System.Drawing.Point(16, 501);
            this.buttonMsg5.Name = "buttonMsg5";
            this.buttonMsg5.Size = new System.Drawing.Size(275, 93);
            this.buttonMsg5.TabIndex = 8;
            this.buttonMsg5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMsg5.UseVisualStyleBackColor = false;
            // 
            // buttonMsg4
            // 
            this.buttonMsg4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMsg4.BackColor = System.Drawing.Color.White;
            this.buttonMsg4.Location = new System.Drawing.Point(16, 397);
            this.buttonMsg4.Name = "buttonMsg4";
            this.buttonMsg4.Size = new System.Drawing.Size(275, 93);
            this.buttonMsg4.TabIndex = 14;
            this.buttonMsg4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMsg4.UseVisualStyleBackColor = false;
            // 
            // labelMsg3
            // 
            this.labelMsg3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg3.BackColor = System.Drawing.Color.White;
            this.labelMsg3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMsg3.Location = new System.Drawing.Point(32, 342);
            this.labelMsg3.Name = "labelMsg3";
            this.labelMsg3.Size = new System.Drawing.Size(255, 45);
            this.labelMsg3.TabIndex = 13;
            this.labelMsg3.Text = "IOS App design project";
            // 
            // labelSender3
            // 
            this.labelSender3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSender3.BackColor = System.Drawing.Color.White;
            this.labelSender3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSender3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSender3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.labelSender3.Image = ((System.Drawing.Image)(resources.GetObject("labelSender3.Image")));
            this.labelSender3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSender3.Location = new System.Drawing.Point(19, 311);
            this.labelSender3.Name = "labelSender3";
            this.labelSender3.Size = new System.Drawing.Size(119, 25);
            this.labelSender3.TabIndex = 12;
            this.labelSender3.Text = "Kevin S ";
            this.labelSender3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonMsg3
            // 
            this.buttonMsg3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMsg3.BackColor = System.Drawing.Color.White;
            this.buttonMsg3.Location = new System.Drawing.Point(16, 296);
            this.buttonMsg3.Name = "buttonMsg3";
            this.buttonMsg3.Size = new System.Drawing.Size(275, 93);
            this.buttonMsg3.TabIndex = 11;
            this.buttonMsg3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMsg3.UseVisualStyleBackColor = false;
            // 
            // labelMsg2
            // 
            this.labelMsg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg2.BackColor = System.Drawing.Color.White;
            this.labelMsg2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMsg2.Location = new System.Drawing.Point(32, 249);
            this.labelMsg2.Name = "labelMsg2";
            this.labelMsg2.Size = new System.Drawing.Size(255, 33);
            this.labelMsg2.TabIndex = 10;
            this.labelMsg2.Text = "Metting Noticication";
            // 
            // labelSender2
            // 
            this.labelSender2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSender2.BackColor = System.Drawing.Color.White;
            this.labelSender2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSender2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSender2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.labelSender2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSender2.Location = new System.Drawing.Point(22, 215);
            this.labelSender2.Name = "labelSender2";
            this.labelSender2.Size = new System.Drawing.Size(111, 22);
            this.labelSender2.TabIndex = 9;
            this.labelSender2.Text = "Matthew ";
            this.labelSender2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSender2.Click += new System.EventHandler(this.labelSender2_Click);
            // 
            // buttonMsg2
            // 
            this.buttonMsg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMsg2.BackColor = System.Drawing.Color.White;
            this.buttonMsg2.Location = new System.Drawing.Point(16, 196);
            this.buttonMsg2.Name = "buttonMsg2";
            this.buttonMsg2.Size = new System.Drawing.Size(275, 93);
            this.buttonMsg2.TabIndex = 8;
            this.buttonMsg2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMsg2.UseVisualStyleBackColor = false;
            // 
            // labelMsg1
            // 
            this.labelMsg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg1.BackColor = System.Drawing.Color.White;
            this.labelMsg1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMsg1.Location = new System.Drawing.Point(30, 142);
            this.labelMsg1.Name = "labelMsg1";
            this.labelMsg1.Size = new System.Drawing.Size(258, 38);
            this.labelMsg1.TabIndex = 7;
            this.labelMsg1.Text = "New Follower Noticication";
            // 
            // labelSender1
            // 
            this.labelSender1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSender1.BackColor = System.Drawing.Color.White;
            this.labelSender1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSender1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSender1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(157)))));
            this.labelSender1.Image = ((System.Drawing.Image)(resources.GetObject("labelSender1.Image")));
            this.labelSender1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSender1.Location = new System.Drawing.Point(28, 113);
            this.labelSender1.Name = "labelSender1";
            this.labelSender1.Size = new System.Drawing.Size(141, 22);
            this.labelSender1.TabIndex = 6;
            this.labelSender1.Text = "Andrew Chen  ";
            this.labelSender1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonMsg1
            // 
            this.buttonMsg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMsg1.BackColor = System.Drawing.Color.Transparent;
            this.buttonMsg1.Location = new System.Drawing.Point(16, 95);
            this.buttonMsg1.Name = "buttonMsg1";
            this.buttonMsg1.Size = new System.Drawing.Size(275, 93);
            this.buttonMsg1.TabIndex = 5;
            this.buttonMsg1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMsg1.UseVisualStyleBackColor = false;
            // 
            // labelLine
            // 
            this.labelLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLine.Location = new System.Drawing.Point(32, 67);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(230, 1);
            this.labelLine.TabIndex = 4;
            this.labelLine.Text = "label1";
            // 
            // labelSearchIcon
            // 
            this.labelSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchIcon.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelSearchIcon.Image")));
            this.labelSearchIcon.Location = new System.Drawing.Point(33, 36);
            this.labelSearchIcon.Name = "labelSearchIcon";
            this.labelSearchIcon.Size = new System.Drawing.Size(39, 31);
            this.labelSearchIcon.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Location = new System.Drawing.Point(71, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "search";
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // buttonRightIcon
            // 
            this.buttonRightIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightIcon.ForeColor = System.Drawing.Color.White;
            this.buttonRightIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonRightIcon.Image")));
            this.buttonRightIcon.Location = new System.Drawing.Point(322, 14);
            this.buttonRightIcon.Name = "buttonRightIcon";
            this.buttonRightIcon.Size = new System.Drawing.Size(60, 29);
            this.buttonRightIcon.TabIndex = 18;
            this.buttonRightIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRightIcon.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete,
            this.Save});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 64);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 30);
            this.Delete.Text = "Delete";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(136, 30);
            this.Save.Text = "Save";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 676);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelNav);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.panelNav.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelMsgContaioner.ResumeLayout(false);
            this.panelMsgContaioner.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label labelnav;
        private System.Windows.Forms.Label labelNiv;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnSpam;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelSearchIcon;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Button buttonMsg1;
        private System.Windows.Forms.Label labelSender1;
        private System.Windows.Forms.Label labelMsg1;
        private System.Windows.Forms.Label labelMsg3;
        private System.Windows.Forms.Label labelSender3;
        private System.Windows.Forms.Button buttonMsg3;
        private System.Windows.Forms.Label labelMsg2;
        private System.Windows.Forms.Label labelSender2;
        private System.Windows.Forms.Button buttonMsg2;
        private System.Windows.Forms.Label labelMsg4;
        private System.Windows.Forms.Label labelSender4;
        private System.Windows.Forms.Button buttonMsg4;
        private System.Windows.Forms.Panel panelMsgContaioner;
        private System.Windows.Forms.Label labelMsg5;
        private System.Windows.Forms.Label labelSender5;
        private System.Windows.Forms.Button buttonMsg5;
        private System.Windows.Forms.Label labelSenderIcon;
        private System.Windows.Forms.Label labelMsgTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPdf;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelAttachment;
        private System.Windows.Forms.Button buttonReply;
        private System.Windows.Forms.Button buttonRightIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Save;
    }
}