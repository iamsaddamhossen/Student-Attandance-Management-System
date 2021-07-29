
namespace SAMS.Forms.PromoteForms
{
    partial class frmStudentPromote
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
            this.btnPSPromoteSemesterRefresh = new System.Windows.Forms.Button();
            this.cmbPSPromoteSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPromote = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStdRetrieve = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbOldPromoted = new System.Windows.Forms.RadioButton();
            this.rdbNotPromoted = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.dgvStudentsList = new System.Windows.Forms.DataGridView();
            this.cmbSSPrograme = new System.Windows.Forms.ComboBox();
            this.btnSSCurrentSemesterRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSSCurrentSemester = new System.Windows.Forms.ComboBox();
            this.cmbSSSession = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSSSessionRefresh = new System.Windows.Forms.Button();
            this.btnSSProgrameRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPSPromoteSemesterRefresh
            // 
            this.btnPSPromoteSemesterRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnPSPromoteSemesterRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPSPromoteSemesterRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSPromoteSemesterRefresh.Location = new System.Drawing.Point(362, 42);
            this.btnPSPromoteSemesterRefresh.Name = "btnPSPromoteSemesterRefresh";
            this.btnPSPromoteSemesterRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnPSPromoteSemesterRefresh.TabIndex = 1;
            this.btnPSPromoteSemesterRefresh.UseVisualStyleBackColor = true;
            // 
            // cmbPSPromoteSemester
            // 
            this.cmbPSPromoteSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPSPromoteSemester.FormattingEnabled = true;
            this.cmbPSPromoteSemester.Location = new System.Drawing.Point(159, 42);
            this.cmbPSPromoteSemester.Name = "cmbPSPromoteSemester";
            this.cmbPSPromoteSemester.Size = new System.Drawing.Size(202, 21);
            this.cmbPSPromoteSemester.TabIndex = 0;
            this.cmbPSPromoteSemester.SelectedIndexChanged += new System.EventHandler(this.cmbPSPromoteSemester_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Promote Semester :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPSPromoteSemesterRefresh);
            this.groupBox1.Controls.Add(this.cmbPSPromoteSemester);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(707, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 94);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Promote Semester";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(945, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(1039, 143);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(85, 38);
            this.btnPromote.TabIndex = 2;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStdRetrieve);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkSelectAll);
            this.groupBox2.Controls.Add(this.dgvStudentsList);
            this.groupBox2.Controls.Add(this.cmbSSPrograme);
            this.groupBox2.Controls.Add(this.btnSSCurrentSemesterRefresh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbSSCurrentSemester);
            this.groupBox2.Controls.Add(this.cmbSSSession);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSSSessionRefresh);
            this.groupBox2.Controls.Add(this.btnSSProgrameRefresh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(32, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 493);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Students By Semester";
            // 
            // btnStdRetrieve
            // 
            this.btnStdRetrieve.Location = new System.Drawing.Point(401, 125);
            this.btnStdRetrieve.Name = "btnStdRetrieve";
            this.btnStdRetrieve.Size = new System.Drawing.Size(133, 37);
            this.btnStdRetrieve.TabIndex = 44;
            this.btnStdRetrieve.Text = "Get Students";
            this.btnStdRetrieve.UseVisualStyleBackColor = true;
            this.btnStdRetrieve.Click += new System.EventHandler(this.btnStdRetrieve_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbOldPromoted);
            this.groupBox3.Controls.Add(this.rdbNotPromoted);
            this.groupBox3.Location = new System.Drawing.Point(401, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter By";
            // 
            // rdbOldPromoted
            // 
            this.rdbOldPromoted.AutoSize = true;
            this.rdbOldPromoted.Checked = true;
            this.rdbOldPromoted.Location = new System.Drawing.Point(23, 27);
            this.rdbOldPromoted.Name = "rdbOldPromoted";
            this.rdbOldPromoted.Size = new System.Drawing.Size(70, 17);
            this.rdbOldPromoted.TabIndex = 0;
            this.rdbOldPromoted.TabStop = true;
            this.rdbOldPromoted.Text = "Promoted";
            this.rdbOldPromoted.UseVisualStyleBackColor = true;
            // 
            // rdbNotPromoted
            // 
            this.rdbNotPromoted.AutoSize = true;
            this.rdbNotPromoted.Location = new System.Drawing.Point(111, 26);
            this.rdbNotPromoted.Name = "rdbNotPromoted";
            this.rdbNotPromoted.Size = new System.Drawing.Size(90, 17);
            this.rdbNotPromoted.TabIndex = 1;
            this.rdbNotPromoted.TabStop = true;
            this.rdbNotPromoted.Text = "Not Promoted";
            this.rdbNotPromoted.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Select New Student :";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(6, 161);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // dgvStudentsList
            // 
            this.dgvStudentsList.AllowUserToAddRows = false;
            this.dgvStudentsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStudentsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsList.Location = new System.Drawing.Point(6, 184);
            this.dgvStudentsList.Name = "dgvStudentsList";
            this.dgvStudentsList.ReadOnly = true;
            this.dgvStudentsList.RowHeadersVisible = false;
            this.dgvStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsList.Size = new System.Drawing.Size(647, 303);
            this.dgvStudentsList.TabIndex = 5;
            // 
            // cmbSSPrograme
            // 
            this.cmbSSPrograme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSSPrograme.FormattingEnabled = true;
            this.cmbSSPrograme.Location = new System.Drawing.Point(137, 84);
            this.cmbSSPrograme.Name = "cmbSSPrograme";
            this.cmbSSPrograme.Size = new System.Drawing.Size(202, 21);
            this.cmbSSPrograme.TabIndex = 35;
            this.cmbSSPrograme.SelectedIndexChanged += new System.EventHandler(this.cmbSSPrograme_SelectedIndexChanged);
            // 
            // btnSSCurrentSemesterRefresh
            // 
            this.btnSSCurrentSemesterRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSSCurrentSemesterRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSSCurrentSemesterRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSCurrentSemesterRefresh.Location = new System.Drawing.Point(340, 122);
            this.btnSSCurrentSemesterRefresh.Name = "btnSSCurrentSemesterRefresh";
            this.btnSSCurrentSemesterRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSSCurrentSemesterRefresh.TabIndex = 39;
            this.btnSSCurrentSemesterRefresh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Session :";
            // 
            // cmbSSCurrentSemester
            // 
            this.cmbSSCurrentSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSSCurrentSemester.FormattingEnabled = true;
            this.cmbSSCurrentSemester.Location = new System.Drawing.Point(137, 122);
            this.cmbSSCurrentSemester.Name = "cmbSSCurrentSemester";
            this.cmbSSCurrentSemester.Size = new System.Drawing.Size(202, 21);
            this.cmbSSCurrentSemester.TabIndex = 38;
            this.cmbSSCurrentSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSSCurrentSemester_SelectedIndexChanged);
            // 
            // cmbSSSession
            // 
            this.cmbSSSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSSSession.FormattingEnabled = true;
            this.cmbSSSession.Location = new System.Drawing.Point(137, 45);
            this.cmbSSSession.Name = "cmbSSSession";
            this.cmbSSSession.Size = new System.Drawing.Size(202, 21);
            this.cmbSSSession.TabIndex = 32;
            this.cmbSSSession.SelectedIndexChanged += new System.EventHandler(this.cmbSSSession_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Current Semester :";
            // 
            // btnSSSessionRefresh
            // 
            this.btnSSSessionRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSSSessionRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSSSessionRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSSessionRefresh.Location = new System.Drawing.Point(340, 45);
            this.btnSSSessionRefresh.Name = "btnSSSessionRefresh";
            this.btnSSSessionRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSSSessionRefresh.TabIndex = 33;
            this.btnSSSessionRefresh.UseVisualStyleBackColor = true;
            this.btnSSSessionRefresh.Click += new System.EventHandler(this.btnSSSessionRefresh_Click);
            // 
            // btnSSProgrameRefresh
            // 
            this.btnSSProgrameRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSSProgrameRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSSProgrameRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSProgrameRefresh.Location = new System.Drawing.Point(340, 83);
            this.btnSSProgrameRefresh.Name = "btnSSProgrameRefresh";
            this.btnSSProgrameRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSSProgrameRefresh.TabIndex = 36;
            this.btnSSProgrameRefresh.UseVisualStyleBackColor = true;
            this.btnSSProgrameRefresh.Click += new System.EventHandler(this.btnSSProgrameRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select Programme :";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmStudentPromote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 574);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPromote);
            this.Name = "frmStudentPromote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Promote";
            this.Load += new System.EventHandler(this.frmStudentPromote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPSPromoteSemesterRefresh;
        private System.Windows.Forms.ComboBox cmbPSPromoteSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSSPrograme;
        private System.Windows.Forms.Button btnSSCurrentSemesterRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSSCurrentSemester;
        private System.Windows.Forms.ComboBox cmbSSSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSSSessionRefresh;
        private System.Windows.Forms.Button btnSSProgrameRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStudentsList;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbOldPromoted;
        private System.Windows.Forms.RadioButton rdbNotPromoted;
        private System.Windows.Forms.Button btnStdRetrieve;
        private System.Windows.Forms.ErrorProvider ep;
    }
}