using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string file = "file.txt";
        public Form2()
        {
            InitializeComponent();
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                    checkedListBox1.Items.Add(ln);
            }
        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form3 MyForm1 = new Form3();
            MyForm1.ShowDialog();
            Close();
        }
    }
}

