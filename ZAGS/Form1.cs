using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZAGS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?","Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void оПрграммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,курсовая работа Колотовой Александры Сергеевны,741-1,2024", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Click(object sender, EventArgs e)
        {

        }

        private void гражданеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeopleList fp = new FormPeopleList();
            fp.Show();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZaivkiList fz = new FormZaivkiList();
            fz.Show();
        }

        private void бракиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrakiList fb = new FormBrakiList();
            fb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Некорректное значение", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Marriage_registrationConnectionString);
            SqlCommand command = connection.CreateCommand();
            string sqlSelect = @"select Б.Статус_брака, Б.Дата_заключения, Г.Фамилия, Г.Имя, Г.Отчество, Г.Пол, Г.Дата_рождения
            from dbo.Граждане Г join dbo.Заявки З on Г.ID_гражданина = З.Жена 
            join dbo.Браки Б on З.Номер_заявки = Б.ID_заявки
            where Б.Номер_свидетельства = @num
            union 
            select Б.Статус_брака, Б.Дата_заключения, Г.Фамилия, Г.Имя, Г.Отчество, Г.Пол, Г.Дата_рождения
            from dbo.Граждане Г join dbo.Заявки З on Г.ID_гражданина = З.Муж 
            join dbo.Браки Б on З.Номер_заявки = Б.ID_заявки
            where Б.Номер_свидетельства = @num;";
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@num", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
