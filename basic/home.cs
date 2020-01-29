using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic
{
    public partial class landing_page : Form
    {
        public landing_page()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            merge_page f = new merge_page();
            f.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            start_btn.Size = new Size(153, 52);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            start_btn.Size = new Size(140, 47);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
