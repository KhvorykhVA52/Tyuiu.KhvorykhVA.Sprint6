using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tyuiu.KhvorykhVA.Sprint6.Task5.V27.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint6\Tyuiu.KhvorykhVA.Sprint6.Task5.V27\bin\Debug\net8.0-windows\InPutDataFileTask5V27.txt";

        private void buttonDoIt_VAK_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_VAK.ColumnCount = 2;
            dataGridViewOutPut_VAK.Columns[0].Width = 20;
            dataGridViewOutPut_VAK.Columns[1].Width = 50;

            this.chartFunc_VAK.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunc_VAK.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunc_VAK.Series[0].Points.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                if (numsMass[i] > 0)
                {
                    dataGridViewOutPut_VAK.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartFunc_VAK.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
        }

        private void buttonOpen_VAK_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-24-1 \n Хворых Виктор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
