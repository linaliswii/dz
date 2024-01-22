using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docoborot
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            
                string newPassword = newPasswordTextBox.Text;

                // Реализуйте здесь логику сброса пароля, например, сохранение нового пароля в базе данных.

                MessageBox.Show("Пароль успешно сброшен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }

