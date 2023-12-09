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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.theater_DBDataSet.Билет);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 next = new Form7();
            next.ShowDialog();
        }
    }
}
