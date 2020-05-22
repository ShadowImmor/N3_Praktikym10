namespace Задание_1_г
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
            this.DoProgramm = new System.Windows.Forms.Button();
            this.InfoFileslabel = new System.Windows.Forms.Label();
            this.InfoFiles = new System.Windows.Forms.RichTextBox();
            this.InfoFileDirectorylabel = new System.Windows.Forms.Label();
            this.InfoFileDirectory = new System.Windows.Forms.RichTextBox();
            this.Exlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoProgramm
            // 
            this.DoProgramm.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoProgramm.Location = new System.Drawing.Point(380, 12);
            this.DoProgramm.Name = "DoProgramm";
            this.DoProgramm.Size = new System.Drawing.Size(358, 52);
            this.DoProgramm.TabIndex = 0;
            this.DoProgramm.Text = "Выполнить программу";
            this.DoProgramm.UseVisualStyleBackColor = true;
            this.DoProgramm.Click += new System.EventHandler(this.DoProgramm_Click);
            // 
            // InfoFileslabel
            // 
            this.InfoFileslabel.AutoSize = true;
            this.InfoFileslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoFileslabel.Location = new System.Drawing.Point(57, 133);
            this.InfoFileslabel.Name = "InfoFileslabel";
            this.InfoFileslabel.Size = new System.Drawing.Size(396, 28);
            this.InfoFileslabel.TabIndex = 1;
            this.InfoFileslabel.Text = "Информация о созданных папках";
            // 
            // InfoFiles
            // 
            this.InfoFiles.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoFiles.Location = new System.Drawing.Point(12, 174);
            this.InfoFiles.Name = "InfoFiles";
            this.InfoFiles.ReadOnly = true;
            this.InfoFiles.Size = new System.Drawing.Size(512, 321);
            this.InfoFiles.TabIndex = 2;
            this.InfoFiles.Text = "";
            // 
            // InfoFileDirectorylabel
            // 
            this.InfoFileDirectorylabel.AutoSize = true;
            this.InfoFileDirectorylabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoFileDirectorylabel.Location = new System.Drawing.Point(645, 133);
            this.InfoFileDirectorylabel.Name = "InfoFileDirectorylabel";
            this.InfoFileDirectorylabel.Size = new System.Drawing.Size(390, 28);
            this.InfoFileDirectorylabel.TabIndex = 3;
            this.InfoFileDirectorylabel.Text = "Файлы в каталоге C:\\temp\\\\ALL";
            // 
            // InfoFileDirectory
            // 
            this.InfoFileDirectory.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoFileDirectory.Location = new System.Drawing.Point(585, 174);
            this.InfoFileDirectory.Name = "InfoFileDirectory";
            this.InfoFileDirectory.ReadOnly = true;
            this.InfoFileDirectory.Size = new System.Drawing.Size(512, 321);
            this.InfoFileDirectory.TabIndex = 4;
            this.InfoFileDirectory.Text = "";
            // 
            // Exlabel
            // 
            this.Exlabel.AutoSize = true;
            this.Exlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exlabel.Location = new System.Drawing.Point(341, 88);
            this.Exlabel.Name = "Exlabel";
            this.Exlabel.Size = new System.Drawing.Size(112, 28);
            this.Exlabel.TabIndex = 5;
            this.Exlabel.Text = "Ошибка:";
            this.Exlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 507);
            this.Controls.Add(this.Exlabel);
            this.Controls.Add(this.InfoFileDirectory);
            this.Controls.Add(this.InfoFileDirectorylabel);
            this.Controls.Add(this.InfoFiles);
            this.Controls.Add(this.InfoFileslabel);
            this.Controls.Add(this.DoProgramm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoProgramm;
        private System.Windows.Forms.Label InfoFileslabel;
        private System.Windows.Forms.RichTextBox InfoFiles;
        private System.Windows.Forms.Label InfoFileDirectorylabel;
        private System.Windows.Forms.RichTextBox InfoFileDirectory;
        private System.Windows.Forms.Label Exlabel;
    }
}

