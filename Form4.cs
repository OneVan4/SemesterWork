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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void зрительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void постановкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постановкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Постановка". При необходимости она может быть перемещена или удалена.
            this.постановкаTableAdapter.Fill(this.theater_DBDataSet.Постановка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 next = new Form9();
            next.ShowDialog();
        }
    }
}
