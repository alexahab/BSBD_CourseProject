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
    public partial class FormZaivkiList : Form
    {
        public FormZaivkiList()
        {
            InitializeComponent();
        }

        private void заявкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marriage_registrationDataSet);

        }

        private void FormZaivkiList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marriage_registrationDataSet.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.marriage_registrationDataSet.Заявки);

        }
    }
}
