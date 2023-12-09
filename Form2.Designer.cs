namespace SemesterWork
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_ticketLabel;
            System.Windows.Forms.Label ticket_levelLabel;
            System.Windows.Forms.Label ticket_priceLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label iD_spectatorLabel;
            System.Windows.Forms.Label iD_performanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.theater_DBDataSet = new SemesterWork.Theater_DBDataSet();
            this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетTableAdapter = new SemesterWork.Theater_DBDataSetTableAdapters.БилетTableAdapter();
            this.tableAdapterManager = new SemesterWork.Theater_DBDataSetTableAdapters.TableAdapterManager();
            this.билетBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.билетBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ticketTextBox = new System.Windows.Forms.TextBox();
            this.ticket_levelTextBox = new System.Windows.Forms.TextBox();
            this.ticket_priceTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_spectatorTextBox = new System.Windows.Forms.TextBox();
            this.iD_performanceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iD_ticketLabel = new System.Windows.Forms.Label();
            ticket_levelLabel = new System.Windows.Forms.Label();
            ticket_priceLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iD_spectatorLabel = new System.Windows.Forms.Label();
            iD_performanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theater_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingNavigator)).BeginInit();
            this.билетBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ticketLabel
            // 
            iD_ticketLabel.AutoSize = true;
            iD_ticketLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ticketLabel.Location = new System.Drawing.Point(34, 58);
            iD_ticketLabel.Name = "iD_ticketLabel";
            iD_ticketLabel.Size = new System.Drawing.Size(75, 18);
            iD_ticketLabel.TabIndex = 1;
            iD_ticketLabel.Text = "ID ticket:";
            // 
            // ticket_levelLabel
            // 
            ticket_levelLabel.AutoSize = true;
            ticket_levelLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ticket_levelLabel.Location = new System.Drawing.Point(34, 102);
            ticket_levelLabel.Name = "ticket_levelLabel";
            ticket_levelLabel.Size = new System.Drawing.Size(91, 18);
            ticket_levelLabel.TabIndex = 3;
            ticket_levelLabel.Text = "ticket level:";
            // 
            // ticket_priceLabel
            // 
            ticket_priceLabel.AutoSize = true;
            ticket_priceLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ticket_priceLabel.Location = new System.Drawing.Point(33, 148);
            ticket_priceLabel.Name = "ticket_priceLabel";
            ticket_priceLabel.Size = new System.Drawing.Size(93, 18);
            ticket_priceLabel.TabIndex = 5;
            ticket_priceLabel.Text = "ticket price:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(33, 188);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(43, 18);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "date:";
            // 
            // iD_spectatorLabel
            // 
            iD_spectatorLabel.AutoSize = true;
            iD_spectatorLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_spectatorLabel.Location = new System.Drawing.Point(33, 229);
            iD_spectatorLabel.Name = "iD_spectatorLabel";
            iD_spectatorLabel.Size = new System.Drawing.Size(100, 18);
            iD_spectatorLabel.TabIndex = 9;
            iD_spectatorLabel.Text = "ID spectator:";
            // 
            // iD_performanceLabel
            // 
            iD_performanceLabel.AutoSize = true;
            iD_performanceLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_performanceLabel.Location = new System.Drawing.Point(29, 282);
            iD_performanceLabel.Name = "iD_performanceLabel";
            iD_performanceLabel.Size = new System.Drawing.Size(123, 18);
            iD_performanceLabel.TabIndex = 11;
            iD_performanceLabel.Text = "ID performance:";
            // 
            // theater_DBDataSet
            // 
            this.theater_DBDataSet.DataSetName = "Theater_DBDataSet";
            this.theater_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // билетBindingSource
            // 
            this.билетBindingSource.DataMember = "Билет";
            this.билетBindingSource.DataSource = this.theater_DBDataSet;
            // 
            // билетTableAdapter
            // 
            this.билетTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SemesterWork.Theater_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетTableAdapter = this.билетTableAdapter;
            this.tableAdapterManager.ЗрительTableAdapter = null;
            this.tableAdapterManager.ПостановкаTableAdapter = null;
            this.tableAdapterManager.ПрограммаTableAdapter = null;
            this.tableAdapterManager.РежиссёрTableAdapter = null;
            // 
            // билетBindingNavigator
            // 
            this.билетBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.билетBindingNavigator.BindingSource = this.билетBindingSource;
            this.билетBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.билетBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.билетBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.билетBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.билетBindingNavigatorSaveItem});
            this.билетBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.билетBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.билетBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.билетBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.билетBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.билетBindingNavigator.Name = "билетBindingNavigator";
            this.билетBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.билетBindingNavigator.Size = new System.Drawing.Size(393, 27);
            this.билетBindingNavigator.TabIndex = 0;
            this.билетBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // билетBindingNavigatorSaveItem
            // 
            this.билетBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.билетBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("билетBindingNavigatorSaveItem.Image")));
            this.билетBindingNavigatorSaveItem.Name = "билетBindingNavigatorSaveItem";
            this.билетBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.билетBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.билетBindingNavigatorSaveItem.Click += new System.EventHandler(this.билетBindingNavigatorSaveItem_Click);
            // 
            // iD_ticketTextBox
            // 
            this.iD_ticketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "ID_ticket", true));
            this.iD_ticketTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_ticketTextBox.Location = new System.Drawing.Point(181, 55);
            this.iD_ticketTextBox.Name = "iD_ticketTextBox";
            this.iD_ticketTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_ticketTextBox.TabIndex = 2;
            // 
            // ticket_levelTextBox
            // 
            this.ticket_levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "ticket_level", true));
            this.ticket_levelTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_levelTextBox.Location = new System.Drawing.Point(181, 102);
            this.ticket_levelTextBox.Name = "ticket_levelTextBox";
            this.ticket_levelTextBox.Size = new System.Drawing.Size(100, 26);
            this.ticket_levelTextBox.TabIndex = 4;
            // 
            // ticket_priceTextBox
            // 
            this.ticket_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "ticket_price", true));
            this.ticket_priceTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_priceTextBox.Location = new System.Drawing.Point(181, 148);
            this.ticket_priceTextBox.Name = "ticket_priceTextBox";
            this.ticket_priceTextBox.Size = new System.Drawing.Size(100, 26);
            this.ticket_priceTextBox.TabIndex = 6;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.билетBindingSource, "date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(181, 188);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // iD_spectatorTextBox
            // 
            this.iD_spectatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "ID_spectator", true));
            this.iD_spectatorTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_spectatorTextBox.Location = new System.Drawing.Point(181, 229);
            this.iD_spectatorTextBox.Name = "iD_spectatorTextBox";
            this.iD_spectatorTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_spectatorTextBox.TabIndex = 10;
            // 
            // iD_performanceTextBox
            // 
            this.iD_performanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "ID_performance", true));
            this.iD_performanceTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_performanceTextBox.Location = new System.Drawing.Point(181, 279);
            this.iD_performanceTextBox.Name = "iD_performanceTextBox";
            this.iD_performanceTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_performanceTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Таблица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(393, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_performanceLabel);
            this.Controls.Add(this.iD_performanceTextBox);
            this.Controls.Add(iD_spectatorLabel);
            this.Controls.Add(this.iD_spectatorTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(ticket_priceLabel);
            this.Controls.Add(this.ticket_priceTextBox);
            this.Controls.Add(ticket_levelLabel);
            this.Controls.Add(this.ticket_levelTextBox);
            this.Controls.Add(iD_ticketLabel);
            this.Controls.Add(this.iD_ticketTextBox);
            this.Controls.Add(this.билетBindingNavigator);
            this.Name = "Form2";
            this.Text = "Билет";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theater_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingNavigator)).EndInit();
            this.билетBindingNavigator.ResumeLayout(false);
            this.билетBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Theater_DBDataSet theater_DBDataSet;
        private System.Windows.Forms.BindingSource билетBindingSource;
        private Theater_DBDataSetTableAdapters.БилетTableAdapter билетTableAdapter;
        private Theater_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator билетBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton билетBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ticketTextBox;
        private System.Windows.Forms.TextBox ticket_levelTextBox;
        private System.Windows.Forms.TextBox ticket_priceTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox iD_spectatorTextBox;
        private System.Windows.Forms.TextBox iD_performanceTextBox;
        private System.Windows.Forms.Button button1;
    }
}