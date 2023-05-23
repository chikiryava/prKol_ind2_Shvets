
namespace Pract15_Shvets
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
            this.takeItemFromArrayGroupBox = new System.Windows.Forms.GroupBox();
            this.showArrayElementButton = new System.Windows.Forms.Button();
            this.arrayValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arrayElementIndexTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createArrayGroupBox = new System.Windows.Forms.GroupBox();
            this.createArrayButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.arraySizeTextBox = new System.Windows.Forms.TextBox();
            this.multiplyArrayGroupBox = new System.Windows.Forms.GroupBox();
            this.multiplyArrayButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showItemsInArrayGroupBox = new System.Windows.Forms.GroupBox();
            this.listOfItemsListBox = new System.Windows.Forms.ListBox();
            this.showItemsInArrayButton = new System.Windows.Forms.Button();
            this.takeItemFromArrayGroupBox.SuspendLayout();
            this.createArrayGroupBox.SuspendLayout();
            this.multiplyArrayGroupBox.SuspendLayout();
            this.showItemsInArrayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // takeItemFromArrayGroupBox
            // 
            this.takeItemFromArrayGroupBox.Controls.Add(this.showArrayElementButton);
            this.takeItemFromArrayGroupBox.Controls.Add(this.arrayValueLabel);
            this.takeItemFromArrayGroupBox.Controls.Add(this.label1);
            this.takeItemFromArrayGroupBox.Controls.Add(this.arrayElementIndexTextBox);
            this.takeItemFromArrayGroupBox.Location = new System.Drawing.Point(104, 383);
            this.takeItemFromArrayGroupBox.Name = "takeItemFromArrayGroupBox";
            this.takeItemFromArrayGroupBox.Size = new System.Drawing.Size(231, 172);
            this.takeItemFromArrayGroupBox.TabIndex = 0;
            this.takeItemFromArrayGroupBox.TabStop = false;
            this.takeItemFromArrayGroupBox.Text = "Обращение к элементу массива";
            this.takeItemFromArrayGroupBox.Visible = false;
            // 
            // showArrayElementButton
            // 
            this.showArrayElementButton.Location = new System.Drawing.Point(49, 99);
            this.showArrayElementButton.Name = "showArrayElementButton";
            this.showArrayElementButton.Size = new System.Drawing.Size(118, 44);
            this.showArrayElementButton.TabIndex = 3;
            this.showArrayElementButton.Text = "Показать значение элемента массива";
            this.showArrayElementButton.UseVisualStyleBackColor = true;
            this.showArrayElementButton.Click += new System.EventHandler(this.showArrayElementButton_Click);
            // 
            // arrayValueLabel
            // 
            this.arrayValueLabel.AutoSize = true;
            this.arrayValueLabel.Location = new System.Drawing.Point(101, 73);
            this.arrayValueLabel.Name = "arrayValueLabel";
            this.arrayValueLabel.Size = new System.Drawing.Size(0, 13);
            this.arrayValueLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите номер элемента массива";
            // 
            // arrayElementIndexTextBox
            // 
            this.arrayElementIndexTextBox.Location = new System.Drawing.Point(49, 36);
            this.arrayElementIndexTextBox.Name = "arrayElementIndexTextBox";
            this.arrayElementIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrayElementIndexTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // createArrayGroupBox
            // 
            this.createArrayGroupBox.Controls.Add(this.createArrayButton);
            this.createArrayGroupBox.Controls.Add(this.label3);
            this.createArrayGroupBox.Controls.Add(this.arraySizeTextBox);
            this.createArrayGroupBox.Location = new System.Drawing.Point(98, 72);
            this.createArrayGroupBox.Name = "createArrayGroupBox";
            this.createArrayGroupBox.Size = new System.Drawing.Size(210, 153);
            this.createArrayGroupBox.TabIndex = 3;
            this.createArrayGroupBox.TabStop = false;
            this.createArrayGroupBox.Text = "Создание массива";
            this.createArrayGroupBox.Visible = false;
            // 
            // createArrayButton
            // 
            this.createArrayButton.Location = new System.Drawing.Point(54, 109);
            this.createArrayButton.Name = "createArrayButton";
            this.createArrayButton.Size = new System.Drawing.Size(100, 25);
            this.createArrayButton.TabIndex = 4;
            this.createArrayButton.Text = "Создать массив";
            this.createArrayButton.UseVisualStyleBackColor = true;
            this.createArrayButton.Click += new System.EventHandler(this.createArrayButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите размерность массива";
            // 
            // arraySizeTextBox
            // 
            this.arraySizeTextBox.Location = new System.Drawing.Point(54, 66);
            this.arraySizeTextBox.Name = "arraySizeTextBox";
            this.arraySizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.arraySizeTextBox.TabIndex = 0;
            // 
            // multiplyArrayGroupBox
            // 
            this.multiplyArrayGroupBox.Controls.Add(this.multiplyArrayButton);
            this.multiplyArrayGroupBox.Controls.Add(this.label4);
            this.multiplyArrayGroupBox.Controls.Add(this.label5);
            this.multiplyArrayGroupBox.Controls.Add(this.multiplierTextBox);
            this.multiplyArrayGroupBox.Location = new System.Drawing.Point(367, 304);
            this.multiplyArrayGroupBox.Name = "multiplyArrayGroupBox";
            this.multiplyArrayGroupBox.Size = new System.Drawing.Size(231, 135);
            this.multiplyArrayGroupBox.TabIndex = 4;
            this.multiplyArrayGroupBox.TabStop = false;
            this.multiplyArrayGroupBox.Text = "Умножение элементов массива";
            this.multiplyArrayGroupBox.Visible = false;
            // 
            // multiplyArrayButton
            // 
            this.multiplyArrayButton.Location = new System.Drawing.Point(49, 99);
            this.multiplyArrayButton.Name = "multiplyArrayButton";
            this.multiplyArrayButton.Size = new System.Drawing.Size(118, 24);
            this.multiplyArrayButton.TabIndex = 3;
            this.multiplyArrayButton.Text = "Умножить массив";
            this.multiplyArrayButton.UseVisualStyleBackColor = true;
            this.multiplyArrayButton.Click += new System.EventHandler(this.multiplyArrayButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Введите множитель";
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(49, 36);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(100, 20);
            this.multiplierTextBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Создать массив",
            "Обращение к элементу массива",
            "Умножение элементов массива",
            "Вывод массива"});
            this.comboBox1.Location = new System.Drawing.Point(84, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выберите действие";
            // 
            // showItemsInArrayGroupBox
            // 
            this.showItemsInArrayGroupBox.Controls.Add(this.showItemsInArrayButton);
            this.showItemsInArrayGroupBox.Controls.Add(this.listOfItemsListBox);
            this.showItemsInArrayGroupBox.Location = new System.Drawing.Point(415, 57);
            this.showItemsInArrayGroupBox.Name = "showItemsInArrayGroupBox";
            this.showItemsInArrayGroupBox.Size = new System.Drawing.Size(207, 198);
            this.showItemsInArrayGroupBox.TabIndex = 5;
            this.showItemsInArrayGroupBox.TabStop = false;
            this.showItemsInArrayGroupBox.Text = "Вывод массива";
            this.showItemsInArrayGroupBox.Visible = false;
            // 
            // listOfItemsListBox
            // 
            this.listOfItemsListBox.FormattingEnabled = true;
            this.listOfItemsListBox.Location = new System.Drawing.Point(23, 21);
            this.listOfItemsListBox.Name = "listOfItemsListBox";
            this.listOfItemsListBox.Size = new System.Drawing.Size(160, 121);
            this.listOfItemsListBox.TabIndex = 0;
            // 
            // showItemsInArrayButton
            // 
            this.showItemsInArrayButton.Location = new System.Drawing.Point(46, 148);
            this.showItemsInArrayButton.Name = "showItemsInArrayButton";
            this.showItemsInArrayButton.Size = new System.Drawing.Size(128, 42);
            this.showItemsInArrayButton.TabIndex = 1;
            this.showItemsInArrayButton.Text = "Вывести все элементы массива";
            this.showItemsInArrayButton.UseVisualStyleBackColor = true;
            this.showItemsInArrayButton.Click += new System.EventHandler(this.showItemsInArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 341);
            this.Controls.Add(this.showItemsInArrayGroupBox);
            this.Controls.Add(this.multiplyArrayGroupBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.takeItemFromArrayGroupBox);
            this.Controls.Add(this.createArrayGroupBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.takeItemFromArrayGroupBox.ResumeLayout(false);
            this.takeItemFromArrayGroupBox.PerformLayout();
            this.createArrayGroupBox.ResumeLayout(false);
            this.createArrayGroupBox.PerformLayout();
            this.multiplyArrayGroupBox.ResumeLayout(false);
            this.multiplyArrayGroupBox.PerformLayout();
            this.showItemsInArrayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox takeItemFromArrayGroupBox;
        private System.Windows.Forms.Label arrayValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arrayElementIndexTextBox;
        private System.Windows.Forms.Button showArrayElementButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox createArrayGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arraySizeTextBox;
        private System.Windows.Forms.Button createArrayButton;
        private System.Windows.Forms.GroupBox multiplyArrayGroupBox;
        private System.Windows.Forms.Button multiplyArrayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox showItemsInArrayGroupBox;
        private System.Windows.Forms.Button showItemsInArrayButton;
        private System.Windows.Forms.ListBox listOfItemsListBox;
    }
}

