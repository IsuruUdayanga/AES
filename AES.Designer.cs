namespace AES
{
    partial class AES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES));
            this.lblMasterKey = new System.Windows.Forms.Label();
            this.txtMasterKey = new System.Windows.Forms.TextBox();
            this.chShowKey = new System.Windows.Forms.CheckBox();
            this.lblHashAlgorithm = new System.Windows.Forms.Label();
            this.cbHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.gbEncryption = new System.Windows.Forms.GroupBox();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.gbFileSelection = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReadOnly = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastWrite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastAccess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.gbContainer.SuspendLayout();
            this.gbEncryption.SuspendLayout();
            this.gbSetup.SuspendLayout();
            this.gbFileSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasterKey
            // 
            this.lblMasterKey.AutoSize = true;
            this.lblMasterKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterKey.Location = new System.Drawing.Point(9, 26);
            this.lblMasterKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasterKey.Name = "lblMasterKey";
            this.lblMasterKey.Size = new System.Drawing.Size(87, 21);
            this.lblMasterKey.TabIndex = 0;
            this.lblMasterKey.Text = "Master Key";
            // 
            // txtMasterKey
            // 
            this.txtMasterKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMasterKey.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterKey.Location = new System.Drawing.Point(97, 24);
            this.txtMasterKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasterKey.MaxLength = 24;
            this.txtMasterKey.Name = "txtMasterKey";
            this.txtMasterKey.Size = new System.Drawing.Size(233, 26);
            this.txtMasterKey.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtMasterKey, "Create your master key. Becareful do not lose your master key or give it to anyon" +
        "e");
            this.txtMasterKey.UseSystemPasswordChar = true;
            this.txtMasterKey.TextChanged += new System.EventHandler(this.txtMasterKey_TextChanged);
            // 
            // chShowKey
            // 
            this.chShowKey.AutoSize = true;
            this.chShowKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chShowKey.Location = new System.Drawing.Point(253, 57);
            this.chShowKey.Margin = new System.Windows.Forms.Padding(4);
            this.chShowKey.Name = "chShowKey";
            this.chShowKey.Size = new System.Drawing.Size(77, 19);
            this.chShowKey.TabIndex = 2;
            this.chShowKey.Text = "Show Key";
            this.chShowKey.UseVisualStyleBackColor = true;
            this.chShowKey.CheckedChanged += new System.EventHandler(this.chShowKey_CheckedChanged);
            // 
            // lblHashAlgorithm
            // 
            this.lblHashAlgorithm.AutoSize = true;
            this.lblHashAlgorithm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashAlgorithm.Location = new System.Drawing.Point(9, 53);
            this.lblHashAlgorithm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHashAlgorithm.Name = "lblHashAlgorithm";
            this.lblHashAlgorithm.Size = new System.Drawing.Size(119, 21);
            this.lblHashAlgorithm.TabIndex = 0;
            this.lblHashAlgorithm.Text = "Hash Algorithm";
            // 
            // cbHashAlgorithm
            // 
            this.cbHashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHashAlgorithm.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHashAlgorithm.FormattingEnabled = true;
            this.cbHashAlgorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA256",
            "SHA512"});
            this.cbHashAlgorithm.Location = new System.Drawing.Point(131, 53);
            this.cbHashAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.cbHashAlgorithm.Name = "cbHashAlgorithm";
            this.cbHashAlgorithm.Size = new System.Drawing.Size(101, 25);
            this.cbHashAlgorithm.TabIndex = 3;
            this.toolTip.SetToolTip(this.cbHashAlgorithm, "Generate Keys using which algorithm. If you don\'t  have any idea what this means," +
        " Then don\'t touch it. :-}");
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(9, 26);
            this.lblFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(74, 21);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Directory";
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.gbEncryption);
            this.gbContainer.Controls.Add(this.gbSetup);
            this.gbContainer.Controls.Add(this.gbFileSelection);
            this.gbContainer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContainer.Location = new System.Drawing.Point(13, 9);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(4);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(4);
            this.gbContainer.Size = new System.Drawing.Size(358, 436);
            this.gbContainer.TabIndex = 6;
            this.gbContainer.TabStop = false;
            // 
            // gbEncryption
            // 
            this.gbEncryption.Controls.Add(this.rbDecrypt);
            this.gbEncryption.Controls.Add(this.rbEncrypt);
            this.gbEncryption.Controls.Add(this.btnDecrypt);
            this.gbEncryption.Controls.Add(this.btnEncrypt);
            this.gbEncryption.Enabled = false;
            this.gbEncryption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEncryption.Location = new System.Drawing.Point(7, 327);
            this.gbEncryption.Name = "gbEncryption";
            this.gbEncryption.Size = new System.Drawing.Size(339, 100);
            this.gbEncryption.TabIndex = 9;
            this.gbEncryption.TabStop = false;
            this.gbEncryption.Text = "Encrypt  && Decrypt";
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.Location = new System.Drawing.Point(12, 21);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(276, 31);
            this.rbDecrypt.TabIndex = 5;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt \"FILE NOT FOUND\"";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.Location = new System.Drawing.Point(12, 55);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(276, 31);
            this.rbEncrypt.TabIndex = 5;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt \"FILE NOT FOUND\"";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.ImageIndex = 2;
            this.btnDecrypt.ImageList = this.imageList;
            this.btnDecrypt.Location = new System.Drawing.Point(295, 21);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(36, 31);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "correct.png");
            this.imageList.Images.SetKeyName(1, "lock.png");
            this.imageList.Images.SetKeyName(2, "unlock.png");
            this.imageList.Images.SetKeyName(3, "about.png");
            this.imageList.Images.SetKeyName(4, "reset.png");
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.ImageIndex = 1;
            this.btnEncrypt.ImageList = this.imageList;
            this.btnEncrypt.Location = new System.Drawing.Point(295, 55);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(36, 31);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.txtMasterKey);
            this.gbSetup.Controls.Add(this.chShowKey);
            this.gbSetup.Controls.Add(this.lblHashAlgorithm);
            this.gbSetup.Controls.Add(this.cbHashAlgorithm);
            this.gbSetup.Controls.Add(this.lblMasterKey);
            this.gbSetup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSetup.Location = new System.Drawing.Point(8, 14);
            this.gbSetup.Margin = new System.Windows.Forms.Padding(4);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Padding = new System.Windows.Forms.Padding(4);
            this.gbSetup.Size = new System.Drawing.Size(340, 92);
            this.gbSetup.TabIndex = 8;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Master password";
            // 
            // gbFileSelection
            // 
            this.gbFileSelection.Controls.Add(this.txtFileName);
            this.gbFileSelection.Controls.Add(this.label7);
            this.gbFileSelection.Controls.Add(this.lblSize);
            this.gbFileSelection.Controls.Add(this.label6);
            this.gbFileSelection.Controls.Add(this.lblReadOnly);
            this.gbFileSelection.Controls.Add(this.label5);
            this.gbFileSelection.Controls.Add(this.lblLastWrite);
            this.gbFileSelection.Controls.Add(this.label4);
            this.gbFileSelection.Controls.Add(this.lblLastAccess);
            this.gbFileSelection.Controls.Add(this.label2);
            this.gbFileSelection.Controls.Add(this.lblExtension);
            this.gbFileSelection.Controls.Add(this.label1);
            this.gbFileSelection.Controls.Add(this.lblName);
            this.gbFileSelection.Controls.Add(this.label3);
            this.gbFileSelection.Controls.Add(this.lblCreate);
            this.gbFileSelection.Controls.Add(this.lblFile);
            this.gbFileSelection.Controls.Add(this.btnSelect);
            this.gbFileSelection.Enabled = false;
            this.gbFileSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFileSelection.Location = new System.Drawing.Point(8, 105);
            this.gbFileSelection.Margin = new System.Windows.Forms.Padding(4);
            this.gbFileSelection.Name = "gbFileSelection";
            this.gbFileSelection.Padding = new System.Windows.Forms.Padding(4);
            this.gbFileSelection.Size = new System.Drawing.Size(340, 221);
            this.gbFileSelection.TabIndex = 7;
            this.gbFileSelection.TabStop = false;
            this.gbFileSelection.Text = "File Selection &&  File Info";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(91, 32);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.MaxLength = 1000;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(205, 15);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Text = "Not Selected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "File Size :";
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(100, 184);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(230, 19);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Not Found";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Is ReadOnly :";
            // 
            // lblReadOnly
            // 
            this.lblReadOnly.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadOnly.Location = new System.Drawing.Point(127, 163);
            this.lblReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReadOnly.Name = "lblReadOnly";
            this.lblReadOnly.Size = new System.Drawing.Size(203, 19);
            this.lblReadOnly.TabIndex = 0;
            this.lblReadOnly.Text = "Not Found";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Write :";
            // 
            // lblLastWrite
            // 
            this.lblLastWrite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastWrite.Location = new System.Drawing.Point(103, 142);
            this.lblLastWrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastWrite.Name = "lblLastWrite";
            this.lblLastWrite.Size = new System.Drawing.Size(227, 19);
            this.lblLastWrite.TabIndex = 0;
            this.lblLastWrite.Text = "Not Found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Access :";
            // 
            // lblLastAccess
            // 
            this.lblLastAccess.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAccess.Location = new System.Drawing.Point(113, 121);
            this.lblLastAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastAccess.Name = "lblLastAccess";
            this.lblLastAccess.Size = new System.Drawing.Size(217, 19);
            this.lblLastAccess.TabIndex = 0;
            this.lblLastAccess.Text = "Not Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Extension  :";
            // 
            // lblExtension
            // 
            this.lblExtension.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(103, 79);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(227, 19);
            this.lblExtension.TabIndex = 0;
            this.lblExtension.Text = "Not Found";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(86, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(244, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Not Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Created :";
            // 
            // lblCreate
            // 
            this.lblCreate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(86, 100);
            this.lblCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(244, 19);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Not Found";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.ImageIndex = 0;
            this.btnSelect.ImageList = this.imageList;
            this.btnSelect.Location = new System.Drawing.Point(304, 23);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(26, 26);
            this.btnSelect.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnSelect, "Select your file");
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FileSelector
            // 
            this.FileSelector.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.FileSelector.Title = "AES  - File Selection";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.ImageIndex = 3;
            this.btnAbout.ImageList = this.imageList;
            this.btnAbout.Location = new System.Drawing.Point(64, 454);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(36, 31);
            this.btnAbout.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImageIndex = 4;
            this.btnReset.ImageList = this.imageList;
            this.btnReset.Location = new System.Drawing.Point(21, 454);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(36, 31);
            this.btnReset.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnReset, "Reset Controllers");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(202, 461);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(171, 19);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Find me on GitHub.";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 495);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 534);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 534);
            this.Name = "AES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES Encryptor";
            this.Load += new System.EventHandler(this.AES_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbEncryption.ResumeLayout(false);
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.gbFileSelection.ResumeLayout(false);
            this.gbFileSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasterKey;
        private System.Windows.Forms.TextBox txtMasterKey;
        private System.Windows.Forms.CheckBox chShowKey;
        private System.Windows.Forms.Label lblHashAlgorithm;
        private System.Windows.Forms.ComboBox cbHashAlgorithm;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.OpenFileDialog FileSelector;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.GroupBox gbFileSelection;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblLastAccess;
        private System.Windows.Forms.Label lblLastWrite;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblReadOnly;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.GroupBox gbEncryption;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}