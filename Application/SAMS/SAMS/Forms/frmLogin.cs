using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ep.Clear();
            lblError.Visible = false;
            if (txtUserName.Text.Trim().Length == 0 )
            {
                ep.SetError(txtUserName, "Please Enter User Name!");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "Please Enter Password!");
                txtPassword.Focus();
                return;
            }

            string query = string.Format("select * from LoginTable where Username='{0}' and password='{1}'",  txtUserName.Text.Trim(), txtPassword.Text.Trim());
            DataTable dt = new DataTable();
            dt = DatabaseAccess.SelectData(query);
            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                } else
                {
                    lblError.Visible = true;
                }
            } else
            {
                lblError.Visible = true;
            }
        }
    }
}
