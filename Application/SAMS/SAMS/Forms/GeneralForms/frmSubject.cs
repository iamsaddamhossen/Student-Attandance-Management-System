using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.Forms.GeneralForms
{
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = string.Format("select SubjectID as [ID], SubjectName as [Subject], Code as [Code], Crhrs as [C-Hrs] from SubjectsTable");
            }
            else
            {
                query = string.Format("select SubjectID as [ID], SubjectName as [Subject], Code as [Code], Crhrs as [C-Hrs] from SubjectsTable where (SubjectName + ' '+ Code) like '%" + searchvalue + "%'");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvSubjectList.DataSource = dt;
                dgvSubjectList.Columns[0].Width = 100;
                dgvSubjectList.Columns[1].Width = 300;
                dgvSubjectList.Columns[2].Width = 100;
                dgvSubjectList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgvSubjectList.DataSource = null;
            }
        }

        private void FormClear()
        {
            txtSubjectName.Clear();
            txtSubjectCode.Clear();
            txtChrs.Clear();
        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            dgvSubjectList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void EnableComponents()
        {
            btnSave.Enabled = true;
            dgvSubjectList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            FillGrid("");
            FormClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableComponents();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSubjectList.DataSource != null)
            {
                if (dgvSubjectList.Rows.Count > 0)
                {
                    //if(dgvSessionList.Rows.Count == 1)
                    //{
                    txtSubjectName.Text = Convert.ToString(dgvSubjectList.CurrentRow.Cells[1].Value);
                    txtSubjectCode.Text = Convert.ToString(dgvSubjectList.CurrentRow.Cells[2].Value);
                    txtChrs.Text = Convert.ToString(dgvSubjectList.CurrentRow.Cells[3].Value);
                    DesibleComponents();
                    //} else {
                    //    MessageBox.Show("Please Select One Record!");
                    //} 

                }
                else
                {
                    MessageBox.Show("List is Emppty!");
                }

            }
            else
            {
                MessageBox.Show("List is Emppty!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSubjectName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSubjectName, "Please Enter Subject Name!");
                txtSubjectName.Focus();
                return;
            }

            if (txtSubjectCode.Text.Trim().Length == 0)
            {
                ep.SetError(txtSubjectCode, "Please Enter Subject Code!");
                txtSubjectCode.Focus();
                return;
            }

            if (txtChrs.Text.Trim().Length == 0)
            {
                ep.SetError(txtChrs, "Please Enter Credit Hours!");
                txtChrs.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SubjectsTable where Code !='" +txtSubjectCode.Text.Trim()+"';");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSubjectName, "Already Exist!");
                    txtSubjectName.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into SubjectsTable(SubjectName, Code, Crhrs) values('{0}','{1}','{2}')",
                txtSubjectName.Text.Trim(), txtSubjectCode.Text.Trim(), txtChrs.Text.Trim());
            bool result = DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Subject Added Successfully!");
                FormClear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSubjectName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSubjectName, "Please Enter Subject Name!");
                txtSubjectName.Focus();
                return;
            }

            if (txtSubjectCode.Text.Trim().Length == 0)
            {
                ep.SetError(txtSubjectCode, "Please Enter Subject Code!");
                txtSubjectCode.Focus();
                return;
            }

            if (txtChrs.Text.Trim().Length == 0)
            {
                ep.SetError(txtChrs, "Please Enter Credit Hours!");
                txtChrs.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SubjectsTable where Code !='" + txtSubjectCode.Text.Trim() + "' and SubjectID  != '"+dgvSubjectList.CurrentRow.Cells[0].Value+"';");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSubjectName, "Already Exist!");
                    txtSubjectName.Focus();
                    return;
                }
            }

            string updatequery = string.Format("update SubjectsTable set SubjectName = '{0}', Code = '{1}', Crhrs = '{2}' where SubjectID = '{3}'",
                txtSubjectName.Text.Trim(), txtSubjectCode.Text.Trim(), txtChrs.Text.Trim(), dgvSubjectList.CurrentRow.Cells[0].Value);
            bool result = DatabaseAccess.UpdateData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Subject Updated Successfully!");
                EnableComponents();
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }
    }
}
