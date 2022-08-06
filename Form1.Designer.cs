namespace StudentDataStoreUsingStruct
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openStudentRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStudentRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeStudentRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridDisplayStudentRecord = new System.Windows.Forms.DataGridView();
            this.groupBoxStudentRecordEntry = new System.Windows.Forms.GroupBox();
            this.labelAddMessage = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxMonthOfAdmission = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.dtPickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelMonthOfAdmission = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.groupBoxStudentRecordDisplay = new System.Windows.Forms.GroupBox();
            this.groupBoxStudentRecordDeletion = new System.Windows.Forms.GroupBox();
            this.labelDeleteMessage2 = new System.Windows.Forms.Label();
            this.labelDeleteMessage1 = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplayStudentRecord)).BeginInit();
            this.groupBoxStudentRecordEntry.SuspendLayout();
            this.groupBoxStudentRecordDisplay.SuspendLayout();
            this.groupBoxStudentRecordDeletion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStudentRecordsToolStripMenuItem,
            this.saveAllChangesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openStudentRecordsToolStripMenuItem
            // 
            this.openStudentRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStudentRecordsToolStripMenuItem1,
            this.closeStudentRecordsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.openStudentRecordsToolStripMenuItem.Name = "openStudentRecordsToolStripMenuItem";
            this.openStudentRecordsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openStudentRecordsToolStripMenuItem.Text = "File";
            // 
            // openStudentRecordsToolStripMenuItem1
            // 
            this.openStudentRecordsToolStripMenuItem1.Name = "openStudentRecordsToolStripMenuItem1";
            this.openStudentRecordsToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.openStudentRecordsToolStripMenuItem1.Text = "Open Student Records";
            this.openStudentRecordsToolStripMenuItem1.Click += new System.EventHandler(this.openStudentRecordsToolStripMenuItem1_Click);
            // 
            // closeStudentRecordsToolStripMenuItem
            // 
            this.closeStudentRecordsToolStripMenuItem.Name = "closeStudentRecordsToolStripMenuItem";
            this.closeStudentRecordsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.closeStudentRecordsToolStripMenuItem.Text = "Close Student Records";
            this.closeStudentRecordsToolStripMenuItem.Click += new System.EventHandler(this.closeStudentRecordsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveAllChangesToolStripMenuItem
            // 
            this.saveAllChangesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.saveAllChangesToolStripMenuItem.Name = "saveAllChangesToolStripMenuItem";
            this.saveAllChangesToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.saveAllChangesToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.undoToolStripMenuItem.Text = "Undo                   Ctrl+Z";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.redoToolStripMenuItem.Text = "Redo                    Ctrl+Y";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.licensesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // licensesToolStripMenuItem
            // 
            this.licensesToolStripMenuItem.Name = "licensesToolStripMenuItem";
            this.licensesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.licensesToolStripMenuItem.Text = "Licenses";
            // 
            // gridDisplayStudentRecord
            // 
            this.gridDisplayStudentRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridDisplayStudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDisplayStudentRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridDisplayStudentRecord.Location = new System.Drawing.Point(0, 19);
            this.gridDisplayStudentRecord.Name = "gridDisplayStudentRecord";
            this.gridDisplayStudentRecord.Size = new System.Drawing.Size(693, 590);
            this.gridDisplayStudentRecord.TabIndex = 2;
            // 
            // groupBoxStudentRecordEntry
            // 
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelAddMessage);
            this.groupBoxStudentRecordEntry.Controls.Add(this.comboBoxGrade);
            this.groupBoxStudentRecordEntry.Controls.Add(this.comboBoxMonthOfAdmission);
            this.groupBoxStudentRecordEntry.Controls.Add(this.textBoxAddress);
            this.groupBoxStudentRecordEntry.Controls.Add(this.textBoxLastName);
            this.groupBoxStudentRecordEntry.Controls.Add(this.textBoxFirstName);
            this.groupBoxStudentRecordEntry.Controls.Add(this.textBoxStudentID);
            this.groupBoxStudentRecordEntry.Controls.Add(this.dtPickerDateOfBirth);
            this.groupBoxStudentRecordEntry.Controls.Add(this.buttonAddRecord);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelGrade);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelMonthOfAdmission);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelAddress);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelDateOfBirth);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelLastName);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelFirstName);
            this.groupBoxStudentRecordEntry.Controls.Add(this.labelStudentID);
            this.groupBoxStudentRecordEntry.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.groupBoxStudentRecordEntry.Location = new System.Drawing.Point(12, 56);
            this.groupBoxStudentRecordEntry.Name = "groupBoxStudentRecordEntry";
            this.groupBoxStudentRecordEntry.Size = new System.Drawing.Size(326, 367);
            this.groupBoxStudentRecordEntry.TabIndex = 3;
            this.groupBoxStudentRecordEntry.TabStop = false;
            this.groupBoxStudentRecordEntry.Text = "Student Record Entry";
            this.groupBoxStudentRecordEntry.Visible = false;
            // 
            // labelAddMessage
            // 
            this.labelAddMessage.AutoSize = true;
            this.labelAddMessage.Location = new System.Drawing.Point(8, 30);
            this.labelAddMessage.Name = "labelAddMessage";
            this.labelAddMessage.Size = new System.Drawing.Size(271, 15);
            this.labelAddMessage.TabIndex = 15;
            this.labelAddMessage.Text = "Please enter all fields and then click Add Record";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(80, 270);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(240, 23);
            this.comboBoxGrade.TabIndex = 14;
            // 
            // comboBoxMonthOfAdmission
            // 
            this.comboBoxMonthOfAdmission.FormattingEnabled = true;
            this.comboBoxMonthOfAdmission.Location = new System.Drawing.Point(134, 233);
            this.comboBoxMonthOfAdmission.Name = "comboBoxMonthOfAdmission";
            this.comboBoxMonthOfAdmission.Size = new System.Drawing.Size(186, 23);
            this.comboBoxMonthOfAdmission.TabIndex = 13;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(80, 197);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(240, 23);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(80, 126);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(240, 23);
            this.textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(80, 92);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(240, 23);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(80, 59);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(240, 23);
            this.textBoxStudentID.TabIndex = 9;
            // 
            // dtPickerDateOfBirth
            // 
            this.dtPickerDateOfBirth.CustomFormat = "MMMMM dd, yyyy";
            this.dtPickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDateOfBirth.Location = new System.Drawing.Point(93, 159);
            this.dtPickerDateOfBirth.Name = "dtPickerDateOfBirth";
            this.dtPickerDateOfBirth.Size = new System.Drawing.Size(227, 23);
            this.dtPickerDateOfBirth.TabIndex = 8;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(93, 317);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(124, 23);
            this.buttonAddRecord.TabIndex = 7;
            this.buttonAddRecord.Text = "Add Record";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(6, 278);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(39, 15);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "Grade";
            // 
            // labelMonthOfAdmission
            // 
            this.labelMonthOfAdmission.AutoSize = true;
            this.labelMonthOfAdmission.Location = new System.Drawing.Point(8, 236);
            this.labelMonthOfAdmission.Name = "labelMonthOfAdmission";
            this.labelMonthOfAdmission.Size = new System.Drawing.Size(120, 15);
            this.labelMonthOfAdmission.TabIndex = 5;
            this.labelMonthOfAdmission.Text = "Month of Admission";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(8, 200);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 15);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(8, 165);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(77, 15);
            this.labelDateOfBirth.TabIndex = 3;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(8, 129);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(65, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(8, 95);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(68, 15);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(8, 60);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(64, 15);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID";
            // 
            // groupBoxStudentRecordDisplay
            // 
            this.groupBoxStudentRecordDisplay.Controls.Add(this.gridDisplayStudentRecord);
            this.groupBoxStudentRecordDisplay.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.groupBoxStudentRecordDisplay.Location = new System.Drawing.Point(344, 56);
            this.groupBoxStudentRecordDisplay.Name = "groupBoxStudentRecordDisplay";
            this.groupBoxStudentRecordDisplay.Size = new System.Drawing.Size(669, 609);
            this.groupBoxStudentRecordDisplay.TabIndex = 5;
            this.groupBoxStudentRecordDisplay.TabStop = false;
            this.groupBoxStudentRecordDisplay.Text = "Student Record Display";
            this.groupBoxStudentRecordDisplay.Visible = false;
            // 
            // groupBoxStudentRecordDeletion
            // 
            this.groupBoxStudentRecordDeletion.Controls.Add(this.labelDeleteMessage2);
            this.groupBoxStudentRecordDeletion.Controls.Add(this.labelDeleteMessage1);
            this.groupBoxStudentRecordDeletion.Controls.Add(this.btnDeleteRecord);
            this.groupBoxStudentRecordDeletion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudentRecordDeletion.Location = new System.Drawing.Point(13, 439);
            this.groupBoxStudentRecordDeletion.Name = "groupBoxStudentRecordDeletion";
            this.groupBoxStudentRecordDeletion.Size = new System.Drawing.Size(324, 226);
            this.groupBoxStudentRecordDeletion.TabIndex = 6;
            this.groupBoxStudentRecordDeletion.TabStop = false;
            this.groupBoxStudentRecordDeletion.Text = "Student Record Deletion";
            this.groupBoxStudentRecordDeletion.Visible = false;
            // 
            // labelDeleteMessage2
            // 
            this.labelDeleteMessage2.AutoSize = true;
            this.labelDeleteMessage2.Location = new System.Drawing.Point(20, 65);
            this.labelDeleteMessage2.Name = "labelDeleteMessage2";
            this.labelDeleteMessage2.Size = new System.Drawing.Size(260, 15);
            this.labelDeleteMessage2.TabIndex = 2;
            this.labelDeleteMessage2.Text = "and then click the Delete Record button below";
            // 
            // labelDeleteMessage1
            // 
            this.labelDeleteMessage1.AutoSize = true;
            this.labelDeleteMessage1.Location = new System.Drawing.Point(20, 50);
            this.labelDeleteMessage1.Name = "labelDeleteMessage1";
            this.labelDeleteMessage1.Size = new System.Drawing.Size(245, 15);
            this.labelDeleteMessage1.TabIndex = 1;
            this.labelDeleteMessage1.Text = "Please select the record to delete from right";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteRecord.Location = new System.Drawing.Point(92, 124);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(123, 21);
            this.btnDeleteRecord.TabIndex = 0;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 713);
            this.Controls.Add(this.groupBoxStudentRecordDeletion);
            this.Controls.Add(this.groupBoxStudentRecordDisplay);
            this.Controls.Add(this.groupBoxStudentRecordEntry);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Troy High School Student Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplayStudentRecord)).EndInit();
            this.groupBoxStudentRecordEntry.ResumeLayout(false);
            this.groupBoxStudentRecordEntry.PerformLayout();
            this.groupBoxStudentRecordDisplay.ResumeLayout(false);
            this.groupBoxStudentRecordDeletion.ResumeLayout(false);
            this.groupBoxStudentRecordDeletion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openStudentRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStudentRecordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeStudentRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridDisplayStudentRecord;
        private System.Windows.Forms.GroupBox groupBoxStudentRecordEntry;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelMonthOfAdmission;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxMonthOfAdmission;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.DateTimePicker dtPickerDateOfBirth;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.GroupBox groupBoxStudentRecordDisplay;
        private System.Windows.Forms.Label labelAddMessage;
        private System.Windows.Forms.GroupBox groupBoxStudentRecordDeletion;
        private System.Windows.Forms.Label labelDeleteMessage2;
        private System.Windows.Forms.Label labelDeleteMessage1;
        private System.Windows.Forms.Button btnDeleteRecord;
    }
}

