using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev21_12
{
    public partial class Form2 : Form
    {
       
        Form3 Satisİslemleri = new Form3();
        Form4 DukkanIslemleri = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            Satisİslemleri.Show();
            this.Hide();
        }

        private void btnDukkanIslemleri_Click(object sender, EventArgs e)
        {
            DukkanIslemleri.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
