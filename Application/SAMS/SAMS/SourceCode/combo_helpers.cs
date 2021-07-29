using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.SourceCode
{
    public class combo_helpers
    {
        public static void SemesterTypes(ComboBox cmb)
        {
            try
            {


                DataTable dtAllSemesterTypes = new DataTable(); 
                dtAllSemesterTypes.Columns.Add("SemesterTypeID");
                dtAllSemesterTypes.Columns.Add("SemesterType");
                dtAllSemesterTypes.Rows.Add("0", "Select Semester Type");
                DataTable dt = new DataTable();
                dt = DatabaseAccess.SelectData("select * from SemesterTypeTable");
                if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow item in dt.Rows)
                            {
                                dtAllSemesterTypes.Rows.Add(item[0], item[1]);
                            }

                        }
                    }
                    cmb.DataSource = dtAllSemesterTypes;
                    cmb.ValueMember = "SemesterTypeID";
                    cmb.DisplayMember = "SemesterType";
                }
                catch
                {

                    cmb.DataSource = null;
                }
        }

        public static void Programmes(ComboBox cmb) 
        { 
            try
            {


                DataTable dtAllProgrames = new DataTable();
                dtAllProgrames.Columns.Add("ProgramID");
                dtAllProgrames.Columns.Add("ProgramName");
                dtAllProgrames.Rows.Add("0", "Select Programe");
                DataTable dt = new DataTable();
                dt = DatabaseAccess.SelectData("select * from ProgramTable");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtAllProgrames.Rows.Add(item[0], item[1]);
                        }

                    }
                }
                cmb.DataSource = dtAllProgrames;
                cmb.ValueMember = "ProgramID";
                cmb.DisplayMember = "ProgramName";
            }
            catch
            {

                cmb.DataSource = null;
            }
        }


        public static void Sessions(ComboBox cmb) 
        {
            try
            {


                DataTable dtAllSessions = new DataTable();
                dtAllSessions.Columns.Add("SessionID");
                dtAllSessions.Columns.Add("SessionName");
                dtAllSessions.Rows.Add("0", "Select Session");
                DataTable dt = new DataTable();
                dt = DatabaseAccess.SelectData("select * from SessionTable");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtAllSessions.Rows.Add(item[0], item[1]);
                        }

                    }
                }
                cmb.DataSource = dtAllSessions;
                cmb.ValueMember = "SessionID";
                cmb.DisplayMember = "SessionName";
            }
            catch
            {

                cmb.DataSource = null;
            }
        }

        public static void Semesters(ComboBox cmb, string semestertypeid) 
        {
            try
            {


                DataTable dtAllSemesters = new DataTable();
                dtAllSemesters.Columns.Add("SemesterID");
                dtAllSemesters.Columns.Add("SemesterName");
                dtAllSemesters.Rows.Add("0", "Select Semester");
                DataTable dt = new DataTable();
                //dt = DatabaseAccess.SelectData("select * from SemesterTable where SemesterType_ID = '"+ semestertypeid + "'");
                dt = DatabaseAccess.SelectData("select SemesterID, SemesterName from SemesterTable where SemesterType_ID = '" + semestertypeid + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtAllSemesters.Rows.Add(item[0], item[1]);
                        }

                    }
                }
                cmb.DataSource = dtAllSemesters;
                cmb.ValueMember = "SemesterID";
                cmb.DisplayMember = "SemesterName";
            }
            catch
            {

                cmb.DataSource = null;
            }
        }

        public static void Subjects(ComboBox cmb) 
        {
            try
            {


                DataTable dtAllSubjects = new DataTable();
                dtAllSubjects.Columns.Add("SubjectID");
                dtAllSubjects.Columns.Add("SubjectName");
                dtAllSubjects.Rows.Add("0", "Select Subject");
                DataTable dt = new DataTable();
                //dt = DatabaseAccess.SelectData("select * from SubjectsTable");
                dt = DatabaseAccess.SelectData("select SubjectID, SubjectName + ' ( '+Code+' )' as [Subject] from SubjectsTable");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtAllSubjects.Rows.Add(item[0], item[1]);
                        }

                    }
                }
                cmb.DataSource = dtAllSubjects;
                cmb.ValueMember = "SubjectID";
                cmb.DisplayMember = "SubjectName";
            }
            catch
            {

                cmb.DataSource = null;
            }
        }

        public static void GetSemestersByProgrameAndSession(ComboBox cmb, string programeid, string sessionid) 
        {
            try
            {


                DataTable dtAllSemester = new DataTable();
                dtAllSemester.Columns.Add("Semester_ID");
                dtAllSemester.Columns.Add("SemesterName");
                dtAllSemester.Rows.Add("0", "Select Semester");
                DataTable dt = new DataTable();
                string query = string.Format("select Semester_ID, SemesterName from SubjectsTimeTable INNER JOIN SemesterTable on Semester_ID = SemesterID "
                + "where Program_ID = " + programeid + " and Session_ID = " + sessionid + " group by Semester_ID,SemesterName");
                dt = DatabaseAccess.SelectData(query);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtAllSemester.Rows.Add(item[0], item[1]);
                        }

                    }
                }
                cmb.DataSource = dtAllSemester;
                cmb.ValueMember = "Semester_ID";
                cmb.DisplayMember = "SemesterName";
            }
            catch
            {

                cmb.DataSource = null;
            }
        }



    }
}
