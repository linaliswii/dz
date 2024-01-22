using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docoborot
{
    public partial class LoginForm : Form
    {
        private const int MaxAttempts = 3; //количество попыток
        private int loginAttempts = 0;
        private string loggedInUser; //  поле для хранения логина пользователя

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Вход выполнен успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginAttempts = 0; // сброс количества попыток после успешного входа
                loggedInUser = username; // сохранение логина пользователя
                this.Hide();
                Individual f2 = new Individual(loggedInUser); // передача логина в конструктор формы Individual
                f2.ShowDialog();
            }
            else
            {
                // Неверный логин или пароль
                loginAttempts++;

                if (loginAttempts >= MaxAttempts)
                {
                    MessageBox.Show("Вы ввели неверный пароль 3 раза. Пожалуйста, сбросьте пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OpenResetPasswordForm();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void OpenResetPasswordForm()
        {
            // Открываем форму сброса пароля
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.ShowDialog();
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Реализуйте проверку логина и пароля здесь.
            // В этом примере просто используем заглушку.
            return username == "admin" && IsValidPassword(password);

        }

        private bool IsValidPassword(string password)
        {
            // требования к паролю
            const string passwordPattern = @"^(?=.*[a-zA-Z]{5})(?=.*\d{3})(?=.*[@#%)(.<>]).*$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}