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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void зрительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.зрительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Зритель". При необходимости она может быть перемещена или удалена.
            this.зрительTableAdapter.Fill(this.theater_DBDataSet.Зритель);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 next = new Form8();
            next.ShowDialog();
        }
    }
}
