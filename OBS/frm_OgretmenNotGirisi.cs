using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class frm_OgretmenNotGirisi : Form
    {
        public int userIDAktar;
        int studentID;
        SQLConnect con = new SQLConnect();
        SqlDataAdapter sqlDataAdap;
        SqlDataReader sqlDataRead;
        SqlCommand sqlCom;
        DataTable dataTable;
        DataSet dataSet;

        public frm_OgretmenNotGirisi()
        {
            InitializeComponent();
        }

        private void frm_OgretmenNotGirisi_Load(object sender, EventArgs e)
        {
            cmb_Sinif.Items.Clear();
            cmb_Sinif.Items.Add("9");
            cmb_Sinif.Items.Add("10");
            cmb_Sinif.Items.Add("11");
            cmb_Sinif.Items.Add("12");
        }

        private void cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_List.DataSource = null;
            sqlDataAdap = new SqlDataAdapter("SELECT id,studentName,studentSurname,exam,grades FROM obs_Students WHERE class=" + cmb_Sinif.SelectedItem + "", con.connect());
            dataSet = new DataSet();
            sqlDataAdap.Fill(dataSet, "Ogrenci");
            dataGrid_List.DataSource = dataSet.Tables["Ogrenci"];
            con.connect().Close();
        }

        private void cmb_Sinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_List.DataSource = null;
            cmb_Brans.Items.Clear();
            sqlCom = new SqlCommand("SELECT lessonName FROM obs_Lessons WHERE classID=@cID AND teacherID=@uID", con.connect());
            sqlCom.Parameters.AddWithValue("@uID", userIDAktar);
            sqlCom.Parameters.AddWithValue("@cID", cmb_Sinif.SelectedItem);
            sqlDataRead = sqlCom.ExecuteReader();
            while (sqlDataRead.Read())
            {
                cmb_Brans.Items.Add(sqlDataRead["lessonName"]);
            }
            con.connect().Close();
            sqlDataRead.Close();
        }

        private void dataGrid_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID = Convert.ToInt32(dataGrid_List.CurrentRow.Cells[0].Value);
        }

        private void btn_NotlariKaydet_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGrid_List_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            studentID = Convert.ToInt32(dataGrid_List.CurrentRow.Cells[0].Value);
            string colName = dataGrid_List.Columns[dataGrid_List.CurrentCell.ColumnIndex].HeaderText.ToString();
            int cellValue = Convert.ToInt32(dataGrid_List.SelectedCells[0].Value);

            sqlCom = new SqlCommand("UPDATE obs_Students SET " + colName + "=" + cellValue + " WHERE id=" + studentID + "",con.connect());
            sqlCom.ExecuteNonQuery();
            con.connect().Close();

        }
    }
}
