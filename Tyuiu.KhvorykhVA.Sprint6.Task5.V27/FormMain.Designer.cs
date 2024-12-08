namespace Tyuiu.KhvorykhVA.Sprint6.Task5.V27
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonHelp_VAK = new Button();
            buttonOpen_VAK = new Button();
            buttonDoIt_VAK = new Button();
            groupBoxTask_VAK = new GroupBox();
            textBoxTask_VAK = new TextBox();
            panel2 = new Panel();
            dataGridViewOutPut_VAK = new DataGridView();
            panel3 = new Panel();
            chartFunc_VAK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxTask_VAK.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_VAK).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_VAK).BeginInit();
            SuspendLayout();
            //
            // panel1
            //
            panel1.Controls.Add(buttonHelp_VAK);
            panel1.Controls.Add(buttonOpen_VAK);
            panel1.Controls.Add(buttonDoIt_VAK);
            panel1.Controls.Add(groupBoxTask_VAK);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 115);
            panel1.TabIndex = 0;
            //
            // buttonHelp_VAK
            //
            buttonHelp_VAK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VAK.BackColor = Color.LightYellow;
            buttonHelp_VAK.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_VAK.Location = new Point(686, 28);
            buttonHelp_VAK.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_VAK.Name = "buttonHelp_VAK";
            buttonHelp_VAK.Size = new Size(88, 74);
            buttonHelp_VAK.TabIndex = 1;
            buttonHelp_VAK.Text = "Справка";
            buttonHelp_VAK.UseVisualStyleBackColor = false;
            buttonHelp_VAK.Click += buttonHelp_VAK_Click;
            //
            // buttonOpen_VAK
            //
            buttonOpen_VAK.BackColor = Color.LightCyan;
            buttonOpen_VAK.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpen_VAK.Location = new Point(592, 28);
            buttonOpen_VAK.Margin = new Padding(4, 3, 4, 3);
            buttonOpen_VAK.Name = "buttonOpen_VAK";
            buttonOpen_VAK.Size = new Size(88, 74);
            buttonOpen_VAK.TabIndex = 1;
            buttonOpen_VAK.Text = "Открыть файл";
            buttonOpen_VAK.UseVisualStyleBackColor = false;
            buttonOpen_VAK.Click += buttonOpen_VAK_Click;
            //
            // buttonDoIt_VAK
            //
            buttonDoIt_VAK.BackColor = Color.PaleGreen;
            buttonDoIt_VAK.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDoIt_VAK.Location = new Point(497, 28);
            buttonDoIt_VAK.Margin = new Padding(4, 3, 4, 3);
            buttonDoIt_VAK.Name = "buttonDoIt_VAK";
            buttonDoIt_VAK.Size = new Size(88, 74);
            buttonDoIt_VAK.TabIndex = 1;
            buttonDoIt_VAK.Text = "Выполнить";
            buttonDoIt_VAK.UseVisualStyleBackColor = false;
            buttonDoIt_VAK.Click += buttonDoIt_VAK_Click;
            //
            // groupBoxTask_VAK
            //
            groupBoxTask_VAK.Controls.Add(textBoxTask_VAK);
            groupBoxTask_VAK.Location = new Point(15, 15);
            groupBoxTask_VAK.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_VAK.Name = "groupBoxTask_VAK";
            groupBoxTask_VAK.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_VAK.Size = new Size(475, 93);
            groupBoxTask_VAK.TabIndex = 0;
            groupBoxTask_VAK.TabStop = false;
            groupBoxTask_VAK.Text = "Условие:";
            //
            // textBoxTask_VAK
            //
            textBoxTask_VAK.Location = new Point(8, 23);
            textBoxTask_VAK.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_VAK.Multiline = true;
            textBoxTask_VAK.Name = "textBoxTask_VAK";
            textBoxTask_VAK.ReadOnly = true;
            textBoxTask_VAK.Size = new Size(459, 63);
            textBoxTask_VAK.TabIndex = 1;
            textBoxTask_VAK.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView\r\nположительные значения и построить диаграмму по этим значениям.\r\n";
            //
            // panel2
            //
            panel2.Controls.Add(dataGridViewOutPut_VAK);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 115);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 404);
            panel2.TabIndex = 1;
            //
            // dataGridViewOutPut_VAK
            //
            dataGridViewOutPut_VAK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_VAK.ColumnHeadersVisible = false;
            dataGridViewOutPut_VAK.Dock = DockStyle.Fill;
            dataGridViewOutPut_VAK.Location = new Point(0, 0);
            dataGridViewOutPut_VAK.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOutPut_VAK.Name = "dataGridViewOutPut_VAK";
            dataGridViewOutPut_VAK.ReadOnly = true;
            dataGridViewOutPut_VAK.RowHeadersVisible = false;
            dataGridViewOutPut_VAK.Size = new Size(226, 404);
            dataGridViewOutPut_VAK.TabIndex = 0;
            //
            // panel3
            //
            panel3.Controls.Add(chartFunc_VAK);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(226, 115);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(582, 404);
            panel3.TabIndex = 2;
            //
            // chartFunc_VAK
            //
            chartArea2.Name = "ChartArea1";
            chartFunc_VAK.ChartAreas.Add(chartArea2);
            chartFunc_VAK.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFunc_VAK.Legends.Add(legend2);
            chartFunc_VAK.Location = new Point(0, 0);
            chartFunc_VAK.Margin = new Padding(4, 3, 4, 3);
            chartFunc_VAK.Name = "chartFunc_VAK";
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.FromArgb(0, 192, 0);
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunc_VAK.Series.Add(series2);
            chartFunc_VAK.Size = new Size(582, 404);
            chartFunc_VAK.TabIndex = 0;
            chartFunc_VAK.Text = "chart1";
            //
            // splitter1
            //
            splitter1.Location = new Point(226, 115);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 404);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            //
            // FormMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 519);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(824, 558);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Хворых В. А.";
            panel1.ResumeLayout(false);
            groupBoxTask_VAK.ResumeLayout(false);
            groupBoxTask_VAK.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_VAK).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunc_VAK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_VAK;
        private System.Windows.Forms.Button buttonOpen_VAK;
        private System.Windows.Forms.Button buttonDoIt_VAK;
        private System.Windows.Forms.GroupBox groupBoxTask_VAK;
        private System.Windows.Forms.TextBox textBoxTask_VAK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_VAK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_VAK;
        private System.Windows.Forms.Splitter splitter1;
    }
}
