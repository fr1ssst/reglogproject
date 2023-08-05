using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormRegLogin
{
    public partial class Form1 : Form
    {
        private DateTime selectedDate;
        private string nameInput = "";
        private string surnameInput = "";
        private string userChoice = "";
        private string mailInput = "";
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
        /// Bool
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
            registerMailTextBox.Clear();
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
            String loginUser = loginWrite.Text;
            String passwordUser = passwordWrite.Text;

            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command= new MySqlCommand("SELECT * FROM `users` WHERE `email` = @lU AND `password` = @pU", dataBase.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show($"Вхід у користувача {loginUser}");
                loginPanel.Visible = false;

            }
            else 
            {
                MessageBox.Show("Невірний пароль чи логін");
            }
        }
        ///
        /// 
        /// RegisterUser
        /// 
        /// 
        ///
        /// Next button in register panel
        ///  
        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmptyOrWhiteSpace(registerNameTextBox) || IsTextBoxEmptyOrWhiteSpace(registerSurnameTextBox))
            {
                MessageBox.Show("Текст в одному з полів відсутній.");
            }
            else if (TextBoxContainsSpace(registerNameTextBox) || TextBoxContainsSpace(registerSurnameTextBox))
            {
                MessageBox.Show("Текст в одному з полів містить пробіли.");
            }
            else
            {
                nameInput = registerNameTextBox.Text;
                surnameInput = registerSurnameTextBox.Text;

                registerPanel1.Visible = false;
                registerPanel2.Visible = true;
            }
        }
        private void nextButton2_Click(object sender, EventArgs e)
        {
            if (!registerManRadioButton.Checked && !registerWomanRadioButton.Checked) 
            {
                MessageBox.Show("Не вибрано жодного варіанту.");
            }
            else 
            {
                /*int dayInput = (int)registerDayNumericUpDown.Value;
                int monthInput = (int)registerMonthNumericUpDown.Value;
                int yearInput = (int)registerYearNumericUpDown.Value;

                DateTime date1 = new DateTime(yearInput, monthInput, dayInput);
                DateTime dateOnly = date1.Date;*/

                if (registerManRadioButton.Checked)
                {
                    userChoice = registerManRadioButton.Text;
                }
                else if (registerWomanRadioButton.Checked)
                {
                    userChoice = registerWomanRadioButton.Text;
                }
                registerPanel2.Visible = false;
                registerPanel3.Visible = true;
            }
        }
        private void nextButton3_Click(object sender, EventArgs e)
        {
            mailInput = registerMailTextBox.Text;

            registerPanel3.Visible = false;
            registerPanel4.Visible = true;
        }
        private void nextButton4_Click(object sender, EventArgs e)
        {
            registerPanel4.Visible = false;
            registerPanel5.Visible = true;
            /*string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";
            if (Regex.IsMatch(passwordInput, pattern))
            {
                passwordInput = registerPasswordTextBox.Text;

                registerPanel4.Visible = false;
                registerPanel5.Visible = true;
            }
            else
            {
                MessageBox.Show("Пароль не задовільняє вимоги.");
            }*/
        }
        private void nextButton5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(registerPhoneTextBox.Text, out int phoneInputSave))
            {
                phoneInput = phoneInputSave;
                registerPanel5.Visible = false;
                privacyAndTermsPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Невірний формат числа.");
            }
        }
        private void endRegisterButton_Click_1(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `dateOfBirth`, `sex`, `email`, `password`, `telephone`) VALUES (@namePlug, @surnamePlug, @dateOfBirthPlug, @sexPlug, @emailPlug, @passwordPlug, @telephonePlug);", dataBase.getConnection());
            //MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `dateOfBirth`, `email`, `password`, `telephone`) VALUES (@namePlug, @surnamePlug, @dateOfBirthPlug,@emailPlug, @passwordPlug, @telephonePlug);", dataBase.getConnection());

            mySqlCommand.Parameters.Add("@namePlug", MySqlDbType.VarChar).Value = registerNameTextBox.Text;
            mySqlCommand.Parameters.Add("@surnamePlug", MySqlDbType.VarChar).Value = registerSurnameTextBox.Text;

            mySqlCommand.Parameters.Add("@dateOfBirthPlug", MySqlDbType.Date).Value = registerDateTimePicker.Value;
            mySqlCommand.Parameters.Add("@sexPlug", MySqlDbType.VarChar).Value = registerManRadioButton.Text;
            mySqlCommand.Parameters.Add("@emailPlug", MySqlDbType.VarChar).Value = registerMailTextBox.Text;
            mySqlCommand.Parameters.Add("@passwordPlug", MySqlDbType.VarChar).Value = registerPasswordTextBox.Text;
            mySqlCommand.Parameters.Add("@telephonePlug", MySqlDbType.Int32).Value = registerPhoneTextBox.Text;

            dataBase.openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("Реєстрація була успішною!");
            }
            else 
            {
                MessageBox.Show("Реєстрація була не виконана!");
            }

            dataBase.closedConnection();



            progressValue = 0;
            endRegisterPanel.Visible = true;
            registerProgressBar.Visible = true;
            progressTimer.Start();

            endRegisterButton.Visible = false;
            privacyAndTermsPanel.Visible = false;
            loginButton2.Visible = false;
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
        private void registerMailTextBox_TextChanged(object sender, EventArgs e)
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
    }
}