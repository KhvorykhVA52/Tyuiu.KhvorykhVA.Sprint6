namespace Tyuiu.KhvorykhVA.Sprint6.Task1.V18
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox GroupBox_Uslovie_KhvorykhVA;
        private System.Windows.Forms.GroupBox GroupBox_Vvod_KhvorykhVA;
        private System.Windows.Forms.GroupBox GroupBox_Vivod_KhvorykhVA;
        private System.Windows.Forms.Button Button_ToDo_KhvorykhVA;
        private System.Windows.Forms.Button Button_About_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_StopValue_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_Stop_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_StartValue_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_Start_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_Uslovie_KhvorykhVA;
        private System.Windows.Forms.PictureBox PictureBox_Formula_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_VivodIgrekov_KhvorykhVA;
        private System.Windows.Forms.TextBox TextBox_Igreki_KhvorykhVA;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            GroupBox_Uslovie_KhvorykhVA = new GroupBox();
            TextBox_Uslovie_KhvorykhVA = new TextBox();
            PictureBox_Formula_KhvorykhVA = new PictureBox();
            GroupBox_Vvod_KhvorykhVA = new GroupBox();
            TextBox_StopValue_KhvorykhVA = new TextBox();
            TextBox_Stop_KhvorykhVA = new TextBox();
            TextBox_StartValue_KhvorykhVA = new TextBox();
            TextBox_Start_KhvorykhVA = new TextBox();
            GroupBox_Vivod_KhvorykhVA = new GroupBox();
            TextBox_VivodIgrekov_KhvorykhVA = new TextBox();
            TextBox_Igreki_KhvorykhVA = new TextBox();
            Button_ToDo_KhvorykhVA = new Button();
            Button_About_KhvorykhVA = new Button();
            GroupBox_Uslovie_KhvorykhVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_KhvorykhVA).BeginInit();
            GroupBox_Vvod_KhvorykhVA.SuspendLayout();
            GroupBox_Vivod_KhvorykhVA.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_Uslovie_KhvorykhVA
            // 
            GroupBox_Uslovie_KhvorykhVA.Controls.Add(TextBox_Uslovie_KhvorykhVA);
            GroupBox_Uslovie_KhvorykhVA.Controls.Add(PictureBox_Formula_KhvorykhVA);
            GroupBox_Uslovie_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GroupBox_Uslovie_KhvorykhVA.Location = new Point(12, 13);
            GroupBox_Uslovie_KhvorykhVA.Name = "GroupBox_Uslovie_KhvorykhVA";
            GroupBox_Uslovie_KhvorykhVA.Size = new Size(476, 237);
            GroupBox_Uslovie_KhvorykhVA.TabIndex = 0;
            GroupBox_Uslovie_KhvorykhVA.TabStop = false;
            GroupBox_Uslovie_KhvorykhVA.Text = "Условие";
            // 
            // TextBox_Uslovie_KhvorykhVA
            // 
            TextBox_Uslovie_KhvorykhVA.BorderStyle = BorderStyle.None;
            TextBox_Uslovie_KhvorykhVA.Location = new Point(12, 26);
            TextBox_Uslovie_KhvorykhVA.Multiline = true;
            TextBox_Uslovie_KhvorykhVA.Name = "TextBox_Uslovie_KhvorykhVA";
            TextBox_Uslovie_KhvorykhVA.ReadOnly = true;
            TextBox_Uslovie_KhvorykhVA.Size = new Size(475, 10);
            TextBox_Uslovie_KhvorykhVA.TabIndex = 1;
            TextBox_Uslovie_KhvorykhVA.TabStop = false;
            TextBox_Uslovie_KhvorykhVA.TextChanged += TextBox_Uslovie_KhvorykhVA_TextChanged;
            // 
            // PictureBox_Formula_KhvorykhVA
            // 
            PictureBox_Formula_KhvorykhVA.Image = (Image)resources.GetObject("PictureBox_Formula_KhvorykhVA.Image");
            PictureBox_Formula_KhvorykhVA.Location = new Point(6, 93);
            PictureBox_Formula_KhvorykhVA.Name = "PictureBox_Formula_KhvorykhVA";
            PictureBox_Formula_KhvorykhVA.Size = new Size(446, 122);
            PictureBox_Formula_KhvorykhVA.TabIndex = 0;
            PictureBox_Formula_KhvorykhVA.TabStop = false;
            PictureBox_Formula_KhvorykhVA.Click += PictureBox_Formula_KhvorykhVA_Click;
            // 
            // GroupBox_Vvod_KhvorykhVA
            // 
            GroupBox_Vvod_KhvorykhVA.Controls.Add(TextBox_StopValue_KhvorykhVA);
            GroupBox_Vvod_KhvorykhVA.Controls.Add(TextBox_Stop_KhvorykhVA);
            GroupBox_Vvod_KhvorykhVA.Controls.Add(TextBox_StartValue_KhvorykhVA);
            GroupBox_Vvod_KhvorykhVA.Controls.Add(TextBox_Start_KhvorykhVA);
            GroupBox_Vvod_KhvorykhVA.Font = new Font("Segoe UI", 11F);
            GroupBox_Vvod_KhvorykhVA.Location = new Point(12, 412);
            GroupBox_Vvod_KhvorykhVA.Name = "GroupBox_Vvod_KhvorykhVA";
            GroupBox_Vvod_KhvorykhVA.Size = new Size(327, 99);
            GroupBox_Vvod_KhvorykhVA.TabIndex = 1;
            GroupBox_Vvod_KhvorykhVA.TabStop = false;
            GroupBox_Vvod_KhvorykhVA.Text = "Ввод данных";
            // 
            // TextBox_StopValue_KhvorykhVA
            // 
            TextBox_StopValue_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextBox_StopValue_KhvorykhVA.Location = new Point(161, 52);
            TextBox_StopValue_KhvorykhVA.Name = "TextBox_StopValue_KhvorykhVA";
            TextBox_StopValue_KhvorykhVA.Size = new Size(128, 23);
            TextBox_StopValue_KhvorykhVA.TabIndex = 3;
            TextBox_StopValue_KhvorykhVA.TabStop = false;
            TextBox_StopValue_KhvorykhVA.KeyPress += textBox_StopValue_KhvorykhVA_KeyPress;
            // 
            // TextBox_Stop_KhvorykhVA
            // 
            TextBox_Stop_KhvorykhVA.BorderStyle = BorderStyle.None;
            TextBox_Stop_KhvorykhVA.Location = new Point(161, 26);
            TextBox_Stop_KhvorykhVA.Name = "TextBox_Stop_KhvorykhVA";
            TextBox_Stop_KhvorykhVA.ReadOnly = true;
            TextBox_Stop_KhvorykhVA.Size = new Size(100, 20);
            TextBox_Stop_KhvorykhVA.TabIndex = 2;
            TextBox_Stop_KhvorykhVA.TabStop = false;
            TextBox_Stop_KhvorykhVA.Text = "Конец шага:";
            // 
            // TextBox_StartValue_KhvorykhVA
            // 
            TextBox_StartValue_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextBox_StartValue_KhvorykhVA.Location = new Point(6, 52);
            TextBox_StartValue_KhvorykhVA.Name = "TextBox_StartValue_KhvorykhVA";
            TextBox_StartValue_KhvorykhVA.Size = new Size(127, 23);
            TextBox_StartValue_KhvorykhVA.TabIndex = 1;
            TextBox_StartValue_KhvorykhVA.TabStop = false;
            TextBox_StartValue_KhvorykhVA.KeyPress += textBox_StartValue_KhvorykhVA_KeyPress;
            // 
            // TextBox_Start_KhvorykhVA
            // 
            TextBox_Start_KhvorykhVA.BorderStyle = BorderStyle.None;
            TextBox_Start_KhvorykhVA.Location = new Point(6, 26);
            TextBox_Start_KhvorykhVA.Name = "TextBox_Start_KhvorykhVA";
            TextBox_Start_KhvorykhVA.ReadOnly = true;
            TextBox_Start_KhvorykhVA.Size = new Size(100, 20);
            TextBox_Start_KhvorykhVA.TabIndex = 0;
            TextBox_Start_KhvorykhVA.TabStop = false;
            TextBox_Start_KhvorykhVA.Text = "Старт шага:";
            // 
            // GroupBox_Vivod_KhvorykhVA
            // 
            GroupBox_Vivod_KhvorykhVA.Controls.Add(TextBox_VivodIgrekov_KhvorykhVA);
            GroupBox_Vivod_KhvorykhVA.Controls.Add(TextBox_Igreki_KhvorykhVA);
            GroupBox_Vivod_KhvorykhVA.Font = new Font("Segoe UI", 11F);
            GroupBox_Vivod_KhvorykhVA.Location = new Point(672, 13);
            GroupBox_Vivod_KhvorykhVA.Name = "GroupBox_Vivod_KhvorykhVA";
            GroupBox_Vivod_KhvorykhVA.Size = new Size(264, 384);
            GroupBox_Vivod_KhvorykhVA.TabIndex = 2;
            GroupBox_Vivod_KhvorykhVA.TabStop = false;
            GroupBox_Vivod_KhvorykhVA.Text = "Вывод данных";
            // 
            // TextBox_VivodIgrekov_KhvorykhVA
            // 
            TextBox_VivodIgrekov_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextBox_VivodIgrekov_KhvorykhVA.Location = new Point(0, 82);
            TextBox_VivodIgrekov_KhvorykhVA.Multiline = true;
            TextBox_VivodIgrekov_KhvorykhVA.Name = "TextBox_VivodIgrekov_KhvorykhVA";
            TextBox_VivodIgrekov_KhvorykhVA.ReadOnly = true;
            TextBox_VivodIgrekov_KhvorykhVA.ScrollBars = ScrollBars.Vertical;
            TextBox_VivodIgrekov_KhvorykhVA.Size = new Size(264, 371);
            TextBox_VivodIgrekov_KhvorykhVA.TabIndex = 3;
            TextBox_VivodIgrekov_KhvorykhVA.TabStop = false;
            // 
            // TextBox_Igreki_KhvorykhVA
            // 
            TextBox_Igreki_KhvorykhVA.BorderStyle = BorderStyle.None;
            TextBox_Igreki_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextBox_Igreki_KhvorykhVA.Location = new Point(6, 26);
            TextBox_Igreki_KhvorykhVA.Name = "TextBox_Igreki_KhvorykhVA";
            TextBox_Igreki_KhvorykhVA.ReadOnly = true;
            TextBox_Igreki_KhvorykhVA.Size = new Size(100, 16);
            TextBox_Igreki_KhvorykhVA.TabIndex = 2;
            TextBox_Igreki_KhvorykhVA.TabStop = false;
            TextBox_Igreki_KhvorykhVA.Text = "Результат:";
            // 
            // Button_ToDo_KhvorykhVA
            // 
            Button_ToDo_KhvorykhVA.BackColor = Color.Green;
            Button_ToDo_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Button_ToDo_KhvorykhVA.Location = new Point(354, 412);
            Button_ToDo_KhvorykhVA.Name = "Button_ToDo_KhvorykhVA";
            Button_ToDo_KhvorykhVA.Size = new Size(185, 41);
            Button_ToDo_KhvorykhVA.TabIndex = 3;
            Button_ToDo_KhvorykhVA.TabStop = false;
            Button_ToDo_KhvorykhVA.Text = "Выполнить";
            Button_ToDo_KhvorykhVA.UseVisualStyleBackColor = false;
            Button_ToDo_KhvorykhVA.Click += button_ToDo_KhvorykhVA_Click;
            // 
            // Button_About_KhvorykhVA
            // 
            Button_About_KhvorykhVA.BackColor = Color.MediumBlue;
            Button_About_KhvorykhVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Button_About_KhvorykhVA.Location = new Point(354, 471);
            Button_About_KhvorykhVA.Name = "Button_About_KhvorykhVA";
            Button_About_KhvorykhVA.Size = new Size(185, 40);
            Button_About_KhvorykhVA.TabIndex = 4;
            Button_About_KhvorykhVA.TabStop = false;
            Button_About_KhvorykhVA.Text = "Справка";
            Button_About_KhvorykhVA.UseVisualStyleBackColor = false;
            Button_About_KhvorykhVA.Click += button_About_KhvorykhVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 527);
            Controls.Add(Button_About_KhvorykhVA);
            Controls.Add(Button_ToDo_KhvorykhVA);
            Controls.Add(GroupBox_Vivod_KhvorykhVA);
            Controls.Add(GroupBox_Vvod_KhvorykhVA);
            Controls.Add(GroupBox_Uslovie_KhvorykhVA);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 18 | KhvorykhVA";
            Load += FormMain_Load;
            GroupBox_Uslovie_KhvorykhVA.ResumeLayout(false);
            GroupBox_Uslovie_KhvorykhVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_KhvorykhVA).EndInit();
            GroupBox_Vvod_KhvorykhVA.ResumeLayout(false);
            GroupBox_Vvod_KhvorykhVA.PerformLayout();
            GroupBox_Vivod_KhvorykhVA.ResumeLayout(false);
            GroupBox_Vivod_KhvorykhVA.PerformLayout();
            ResumeLayout(false);
        }
    }
}
