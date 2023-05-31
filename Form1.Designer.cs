namespace Anket
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
            components = new System.ComponentModel.Container();
            Load = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            surname = new Label();
            Name = new Label();
            fathersName = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            fathersnameTextBox = new TextBox();
            Country = new Label();
            City = new Label();
            Phone = new Label();
            Date = new Label();
            dateTimePicker1 = new DateTimePicker();
            Sex = new Label();
            Man = new RadioButton();
            Female = new RadioButton();
            countryTextBox = new TextBox();
            cityTextBox = new TextBox();
            phoneTextBox = new TextBox();
            Save = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            jsonTextBox = new TextBox();
            SuspendLayout();
            // 
            // Load
            // 
            Load.Location = new Point(404, 1);
            Load.Name = "Load";
            Load.Size = new Size(112, 34);
            Load.TabIndex = 1;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(71, 84);
            surname.Name = "surname";
            surname.Size = new Size(82, 25);
            surname.TabIndex = 2;
            surname.Text = "Surname";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(71, 137);
            Name.Name = "Name";
            Name.Size = new Size(59, 25);
            Name.TabIndex = 3;
            Name.Text = "Name";
            // 
            // fathersName
            // 
            fathersName.AutoSize = true;
            fathersName.Location = new Point(12, 203);
            fathersName.Name = "fathersName";
            fathersName.Size = new Size(122, 25);
            fathersName.TabIndex = 4;
            fathersName.Text = "  Father Name";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(160, 84);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(150, 31);
            surnameTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(160, 137);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 6;
            // 
            // fathersnameTextBox
            // 
            fathersnameTextBox.Location = new Point(160, 203);
            fathersnameTextBox.Name = "fathersnameTextBox";
            fathersnameTextBox.Size = new Size(150, 31);
            fathersnameTextBox.TabIndex = 7;
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(71, 322);
            Country.Name = "Country";
            Country.Size = new Size(75, 25);
            Country.TabIndex = 8;
            Country.Text = "Country";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(71, 380);
            City.Name = "City";
            City.Size = new Size(42, 25);
            City.TabIndex = 9;
            City.Text = "City";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(71, 436);
            Phone.Name = "Phone";
            Phone.Size = new Size(62, 25);
            Phone.TabIndex = 10;
            Phone.Text = "Phone";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(71, 491);
            Date.Name = "Date";
            Date.Size = new Size(49, 25);
            Date.TabIndex = 11;
            Date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(200, 491);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Location = new Point(71, 560);
            Sex.Name = "Sex";
            Sex.Size = new Size(39, 25);
            Sex.TabIndex = 13;
            Sex.Text = "Sex";
            // 
            // Man
            // 
            Man.AutoSize = true;
            Man.Location = new Point(200, 558);
            Man.Name = "Man";
            Man.Size = new Size(72, 29);
            Man.TabIndex = 14;
            Man.TabStop = true;
            Man.Text = "Man";
            Man.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(375, 558);
            Female.Name = "Female";
            Female.Size = new Size(93, 29);
            Female.TabIndex = 15;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(160, 322);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(150, 31);
            countryTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(160, 380);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(150, 31);
            cityTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(160, 436);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(150, 31);
            phoneTextBox.TabIndex = 18;
            // 
            // Save
            // 
            Save.Location = new Point(71, 612);
            Save.Name = "Save";
            Save.Size = new Size(445, 50);
            Save.TabIndex = 19;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // jsonTextBox
            // 
            jsonTextBox.Location = new Point(160, 4);
            jsonTextBox.Name = "jsonTextBox";
            jsonTextBox.Size = new Size(150, 31);
            jsonTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 674);
            Controls.Add(jsonTextBox);
            Controls.Add(Save);
            Controls.Add(phoneTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(Female);
            Controls.Add(Man);
            Controls.Add(Sex);
            Controls.Add(dateTimePicker1);
            Controls.Add(Date);
            Controls.Add(Phone);
            Controls.Add(City);
            Controls.Add(Country);
            Controls.Add(fathersnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(fathersName);
            Controls.Add(Name);
            Controls.Add(surname);
            Controls.Add(Load);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Load;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label surname;
        private Label Name;
        private Label fathersName;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox fathersnameTextBox;
        private Label Country;
        private Label City;
        private Label Phone;
        private Label Date;
        private DateTimePicker dateTimePicker1;
        private Label Sex;
        private RadioButton Man;
        private RadioButton Female;
        private TextBox countryTextBox;
        private TextBox cityTextBox;
        private TextBox phoneTextBox;
        private Button Save;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox jsonTextBox;
    }
}