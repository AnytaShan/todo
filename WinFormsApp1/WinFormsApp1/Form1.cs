using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string file = "file.txt";
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {

                    listBox1.Items.Add(ln);

                }
            }
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text;
            if (!String.IsNullOrWhiteSpace(task))
            {
                listBox1.Items.Add(task);
                textBox1.Clear();
            }
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string writePath = "file.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            button1.Text = "Чек-лист сохранён";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

