using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class frm_Menu : Form
    {

        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_OgrenciGirisi_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.user = "Öğrenci";
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_OgretmenGirisi_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.user = "Öğretmen";
            this.Hide();
            frm.ShowDialog();
        }
    }
}
