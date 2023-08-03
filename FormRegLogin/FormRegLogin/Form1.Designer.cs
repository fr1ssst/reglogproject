namespace FormRegLogin
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
            this.components = new System.ComponentModel.Container();
            this.passwordWrite = new System.Windows.Forms.TextBox();
            this.loginWrite = new System.Windows.Forms.TextBox();
            this.showHideCheckBox = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.registerNameTextBox = new System.Windows.Forms.TextBox();
            this.registerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.registerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextButton2 = new System.Windows.Forms.Button();
            this.registerManRadioButton = new System.Windows.Forms.RadioButton();
            this.registerSexGroupBox = new System.Windows.Forms.GroupBox();
            this.registerWomanRadioButton = new System.Windows.Forms.RadioButton();
            this.nextButton3 = new System.Windows.Forms.Button();
            this.registerMailTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nextButton4 = new System.Windows.Forms.Button();
            this.endRegisterButton = new System.Windows.Forms.Button();
            this.registerProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.registerPanel1 = new System.Windows.Forms.Panel();
            this.registerPanel2 = new System.Windows.Forms.Panel();
            this.registerDateTimePickerGroupBox = new System.Windows.Forms.GroupBox();
            this.registerPanel3 = new System.Windows.Forms.Panel();
            this.registerPanel4 = new System.Windows.Forms.Panel();
            this.registerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.registerPanel5 = new System.Windows.Forms.Panel();
            this.nextButton5 = new System.Windows.Forms.Button();
            this.endRegisterPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton2 = new System.Windows.Forms.Button();
            this.registerSexGroupBox.SuspendLayout();
            this.registerPanel1.SuspendLayout();
            this.registerPanel2.SuspendLayout();
            this.registerDateTimePickerGroupBox.SuspendLayout();
            this.registerPanel3.SuspendLayout();
            this.registerPanel4.SuspendLayout();
            this.registerPanel5.SuspendLayout();
            this.endRegisterPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordWrite
            // 
            this.passwordWrite.Location = new System.Drawing.Point(14, 42);
            this.passwordWrite.Name = "passwordWrite";
            this.passwordWrite.PlaceholderText = "Пароль";
            this.passwordWrite.Size = new System.Drawing.Size(226, 23);
            this.passwordWrite.TabIndex = 0;
            this.passwordWrite.UseSystemPasswordChar = true;
            this.passwordWrite.TextChanged += new System.EventHandler(this.passwordWrite_TextChanged);
            // 
            // loginWrite
            // 
            this.loginWrite.Location = new System.Drawing.Point(14, 13);
            this.loginWrite.Name = "loginWrite";
            this.loginWrite.PlaceholderText = "Логін (адреса електронної пошти)";
            this.loginWrite.Size = new System.Drawing.Size(226, 23);
            this.loginWrite.TabIndex = 1;
            this.loginWrite.TextChanged += new System.EventHandler(this.loginWrite_TextChanged);
            // 
            // showHideCheckBox
            // 
            this.showHideCheckBox.AutoSize = true;
            this.showHideCheckBox.Location = new System.Drawing.Point(247, 47);
            this.showHideCheckBox.Name = "showHideCheckBox";
            this.showHideCheckBox.Size = new System.Drawing.Size(15, 14);
            this.showHideCheckBox.TabIndex = 2;
            this.showHideCheckBox.UseVisualStyleBackColor = true;
            this.showHideCheckBox.CheckedChanged += new System.EventHandler(this.showHideCheckBox_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(86, 98);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 25);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Вхід";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // nextButton1
            // 
            this.nextButton1.Location = new System.Drawing.Point(122, 88);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(75, 23);
            this.nextButton1.TabIndex = 4;
            this.nextButton1.Text = "Далі";
            this.nextButton1.UseVisualStyleBackColor = true;
            this.nextButton1.Click += new System.EventHandler(this.nextButton1_Click);
            // 
            // registerNameTextBox
            // 
            this.registerNameTextBox.Location = new System.Drawing.Point(20, 19);
            this.registerNameTextBox.Name = "registerNameTextBox";
            this.registerNameTextBox.PlaceholderText = "Ім\'я";
            this.registerNameTextBox.Size = new System.Drawing.Size(177, 23);
            this.registerNameTextBox.TabIndex = 3;
            // 
            // registerSurnameTextBox
            // 
            this.registerSurnameTextBox.Location = new System.Drawing.Point(20, 48);
            this.registerSurnameTextBox.Name = "registerSurnameTextBox";
            this.registerSurnameTextBox.PlaceholderText = "Прізвище (необов’язково)";
            this.registerSurnameTextBox.Size = new System.Drawing.Size(177, 23);
            this.registerSurnameTextBox.TabIndex = 2;
            // 
            // registerDateTimePicker
            // 
            this.registerDateTimePicker.Location = new System.Drawing.Point(6, 22);
            this.registerDateTimePicker.Name = "registerDateTimePicker";
            this.registerDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.registerDateTimePicker.TabIndex = 6;
            this.registerDateTimePicker.ValueChanged += new System.EventHandler(this.registerDateTimePicker_ValueChanged);
            // 
            // nextButton2
            // 
            this.nextButton2.Location = new System.Drawing.Point(147, 162);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(75, 23);
            this.nextButton2.TabIndex = 7;
            this.nextButton2.Text = "Далі";
            this.nextButton2.UseVisualStyleBackColor = true;
            this.nextButton2.Click += new System.EventHandler(this.nextButton2_Click);
            // 
            // registerManRadioButton
            // 
            this.registerManRadioButton.AutoSize = true;
            this.registerManRadioButton.Location = new System.Drawing.Point(6, 22);
            this.registerManRadioButton.Name = "registerManRadioButton";
            this.registerManRadioButton.Size = new System.Drawing.Size(50, 19);
            this.registerManRadioButton.TabIndex = 8;
            this.registerManRadioButton.TabStop = true;
            this.registerManRadioButton.Text = "Чол.";
            this.registerManRadioButton.UseVisualStyleBackColor = true;
            this.registerManRadioButton.CheckedChanged += new System.EventHandler(this.registerManRadioButton_CheckedChanged);
            // 
            // registerSexGroupBox
            // 
            this.registerSexGroupBox.Controls.Add(this.registerWomanRadioButton);
            this.registerSexGroupBox.Controls.Add(this.registerManRadioButton);
            this.registerSexGroupBox.Location = new System.Drawing.Point(10, 73);
            this.registerSexGroupBox.Name = "registerSexGroupBox";
            this.registerSexGroupBox.Size = new System.Drawing.Size(212, 83);
            this.registerSexGroupBox.TabIndex = 9;
            this.registerSexGroupBox.TabStop = false;
            this.registerSexGroupBox.Text = "Стать";
            this.registerSexGroupBox.Enter += new System.EventHandler(this.registerSexGroupBox_Enter);
            // 
            // registerWomanRadioButton
            // 
            this.registerWomanRadioButton.AutoSize = true;
            this.registerWomanRadioButton.Location = new System.Drawing.Point(7, 47);
            this.registerWomanRadioButton.Name = "registerWomanRadioButton";
            this.registerWomanRadioButton.Size = new System.Drawing.Size(49, 19);
            this.registerWomanRadioButton.TabIndex = 9;
            this.registerWomanRadioButton.TabStop = true;
            this.registerWomanRadioButton.Text = "Жін.";
            this.registerWomanRadioButton.UseVisualStyleBackColor = true;
            // 
            // nextButton3
            // 
            this.nextButton3.Location = new System.Drawing.Point(109, 49);
            this.nextButton3.Name = "nextButton3";
            this.nextButton3.Size = new System.Drawing.Size(75, 23);
            this.nextButton3.TabIndex = 10;
            this.nextButton3.Text = "Далі";
            this.nextButton3.UseVisualStyleBackColor = true;
            this.nextButton3.Click += new System.EventHandler(this.nextButton3_Click);
            // 
            // registerMailTextBox
            // 
            this.registerMailTextBox.Location = new System.Drawing.Point(3, 3);
            this.registerMailTextBox.Name = "registerMailTextBox";
            this.registerMailTextBox.PlaceholderText = "Ім\'я користувача";
            this.registerMailTextBox.Size = new System.Drawing.Size(181, 23);
            this.registerMailTextBox.TabIndex = 11;
            this.registerMailTextBox.TextChanged += new System.EventHandler(this.registerMailTextBox_TextChanged);
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(3, 3);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PlaceholderText = "Пароль";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(137, 23);
            this.registerPasswordTextBox.TabIndex = 12;
            this.registerPasswordTextBox.UseSystemPasswordChar = true;
            this.registerPasswordTextBox.TextChanged += new System.EventHandler(this.registerPasswordTextBox_TextChanged);
            // 
            // nextButton4
            // 
            this.nextButton4.Location = new System.Drawing.Point(65, 49);
            this.nextButton4.Name = "nextButton4";
            this.nextButton4.Size = new System.Drawing.Size(75, 23);
            this.nextButton4.TabIndex = 13;
            this.nextButton4.Text = "Далі";
            this.nextButton4.UseVisualStyleBackColor = true;
            this.nextButton4.Click += new System.EventHandler(this.nextButton4_Click);
            // 
            // endRegisterButton
            // 
            this.endRegisterButton.Location = new System.Drawing.Point(3, 3);
            this.endRegisterButton.Name = "endRegisterButton";
            this.endRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.endRegisterButton.TabIndex = 15;
            this.endRegisterButton.Text = "Створити профіль";
            this.endRegisterButton.UseVisualStyleBackColor = true;
            this.endRegisterButton.Click += new System.EventHandler(this.endRegisterButton_Click);
            // 
            // registerProgressBar
            // 
            this.registerProgressBar.Location = new System.Drawing.Point(3, 32);
            this.registerProgressBar.Name = "registerProgressBar";
            this.registerProgressBar.Size = new System.Drawing.Size(262, 23);
            this.registerProgressBar.TabIndex = 16;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // registerPanel1
            // 
            this.registerPanel1.Controls.Add(this.registerNameTextBox);
            this.registerPanel1.Controls.Add(this.registerSurnameTextBox);
            this.registerPanel1.Controls.Add(this.nextButton1);
            this.registerPanel1.Location = new System.Drawing.Point(12, 12);
            this.registerPanel1.Name = "registerPanel1";
            this.registerPanel1.Size = new System.Drawing.Size(239, 126);
            this.registerPanel1.TabIndex = 17;
            this.registerPanel1.Visible = false;
            // 
            // registerPanel2
            // 
            this.registerPanel2.Controls.Add(this.registerDateTimePickerGroupBox);
            this.registerPanel2.Controls.Add(this.nextButton2);
            this.registerPanel2.Controls.Add(this.registerSexGroupBox);
            this.registerPanel2.Location = new System.Drawing.Point(260, 12);
            this.registerPanel2.Name = "registerPanel2";
            this.registerPanel2.Size = new System.Drawing.Size(239, 193);
            this.registerPanel2.TabIndex = 18;
            this.registerPanel2.Visible = false;
            // 
            // registerDateTimePickerGroupBox
            // 
            this.registerDateTimePickerGroupBox.Controls.Add(this.registerDateTimePicker);
            this.registerDateTimePickerGroupBox.Location = new System.Drawing.Point(10, 13);
            this.registerDateTimePickerGroupBox.Name = "registerDateTimePickerGroupBox";
            this.registerDateTimePickerGroupBox.Size = new System.Drawing.Size(212, 54);
            this.registerDateTimePickerGroupBox.TabIndex = 23;
            this.registerDateTimePickerGroupBox.TabStop = false;
            this.registerDateTimePickerGroupBox.Text = "Дата народження";
            // 
            // registerPanel3
            // 
            this.registerPanel3.Controls.Add(this.nextButton3);
            this.registerPanel3.Controls.Add(this.registerMailTextBox);
            this.registerPanel3.Location = new System.Drawing.Point(12, 338);
            this.registerPanel3.Name = "registerPanel3";
            this.registerPanel3.Size = new System.Drawing.Size(200, 100);
            this.registerPanel3.TabIndex = 19;
            this.registerPanel3.Visible = false;
            // 
            // registerPanel4
            // 
            this.registerPanel4.Controls.Add(this.registerPasswordTextBox);
            this.registerPanel4.Controls.Add(this.nextButton4);
            this.registerPanel4.Location = new System.Drawing.Point(285, 338);
            this.registerPanel4.Name = "registerPanel4";
            this.registerPanel4.Size = new System.Drawing.Size(200, 100);
            this.registerPanel4.TabIndex = 20;
            this.registerPanel4.Visible = false;
            // 
            // registerPhoneTextBox
            // 
            this.registerPhoneTextBox.Location = new System.Drawing.Point(3, 3);
            this.registerPhoneTextBox.Name = "registerPhoneTextBox";
            this.registerPhoneTextBox.PlaceholderText = "Номер телефону";
            this.registerPhoneTextBox.Size = new System.Drawing.Size(137, 23);
            this.registerPhoneTextBox.TabIndex = 21;
            this.registerPhoneTextBox.TextChanged += new System.EventHandler(this.registerPhoneTextBox_TextChanged);
            // 
            // registerPanel5
            // 
            this.registerPanel5.Controls.Add(this.nextButton5);
            this.registerPanel5.Controls.Add(this.registerPhoneTextBox);
            this.registerPanel5.Location = new System.Drawing.Point(573, 338);
            this.registerPanel5.Name = "registerPanel5";
            this.registerPanel5.Size = new System.Drawing.Size(200, 100);
            this.registerPanel5.TabIndex = 22;
            this.registerPanel5.Visible = false;
            // 
            // nextButton5
            // 
            this.nextButton5.Location = new System.Drawing.Point(65, 49);
            this.nextButton5.Name = "nextButton5";
            this.nextButton5.Size = new System.Drawing.Size(75, 23);
            this.nextButton5.TabIndex = 22;
            this.nextButton5.Text = "Далі";
            this.nextButton5.UseVisualStyleBackColor = true;
            this.nextButton5.Click += new System.EventHandler(this.nextButton5_Click);
            // 
            // endRegisterPanel
            // 
            this.endRegisterPanel.Controls.Add(this.endRegisterButton);
            this.endRegisterPanel.Controls.Add(this.registerProgressBar);
            this.endRegisterPanel.Location = new System.Drawing.Point(250, 211);
            this.endRegisterPanel.Name = "endRegisterPanel";
            this.endRegisterPanel.Size = new System.Drawing.Size(268, 100);
            this.endRegisterPanel.TabIndex = 23;
            this.endRegisterPanel.Visible = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginWrite);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.showHideCheckBox);
            this.loginPanel.Controls.Add(this.passwordWrite);
            this.loginPanel.Location = new System.Drawing.Point(508, 41);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(265, 130);
            this.loginPanel.TabIndex = 24;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(698, 12);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 25;
            this.registerButton.Text = "Реєстрація";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton2
            // 
            this.loginButton2.Location = new System.Drawing.Point(617, 12);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(75, 23);
            this.loginButton2.TabIndex = 26;
            this.loginButton2.Text = "Вхід";
            this.loginButton2.UseVisualStyleBackColor = true;
            this.loginButton2.Visible = false;
            this.loginButton2.Click += new System.EventHandler(this.loginButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.loginButton2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerPanel3);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.endRegisterPanel);
            this.Controls.Add(this.registerPanel2);
            this.Controls.Add(this.registerPanel1);
            this.Controls.Add(this.registerPanel5);
            this.Controls.Add(this.registerPanel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.registerSexGroupBox.ResumeLayout(false);
            this.registerSexGroupBox.PerformLayout();
            this.registerPanel1.ResumeLayout(false);
            this.registerPanel1.PerformLayout();
            this.registerPanel2.ResumeLayout(false);
            this.registerDateTimePickerGroupBox.ResumeLayout(false);
            this.registerPanel3.ResumeLayout(false);
            this.registerPanel3.PerformLayout();
            this.registerPanel4.ResumeLayout(false);
            this.registerPanel4.PerformLayout();
            this.registerPanel5.ResumeLayout(false);
            this.registerPanel5.PerformLayout();
            this.endRegisterPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox passwordWrite;
        private TextBox loginWrite;
        private CheckBox showHideCheckBox;
        private Button loginButton;
        private Button nextButton1;
        private TextBox registerNameTextBox;
        private TextBox registerSurnameTextBox;
        private DateTimePicker registerDateTimePicker;
        private Button nextButton2;
        private RadioButton registerManRadioButton;
        private GroupBox registerSexGroupBox;
        private RadioButton registerWomanRadioButton;
        private Button nextButton3;
        private TextBox registerMailTextBox;
        private TextBox registerPasswordTextBox;
        private Button nextButton4;
        private Button endRegisterButton;
        private ProgressBar registerProgressBar;
        private System.Windows.Forms.Timer progressTimer;
        private Panel registerPanel1;
        private Panel registerPanel2;
        private Panel registerPanel3;
        private Panel registerPanel4;
        private TextBox registerPhoneTextBox;
        private Panel registerPanel5;
        private Button nextButton5;
        private GroupBox registerDateTimePickerGroupBox;
        private Panel endRegisterPanel;
        private Panel loginPanel;
        private Button registerButton;
        private Button loginButton2;
    }
}