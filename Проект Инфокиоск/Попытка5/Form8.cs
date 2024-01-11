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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private string filePath = "C:\\Users\\User\\Desktop\\Проект Инфокиоск\\Баланс.txt";

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Считываем текущий баланс из файла
                    string balanceStr = File.ReadAllText(filePath);

                    // Отображаем баланс в соответствующем элементе управления (например, Label)
                    label1.Text = $"Баланс: {balanceStr} руб.";
                }
                else
                {
                    MessageBox.Show("Файл с балансом не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("a");
            form3.Show();
            this.Hide();
        }
    }
}

