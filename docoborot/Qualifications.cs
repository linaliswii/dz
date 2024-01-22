using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace docoborot
{
    public partial class Qualifications : Form
    {
        private string loggedInUser;
        public Qualifications(string username)
        {
            InitializeComponent();
            loggedInUser = username;
            UpdateLoggedInUserLabel();
            this.Load += Qualifications_Load;
        }

        private void UpdateLoggedInUserLabel()
        {
            lblLoggedInUser.Text = $"Логин: {loggedInUser}";
        }

        private void Qualifications_Load(object sender, EventArgs e)
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
                    var sql = "Select * from educationalprogram";

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
        public string name;
        public string duration;
        public string qualification;
        public string tuitioncost;
        public string column;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            column = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            i = e.RowIndex;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = dataGridView1[1, i].Value.ToString();
            duration = dataGridView1[2, i].Value.ToString();
            qualification = dataGridView1[3, i].Value.ToString();
            tuitioncost = dataGridView1[4, i].Value.ToString();
           try
            {
                string put = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор1.docx";

                if (File.Exists(put))
                {
                    using (DocX doc = DocX.Load(put))
                    {
                        doc.ReplaceText("#квалиф#", qualification);
                        doc.Save(put);
                    }
                }
                else
                {
                    MessageBox.Show("шаблон не найден.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }

            try
            {
              
                string filePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\1.txt";
                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    fileContent = fileContent.Replace("#квалиф#", qualification);
                    // Записываем измененное содержимое обратно в файл
                    File.WriteAllText(filePath, fileContent);
                }
                else
                {
                    MessageBox.Show("Файл не найден.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
            try
            {
                string templateFilePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Квитанция.docx";

                if (File.Exists(templateFilePath))
                {
                    using (DocX doc = DocX.Load(templateFilePath))
                    {
                        doc.ReplaceText("#сумма#", tuitioncost);
                        doc.Save();
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
            this.Hide();
            Dogovor f2 = new Dogovor(loggedInUser);
            f2.ShowDialog();
        }
    }
    }

