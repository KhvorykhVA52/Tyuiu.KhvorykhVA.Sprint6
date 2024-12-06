using System;
using System.Windows.Forms;
using Tyuiu.KhvorykhVA.Sprint6.Task3.V10.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task3.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                     { -19, 3, 12, -11, 19 },
                                     { -20, 11, 9, 19, -19 },
                                     { -20, 10, -9, 17, 9 },
                                     { -4, 9, -8, 13, -8 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewOne_SNM.ColumnCount = columns;
            dataGridViewOne_SNM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOne_SNM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOne_SNM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxResult_SNM.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выпонил студент группы АСОиУБ-24-1 Хворых Виктор Александрович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
