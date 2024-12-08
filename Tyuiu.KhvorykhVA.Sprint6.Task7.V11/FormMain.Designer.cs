namespace Tyuiu.KhvorykhVA.Sprint6.Task7.V11
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();

            // textBox1
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(805, 77);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дан файл InPutFileTask7V11.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в пятой строке отрицательные числа на 9. Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";

            // groupBox1
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";

            // buttonLoad
            this.buttonLoad.Location = new System.Drawing.Point(18, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(76, 68);
            this.buttonLoad.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonLoad, "Открыть файл");
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // buttonRes
            this.buttonRes.Enabled = false;
            this.buttonRes.Location = new System.Drawing.Point(105, 9);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(93, 70);
            this.buttonRes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonRes, "Вывести результат");
            this.buttonRes.Text = "Результат";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);

            // buttonHelp
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Location = new System.Drawing.Point(750, 18);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(65, 65);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // buttonSave
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(210, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 71);
            this.buttonSave.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonSave, "Сохранить результат в файл");
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // panel1
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonRes);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 196);
            this.panel1.TabIndex = 0;

            // panel2
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 521);
            this.panel2.TabIndex = 1;

            // groupBox2
            this.groupBox2.Controls.Add(this.dataGridViewIn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 521);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод";

            // dataGridViewIn
            this.dataGridViewIn.AllowUserToAddRows = false;
            this.dataGridViewIn.AllowUserToDeleteRows = false;
            this.dataGridViewIn.AllowUserToResizeColumns = false;
            this.dataGridViewIn.AllowUserToResizeRows = false;
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.RowHeadersWidth = 51;
            this.dataGridViewIn.Size = new System.Drawing.Size(419, 495);
            this.dataGridViewIn.TabIndex = 0;
            this.dataGridViewIn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewIn.GridColor = System.Drawing.Color.Black;
            this.dataGridViewIn.RowHeadersVisible = false;
            this.dataGridViewIn.ColumnHeadersVisible = false;

            // panel3
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(425, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 521);
            this.panel3.TabIndex = 1;

            // groupBox3
            this.groupBox3.Controls.Add(this.dataGridViewOut);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 521);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";

            // dataGridViewOut
            this.dataGridViewOut.AllowUserToAddRows = false;
            this.dataGridViewOut.AllowUserToDeleteRows = false;
            this.dataGridViewOut.AllowUserToResizeColumns = false;
            this.dataGridViewOut.AllowUserToResizeRows = false;
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.RowHeadersWidth = 51;
            this.dataGridViewOut.Size = new System.Drawing.Size(419, 495);
            this.dataGridViewOut.TabIndex = 0;
            this.dataGridViewOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewOut.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOut.RowHeadersVisible = false;
            this.dataGridViewOut.ColumnHeadersVisible = false;

            // openFileDialogTask
            this.openFileDialogTask.FileName = "InPutFileTask7V11.csv";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 717);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "#6.7 Добавление к решению итоговых проектов по спринту";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
