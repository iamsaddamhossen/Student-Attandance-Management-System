using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMS
{
    class DatabaseAccess
    {
        private static SqlConnection conn;

        private static SqlConnection ConnOpen()
        {
            if(conn == null)
            {
                conn = new SqlConnection(@"Data Source=HOLLIE;Initial Catalog=StudentAttendanceSystemDb;Integrated Security=True");
            }

            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            return conn;
        }

        public static bool InsertData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if(noofrecord > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool UpdateData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool DeleteData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static DataTable SelectData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, ConnOpen());
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
    
    
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte []
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base64 Strings
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            // Convert base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public static bool InsertAttendanceLog(DataTable UserLogDataTable)
        {
            return true;
        }
    }
}
