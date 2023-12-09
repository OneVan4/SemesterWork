using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SemesterWork
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theater_DBDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ID_ticket");
            listBox1.Items.Add("ticket_level");
            listBox1.Items.Add("ticket_price");
            listBox1.Items.Add("date");
            listBox1.Items.Add("ID_spectator");
            listBox1.Items.Add("ID_performance");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theater_DBDataSet.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.theater_DBDataSet.Билет);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = билетDataGridView.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = this.билетDataGridView.Columns[0];
                    break;
                case 1:
                    Col = this.билетDataGridView.Columns[1];
                    break;
                case 2:
                    Col = this.билетDataGridView.Columns[2];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.билетDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.билетDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.билетBindingSource.Filter = "наименование='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            билетBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < билетDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < билетDataGridView.RowCount - 1; j++)
                {
                    билетDataGridView[i, j].Style.BackColor = Color.White;
                    билетDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < билетDataGridView.ColumnCount; i++)
                for (int j = 0; j < билетDataGridView.RowCount - 1; j++)
                    if (билетDataGridView[i, j].Value.ToString().StartsWith(textBox1.Text) == true)
                    {
                        билетDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        билетDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
