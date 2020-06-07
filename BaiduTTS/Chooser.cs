using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiduTTS
{
    public partial class Chooser : Form
    {
        public Chooser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaiduApi form1 = new BaiduApi();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AliApi aliApi = new AliApi();
            aliApi.Show();
        }
    }
}
