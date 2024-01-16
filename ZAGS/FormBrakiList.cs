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
    public partial class FormBrakiList : Form
    {
        public FormBrakiList()
        {
            InitializeComponent();
        }

        private void бракиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бракиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marriage_registrationDataSet);

        }

        private void FormBrakiList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marriage_registrationDataSet.Браки". При необходимости она может быть перемещена или удалена.
            this.бракиTableAdapter.Fill(this.marriage_registrationDataSet.Браки);

        }
    }
}
