using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z80Plus
{
    public partial class Form1 : Form
    {
        public readonly static string Version = "1.1.1.1";
        public Form1()
        {
            InitializeComponent();
            this.Text += " V" + Version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
