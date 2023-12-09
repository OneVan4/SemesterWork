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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void зрительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.зрительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ID_spectator");
            listBox1.Items.Add("name");
            listBox1.Items.Add("surname");
            listBox1.Items.Add("email");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Зритель". При необходимости она может быть перемещена или удалена.
            this.зрительTableAdapter.Fill(this.theater_DBDataSet.Зритель);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = зрительDataGridView.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = this.зрительDataGridView.Columns[0];
                    break;
                case 1:
                    Col = this.зрительDataGridView.Columns[1];
                    break;
                case 2:
                    Col = this.зрительDataGridView.Columns[2];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.зрительDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.зрительDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.зрительBindingSource.Filter = "наименование='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            зрительBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < зрительDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < зрительDataGridView.RowCount - 1; j++)
                {
                    зрительDataGridView[i, j].Style.BackColor = Color.White;
                    зрительDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < зрительDataGridView.ColumnCount; i++)
                for (int j = 0; j < зрительDataGridView.RowCount - 1; j++)
                    if (зрительDataGridView[i, j].Value.ToString().StartsWith(textBox1.Text) == true)
                    {
                        зрительDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        зрительDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
