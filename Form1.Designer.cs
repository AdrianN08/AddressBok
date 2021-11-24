
namespace Addressbook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPhoneNr = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAdressBook = new System.Windows.Forms.GroupBox();
            this.grpSortBy = new System.Windows.Forms.GroupBox();
            this.cbxSortBy = new System.Windows.Forms.ComboBox();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.lblContactList = new System.Windows.Forms.Label();
            this.lbxContactsInfo = new System.Windows.Forms.ListBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpAdressBook.SuspendLayout();
            this.grpSortBy.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.toolStripSeparator1,
            this.tsmOpen,
            this.tsmSave,
            this.tsmSaveAs,
            this.toolStripSeparator2,
            this.tsmReset,
            this.tsmClose});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // tsmNew
            // 
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.Size = new System.Drawing.Size(121, 22);
            this.tsmNew.Text = "New";
            this.tsmNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(121, 22);
            this.tsmOpen.Text = "Open";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(121, 22);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.Size = new System.Drawing.Size(121, 22);
            this.tsmSaveAs.Text = "Save as...";
            this.tsmSaveAs.Click += new System.EventHandler(this.tsmSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // tsmReset
            // 
            this.tsmReset.Name = "tsmReset";
            this.tsmReset.Size = new System.Drawing.Size(121, 22);
            this.tsmReset.Text = "Reset";
            this.tsmReset.Click += new System.EventHandler(this.tsmReset_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(121, 22);
            this.tsmClose.Text = "Close";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.btnClear);
            this.grpContact.Controls.Add(this.btnUpdate);
            this.grpContact.Controls.Add(this.btnRemove);
            this.grpContact.Controls.Add(this.btnAdd);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.lblPhone);
            this.grpContact.Controls.Add(this.lblCity);
            this.grpContact.Controls.Add(this.lblZipCode);
            this.grpContact.Controls.Add(this.lblAdress);
            this.grpContact.Controls.Add(this.lblName);
            this.grpContact.Controls.Add(this.tbxEmail);
            this.grpContact.Controls.Add(this.tbxPhoneNr);
            this.grpContact.Controls.Add(this.tbxCity);
            this.grpContact.Controls.Add(this.tbxZipCode);
            this.grpContact.Controls.Add(this.tbxAdress);
            this.grpContact.Controls.Add(this.tbxName);
            this.grpContact.Location = new System.Drawing.Point(10, 54);
            this.grpContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContact.Name = "grpContact";
            this.grpContact.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContact.Size = new System.Drawing.Size(400, 190);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "New Contact";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(303, 146);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 22);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(210, 146);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 22);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(104, 146);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 22);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(10, 146);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(351, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhone.Location = new System.Drawing.Point(147, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCity.Location = new System.Drawing.Point(359, 76);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lblZipCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZipCode.Location = new System.Drawing.Point(131, 76);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(55, 15);
            this.lblZipCode.TabIndex = 8;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdress.Location = new System.Drawing.Point(344, 40);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(42, 15);
            this.lblAdress.TabIndex = 7;
            this.lblAdress.Text = "Adress";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(147, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(210, 104);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PlaceholderText = "Email";
            this.tbxEmail.Size = new System.Drawing.Size(176, 23);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxPhoneNr
            // 
            this.tbxPhoneNr.Location = new System.Drawing.Point(10, 104);
            this.tbxPhoneNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNr.Name = "tbxPhoneNr";
            this.tbxPhoneNr.PlaceholderText = "Phone";
            this.tbxPhoneNr.Size = new System.Drawing.Size(176, 23);
            this.tbxPhoneNr.TabIndex = 4;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(210, 68);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.PlaceholderText = "City";
            this.tbxCity.Size = new System.Drawing.Size(176, 23);
            this.tbxCity.TabIndex = 3;
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(10, 68);
            this.tbxZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.PlaceholderText = "Zip Code";
            this.tbxZipCode.Size = new System.Drawing.Size(176, 23);
            this.tbxZipCode.TabIndex = 2;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(210, 30);
            this.tbxAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.PlaceholderText = "Adress";
            this.tbxAdress.Size = new System.Drawing.Size(176, 23);
            this.tbxAdress.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(10, 30);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.Name = "tbxName";
            this.tbxName.PlaceholderText = "Name";
            this.tbxName.Size = new System.Drawing.Size(176, 23);
            this.tbxName.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(38, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 15);
            this.lblTitle.TabIndex = 2;
            // 
            // grpAdressBook
            // 
            this.grpAdressBook.Controls.Add(this.grpSortBy);
            this.grpAdressBook.Controls.Add(this.gpSearch);
            this.grpAdressBook.Controls.Add(this.lblContactList);
            this.grpAdressBook.Controls.Add(this.lbxContactsInfo);
            this.grpAdressBook.Location = new System.Drawing.Point(416, 23);
            this.grpAdressBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAdressBook.Name = "grpAdressBook";
            this.grpAdressBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAdressBook.Size = new System.Drawing.Size(410, 221);
            this.grpAdressBook.TabIndex = 3;
            this.grpAdressBook.TabStop = false;
            this.grpAdressBook.Text = "Address Book";
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.cbxSortBy);
            this.grpSortBy.Location = new System.Drawing.Point(205, 36);
            this.grpSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSortBy.Name = "grpSortBy";
            this.grpSortBy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSortBy.Size = new System.Drawing.Size(188, 55);
            this.grpSortBy.TabIndex = 4;
            this.grpSortBy.TabStop = false;
            this.grpSortBy.Text = "Sort By";
            // 
            // cbxSortBy
            // 
            this.cbxSortBy.FormattingEnabled = true;
            this.cbxSortBy.Items.AddRange(new object[] {
            "Name",
            "Adress",
            "Zip Code",
            "City",
            "Phone",
            "Email"});
            this.cbxSortBy.Location = new System.Drawing.Point(5, 20);
            this.cbxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSortBy.Name = "cbxSortBy";
            this.cbxSortBy.Size = new System.Drawing.Size(176, 23);
            this.cbxSortBy.TabIndex = 2;
            this.cbxSortBy.SelectedIndexChanged += new System.EventHandler(this.cbxSortBy_SelectedIndexChanged);
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.label1);
            this.gpSearch.Controls.Add(this.btnCancel);
            this.gpSearch.Controls.Add(this.btnSearch);
            this.gpSearch.Controls.Add(this.tbxSearch);
            this.gpSearch.Controls.Add(this.cbxSearch);
            this.gpSearch.Location = new System.Drawing.Point(205, 97);
            this.gpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpSearch.Size = new System.Drawing.Size(187, 120);
            this.gpSearch.TabIndex = 3;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(145, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(99, 86);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(5, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbxSearch.Location = new System.Drawing.Point(5, 55);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PlaceholderText = "Search";
            this.tbxSearch.Size = new System.Drawing.Size(176, 23);
            this.tbxSearch.TabIndex = 2;
            // 
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "Name",
            "Adress",
            "Zip Code",
            "City",
            "Phone",
            "Email"});
            this.cbxSearch.Location = new System.Drawing.Point(5, 18);
            this.cbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(176, 23);
            this.cbxSearch.TabIndex = 1;
            this.cbxSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
            // 
            // lblContactList
            // 
            this.lblContactList.AutoSize = true;
            this.lblContactList.Location = new System.Drawing.Point(15, 20);
            this.lblContactList.Name = "lblContactList";
            this.lblContactList.Size = new System.Drawing.Size(0, 15);
            this.lblContactList.TabIndex = 1;
            // 
            // lbxContactsInfo
            // 
            this.lbxContactsInfo.FormattingEnabled = true;
            this.lbxContactsInfo.ItemHeight = 15;
            this.lbxContactsInfo.Location = new System.Drawing.Point(15, 36);
            this.lbxContactsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxContactsInfo.Name = "lbxContactsInfo";
            this.lbxContactsInfo.Size = new System.Drawing.Size(176, 169);
            this.lbxContactsInfo.TabIndex = 0;
            this.lbxContactsInfo.SelectedIndexChanged += new System.EventHandler(this.lbxContactsInfo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(838, 271);
            this.Controls.Add(this.grpAdressBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpAdressBook.ResumeLayout(false);
            this.grpAdressBook.PerformLayout();
            this.grpSortBy.ResumeLayout(false);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmReset;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPhoneNr;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAdressBook;
        private System.Windows.Forms.Label lblContactList;
        private System.Windows.Forms.ListBox lbxContactsInfo;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.ComboBox cbxSortBy;
        private System.Windows.Forms.GroupBox grpSortBy;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

