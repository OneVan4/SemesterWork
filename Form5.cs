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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void программаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.программаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Программа". При необходимости она может быть перемещена или удалена.
            this.программаTableAdapter.Fill(this.theater_DBDataSet.Программа);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();   
            form10.ShowDialog();    
        
        }
    }
}
