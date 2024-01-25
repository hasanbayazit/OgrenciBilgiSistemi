using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class frm_OgrenciBilgiEkrani : Form
    {
        public int userIDAktar; 
        int studentID;
        SQLConnect con = new SQLConnect();
        SqlDataAdapter sqlDataAdap;
        SqlDataReader sqlDataRead;
        SqlCommand sqlCom;
        //MySqlDataAdapter sqlDataAdap;
        //MySqlDataReader sqlDataRead;
        //MySqlCommand sqlCom;
        DataTable dataTable;
        DataSet dataSet;

        public frm_OgrenciBilgiEkrani()
        {
            InitializeComponent();
        }

        private void frm_OgrenciBilgiEkrani_Load(object sender, EventArgs e)
        {
            sqlDataAdap = new SqlDataAdapter("SELECT studentName, studentSurname,lessonName, sinavNotu1,sinavNotu2,sinavNotu3,sozluNotu1,sozluNotu2,sozluNotu3,projeNotu1,projeNotu2,performansNotu1,performansNotu2 FROM obs_Grades INNER JOIN obs_Students ON obs_Grades.studentID = obs_Students.id INNER JOIN obs_Lessons ON obs_Grades.lessonID = obs_Lessons.id WHERE obs_Students.id = " + userIDAktar + "", con.connect());
            dataSet = new DataSet();
            sqlDataAdap.Fill(dataSet, "Ogrenci");
            dataGrid_List.DataSource = dataSet.Tables["Ogrenci"];
            con.connect().Close();
        }
    }
}
