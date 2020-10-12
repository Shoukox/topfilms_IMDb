namespace topimdb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxFilms = new System.Windows.Forms.TextBox();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.textBoxFilters = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonStart.Location = new System.Drawing.Point(407, 354);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 48);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxFilms
            // 
            this.textBoxFilms.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxFilms.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilms.Multiline = true;
            this.textBoxFilms.Name = "textBoxFilms";
            this.textBoxFilms.ReadOnly = true;
            this.textBoxFilms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFilms.Size = new System.Drawing.Size(508, 336);
            this.textBoxFilms.TabIndex = 2;
            this.textBoxFilms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(293, 354);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(108, 17);
            this.checkBoxRandom.TabIndex = 3;
            this.checkBoxRandom.Text = "Рандом фильм?";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            // 
            // textBoxFilters
            // 
            this.textBoxFilters.Location = new System.Drawing.Point(143, 354);
            this.textBoxFilters.Multiline = true;
            this.textBoxFilters.Name = "textBoxFilters";
            this.textBoxFilters.Size = new System.Drawing.Size(132, 48);
            this.textBoxFilters.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(293, 377);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 30);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Сортировать \r\nпо жанрам?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 414);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxFilters);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.textBoxFilms);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxFilms;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.TextBox textBoxFilters;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

