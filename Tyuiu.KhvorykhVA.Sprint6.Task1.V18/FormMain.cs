using System;
using System.Windows.Forms;
using Tyuiu.KhvorykhVA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task1.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox_StartValue_KhvorykhVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox_StopValue_KhvorykhVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button_About_KhvorykhVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-24-1 Хворых Виктор Александрович", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_ToDo_KhvorykhVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int Start = Convert.ToInt32(TextBox_StartValue_KhvorykhVA.Text);
                int Stop = Convert.ToInt32(TextBox_StopValue_KhvorykhVA.Text);

                string strLine;
                int len = ds.GetMassFunction(Start, Stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);

                TextBox_VivodIgrekov_KhvorykhVA.Text = "";
                TextBox_VivodIgrekov_KhvorykhVA.AppendText("+----------+----------+" + Environment.NewLine);
                TextBox_VivodIgrekov_KhvorykhVA.AppendText("|       X        |      f(x)     |" + Environment.NewLine);
                TextBox_VivodIgrekov_KhvorykhVA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|     {0,4:f1}      |{1,10:f2}   |", Start + i, valueArray[i]);
                    TextBox_VivodIgrekov_KhvorykhVA.AppendText(strLine + Environment.NewLine);
                }

                TextBox_VivodIgrekov_KhvorykhVA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_Uslovie_KhvorykhVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox_Formula_KhvorykhVA_Click(object sender, EventArgs e)
        {

        }
    }
}
