﻿namespace FormRegLogin
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
            this.nextButton2 = new System.Windows.Forms.Button();
            this.registerManRadioButton = new System.Windows.Forms.RadioButton();
            this.registerSexGroupBox = new System.Windows.Forms.GroupBox();
            this.registerWomanRadioButton = new System.Windows.Forms.RadioButton();
            this.nextButton3 = new System.Windows.Forms.Button();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nextButton4 = new System.Windows.Forms.Button();
            this.registerProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.registerPanel1 = new System.Windows.Forms.Panel();
            this.registerPanel2 = new System.Windows.Forms.Panel();
            this.registerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registerPanel3 = new System.Windows.Forms.Panel();
            this.registerLoginTextBox = new System.Windows.Forms.TextBox();
            this.registerPanel4 = new System.Windows.Forms.Panel();
            this.showHideCheckBox2 = new System.Windows.Forms.CheckBox();
            this.registerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.registerPanel5 = new System.Windows.Forms.Panel();
            this.nextButton5 = new System.Windows.Forms.Button();
            this.endRegisterPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton2 = new System.Windows.Forms.Button();
            this.privacyAndTermsLabel = new System.Windows.Forms.Label();
            this.privacyAndTermsLabel2 = new System.Windows.Forms.Label();
            this.privacyAndTermsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.endRegisterButton = new System.Windows.Forms.Button();
            this.privacyAndTermsPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userSurnameLabel = new System.Windows.Forms.Label();
            this.userDateOfBirthLabel = new System.Windows.Forms.Label();
            this.userSexLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userInformationsPanel = new System.Windows.Forms.Panel();
            this.changeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.changeSurnameButton = new System.Windows.Forms.Button();
            this.changeNameTextBox = new System.Windows.Forms.TextBox();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.acceptChangeNameButton = new System.Windows.Forms.Button();
            this.acceptChangeSurnameButton = new System.Windows.Forms.Button();
            this.registerSexGroupBox.SuspendLayout();
            this.registerPanel1.SuspendLayout();
            this.registerPanel2.SuspendLayout();
            this.registerPanel3.SuspendLayout();
            this.registerPanel4.SuspendLayout();
            this.registerPanel5.SuspendLayout();
            this.endRegisterPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.privacyAndTermsPanel.SuspendLayout();
            this.userInformationsPanel.SuspendLayout();
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
            this.registerNameTextBox.TextChanged += new System.EventHandler(this.registerNameTextBox_TextChanged);
            // 
            // registerSurnameTextBox
            // 
            this.registerSurnameTextBox.Location = new System.Drawing.Point(20, 48);
            this.registerSurnameTextBox.Name = "registerSurnameTextBox";
            this.registerSurnameTextBox.PlaceholderText = "Прізвище (необов’язково)";
            this.registerSurnameTextBox.Size = new System.Drawing.Size(177, 23);
            this.registerSurnameTextBox.TabIndex = 2;
            this.registerSurnameTextBox.TextChanged += new System.EventHandler(this.registerSurnameTextBox_TextChanged);
            // 
            // nextButton2
            // 
            this.nextButton2.Location = new System.Drawing.Point(150, 179);
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
            this.registerSexGroupBox.Location = new System.Drawing.Point(10, 90);
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
            this.registerWomanRadioButton.CheckedChanged += new System.EventHandler(this.registerWomanRadioButton_CheckedChanged);
            // 
            // nextButton3
            // 
            this.nextButton3.Location = new System.Drawing.Point(122, 53);
            this.nextButton3.Name = "nextButton3";
            this.nextButton3.Size = new System.Drawing.Size(75, 23);
            this.nextButton3.TabIndex = 10;
            this.nextButton3.Text = "Далі";
            this.nextButton3.UseVisualStyleBackColor = true;
            this.nextButton3.Click += new System.EventHandler(this.nextButton3_Click);
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(3, 3);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PlaceholderText = "Пароль";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(219, 23);
            this.registerPasswordTextBox.TabIndex = 12;
            this.registerPasswordTextBox.UseSystemPasswordChar = true;
            this.registerPasswordTextBox.TextChanged += new System.EventHandler(this.registerPasswordTextBox_TextChanged);
            // 
            // nextButton4
            // 
            this.nextButton4.Location = new System.Drawing.Point(65, 74);
            this.nextButton4.Name = "nextButton4";
            this.nextButton4.Size = new System.Drawing.Size(75, 23);
            this.nextButton4.TabIndex = 13;
            this.nextButton4.Text = "Далі";
            this.nextButton4.UseVisualStyleBackColor = true;
            this.nextButton4.Click += new System.EventHandler(this.nextButton4_Click);
            // 
            // registerProgressBar
            // 
            this.registerProgressBar.Location = new System.Drawing.Point(3, 32);
            this.registerProgressBar.Name = "registerProgressBar";
            this.registerProgressBar.Size = new System.Drawing.Size(262, 23);
            this.registerProgressBar.TabIndex = 16;
            this.registerProgressBar.Click += new System.EventHandler(this.registerProgressBar_Click);
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
            this.registerPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel1_Paint);
            // 
            // registerPanel2
            // 
            this.registerPanel2.Controls.Add(this.nextButton2);
            this.registerPanel2.Controls.Add(this.registerDateTimePicker);
            this.registerPanel2.Controls.Add(this.registerSexGroupBox);
            this.registerPanel2.Location = new System.Drawing.Point(12, 144);
            this.registerPanel2.Name = "registerPanel2";
            this.registerPanel2.Size = new System.Drawing.Size(239, 206);
            this.registerPanel2.TabIndex = 18;
            this.registerPanel2.Visible = false;
            this.registerPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel2_Paint);
            // 
            // registerDateTimePicker
            // 
            this.registerDateTimePicker.Location = new System.Drawing.Point(10, 32);
            this.registerDateTimePicker.Name = "registerDateTimePicker";
            this.registerDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.registerDateTimePicker.TabIndex = 32;
            this.registerDateTimePicker.ValueChanged += new System.EventHandler(this.registerDateTimePicker_ValueChanged);
            // 
            // registerPanel3
            // 
            this.registerPanel3.Controls.Add(this.registerLoginTextBox);
            this.registerPanel3.Controls.Add(this.nextButton3);
            this.registerPanel3.Location = new System.Drawing.Point(12, 356);
            this.registerPanel3.Name = "registerPanel3";
            this.registerPanel3.Size = new System.Drawing.Size(239, 100);
            this.registerPanel3.TabIndex = 19;
            this.registerPanel3.Visible = false;
            this.registerPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel3_Paint);
            // 
            // registerLoginTextBox
            // 
            this.registerLoginTextBox.Location = new System.Drawing.Point(3, 14);
            this.registerLoginTextBox.Name = "registerLoginTextBox";
            this.registerLoginTextBox.PlaceholderText = "Логін (адреса електронної пошти)";
            this.registerLoginTextBox.Size = new System.Drawing.Size(222, 23);
            this.registerLoginTextBox.TabIndex = 11;
            this.registerLoginTextBox.TextChanged += new System.EventHandler(this.registerLoginTextBox_TextChanged);
            // 
            // registerPanel4
            // 
            this.registerPanel4.Controls.Add(this.showHideCheckBox2);
            this.registerPanel4.Controls.Add(this.registerPasswordTextBox);
            this.registerPanel4.Controls.Add(this.nextButton4);
            this.registerPanel4.Location = new System.Drawing.Point(12, 468);
            this.registerPanel4.Name = "registerPanel4";
            this.registerPanel4.Size = new System.Drawing.Size(239, 100);
            this.registerPanel4.TabIndex = 20;
            this.registerPanel4.Visible = false;
            this.registerPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel4_Paint);
            // 
            // showHideCheckBox2
            // 
            this.showHideCheckBox2.AutoSize = true;
            this.showHideCheckBox2.Location = new System.Drawing.Point(224, 11);
            this.showHideCheckBox2.Name = "showHideCheckBox2";
            this.showHideCheckBox2.Size = new System.Drawing.Size(15, 14);
            this.showHideCheckBox2.TabIndex = 14;
            this.showHideCheckBox2.UseVisualStyleBackColor = true;
            this.showHideCheckBox2.CheckedChanged += new System.EventHandler(this.showHideCheckBox2_CheckedChanged);
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
            this.registerPanel5.Location = new System.Drawing.Point(12, 574);
            this.registerPanel5.Name = "registerPanel5";
            this.registerPanel5.Size = new System.Drawing.Size(239, 100);
            this.registerPanel5.TabIndex = 22;
            this.registerPanel5.Visible = false;
            this.registerPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel5_Paint);
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
            this.endRegisterPanel.Controls.Add(this.registerProgressBar);
            this.endRegisterPanel.Location = new System.Drawing.Point(399, 607);
            this.endRegisterPanel.Name = "endRegisterPanel";
            this.endRegisterPanel.Size = new System.Drawing.Size(268, 100);
            this.endRegisterPanel.TabIndex = 23;
            this.endRegisterPanel.Visible = false;
            this.endRegisterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.endRegisterPanel_Paint);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginWrite);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.showHideCheckBox);
            this.loginPanel.Controls.Add(this.passwordWrite);
            this.loginPanel.Location = new System.Drawing.Point(765, 41);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(265, 130);
            this.loginPanel.TabIndex = 24;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(955, 12);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 25;
            this.registerButton.Text = "Реєстрація";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton2
            // 
            this.loginButton2.Location = new System.Drawing.Point(955, 12);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(75, 23);
            this.loginButton2.TabIndex = 26;
            this.loginButton2.Text = "Вхід";
            this.loginButton2.UseVisualStyleBackColor = true;
            this.loginButton2.Visible = false;
            this.loginButton2.Click += new System.EventHandler(this.loginButton2_Click);
            // 
            // privacyAndTermsLabel
            // 
            this.privacyAndTermsLabel.AutoSize = true;
            this.privacyAndTermsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.privacyAndTermsLabel.Location = new System.Drawing.Point(102, 44);
            this.privacyAndTermsLabel.Name = "privacyAndTermsLabel";
            this.privacyAndTermsLabel.Size = new System.Drawing.Size(252, 25);
            this.privacyAndTermsLabel.TabIndex = 27;
            this.privacyAndTermsLabel.Text = "Конфіденційність і умови";
            // 
            // privacyAndTermsLabel2
            // 
            this.privacyAndTermsLabel2.AutoSize = true;
            this.privacyAndTermsLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.privacyAndTermsLabel2.Location = new System.Drawing.Point(46, 69);
            this.privacyAndTermsLabel2.Name = "privacyAndTermsLabel2";
            this.privacyAndTermsLabel2.Size = new System.Drawing.Size(352, 40);
            this.privacyAndTermsLabel2.TabIndex = 28;
            this.privacyAndTermsLabel2.Text = "Щоб створити обліковий запис EcoITTechnology, \r\nпотрібно прийняти";
            // 
            // privacyAndTermsLinkLabel
            // 
            this.privacyAndTermsLinkLabel.AutoSize = true;
            this.privacyAndTermsLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.privacyAndTermsLinkLabel.Location = new System.Drawing.Point(195, 89);
            this.privacyAndTermsLinkLabel.Name = "privacyAndTermsLinkLabel";
            this.privacyAndTermsLinkLabel.Size = new System.Drawing.Size(218, 20);
            this.privacyAndTermsLinkLabel.TabIndex = 29;
            this.privacyAndTermsLinkLabel.TabStop = true;
            this.privacyAndTermsLinkLabel.Text = "Загальні положення та умови";
            this.privacyAndTermsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.privacyAndTermsLinkLabel_LinkClicked);
            // 
            // endRegisterButton
            // 
            this.endRegisterButton.Location = new System.Drawing.Point(195, 124);
            this.endRegisterButton.Name = "endRegisterButton";
            this.endRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.endRegisterButton.TabIndex = 30;
            this.endRegisterButton.Text = "Прийняти";
            this.endRegisterButton.UseVisualStyleBackColor = true;
            this.endRegisterButton.Click += new System.EventHandler(this.endRegisterButton_Click_1);
            // 
            // privacyAndTermsPanel
            // 
            this.privacyAndTermsPanel.Controls.Add(this.privacyAndTermsLinkLabel);
            this.privacyAndTermsPanel.Controls.Add(this.privacyAndTermsLabel);
            this.privacyAndTermsPanel.Controls.Add(this.endRegisterButton);
            this.privacyAndTermsPanel.Controls.Add(this.privacyAndTermsLabel2);
            this.privacyAndTermsPanel.Location = new System.Drawing.Point(315, 390);
            this.privacyAndTermsPanel.Name = "privacyAndTermsPanel";
            this.privacyAndTermsPanel.Size = new System.Drawing.Size(460, 210);
            this.privacyAndTermsPanel.TabIndex = 31;
            this.privacyAndTermsPanel.Visible = false;
            this.privacyAndTermsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.privacyAndTermsPanel_Paint);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.Location = new System.Drawing.Point(17, 41);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(38, 20);
            this.userNameLabel.TabIndex = 32;
            this.userNameLabel.Text = "Ім\'я:";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userSurnameLabel
            // 
            this.userSurnameLabel.AutoSize = true;
            this.userSurnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSurnameLabel.Location = new System.Drawing.Point(17, 72);
            this.userSurnameLabel.Name = "userSurnameLabel";
            this.userSurnameLabel.Size = new System.Drawing.Size(80, 20);
            this.userSurnameLabel.TabIndex = 33;
            this.userSurnameLabel.Text = "Прізвище:";
            this.userSurnameLabel.Click += new System.EventHandler(this.userSurnameLabel_Click);
            // 
            // userDateOfBirthLabel
            // 
            this.userDateOfBirthLabel.AutoSize = true;
            this.userDateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userDateOfBirthLabel.Location = new System.Drawing.Point(17, 102);
            this.userDateOfBirthLabel.Name = "userDateOfBirthLabel";
            this.userDateOfBirthLabel.Size = new System.Drawing.Size(136, 20);
            this.userDateOfBirthLabel.TabIndex = 34;
            this.userDateOfBirthLabel.Text = "Дата народження:";
            this.userDateOfBirthLabel.Click += new System.EventHandler(this.userDateOfBirthLabel_Click);
            // 
            // userSexLabel
            // 
            this.userSexLabel.AutoSize = true;
            this.userSexLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSexLabel.Location = new System.Drawing.Point(17, 134);
            this.userSexLabel.Name = "userSexLabel";
            this.userSexLabel.Size = new System.Drawing.Size(49, 20);
            this.userSexLabel.TabIndex = 35;
            this.userSexLabel.Text = "Стать:";
            this.userSexLabel.Click += new System.EventHandler(this.userSexLabel_Click);
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLoginLabel.Location = new System.Drawing.Point(17, 169);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(50, 20);
            this.userLoginLabel.TabIndex = 36;
            this.userLoginLabel.Text = "Логін:";
            this.userLoginLabel.Click += new System.EventHandler(this.userLoginLabel_Click);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPasswordLabel.Location = new System.Drawing.Point(17, 205);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(65, 20);
            this.userPasswordLabel.TabIndex = 37;
            this.userPasswordLabel.Text = "Пароль:";
            this.userPasswordLabel.Click += new System.EventHandler(this.userPasswordLabel_Click);
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPhoneLabel.Location = new System.Drawing.Point(17, 238);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(130, 20);
            this.userPhoneLabel.TabIndex = 38;
            this.userPhoneLabel.Text = "Номер телефона:";
            this.userPhoneLabel.Click += new System.EventHandler(this.userPhoneLabel_Click);
            // 
            // userInformationsPanel
            // 
            this.userInformationsPanel.Controls.Add(this.changeSurnameTextBox);
            this.userInformationsPanel.Controls.Add(this.changeSurnameButton);
            this.userInformationsPanel.Controls.Add(this.changeNameTextBox);
            this.userInformationsPanel.Controls.Add(this.changeNameButton);
            this.userInformationsPanel.Controls.Add(this.userIdLabel);
            this.userInformationsPanel.Controls.Add(this.userNameLabel);
            this.userInformationsPanel.Controls.Add(this.userPhoneLabel);
            this.userInformationsPanel.Controls.Add(this.userSurnameLabel);
            this.userInformationsPanel.Controls.Add(this.userPasswordLabel);
            this.userInformationsPanel.Controls.Add(this.userDateOfBirthLabel);
            this.userInformationsPanel.Controls.Add(this.userLoginLabel);
            this.userInformationsPanel.Controls.Add(this.userSexLabel);
            this.userInformationsPanel.Controls.Add(this.acceptChangeNameButton);
            this.userInformationsPanel.Controls.Add(this.acceptChangeSurnameButton);
            this.userInformationsPanel.Location = new System.Drawing.Point(304, 31);
            this.userInformationsPanel.Name = "userInformationsPanel";
            this.userInformationsPanel.Size = new System.Drawing.Size(455, 353);
            this.userInformationsPanel.TabIndex = 39;
            this.userInformationsPanel.Visible = false;
            this.userInformationsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userInformationsPanel_Paint);
            // 
            // changeSurnameTextBox
            // 
            this.changeSurnameTextBox.Location = new System.Drawing.Point(194, 72);
            this.changeSurnameTextBox.Name = "changeSurnameTextBox";
            this.changeSurnameTextBox.Size = new System.Drawing.Size(177, 23);
            this.changeSurnameTextBox.TabIndex = 44;
            this.changeSurnameTextBox.Visible = false;
            this.changeSurnameTextBox.TextChanged += new System.EventHandler(this.changeSurnameTextBox_TextChanged);
            // 
            // changeSurnameButton
            // 
            this.changeSurnameButton.Location = new System.Drawing.Point(377, 72);
            this.changeSurnameButton.Name = "changeSurnameButton";
            this.changeSurnameButton.Size = new System.Drawing.Size(75, 23);
            this.changeSurnameButton.TabIndex = 43;
            this.changeSurnameButton.Text = "Змінити";
            this.changeSurnameButton.UseVisualStyleBackColor = true;
            this.changeSurnameButton.Click += new System.EventHandler(this.changeSurnameButton_Click);
            // 
            // changeNameTextBox
            // 
            this.changeNameTextBox.Location = new System.Drawing.Point(194, 42);
            this.changeNameTextBox.Name = "changeNameTextBox";
            this.changeNameTextBox.Size = new System.Drawing.Size(177, 23);
            this.changeNameTextBox.TabIndex = 42;
            this.changeNameTextBox.Visible = false;
            this.changeNameTextBox.TextChanged += new System.EventHandler(this.changeNameTextBox_TextChanged);
            // 
            // changeNameButton
            // 
            this.changeNameButton.Location = new System.Drawing.Point(377, 41);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(75, 23);
            this.changeNameButton.TabIndex = 41;
            this.changeNameButton.Text = "Змінити";
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userIdLabel.Location = new System.Drawing.Point(17, 10);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(74, 20);
            this.userIdLabel.TabIndex = 40;
            this.userIdLabel.Text = "Ваш айді:";
            this.userIdLabel.Click += new System.EventHandler(this.userIdLabel_Click);
            // 
            // acceptChangeNameButton
            // 
            this.acceptChangeNameButton.Location = new System.Drawing.Point(377, 41);
            this.acceptChangeNameButton.Name = "acceptChangeNameButton";
            this.acceptChangeNameButton.Size = new System.Drawing.Size(75, 23);
            this.acceptChangeNameButton.TabIndex = 45;
            this.acceptChangeNameButton.Text = "Зберегти";
            this.acceptChangeNameButton.UseVisualStyleBackColor = true;
            this.acceptChangeNameButton.Visible = false;
            this.acceptChangeNameButton.Click += new System.EventHandler(this.acceptChangeNameButton_Click);
            // 
            // acceptChangeSurnameButton
            // 
            this.acceptChangeSurnameButton.Location = new System.Drawing.Point(377, 72);
            this.acceptChangeSurnameButton.Name = "acceptChangeSurnameButton";
            this.acceptChangeSurnameButton.Size = new System.Drawing.Size(75, 23);
            this.acceptChangeSurnameButton.TabIndex = 46;
            this.acceptChangeSurnameButton.Text = "Зберегти";
            this.acceptChangeSurnameButton.UseVisualStyleBackColor = true;
            this.acceptChangeSurnameButton.Click += new System.EventHandler(this.acceptChangeSurnameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 719);
            this.Controls.Add(this.userInformationsPanel);
            this.Controls.Add(this.privacyAndTermsPanel);
            this.Controls.Add(this.loginButton2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerPanel4);
            this.Controls.Add(this.registerPanel3);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.endRegisterPanel);
            this.Controls.Add(this.registerPanel2);
            this.Controls.Add(this.registerPanel1);
            this.Controls.Add(this.registerPanel5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.registerSexGroupBox.ResumeLayout(false);
            this.registerSexGroupBox.PerformLayout();
            this.registerPanel1.ResumeLayout(false);
            this.registerPanel1.PerformLayout();
            this.registerPanel2.ResumeLayout(false);
            this.registerPanel3.ResumeLayout(false);
            this.registerPanel3.PerformLayout();
            this.registerPanel4.ResumeLayout(false);
            this.registerPanel4.PerformLayout();
            this.registerPanel5.ResumeLayout(false);
            this.registerPanel5.PerformLayout();
            this.endRegisterPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.privacyAndTermsPanel.ResumeLayout(false);
            this.privacyAndTermsPanel.PerformLayout();
            this.userInformationsPanel.ResumeLayout(false);
            this.userInformationsPanel.PerformLayout();
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
        private Button nextButton2;
        private RadioButton registerManRadioButton;
        private GroupBox registerSexGroupBox;
        private RadioButton registerWomanRadioButton;
        private Button nextButton3;
        private TextBox registerPasswordTextBox;
        private Button nextButton4;
        private ProgressBar registerProgressBar;
        private System.Windows.Forms.Timer progressTimer;
        private Panel registerPanel1;
        private Panel registerPanel2;
        private Panel registerPanel3;
        private Panel registerPanel4;
        private TextBox registerPhoneTextBox;
        private Panel registerPanel5;
        private Button nextButton5;
        private Panel endRegisterPanel;
        private Panel loginPanel;
        private Button registerButton;
        private Button loginButton2;
        private Label privacyAndTermsLabel;
        private Label privacyAndTermsLabel2;
        private LinkLabel privacyAndTermsLinkLabel;
        private Button endRegisterButton;
        private Panel privacyAndTermsPanel;
        private DateTimePicker registerDateTimePicker;
        private TextBox registerLoginTextBox;
        private Label userNameLabel;
        private Label userSurnameLabel;
        private Label userDateOfBirthLabel;
        private Label userSexLabel;
        private Label userLoginLabel;
        private Label userPasswordLabel;
        private Label userPhoneLabel;
        private Panel userInformationsPanel;
        private Label userIdLabel;
        private CheckBox showHideCheckBox2;
        private Button changeNameButton;
        private TextBox changeSurnameTextBox;
        private Button changeSurnameButton;
        private TextBox changeNameTextBox;
        private Button acceptChangeNameButton;
        private Button acceptChangeSurnameButton;
    }
}