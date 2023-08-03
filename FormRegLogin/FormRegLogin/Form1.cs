using System.Data;
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

        private void registerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        ///
        ///
        /// Next button in register panel
        /// 
        /// 
        private void nextButton1_Click(object sender, EventArgs e)
        {
            nameInput = registerNameTextBox.Text;
            surnameInput = registerSurnameTextBox.Text;

            registerPanel1.Visible = false;
            registerPanel2.Visible = true;
        }
        private void nextButton2_Click(object sender, EventArgs e)
        {
            selectedDate = registerDateTimePicker.Value;

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
        private void nextButton3_Click(object sender, EventArgs e)
        {
            mailInput = registerMailTextBox.Text;

            registerPanel3.Visible = false;
            registerPanel4.Visible = true;
        }
        private void nextButton4_Click(object sender, EventArgs e)
        {
            if(registerPasswordTextBox.Text == "!" || registerPasswordTextBox.Text == "-" || registerPasswordTextBox.Text == "+" || registerPasswordTextBox.Text == "")
            {
                MessageBox.Show("Пароль повинен мати");
            }
            else 
            {
                passwordInput = registerPasswordTextBox.Text;
                registerPanel4.Visible = false;
                registerPanel5.Visible = true;
            }
        }
        private void registerManRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registerSexGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void registerMailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void endRegisterButton_Click(object sender, EventArgs e)
        {
            progressValue = 0;
            registerProgressBar.Visible = true;
            progressTimer.Start();

            endRegisterButton.Visible = false;
        }

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

        private void nextButton5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(registerPhoneTextBox.Text, out int phoneInputSave))
            {
                phoneInput = phoneInputSave;
                registerPanel5.Visible = false;
                endRegisterPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Невірний формат числа.");
            }
        }

        private void registerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void loginGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
            loginButton2.Visible = false;
            registerPanel1.Visible = false;
            loginPanel.Visible = true;
            registerButton.Visible = true;
        }
    }
}