using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool Baku_time  { get; set; }
        Timer time = new Timer();
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Baku_time = false;
            if (Baku_time == false)
            {
                time.Tick += Time_Tick1; ;
                time.Interval = 1000;
                time.Start();
            }
            this.BackgroundImage = Properties.Resources.rxsjL4;
            label1.ForeColor = Color.Black;
        }

        private void Time_Tick1(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.UtcNow.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baku_time = true;
            if (Baku_time == true)
            {
                time.Tick += Time_Tick;
                time.Interval = 1000;
                time.Start();
            }
            this.BackgroundImage = Properties.Resources.visit_baku_azerbaijan_pictures_7;
            label1.ForeColor = Color.White;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
