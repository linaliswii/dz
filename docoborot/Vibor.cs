using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace docoborot
{
    public partial class Individual : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private string loggedInUser;
        public Individual(string username)
        {
   
            InitializeComponent();
            loggedInUser = username;
            UpdateLoggedInUserLabel();

            // Вызовем метод для загрузки данных
            this.Load += Individual_Load;
        }

        private void Individual_Load(object sender, EventArgs e)
        {
            try
            {
                //Statement 2
                var cs = "Host=localhost;Username=postgres;Password=1234;Database=docob";

                //Statement 3
                using (NpgsqlConnection con = new NpgsqlConnection(cs))
                {
                    con.Open();

                    //Statement 4
                    var sql = "Select * from individual";

                    //Statement 5
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        //Statement 6
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            //Statement 7
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            //Statement 8
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int i;
        public string lastname;
        public string firstname;
        public string middlename;
        public string residenceaddress;
        public string dateofbirth;
        public string passportserialnumber;
        public string email;
        public string phonenumber;
        public string position;
        public string workplace;
        public string column;
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            column = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            i = e.RowIndex;
        }

     

        private void UpdateLoggedInUserLabel()
        {
            // В этом примере предполагается, что у вас есть Label с именем lblLoggedInUser
            lblLoggedInUser.Text = $"Логин: {loggedInUser}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lastname = dataGridView1[1, i].Value.ToString();
            firstname = dataGridView1[2, i].Value.ToString();
            middlename = dataGridView1[3, i].Value.ToString();
            residenceaddress = dataGridView1[6, i].Value.ToString();
            dateofbirth = dataGridView1[4, i].Value.ToString();
            passportserialnumber = dataGridView1[5, i].Value.ToString();
            phonenumber = dataGridView1[8, i].Value.ToString();
            email = dataGridView1[7, i].Value.ToString();
            position = dataGridView1[9, i].Value.ToString();
            workplace = dataGridView1[10, i].Value.ToString();

            try
            {
                string templatePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор.docx";
                string newFilePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор1.docx";

                if (File.Exists(templatePath))
                {
                    using (DocX doc = DocX.Load(templatePath))
                    {
                        doc.ReplaceText("#местоработы#", workplace);
                        doc.ReplaceText("#фамилия#", lastname);
                        doc.ReplaceText("#имя#", firstname);
                        doc.ReplaceText("#отчество#", middlename);
                        doc.ReplaceText("#др#", dateofbirth);
                        doc.ReplaceText("#адрес#", residenceaddress);
                        doc.ReplaceText("#паспорт#", passportserialnumber);
                        doc.ReplaceText("#телефон#", phonenumber);
                        doc.SaveAs(newFilePath); // Сохраняем изменения в новом файле
                    }
                }
                else
                {
                    MessageBox.Show("Файл-шаблон не найден.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        

            lastname = dataGridView1[1, i].Value.ToString();
            firstname = dataGridView1[2, i].Value.ToString();
            middlename = dataGridView1[3, i].Value.ToString();
            residenceaddress = dataGridView1[6, i].Value.ToString();
            dateofbirth = dataGridView1[4, i].Value.ToString();
            passportserialnumber = dataGridView1[5, i].Value.ToString();
            phonenumber = dataGridView1[8, i].Value.ToString();
            email = dataGridView1[7, i].Value.ToString();
            position = dataGridView1[9, i].Value.ToString();
            workplace = dataGridView1[10, i].Value.ToString();

          
           try
            {
                // Путь к шаблону
                string templateFile = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\1.txt";
                if (File.Exists(templateFile))
                {
                    string newTxtFilePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор1.txt";
                    string templateContent = File.ReadAllText(templateFile);
                    templateContent = templateContent.Replace("#местоработы#", workplace);
                    templateContent = templateContent.Replace("#фамилия#", lastname);
                    templateContent = templateContent.Replace("#имя#", firstname);
                    templateContent = templateContent.Replace("#отчество#", middlename);
                    templateContent = templateContent.Replace("#др#", dateofbirth);
                    templateContent = templateContent.Replace("#адрес#", residenceaddress);
                    templateContent = templateContent.Replace("#паспорт#", passportserialnumber);
                    templateContent = templateContent.Replace("#телефон#", phonenumber);
                    File.WriteAllText(newTxtFilePath, templateContent);
                }
                else
                {
                    MessageBox.Show("Шаблон не найден.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
            string templateFilePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Квитанция.docx";
            if (File.Exists(templateFilePath))
            {
                string newFilePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Квитанция1.docx";
                File.Copy(templateFilePath, newFilePath, true);
                using (DocX doc = DocX.Load(newFilePath))
                {
                    doc.ReplaceText("#фамилия#", lastname);
                    doc.ReplaceText("#имя#", firstname);
                    doc.ReplaceText("#отчество#", middlename);
                    doc.ReplaceText("#адрес#", residenceaddress);
                    doc.ReplaceText("#местоработы#", workplace);
                    doc.Save();
                }
            }
            this.Hide();
            Qualifications f2 = new Qualifications(loggedInUser);
            f2.ShowDialog();
        }

        internal void button3_Click(object value, EventArgs empty)
        {
            throw new NotImplementedException();
        }
    }
}

