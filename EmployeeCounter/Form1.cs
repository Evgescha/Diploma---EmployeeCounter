using System;
using System.Windows.Forms;

namespace EmployeeCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Нарушения". При необходимости она может быть перемещена или удалена.
            this.нарушенияTableAdapter.Fill(this.eployeesCounterDataSet.Нарушения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.ПройденноеПовышение". При необходимости она может быть перемещена или удалена.
            this.пройденноеПовышениеTableAdapter.Fill(this.eployeesCounterDataSet.ПройденноеПовышение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.РаботаРаньше". При необходимости она может быть перемещена или удалена.
            this.работаРаньшеTableAdapter.Fill(this.eployeesCounterDataSet.РаботаРаньше);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Образование". При необходимости она может быть перемещена или удалена.
            this.образованиеTableAdapter.Fill(this.eployeesCounterDataSet.Образование);
            reloadAll();
            dataGridView3.Columns[0].Visible = false;
            dataGridView5.Columns[0].Visible = false;
        }
        private void reloadAll() {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.ПланированиеПовышения". При необходимости она может быть перемещена или удалена.
            this.планированиеПовышенияTableAdapter.Fill(this.eployeesCounterDataSet.ПланированиеПовышения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.ВладениеЯзыками". При необходимости она может быть перемещена или удалена.
            this.владениеЯзыкамиTableAdapter.Fill(this.eployeesCounterDataSet.ВладениеЯзыками);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Языки". При необходимости она может быть перемещена или удалена.
            this.языкиTableAdapter.Fill(this.eployeesCounterDataSet.Языки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Статусы". При необходимости она может быть перемещена или удалена.
            this.статусыTableAdapter.Fill(this.eployeesCounterDataSet.Статусы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.eployeesCounterDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.eployeesCounterDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eployeesCounterDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
            this.подразделенияTableAdapter.Fill(this.eployeesCounterDataSet.Подразделения);
        }
        // подразделения
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    подразделенияTableAdapter.Update(eployeesCounterDataSet.Подразделения);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //сотрудники 
        private void saveEmployeeTable(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    сотрудникиTableAdapter.Update(eployeesCounterDataSet.Сотрудники);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //статусы
        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    статусыTableAdapter.Update(eployeesCounterDataSet.Статусы);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //должности
        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    должностиTableAdapter.Update(eployeesCounterDataSet.Должности);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //языки
        private void toolStripButton44_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    языкиTableAdapter.Update(eployeesCounterDataSet.Языки);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //планирование
        private void toolStripButton51_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    планированиеПовышенияTableAdapter.Update(eployeesCounterDataSet.ПланированиеПовышения);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //образование
        private void toolStripButton65_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    образованиеTableAdapter.Update(eployeesCounterDataSet.Образование);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        // опвыт работы
        private void toolStripButton72_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    работаРаньшеTableAdapter.Update(eployeesCounterDataSet.РаботаРаньше);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //владение языками
        private void toolStripButton79_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    владениеЯзыкамиTableAdapter.Update(eployeesCounterDataSet.ВладениеЯзыками);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //повышения квалификации сотрудника
        private void toolStripButton86_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    пройденноеПовышениеTableAdapter.Update(eployeesCounterDataSet.ПройденноеПовышение);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //нарушения
        private void toolStripButton93_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    нарушенияTableAdapter.Update(eployeesCounterDataSet.Нарушения);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView10_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView5_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView7_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView9_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        //владение языками
        private void toolStripButton37_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?", "Подтвердите сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    владениеЯзыкамиTableAdapter.Update(eployeesCounterDataSet.ВладениеЯзыками);
                    MessageBox.Show("Изменения сохранены");
                    reloadAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.RemoveFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = $"ФИО LIKE '%{textBox1.Text}%'"; 
        }
    }
}
