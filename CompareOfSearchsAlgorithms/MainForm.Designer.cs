namespace CompareOfSearchsAlgorithms
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
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumberOfItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandomFillWithoutRepeats = new System.Windows.Forms.Button();
            this.btnFillFandom = new System.Windows.Forms.Button();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnBinary = new System.Windows.Forms.RadioButton();
            this.rbtnIncremental = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item});
            this.dataGridViewArray.Location = new System.Drawing.Point(126, 122);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.ReadOnly = true;
            this.dataGridViewArray.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewArray.RowTemplate.Height = 28;
            this.dataGridViewArray.Size = new System.Drawing.Size(218, 771);
            this.dataGridViewArray.TabIndex = 2;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtNumberOfItems);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(447, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 83);
            this.panel1.TabIndex = 3;
            // 
            // txtNumberOfItems
            // 
            this.txtNumberOfItems.Location = new System.Drawing.Point(299, 34);
            this.txtNumberOfItems.Name = "txtNumberOfItems";
            this.txtNumberOfItems.Size = new System.Drawing.Size(82, 26);
            this.txtNumberOfItems.TabIndex = 1;
            this.txtNumberOfItems.Text = "100";
            this.txtNumberOfItems.TextChanged += new System.EventHandler(this.txtNumberOfItems_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов в массиве";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnRandomFillWithoutRepeats);
            this.panel2.Controls.Add(this.btnFillFandom);
            this.panel2.Controls.Add(this.txtMaxValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMinValue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(447, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 375);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Заполнение массива";
            // 
            // btnRandomFillWithoutRepeats
            // 
            this.btnRandomFillWithoutRepeats.Location = new System.Drawing.Point(248, 194);
            this.btnRandomFillWithoutRepeats.Name = "btnRandomFillWithoutRepeats";
            this.btnRandomFillWithoutRepeats.Size = new System.Drawing.Size(185, 129);
            this.btnRandomFillWithoutRepeats.TabIndex = 5;
            this.btnRandomFillWithoutRepeats.Text = "Заполнить случайными числами без повторений";
            this.btnRandomFillWithoutRepeats.UseVisualStyleBackColor = true;
            this.btnRandomFillWithoutRepeats.Click += new System.EventHandler(this.btnRandomFillWithoutRepeats_Click);
            // 
            // btnFillFandom
            // 
            this.btnFillFandom.Location = new System.Drawing.Point(18, 194);
            this.btnFillFandom.Name = "btnFillFandom";
            this.btnFillFandom.Size = new System.Drawing.Size(184, 129);
            this.btnFillFandom.TabIndex = 4;
            this.btnFillFandom.Text = "Заполнить случайными числами";
            this.btnFillFandom.UseVisualStyleBackColor = true;
            this.btnFillFandom.Click += new System.EventHandler(this.btnFillFandom_Click);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(270, 122);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(52, 26);
            this.txtMaxValue.TabIndex = 3;
            this.txtMaxValue.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальная граница";
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(270, 74);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(52, 26);
            this.txtMinValue.TabIndex = 1;
            this.txtMinValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Минимальная граница";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rbtnBinary);
            this.panel3.Controls.Add(this.rbtnIncremental);
            this.panel3.Location = new System.Drawing.Point(447, 661);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 147);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вариант поиска";
            // 
            // rbtnBinary
            // 
            this.rbtnBinary.AutoSize = true;
            this.rbtnBinary.Location = new System.Drawing.Point(49, 84);
            this.rbtnBinary.Name = "rbtnBinary";
            this.rbtnBinary.Size = new System.Drawing.Size(110, 24);
            this.rbtnBinary.TabIndex = 1;
            this.rbtnBinary.Text = "Бинарный";
            this.rbtnBinary.UseVisualStyleBackColor = true;
            // 
            // rbtnIncremental
            // 
            this.rbtnIncremental.AutoSize = true;
            this.rbtnIncremental.Checked = true;
            this.rbtnIncremental.Location = new System.Drawing.Point(49, 54);
            this.rbtnIncremental.Name = "rbtnIncremental";
            this.rbtnIncremental.Size = new System.Drawing.Size(120, 24);
            this.rbtnIncremental.TabIndex = 0;
            this.rbtnIncremental.TabStop = true;
            this.rbtnIncremental.Text = "Перебором";
            this.rbtnIncremental.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 661);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 147);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(979, 122);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(692, 686);
            this.txtAnswer.TabIndex = 7;
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(1508, 820);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(163, 40);
            this.btnClearText.TabIndex = 8;
            this.btnClearText.Text = "Очистить";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(975, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Результат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Массив";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1847, 978);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Сравнение алгоритмов поиска";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumberOfItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRandomFillWithoutRepeats;
        private System.Windows.Forms.Button btnFillFandom;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnBinary;
        private System.Windows.Forms.RadioButton rbtnIncremental;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

