namespace UIWinForms
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
            this.AddValuePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddValueTextBox = new System.Windows.Forms.TextBox();
            this.AddValueButton = new System.Windows.Forms.Button();
            this.ProgressBarPanel = new System.Windows.Forms.Panel();
            this.SortButtonPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddValuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddValuePanel
            // 
            this.AddValuePanel.Controls.Add(this.button1);
            this.AddValuePanel.Controls.Add(this.textBox1);
            this.AddValuePanel.Controls.Add(this.AddValueButton);
            this.AddValuePanel.Controls.Add(this.AddValueTextBox);
            this.AddValuePanel.Controls.Add(this.panel2);
            this.AddValuePanel.Location = new System.Drawing.Point(3, 2);
            this.AddValuePanel.Name = "AddValuePanel";
            this.AddValuePanel.Size = new System.Drawing.Size(414, 86);
            this.AddValuePanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 80);
            this.panel2.TabIndex = 1;
            // 
            // AddValueTextBox
            // 
            this.AddValueTextBox.Location = new System.Drawing.Point(17, 10);
            this.AddValueTextBox.Name = "AddValueTextBox";
            this.AddValueTextBox.Size = new System.Drawing.Size(208, 20);
            this.AddValueTextBox.TabIndex = 2;
            // 
            // AddValueButton
            // 
            this.AddValueButton.Location = new System.Drawing.Point(244, 10);
            this.AddValueButton.Name = "AddValueButton";
            this.AddValueButton.Size = new System.Drawing.Size(156, 20);
            this.AddValueButton.TabIndex = 3;
            this.AddValueButton.Text = "Добавить число";
            this.AddValueButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBarPanel
            // 
            this.ProgressBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarPanel.Location = new System.Drawing.Point(7, 94);
            this.ProgressBarPanel.Name = "ProgressBarPanel";
            this.ProgressBarPanel.Size = new System.Drawing.Size(797, 392);
            this.ProgressBarPanel.TabIndex = 2;
            // 
            // SortButtonPanel
            // 
            this.SortButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortButtonPanel.Location = new System.Drawing.Point(423, 2);
            this.SortButtonPanel.Name = "SortButtonPanel";
            this.SortButtonPanel.Size = new System.Drawing.Size(381, 86);
            this.SortButtonPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить число";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 491);
            this.Controls.Add(this.SortButtonPanel);
            this.Controls.Add(this.ProgressBarPanel);
            this.Controls.Add(this.AddValuePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AddValuePanel.ResumeLayout(false);
            this.AddValuePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddValuePanel;
        private System.Windows.Forms.Button AddValueButton;
        private System.Windows.Forms.TextBox AddValueTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ProgressBarPanel;
        private System.Windows.Forms.Panel SortButtonPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

