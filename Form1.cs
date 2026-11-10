using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class Form1 : Form
    {
        // создаём приватный список (коллекция экземпляров одного класса)
        // для хранения объектов Contact - он будет доступен только внутри
        // формы и изначально пуст
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        // Обновляет отображение списка контактов в ListBox
        private void UpdateContactList()
        {
            lstContacts.Items.Clear();
            foreach (var c in contacts)
                lstContacts.Items.Add(c);
        }

        // Очищает поля ввода и устанавливает первую категорию, если она есть
        private void ClearInputFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }

        // Обработчик добавления контакта
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Заполните имя и телефон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var category = cmbCategory.SelectedItem?.ToString() ?? (cmbCategory.Items.Count > 0 ? cmbCategory.Items[0].ToString() : "Другое");
            Contact newContact = new Contact(txtName.Text.Trim(), txtPhone.Text.Trim(), category);
            contacts.Add(newContact);

            UpdateContactList();
            ClearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт для удаления.",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = lstContacts.SelectedIndex;
            contacts.RemoveAt(index);
            UpdateContactList();
            lblDetails.Text = ""; // очищаем детали
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // обновить список
            UpdateContactList();
        }
        // показ телефона при выборе контакта
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {
                Contact selected = contacts[lstContacts.SelectedIndex];
                lblDetails.Text = $"Teneon: {selected.Phone}";
            }
            else
            {
                lblDetails.Text = "";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // условие (вводимый символ НЕ цифра и НЕ + и НЕ backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar == '\b')
            {
                // символ не показываем в поле
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // показываем диалоговое окно, если нажато НЕ ДА, отменяем закрытие формы
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}