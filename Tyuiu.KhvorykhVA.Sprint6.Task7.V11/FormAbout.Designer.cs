namespace Tyuiu.KhvorykhVA.Sprint6.Task7.V11
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOK;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(245, 223);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Разработчик:\r\nХворых Виктор Александрович\r\n\r\nГруппа:\r\nАСОиУБ-24-1\r\n\r\nСпринт 6 \r\nЗадание 7\r\nВариант 11";

            // buttonOK
            this.buttonOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(163, 241);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 33);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

            // FormAbout
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 286);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAbout";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
