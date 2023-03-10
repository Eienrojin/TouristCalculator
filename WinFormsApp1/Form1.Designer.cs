
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.CitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StartCityLabel
            // 
            this.StartCityLabel.AutoSize = true;
            this.StartCityLabel.Location = new System.Drawing.Point(221, 15);
            this.StartCityLabel.Name = "StartCityLabel";
            this.StartCityLabel.Size = new System.Drawing.Size(125, 15);
            this.StartCityLabel.TabIndex = 1;
            this.StartCityLabel.Text = "Город отправления - ";
            // 
            // TravelLabel
            // 
            this.TravelLabel.AutoSize = true;
            this.TravelLabel.Location = new System.Drawing.Point(221, 41);
            this.TravelLabel.Name = "TravelLabel";
            this.TravelLabel.Size = new System.Drawing.Size(68, 15);
            this.TravelLabel.TabIndex = 2;
            this.TravelLabel.Text = "Маршрут -";
            // 
            // AddToCityList
            // 
            this.AddToCityList.Location = new System.Drawing.Point(12, 41);
            this.AddToCityList.Name = "AddToCityList";
            this.AddToCityList.Size = new System.Drawing.Size(75, 54);
            this.AddToCityList.TabIndex = 3;
            this.AddToCityList.Text = "Добавить в маршрут";
            this.AddToCityList.UseVisualStyleBackColor = true;
            this.AddToCityList.Click += new System.EventHandler(this.AddToCityList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Это город отправления";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Я из ЕС";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

