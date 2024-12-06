using Tyuiu.KhvorykhVA.Sprint6.Task2.V25.Lib;
namespace Tyuiu.KhvorykhVA.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonPerform_ZNA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_ZNA.Text);
                int stopStep = Convert.ToInt32(textBoxInputEnd_ZNA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_ZNA.Text = "";
                textBoxResult_ZNA.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_ZNA.AppendText("|      X     +     f(x)   +" + Environment.NewLine);
                textBoxResult_ZNA.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}      |   {1, 5:f2}     |", startStep, array[i]);
                    textBoxResult_ZNA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_ZNA.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonReference_ZNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-24-1 Хворых Виктор Александрович", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxThree_ZNA_Enter(object sender, EventArgs e)
        {

        }
    }
}
