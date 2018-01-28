namespace SolidWorksMacro
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openAssemblyButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.swVisible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openAssemblyButton
            // 
            this.openAssemblyButton.Location = new System.Drawing.Point(12, 12);
            this.openAssemblyButton.Name = "openAssemblyButton";
            this.openAssemblyButton.Size = new System.Drawing.Size(310, 41);
            this.openAssemblyButton.TabIndex = 1;
            this.openAssemblyButton.Text = "Open Assembly";
            this.openAssemblyButton.UseVisualStyleBackColor = true;
            this.openAssemblyButton.Click += new System.EventHandler(this.OpenAssemblyButtonClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 93);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(310, 391);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "";
            // 
            // swVisible
            // 
            this.swVisible.AutoSize = true;
            this.swVisible.Location = new System.Drawing.Point(12, 59);
            this.swVisible.Name = "swVisible";
            this.swVisible.Size = new System.Drawing.Size(56, 17);
            this.swVisible.TabIndex = 3;
            this.swVisible.Text = "Visible";
            this.swVisible.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 496);
            this.Controls.Add(this.swVisible);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.openAssemblyButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openAssemblyButton;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.CheckBox swVisible;
    }
}

