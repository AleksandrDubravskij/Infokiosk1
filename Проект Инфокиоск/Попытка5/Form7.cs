using System;
using System.Windows.Forms;

namespace Попытка5
{
    public partial class Form7 : Form
    {
        private string filePath = "C:\\Users\\User\\Desktop\\Проект Инфокиоск\\Баланс.txt";

        public Form7()
        {
            InitializeComponent();
            LoadBalance(); // Загрузка баланса при инициализации формы
        }

        private void LoadBalance()
        {
            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    // Считываем текущий баланс из файла
                    string balanceStr = System.IO.File.ReadAllText(filePath);

                    // Отображаем баланс в лейбле
                    label1.Text = $"Текущий баланс: {balanceStr} руб.";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем текущий баланс из файла
                int currentBalance = int.Parse(System.IO.File.ReadAllText(filePath));

                // Проверяем, введено ли корректное число в textBoxRecharge
                if (int.TryParse(textBox1.Text, out int rechargeAmount) && rechargeAmount > 0)
                {
                    // Пополняем баланс
                    int newBalance = currentBalance + rechargeAmount;

                    // Записываем новый баланс в файл
                    System.IO.File.WriteAllText(filePath, newBalance.ToString());

                    // Обновляем отображение баланса
                    label1.Text = $"Текущий баланс: {newBalance} руб.";
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму для пополнения баланса.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при пополнении баланса: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("a");
            form3.Show();
            this.Hide();
        }
    }
}
