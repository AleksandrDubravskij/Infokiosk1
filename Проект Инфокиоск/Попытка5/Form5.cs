using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeZoneInfo;

namespace Попытка5
{
    public partial class Form5 : Form
    {
        private string filePath = "C:\\Users\\User\\Desktop\\Проект Инфокиоск\\Баланс.txt";

        public Form5()
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
                    label5.Text = $"Баланс: {balanceStr} руб.";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // При изменении текста в textBox2 выполняем необходимые действия

            // Пример: попробуем преобразовать текст в число и вывести результат в label5
            if (int.TryParse(textBox2.Text, out int enteredNumber))
            {

            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // При клике на label5 выполняем необходимые действия
            // Пример: выведем сообщение о том, что label5 был кликнут

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что оба текстовых поля не пусты
                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text))
                {
                    MessageBox.Show("Заполните оба текстовых поля для продолжения.");
                    return; // Прекращаем выполнение метода, так как одно из полей пусто
                }

                // Получаем текущий баланс из файла
                int currentBalance = int.Parse(System.IO.File.ReadAllText(filePath));

                // Проверяем, введено ли корректное число в textBox2
                if (int.TryParse(textBox2.Text, out int enteredNumber))
                {
                    // Проверяем, достаточно ли средств на балансе
                    if (currentBalance >= enteredNumber)
                    {
                        // Вычитаем введенное число из текущего баланса
                        int newBalance = currentBalance - enteredNumber;

                        // Записываем новый баланс в файл
                        System.IO.File.WriteAllText(filePath, newBalance.ToString());

                        // Обновляем отображение баланса в label5
                        label5.Text = $"Баланс: {newBalance} руб.";

                        // Переходим на 6 форму
                        Form6 form6 = new Form6();
                        form6.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств на балансе.");
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректное число в сумму пополнения.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении баланса: {ex.Message}");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}


