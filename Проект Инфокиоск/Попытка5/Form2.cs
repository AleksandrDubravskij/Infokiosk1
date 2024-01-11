using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Попытка5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string projectPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Проект Инфокиоск\\";

                // Массив с именами пользователей
                string[] userNames = { "user1", "user2", "user3" }; // Добавьте нужные имена

                foreach (string userName in userNames)
                {
                    // Задайте путь к файлу с кодом выбранного пользователя
                    string filePath = Path.Combine(projectPath, $"{userName}_code.txt");

                    // Проверьте, существует ли файл
                    if (File.Exists(filePath))
                    {
                        // Прочитайте первые 4 символа из файла
                        string correctCodeFromFile = File.ReadAllText(filePath).Substring(0, 4);

                        // Получите введенный код из текстового поля
                        string enteredCode = textBox1.Text;

                        // Проверьте совпадение введенного кода с кодом из файла
                        if (enteredCode == correctCodeFromFile)
                        {
                            Form3 form3 = new Form3(userName); // Передайте информацию о пользователе в конструктор
                            form3.Show();
                            this.Hide();
                            return; // Если код совпал, выход из цикла
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Файл с кодом для пользователя {userName} не найден.");
                    }
                }

                // Если мы дошли до этой точки, значит, код не совпал ни для одного пользователя
                label2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }




}





