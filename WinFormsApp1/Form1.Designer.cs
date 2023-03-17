
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CitiesComboBox = new System.Windows.Forms.ComboBox();
            this.StartCityLabel = new System.Windows.Forms.Label();
            this.TravelLabel = new System.Windows.Forms.Label();
            this.AddToCityList = new System.Windows.Forms.Button();
            this.StartCityButton = new System.Windows.Forms.Button();
            this.IsEuropeanCheckBox = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SafeDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.CalculateTransitButton = new System.Windows.Forms.Button();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CitiesComboBox
            // 
            this.CitiesComboBox.FormattingEnabled = true;
            this.CitiesComboBox.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинёв",
            "Мадрид",
            "Будапешт"});
            this.CitiesComboBox.Location = new System.Drawing.Point(12, 12);
            this.CitiesComboBox.Name = "CitiesComboBox";
            this.CitiesComboBox.Size = new System.Drawing.Size(203, 23);
            this.CitiesComboBox.TabIndex = 0;
            // 
            // StartCityLabel
            // 
            this.StartCityLabel.AutoSize = true;
            this.StartCityLabel.Location = new System.Drawing.Point(221, 80);
            this.StartCityLabel.Name = "StartCityLabel";
            this.StartCityLabel.Size = new System.Drawing.Size(125, 15);
            this.StartCityLabel.TabIndex = 1;
            this.StartCityLabel.Text = "Город отправления - ";
            // 
            // TravelLabel
            // 
            this.TravelLabel.AutoSize = true;
            this.TravelLabel.Location = new System.Drawing.Point(221, 100);
            this.TravelLabel.Name = "TravelLabel";
            this.TravelLabel.Size = new System.Drawing.Size(68, 15);
            this.TravelLabel.TabIndex = 2;
            this.TravelLabel.Text = "Маршрут -";
            // 
            // AddToCityList
            // 
            this.AddToCityList.Location = new System.Drawing.Point(12, 80);
            this.AddToCityList.Name = "AddToCityList";
            this.AddToCityList.Size = new System.Drawing.Size(75, 54);
            this.AddToCityList.TabIndex = 3;
            this.AddToCityList.Text = "Добавить в маршрут";
            this.AddToCityList.UseVisualStyleBackColor = true;
            this.AddToCityList.Click += new System.EventHandler(this.AddToCityList_Click);
            // 
            // StartCityButton
            // 
            this.StartCityButton.Location = new System.Drawing.Point(93, 80);
            this.StartCityButton.Name = "StartCityButton";
            this.StartCityButton.Size = new System.Drawing.Size(122, 54);
            this.StartCityButton.TabIndex = 4;
            this.StartCityButton.Text = "Это город отправления";
            this.StartCityButton.UseVisualStyleBackColor = true;
            this.StartCityButton.Click += new System.EventHandler(this.StartCityButton_Click);
            // 
            // IsEuropeanCheckBox
            // 
            this.IsEuropeanCheckBox.AutoSize = true;
            this.IsEuropeanCheckBox.Location = new System.Drawing.Point(12, 140);
            this.IsEuropeanCheckBox.Name = "IsEuropeanCheckBox";
            this.IsEuropeanCheckBox.Size = new System.Drawing.Size(65, 19);
            this.IsEuropeanCheckBox.TabIndex = 5;
            this.IsEuropeanCheckBox.Text = "Я из ЕС";
            this.IsEuropeanCheckBox.UseVisualStyleBackColor = true;
            this.IsEuropeanCheckBox.CheckedChanged += new System.EventHandler(this.IsEuropeanCheckBox_CheckedChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(439, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 191);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SafeDeleteCheckBox
            // 
            this.SafeDeleteCheckBox.AutoSize = true;
            this.SafeDeleteCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SafeDeleteCheckBox.Location = new System.Drawing.Point(398, 223);
            this.SafeDeleteCheckBox.Name = "SafeDeleteCheckBox";
            this.SafeDeleteCheckBox.Size = new System.Drawing.Size(131, 19);
            this.SafeDeleteCheckBox.TabIndex = 7;
            this.SafeDeleteCheckBox.Text = "Отключить защиту";
            this.SafeDeleteCheckBox.UseVisualStyleBackColor = true;
            this.SafeDeleteCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CalculateTransitButton
            // 
            this.CalculateTransitButton.Location = new System.Drawing.Point(12, 165);
            this.CalculateTransitButton.Name = "CalculateTransitButton";
            this.CalculateTransitButton.Size = new System.Drawing.Size(203, 77);
            this.CalculateTransitButton.TabIndex = 8;
            this.CalculateTransitButton.Text = "Расчитать стоимость";
            this.CalculateTransitButton.UseVisualStyleBackColor = true;
            this.CalculateTransitButton.Click += new System.EventHandler(this.CalculateTransitButton_Click);
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(12, 41);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(203, 23);
            this.BudgetTextBox.TabIndex = 9;
            this.BudgetTextBox.TextChanged += new System.EventHandler(this.BudgetTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "- Бюджет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.CalculateTransitButton);
            this.Controls.Add(this.SafeDeleteCheckBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IsEuropeanCheckBox);
            this.Controls.Add(this.StartCityButton);
            this.Controls.Add(this.AddToCityList);
            this.Controls.Add(this.TravelLabel);
            this.Controls.Add(this.StartCityLabel);
            this.Controls.Add(this.CitiesComboBox);
            this.Name = "Form1";
            this.Text = "Туристический калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CitiesComboBox;
        private System.Windows.Forms.Label StartCityLabel;
        private System.Windows.Forms.Label TravelLabel;
        private System.Windows.Forms.Button AddToCityList;
        private System.Windows.Forms.Button StartCityButton;
        private System.Windows.Forms.CheckBox IsEuropeanCheckBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox SafeDeleteCheckBox;
        private System.Windows.Forms.Button CalculateTransitButton;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.Label label1;
    }
}

