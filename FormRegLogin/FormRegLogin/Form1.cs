using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FormRegLogin
{
    public partial class Form1 : Form
    {
        private DateTime selectedDate;
        private string nameInput = "";
        private string surnameInput = "";
        private string userChoice = "";
        private string loginInput = "";
        private string passwordInput = "";
        private int phoneInput = 0; 

        private int progressValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// 
        /// 
        /// Bool Options
        /// 
        /// 
        private bool IsTextBoxEmptyOrWhiteSpace(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        private bool TextBoxContainsSpace(TextBox textBox)
        {
            return textBox.Text.Contains(" ");
        }
        ///
        /// Main menu (Panel, Button)
        /// 
        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            registerPanel1.Visible = true;
            loginButton2.Visible = true;
            loginPanel.Visible = false;
            registerButton.Visible = false;
        }
        private void loginButton2_Click(object sender, EventArgs e)
        {
            registerNameTextBox.Clear();
            registerSurnameTextBox.Clear();
            registerLoginTextBox.Clear();
            registerPasswordTextBox.Clear();
            registerPhoneTextBox.Clear();

            loginButton2.Visible = false;
            registerPanel1.Visible = false;
            registerPanel2.Visible = false;
            registerPanel3.Visible = false;
            registerPanel4.Visible = false;
            registerPanel5.Visible = false;
            privacyAndTermsPanel.Visible = false;
            //endRegisterPanel.Visible = false;

            loginPanel.Visible = true;
            registerButton.Visible = true;
        }
        /// 
        /// 
        /// LoginUser
        /// 
        /// 
        private void passwordWrite_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginWrite_TextChanged(object sender, EventArgs e)
        {

        }
        private void showHideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordWrite.UseSystemPasswordChar = !showHideCheckBox.Checked;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            string loginUser = loginWrite.Text;
            string passwordUser = passwordWrite.Text;

            string hashedPasswordFromDatabase = GetHashedPasswordFromDatabase(loginUser);


            if (!string.IsNullOrEmpty(hashedPasswordFromDatabase))
            {
                // ��������� ����
                bool passwordMatches = BCrypt.Net.BCrypt.Verify(passwordUser, hashedPasswordFromDatabase);

                if (passwordMatches)
                {
                    MessageBox.Show("���� �������� ������.");
                }
                else
                {
                    MessageBox.Show("������ �������.");
                }
            }
            else
            {
                MessageBox.Show("����������� � ����� ��'�� �� ��������.");
            }
        }      
        private string GetHashedPasswordFromDatabase(string loginUser)
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT password FROM users WHERE email = @Username", dataBase.getConnection());
            command.Parameters.AddWithValue("@Username", loginUser);

            object result = command.ExecuteScalar();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
            dataBase.closedConnection();
        }
        ///
        /// 
        /// RegisterUser
        /// 
        /// 
        ///
        /// Next button in register panel
        ///  
        private void nextButton1_Click(object sender, EventArgs e) //Name and surname
        {
            if (IsTextBoxEmptyOrWhiteSpace(registerNameTextBox) || IsTextBoxEmptyOrWhiteSpace(registerSurnameTextBox))
            {
                MessageBox.Show("����� � ������ � ���� �������.");
            }
            else if (TextBoxContainsSpace(registerNameTextBox) || TextBoxContainsSpace(registerSurnameTextBox))
            {
                MessageBox.Show("����� � ������ � ���� ������ ������.");
            }
            else
            {
                nameInput = registerNameTextBox.Text;
                surnameInput = registerSurnameTextBox.Text;

                registerPanel1.Visible = false;
                registerPanel2.Visible = true;
            }
        }
        private void nextButton2_Click(object sender, EventArgs e) //userSex
        {
            if (!registerManRadioButton.Checked && !registerWomanRadioButton.Checked) 
            {
                MessageBox.Show("�� ������� ������� �������.");
            }
            else 
            {
                /*int dayInput = (int)registerDayNumericUpDown.Value;
                int monthInput = (int)registerMonthNumericUpDown.Value;
                int yearInput = (int)registerYearNumericUpDown.Value;

                DateTime date1 = new DateTime(yearInput, monthInput, dayInput);
                DateTime dateOnly = date1.Date;*/
                selectedDate = registerDateTimePicker.Value;

                if (registerManRadioButton.Checked)
                {
                    userChoice = registerManRadioButton.Text;
                }
                else if (registerWomanRadioButton.Checked)
                {
                    userChoice = registerWomanRadioButton.Text;
                }
                else 
                {
                    MessageBox.Show("������� �����.");
                }
                registerPanel2.Visible = false;
                registerPanel3.Visible = true;
            }
        }
        private void nextButton3_Click(object sender, EventArgs e) //login
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @lU", dataBase.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = registerLoginTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("����� ���� ��� ����, ������ �����!");
            }
            else
            {
                if (IsTextBoxEmptyOrWhiteSpace(registerLoginTextBox))
                {
                    MessageBox.Show("����� � ����� ��� �������.");
                }
                else if (TextBoxContainsSpace(registerLoginTextBox))
                {
                    MessageBox.Show("����� � ����� ��� ������ ������.");
                }
                else
                {
                    loginInput = registerLoginTextBox.Text;

                    registerPanel3.Visible = false;
                    registerPanel4.Visible = true;
                }
            }
        }
        private void nextButton4_Click(object sender, EventArgs e) //password
        {
            if (IsTextBoxEmptyOrWhiteSpace(registerPasswordTextBox))
            {
                MessageBox.Show("����� � ����� ��� �������.");
            }
            else if (TextBoxContainsSpace(registerPasswordTextBox))
            {
                MessageBox.Show("����� � ����� ��� ������ ������.");
            }
            else
            {         
                registerPanel4.Visible = false;
                registerPanel5.Visible = true;
            }

            /*string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";
            if (Regex.IsMatch(passwordInput, pattern))
            {
                passwordInput = registerPasswordTextBox.Text;

                registerPanel4.Visible = false;
                registerPanel5.Visible = true;
            }
            else
            {
                MessageBox.Show("������ �� ���������� ������.");
            }*/
        }
        private void nextButton5_Click(object sender, EventArgs e) //phone
        {
            if (int.TryParse(registerPhoneTextBox.Text, out int phoneInputSave))
            {
                phoneInput = phoneInputSave;
                registerPanel5.Visible = false;
                privacyAndTermsPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("������� ������ �����.");
            }
        }
        private void endRegisterButton_Click_1(object sender, EventArgs e) //end
        {
            DataBase dataBase = new DataBase();

            nameInput = registerNameTextBox.Text;
            surnameInput = registerSurnameTextBox.Text;
            loginInput = registerLoginTextBox.Text;
            passwordInput = registerPasswordTextBox.Text;

            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordInput, salt);

            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `dateOfBirth`, `sex`, `email`, `password`, `telephone`) VALUES (@namePlug, @surnamePlug, @dateOfBirthPlug, @sexPlug, @emailPlug, @passwordPlug, @telephonePlug);", dataBase.getConnection());

            mySqlCommand.Parameters.AddWithValue("@namePlug", nameInput);
            mySqlCommand.Parameters.AddWithValue("@surnamePlug", surnameInput);          

            if (registerManRadioButton.Checked)
            {
                mySqlCommand.Parameters.AddWithValue("@sexPlug", userChoice);             
            }
            else if (registerWomanRadioButton.Checked)
            {
                mySqlCommand.Parameters.AddWithValue("@sexPlug", userChoice);                
            }

            mySqlCommand.Parameters.Add("@dateOfBirthPlug", MySqlDbType.Date).Value = registerDateTimePicker.Value;         
            mySqlCommand.Parameters.AddWithValue("@emailPlug", loginInput);
            mySqlCommand.Parameters.AddWithValue("@passwordPlug", hashedPassword);
            mySqlCommand.Parameters.Add("@telephonePlug", MySqlDbType.Int32).Value = registerPhoneTextBox.Text;      

            dataBase.openConnection();
            progressValue = 0;

            privacyAndTermsPanel.Visible = false;
            loginButton2.Visible = false;

            progressTimer.Start();
            endRegisterPanel.Visible = true;
            registerProgressBar.Visible = true;

            if (mySqlCommand.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("��������� ���� �������!");
            }
            else 
            {
                MessageBox.Show("��������� ���� �� ��������!");
                return;
            }

            dataBase.closedConnection();
        }
        ///
        /// TextBox in register panel
        /// 
        private void registerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void registerSurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void registerLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void registerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void registerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        ///
        /// LableLink in register panel
        /// 
        private void privacyAndTermsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        ///
        /// RadioButton in register panel
        /// 
        private void registerManRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void registerWomanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        ///
        /// NumericUpDown in register panel
        /// 
        private void registerDayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void registerMonthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void registerYearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        ///
        /// GroupBox in register panel
        /// 
        private void registerSexGroupBox_Enter(object sender, EventArgs e)
        {

        }
        ///
        /// Panel in register panel
        /// 
        private void registerPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void privacyAndTermsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void endRegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        ///
        ///
        /// Components
        /// 
        /// 
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (progressValue >= registerProgressBar.Maximum)
            {
                progressTimer.Stop();
                endRegisterPanel.Visible = false;
                registerProgressBar.Visible = false;
            }
            else
            {
                progressValue++;
                registerProgressBar.Value = progressValue;
            }
        }

        private void registerDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void registerProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}