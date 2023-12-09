using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterWork
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void режиссёрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.режиссёрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Режиссёр". При необходимости она может быть перемещена или удалена.
            this.режиссёрTableAdapter.Fill(this.theater_DBDataSet.Режиссёр);

        }
    }
}
