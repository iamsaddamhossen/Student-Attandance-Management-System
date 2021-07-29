
namespace SAMS.Forms.TimeTableForms
{
    partial class frmTimeTables
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lbllsActive = new System.Windows.Forms.Label();
            this.btnSubjectRefresh = new System.Windows.Forms.Button();
            this.btnSemesterRefresh = new System.Windows.Forms.Button();
            this.btnSemesterTypeRefresh = new System.Windows.Forms.Button();
            this.btnProgrammeRefresh = new System.Windows.Forms.Button();
            this.btnSessionRefresh = new System.Windows.Forms.Button();
            this.cmbSemesterType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.dtpToTime = new System.Windows.Forms.DateTimePicker();
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbProgramme = new System.Windows.Forms.ComboBox();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.lbllsActive);
            this.groupBox1.Controls.Add(this.btnSubjectRefresh);
            this.groupBox1.Controls.Add(this.btnSemesterRefresh);
            this.groupBox1.Controls.Add(this.btnSemesterTypeRefresh);
            this.groupBox1.Controls.Add(this.btnProgrammeRefresh);
            this.groupBox1.Controls.Add(this.btnSessionRefresh);
            this.groupBox1.Controls.Add(this.cmbSemesterType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpYear);
            this.groupBox1.Controls.Add(this.dtpToTime);
            this.groupBox1.Controls.Add(this.dtpFromTime);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.cmbSubject);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.cmbProgramme);
            this.groupBox1.Controls.Add(this.cmbSession);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Subject Time Table";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(488, 184);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 27;
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.Visible = false;
            // 
            // lbllsActive
            // 
            this.lbllsActive.AutoSize = true;
            this.lbllsActive.Location = new System.Drawing.Point(419, 184);
            this.lbllsActive.Name = "lbllsActive";
            this.lbllsActive.Size = new System.Drawing.Size(54, 13);
            this.lbllsActive.TabIndex = 21;
            this.lbllsActive.Text = "Is Active :";
            this.lbllsActive.Visible = false;
            // 
            // btnSubjectRefresh
            // 
            this.btnSubjectRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSubjectRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubjectRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectRefresh.Location = new System.Drawing.Point(341, 169);
            this.btnSubjectRefresh.Name = "btnSubjectRefresh";
            this.btnSubjectRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSubjectRefresh.TabIndex = 16;
            this.btnSubjectRefresh.UseVisualStyleBackColor = true;
            this.btnSubjectRefresh.Click += new System.EventHandler(this.btnSubjectRefresh_Click);
            // 
            // btnSemesterRefresh
            // 
            this.btnSemesterRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSemesterRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSemesterRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemesterRefresh.Location = new System.Drawing.Point(341, 135);
            this.btnSemesterRefresh.Name = "btnSemesterRefresh";
            this.btnSemesterRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSemesterRefresh.TabIndex = 15;
            this.btnSemesterRefresh.UseVisualStyleBackColor = true;
            this.btnSemesterRefresh.Click += new System.EventHandler(this.btnSemesterRefresh_Click);
            // 
            // btnSemesterTypeRefresh
            // 
            this.btnSemesterTypeRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSemesterTypeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSemesterTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemesterTypeRefresh.Location = new System.Drawing.Point(341, 104);
            this.btnSemesterTypeRefresh.Name = "btnSemesterTypeRefresh";
            this.btnSemesterTypeRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSemesterTypeRefresh.TabIndex = 14;
            this.btnSemesterTypeRefresh.UseVisualStyleBackColor = true;
            this.btnSemesterTypeRefresh.Click += new System.EventHandler(this.btnSemesterTypeRefresh_Click);
            // 
            // btnProgrammeRefresh
            // 
            this.btnProgrammeRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnProgrammeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProgrammeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgrammeRefresh.Location = new System.Drawing.Point(341, 72);
            this.btnProgrammeRefresh.Name = "btnProgrammeRefresh";
            this.btnProgrammeRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnProgrammeRefresh.TabIndex = 13;
            this.btnProgrammeRefresh.UseVisualStyleBackColor = true;
            this.btnProgrammeRefresh.Click += new System.EventHandler(this.btnProgrammeRefresh_Click);
            // 
            // btnSessionRefresh
            // 
            this.btnSessionRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSessionRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSessionRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionRefresh.Location = new System.Drawing.Point(341, 42);
            this.btnSessionRefresh.Name = "btnSessionRefresh";
            this.btnSessionRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSessionRefresh.TabIndex = 12;
            this.btnSessionRefresh.UseVisualStyleBackColor = true;
            this.btnSessionRefresh.Click += new System.EventHandler(this.btnSessionRefresh_Click);
            // 
            // cmbSemesterType
            // 
            this.cmbSemesterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterType.FormattingEnabled = true;
            this.cmbSemesterType.Location = new System.Drawing.Point(154, 104);
            this.cmbSemesterType.Name = "cmbSemesterType";
            this.cmbSemesterType.Size = new System.Drawing.Size(186, 21);
            this.cmbSemesterType.TabIndex = 9;
            this.cmbSemesterType.SelectedIndexChanged += new System.EventHandler(this.cmbSemesterType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select Semester Type :";
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(488, 148);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.ShowUpDown = true;
            this.dtpYear.Size = new System.Drawing.Size(202, 20);
            this.dtpYear.TabIndex = 24;
            // 
            // dtpToTime
            // 
            this.dtpToTime.CustomFormat = "hh:mm tt";
            this.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToTime.Location = new System.Drawing.Point(488, 111);
            this.dtpToTime.Name = "dtpToTime";
            this.dtpToTime.ShowUpDown = true;
            this.dtpToTime.Size = new System.Drawing.Size(202, 20);
            this.dtpToTime.TabIndex = 23;
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.CustomFormat = "hh:mm tt";
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromTime.Location = new System.Drawing.Point(488, 75);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.ShowUpDown = true;
            this.dtpFromTime.Size = new System.Drawing.Size(202, 20);
            this.dtpFromTime.TabIndex = 16;
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Select Day",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDay.Location = new System.Drawing.Point(488, 40);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(202, 21);
            this.cmbDay.TabIndex = 22;
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(138, 169);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(202, 21);
            this.cmbSubject.TabIndex = 11;
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(138, 135);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(202, 21);
            this.cmbSemester.TabIndex = 10;
            // 
            // cmbProgramme
            // 
            this.cmbProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgramme.FormattingEnabled = true;
            this.cmbProgramme.Location = new System.Drawing.Point(138, 73);
            this.cmbProgramme.Name = "cmbProgramme";
            this.cmbProgramme.Size = new System.Drawing.Size(202, 21);
            this.cmbProgramme.TabIndex = 8;
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(138, 42);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(202, 21);
            this.cmbSession.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Year :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "To Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "From Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select Day :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(34, 234);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(656, 76);
            this.txtDescription.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Semester :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Programme :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Session :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(777, 312);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(777, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(777, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(872, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(73, 369);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(667, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search :";
            // 
            // dgvTimeTable
            // 
            this.dgvTimeTable.AllowUserToAddRows = false;
            this.dgvTimeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimeTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeTable.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTimeTable.Location = new System.Drawing.Point(23, 420);
            this.dgvTimeTable.MultiSelect = false;
            this.dgvTimeTable.Name = "dgvTimeTable";
            this.dgvTimeTable.ReadOnly = true;
            this.dgvTimeTable.RowHeadersVisible = false;
            this.dgvTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeTable.Size = new System.Drawing.Size(1227, 213);
            this.dgvTimeTable.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmTimeTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 645);
            this.Controls.Add(this.dgvTimeTable);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimeTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Table";
            this.Activated += new System.EventHandler(this.frmTimeTables_Load);
            this.Load += new System.EventHandler(this.frmTimeTables_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbProgramme;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.DateTimePicker dtpFromTime;
        private System.Windows.Forms.DateTimePicker dtpToTime;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.ComboBox cmbSemesterType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvTimeTable;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnSessionRefresh;
        private System.Windows.Forms.Button btnProgrammeRefresh;
        private System.Windows.Forms.Button btnSemesterTypeRefresh;
        private System.Windows.Forms.Button btnSemesterRefresh;
        private System.Windows.Forms.Button btnSubjectRefresh;
        private System.Windows.Forms.Label lbllsActive;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}