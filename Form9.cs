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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void постановкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постановкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ID_performance");
            listBox1.Items.Add("name");
            listBox1.Items.Add("describtion");
            listBox1.Items.Add("producer");
            listBox1.Items.Add("ID_program");
            listBox1.Items.Add("ID_performance");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Постановка". При необходимости она может быть перемещена или удалена.
            this.постановкаTableAdapter.Fill(this.theater_DBDataSet.Постановка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = постановкаDataGridView.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = this.постановкаDataGridView.Columns[0];
                    break;
                case 1:
                    Col = this.постановкаDataGridView.Columns[1];
                    break;
                case 2:
                    Col = this.постановкаDataGridView.Columns[2];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.постановкаDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.постановкаDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.постановкаBindingSource.Filter = "наименование='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            постановкаBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < постановкаDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < постановкаDataGridView.RowCount - 1; j++)
                {
                    постановкаDataGridView[i, j].Style.BackColor = Color.White;
                    постановкаDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < постановкаDataGridView.ColumnCount; i++)
                for (int j = 0; j < постановкаDataGridView.RowCount - 1; j++)
                    if (постановкаDataGridView[i, j].Value.ToString().StartsWith(textBox1.Text) == true)
                    {
                        постановкаDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        постановкаDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
