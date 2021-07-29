using SAMS.Forms.GeneralForms;
using SAMS.Forms.PromoteForms;
using SAMS.Forms.StudentForms;
using SAMS.Forms.TimeTableForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioMetrixCore;

namespace SAMS.Forms
{
    public partial class frmMain : Form
    {
        frmAddProgramme AddProgrammeForm;
        frmAddSession AddSessionForm;
        frmSemesterType FrmSemesterType;
        frmSemesters SemesterForm;
        frmSubject SubjectsForm;
        frmTimeTables TimeTablesForm;
        frmAddStudents AddStudentForm;
        frmStudentPromote StudentPromoteForm;
        Master BioMatricAttandanceForm;
        public frmMain()
        {
            InitializeComponent();
            this.AutoScroll = true;
            tsslbl.Text = DateTime.Now.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void programmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddProgrammeForm == null)
            {
                AddProgrammeForm = new frmAddProgramme();
            }
                AddProgrammeForm.TopLevel = false;
                panelParent.Controls.Add(AddProgrammeForm);
                AddProgrammeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                AddProgrammeForm.Dock = DockStyle.Fill;
                AddProgrammeForm.Show();
                AddProgrammeForm.BringToFront();
            
            
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddSessionForm == null)
            {
                AddSessionForm = new frmAddSession();
            }
            
            AddSessionForm.TopLevel = false;
            panelParent.Controls.Add(AddSessionForm);
            AddSessionForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AddSessionForm.Dock = DockStyle.Fill;
            AddSessionForm.Show();
            AddSessionForm.BringToFront();
        }

        private void addSemesterTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSemesterType == null)
            {
                FrmSemesterType = new frmSemesterType();
            }

            FrmSemesterType.TopLevel = false;
            panelParent.Controls.Add(FrmSemesterType);
            FrmSemesterType.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FrmSemesterType.Dock = DockStyle.Fill;
            FrmSemesterType.Show();
            FrmSemesterType.BringToFront();
        }

        private void addSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SemesterForm == null)
            {
                SemesterForm = new frmSemesters();
            }
            SemesterForm.TopLevel = false;
            panelParent.Controls.Add(SemesterForm);
            SemesterForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SemesterForm.Dock = DockStyle.Fill;
            SemesterForm.Show();
            SemesterForm.BringToFront();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SubjectsForm == null)
            {
                SubjectsForm = new frmSubject();
            }
            SubjectsForm.TopLevel = false;
            panelParent.Controls.Add(SubjectsForm);
            SubjectsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SubjectsForm.Dock = DockStyle.Fill;
            SubjectsForm.Show();
            SubjectsForm.BringToFront();
        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (TimeTablesForm == null)
            {
                TimeTablesForm = new frmTimeTables();
            }
            TimeTablesForm.TopLevel = false;
            panelParent.Controls.Add(TimeTablesForm);
            TimeTablesForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TimeTablesForm.Dock = DockStyle.Fill;
            TimeTablesForm.Activate();
            TimeTablesForm.Show();
            TimeTablesForm.BringToFront();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddStudentForm == null) 
            {
                AddStudentForm = new frmAddStudents();
            }
            AddStudentForm.TopLevel = false;
            panelParent.Controls.Add(AddStudentForm);
            AddStudentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AddStudentForm.Dock = DockStyle.Fill;
            AddStudentForm.Activate();
            AddStudentForm.Show();
            AddStudentForm.BringToFront();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void promoteStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

                if (StudentPromoteForm == null)
            {
                StudentPromoteForm = new frmStudentPromote();
            }
            StudentPromoteForm.TopLevel = false;
            panelParent.Controls.Add(StudentPromoteForm);
            StudentPromoteForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            StudentPromoteForm.Dock = DockStyle.Fill;
            StudentPromoteForm.Activate();
            StudentPromoteForm.Show();
            StudentPromoteForm.BringToFront();

        }

        private void attendaneMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(BioMatricAttandanceForm == null)
            {
                BioMatricAttandanceForm = new BioMetrixCore.Master();
            }
            BioMatricAttandanceForm = new BioMetrixCore.Master();
            BioMatricAttandanceForm.TopLevel = false;
            panelParent.Controls.Add(BioMatricAttandanceForm);
            BioMatricAttandanceForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            BioMatricAttandanceForm.Dock = DockStyle.Fill;
            BioMatricAttandanceForm.Show();
            BioMatricAttandanceForm.BringToFront();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            promoteStudentsToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addStudentsToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            programmeToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            sessionToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            subjectToolStripMenuItem_Click(sender, e);
        }

        private void semestersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addSemesterSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSemesterTypeToolStripMenuItem_Click(sender, e);
        }

        private void addSemesterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addSemesterToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timeTableToolStripMenuItem_Click(sender,e);
        }

        private void showSemesterSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjectToolStripMenuItem_Click(sender, e);
        }

        private void dailyAttendanceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dailyAttendanceRecordToolStripMenuItem_Click(sender, e);
        }

        private void customAttendaneRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            customAttendaneRecordToolStripMenuItem_Click(sender,e);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
