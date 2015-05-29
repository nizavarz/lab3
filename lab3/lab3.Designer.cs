namespace lab3
{
    partial class Menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(74, 58);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(255, 44);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Редактор блюд и напитков";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Смета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Edit);
            this.Name = "Menu";
            this.Text = "Редактор праздничного стола";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button button1;
    }
}

