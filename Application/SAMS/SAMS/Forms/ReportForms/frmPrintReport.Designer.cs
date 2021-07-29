
namespace SAMS.Forms.ReportForms
{
    partial class frmPrintReport
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
            this.btnSemesterTypeRefresh = new System.Windows.Forms.Button();
            this.cmbSemesterType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStdSearch = new System.Windows.Forms.TextBox();
            this.btnSemesterRefresh = new System.Windows.Forms.Button();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.btnProgrammeRefresh = new System.Windows.Forms.Button();
            this.cmbProgramme = new System.Windows.Forms.ComboBox();
            this.btnSessionRefresh = new System.Windows.Forms.Button();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateReport);
            this.groupBox1.Controls.Add(this.btnSemesterTypeRefresh);
            this.groupBox1.Controls.Add(this.cmbSemesterType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtStdSearch);
            this.groupBox1.Controls.Add(this.btnSemesterRefresh);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.btnProgrammeRefresh);
            this.groupBox1.Controls.Add(this.cmbProgramme);
            this.groupBox1.Controls.Add(this.btnSessionRefresh);
            this.groupBox1.Controls.Add(this.cmbSession);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Parameter";
            // 
            // btnSemesterTypeRefresh
            // 
            this.btnSemesterTypeRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSemesterTypeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSemesterTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemesterTypeRefresh.Location = new System.Drawing.Point(755, 50);
            this.btnSemesterTypeRefresh.Name = "btnSemesterTypeRefresh";
            this.btnSemesterTypeRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSemesterTypeRefresh.TabIndex = 23;
            this.btnSemesterTypeRefresh.UseVisualStyleBackColor = true;
            this.btnSemesterTypeRefresh.Click += new System.EventHandler(this.btnSemesterTypeRefresh_Click);
            // 
            // cmbSemesterType
            // 
            this.cmbSemesterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterType.FormattingEnabled = true;
            this.cmbSemesterType.Location = new System.Drawing.Point(554, 50);
            this.cmbSemesterType.Name = "cmbSemesterType";
            this.cmbSemesterType.Size = new System.Drawing.Size(200, 21);
            this.cmbSemesterType.TabIndex = 22;
            this.cmbSemesterType.SelectedIndexChanged += new System.EventHandler(this.cmbSemesterType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Select Semester Type :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1019, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 22);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtStdSearch
            // 
            this.txtStdSearch.Location = new System.Drawing.Point(813, 50);
            this.txtStdSearch.Name = "txtStdSearch";
            this.txtStdSearch.Size = new System.Drawing.Size(206, 20);
            this.txtStdSearch.TabIndex = 19;
            // 
            // btnSemesterRefresh
            // 
            this.btnSemesterRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSemesterRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSemesterRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemesterRefresh.Location = new System.Drawing.Point(757, 96);
            this.btnSemesterRefresh.Name = "btnSemesterRefresh";
            this.btnSemesterRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSemesterRefresh.TabIndex = 18;
            this.btnSemesterRefresh.UseVisualStyleBackColor = true;
            this.btnSemesterRefresh.Click += new System.EventHandler(this.btnSemesterRefresh_Click);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(554, 96);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(202, 21);
            this.cmbSemester.TabIndex = 17;
            // 
            // btnProgrammeRefresh
            // 
            this.btnProgrammeRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnProgrammeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProgrammeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgrammeRefresh.Location = new System.Drawing.Point(495, 96);
            this.btnProgrammeRefresh.Name = "btnProgrammeRefresh";
            this.btnProgrammeRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnProgrammeRefresh.TabIndex = 16;
            this.btnProgrammeRefresh.UseVisualStyleBackColor = true;
            this.btnProgrammeRefresh.Click += new System.EventHandler(this.btnProgrammeRefresh_Click);
            // 
            // cmbProgramme
            // 
            this.cmbProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgramme.FormattingEnabled = true;
            this.cmbProgramme.Location = new System.Drawing.Point(292, 97);
            this.cmbProgramme.Name = "cmbProgramme";
            this.cmbProgramme.Size = new System.Drawing.Size(202, 21);
            this.cmbProgramme.TabIndex = 15;
            // 
            // btnSessionRefresh
            // 
            this.btnSessionRefresh.BackgroundImage = global::SAMS.Properties.Resources.iconrefresh15;
            this.btnSessionRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSessionRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionRefresh.Location = new System.Drawing.Point(235, 95);
            this.btnSessionRefresh.Name = "btnSessionRefresh";
            this.btnSessionRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnSessionRefresh.TabIndex = 14;
            this.btnSessionRefresh.UseVisualStyleBackColor = true;
            this.btnSessionRefresh.Click += new System.EventHandler(this.btnSessionRefresh_Click);
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(32, 95);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(202, 21);
            this.cmbSession.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search Student :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Semester :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Program :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Session :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(36, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(950, 83);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(96, 35);
            this.btnGenerateReport.TabIndex = 24;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmPrintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrintReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrintReport";
            this.Load += new System.EventHandler(this.frmPrintReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSessionRefresh;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Button btnProgrammeRefresh;
        private System.Windows.Forms.ComboBox cmbProgramme;
        private System.Windows.Forms.Button btnSemesterRefresh;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSemesterTypeRefresh;
        private System.Windows.Forms.ComboBox cmbSemesterType;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtStdSearch;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ErrorProvider ep;
    }
}