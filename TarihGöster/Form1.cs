using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarihGöster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            lbTarihVarsayilan.Text = bugun.ToString();
            string formatlitarih = String.Format("{0:dd.MMM.yyyy}", bugun);
            lbTarihFormatli.Text = formatlitarih;
        }
    }
}
