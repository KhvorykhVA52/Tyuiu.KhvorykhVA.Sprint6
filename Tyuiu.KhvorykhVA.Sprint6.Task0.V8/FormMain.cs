using System;
using System.Windows.Forms;
using Tyuiu.KhvorykhVA.Sprint6.Task0.V8.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            pictureBoxGraph.Image = Image.FromFile(@"C:\Users\User\Downloads\formula.jpg");
        }

        private void textBoxValueX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = Convert.ToInt32(textBoxValueX.Text);
                double result = ds.Calculate(x);
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("АСОиУБ-24-1 Хворых Виктор Александрович", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxValueX_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxGraph_Click(object sender, EventArgs e)
        {

        }
    }
}
