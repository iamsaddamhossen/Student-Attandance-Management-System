using SAMS.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.Forms.ReportForms
{
    public partial class frmPrintReport : Form
    {
        public frmPrintReport()
        {
            InitializeComponent();
        }

        public string stdnid = null;

        private void frmPrintReport_Load(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSession);
            combo_helpers.Programmes(cmbProgramme);
            combo_helpers.SemesterTypes(cmbSemesterType);

        }

        private void cmbSemesterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_helpers.Semesters(cmbSemester, Convert.ToString(cmbSemesterType.SelectedValue));
        }

        private void btnSessionRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSession);
            
        }

        private void btnProgrammeRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Programmes(cmbProgramme);
            
        }

        private void btnSemesterTypeRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.SemesterTypes(cmbSemesterType);
        }

        private void btnSemesterRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Semesters(cmbSemester, Convert.ToString(cmbSemesterType.SelectedValue));
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(cmbSession.SelectedIndex == 0)
            {
                ep.SetError(cmbSession, "Please Select Session");
                cmbSession.Focus();
                return;
            }

            if (cmbProgramme.SelectedIndex == 0)
            {
                ep.SetError(cmbProgramme, "Please Select Programme");
                cmbProgramme.Focus();
                return;
            }

            if (cmbSemesterType.SelectedIndex == 0)
            {
                ep.SetError(cmbSemesterType, "Please Select Semester Type");
                cmbSemesterType.Focus();
                return;
            }

            if (cmbSemester.SelectedIndex == 0)
            {
                ep.SetError(cmbSemester, "Please Select Semester");
                cmbSemester.Focus();
                return;
            }

            if(string.IsNullOrEmpty(stdnid))
            {
                stdnid = null;
            } 

            if(string.IsNullOrWhiteSpace(stdnid))
            {
                stdnid = null;
            }

        }
    }
}
