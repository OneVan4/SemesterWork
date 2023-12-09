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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void программаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.программаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Программа". При необходимости она может быть перемещена или удалена.
            this.программаTableAdapter.Fill(this.theater_DBDataSet.Программа);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = программаDataGridView.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = this.программаDataGridView.Columns[0];
                    break;
                case 1:
                    Col = this.программаDataGridView.Columns[1];
                    break;
                case 2:
                    Col = this.программаDataGridView.Columns[2];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.программаDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.программаDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.программаBindingSource.Filter = "наименование='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            программаBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < программаDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < программаDataGridView.RowCount - 1; j++)
                {
                    программаDataGridView[i, j].Style.BackColor = Color.White;
                    программаDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < программаDataGridView.ColumnCount; i++)
                for (int j = 0; j < программаDataGridView.RowCount - 1; j++)
                    if (программаDataGridView[i, j].Value.ToString().StartsWith(textBox1.Text) == true)
                    {
                        программаDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        программаDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
