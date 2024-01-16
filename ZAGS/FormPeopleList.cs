using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAGS
{
    public partial class FormPeopleList : Form
    {
        public FormPeopleList()
        {
            InitializeComponent();
        }

        private void гражданеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marriage_registrationDataSet);

        }

        private void гражданеBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marriage_registrationDataSet);

        }

        private void FormPeopleList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marriage_registrationDataSet.Граждане". При необходимости она может быть перемещена или удалена.
            this.гражданеTableAdapter.Fill(this.marriage_registrationDataSet.Граждане);

        }
    }
}
