using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 页面大窗口显示
{
    public partial class Form2 : Form
    {
        public Form2(String show_text, String size_text, bool style_text)
        {
            InitializeComponent();
            label1.Text = show_text;
            label1.Font = new Font("楷书", int.Parse(size_text), FontStyle.Bold);
            
            if (style_text == true)
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                label1.BackColor = Color.Black;
            }
            label1.Hide();
            //label1.Font.Size = int.Parse(size_text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Width = this.Width;
            label1.Height = this.Height;
            label1.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
