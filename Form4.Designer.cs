namespace SemesterWork
{
    partial class Form4
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
            System.Windows.Forms.Label iD_performanceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label describtionLabel;
            System.Windows.Forms.Label producerLabel;
            System.Windows.Forms.Label iD_programLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.theater_DBDataSet = new SemesterWork.Theater_DBDataSet();
            this.постановкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постановкаTableAdapter = new SemesterWork.Theater_DBDataSetTableAdapters.ПостановкаTableAdapter();
            this.tableAdapterManager = new SemesterWork.Theater_DBDataSetTableAdapters.TableAdapterManager();
            this.постановкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.постановкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_performanceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.describtionTextBox = new System.Windows.Forms.TextBox();
            this.producerTextBox = new System.Windows.Forms.TextBox();
            this.iD_programTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iD_performanceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            describtionLabel = new System.Windows.Forms.Label();
            producerLabel = new System.Windows.Forms.Label();
            iD_programLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theater_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постановкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постановкаBindingNavigator)).BeginInit();
            this.постановкаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_performanceLabel
            // 
            iD_performanceLabel.AutoSize = true;
            iD_performanceLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_performanceLabel.Location = new System.Drawing.Point(29, 65);
            iD_performanceLabel.Name = "iD_performanceLabel";
            iD_performanceLabel.Size = new System.Drawing.Size(123, 18);
            iD_performanceLabel.TabIndex = 1;
            iD_performanceLabel.Text = "ID performance:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(29, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(50, 18);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // describtionLabel
            // 
            describtionLabel.AutoSize = true;
            describtionLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            describtionLabel.Location = new System.Drawing.Point(29, 155);
            describtionLabel.Name = "describtionLabel";
            describtionLabel.Size = new System.Drawing.Size(91, 18);
            describtionLabel.TabIndex = 5;
            describtionLabel.Text = "describtion:";
            // 
            // producerLabel
            // 
            producerLabel.AutoSize = true;
            producerLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            producerLabel.Location = new System.Drawing.Point(29, 202);
            producerLabel.Name = "producerLabel";
            producerLabel.Size = new System.Drawing.Size(76, 18);
            producerLabel.TabIndex = 7;
            producerLabel.Text = "producer:";
            // 
            // iD_programLabel
            // 
            iD_programLabel.AutoSize = true;
            iD_programLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_programLabel.Location = new System.Drawing.Point(28, 248);
            iD_programLabel.Name = "iD_programLabel";
            iD_programLabel.Size = new System.Drawing.Size(94, 18);
            iD_programLabel.TabIndex = 9;
            iD_programLabel.Text = "ID program:";
            // 
            // theater_DBDataSet
            // 
            this.theater_DBDataSet.DataSetName = "Theater_DBDataSet";
            this.theater_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // постановкаBindingSource
            // 
            this.постановкаBindingSource.DataMember = "Постановка";
            this.постановкаBindingSource.DataSource = this.theater_DBDataSet;
            // 
            // постановкаTableAdapter
            // 
            this.постановкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SemesterWork.Theater_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетTableAdapter = null;
            this.tableAdapterManager.ЗрительTableAdapter = null;
            this.tableAdapterManager.ПостановкаTableAdapter = this.постановкаTableAdapter;
            this.tableAdapterManager.ПрограммаTableAdapter = null;
            this.tableAdapterManager.РежиссёрTableAdapter = null;
            // 
            // постановкаBindingNavigator
            // 
            this.постановкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.постановкаBindingNavigator.BindingSource = this.постановкаBindingSource;
            this.постановкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.постановкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.постановкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.постановкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.постановкаBindingNavigatorSaveItem});
            this.постановкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.постановкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.постановкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.постановкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.постановкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.постановкаBindingNavigator.Name = "постановкаBindingNavigator";
            this.постановкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.постановкаBindingNavigator.Size = new System.Drawing.Size(362, 27);
            this.постановкаBindingNavigator.TabIndex = 0;
            this.постановкаBindingNavigator.Text = "bindingNavigator1";
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
            // постановкаBindingNavigatorSaveItem
            // 
            this.постановкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.постановкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("постановкаBindingNavigatorSaveItem.Image")));
            this.постановкаBindingNavigatorSaveItem.Name = "постановкаBindingNavigatorSaveItem";
            this.постановкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.постановкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.постановкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.постановкаBindingNavigatorSaveItem_Click);
            // 
            // iD_performanceTextBox
            // 
            this.iD_performanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постановкаBindingSource, "ID_performance", true));
            this.iD_performanceTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_performanceTextBox.Location = new System.Drawing.Point(199, 65);
            this.iD_performanceTextBox.Name = "iD_performanceTextBox";
            this.iD_performanceTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_performanceTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постановкаBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(199, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // describtionTextBox
            // 
            this.describtionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постановкаBindingSource, "describtion", true));
            this.describtionTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describtionTextBox.Location = new System.Drawing.Point(199, 155);
            this.describtionTextBox.Name = "describtionTextBox";
            this.describtionTextBox.Size = new System.Drawing.Size(100, 26);
            this.describtionTextBox.TabIndex = 6;
            // 
            // producerTextBox
            // 
            this.producerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постановкаBindingSource, "producer", true));
            this.producerTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerTextBox.Location = new System.Drawing.Point(199, 196);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(100, 26);
            this.producerTextBox.TabIndex = 8;
            // 
            // iD_programTextBox
            // 
            this.iD_programTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постановкаBindingSource, "ID_program", true));
            this.iD_programTextBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_programTextBox.Location = new System.Drawing.Point(199, 245);
            this.iD_programTextBox.Name = "iD_programTextBox";
            this.iD_programTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_programTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Таблица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_programLabel);
            this.Controls.Add(this.iD_programTextBox);
            this.Controls.Add(producerLabel);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(describtionLabel);
            this.Controls.Add(this.describtionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(iD_performanceLabel);
            this.Controls.Add(this.iD_performanceTextBox);
            this.Controls.Add(this.постановкаBindingNavigator);
            this.Name = "Form4";
            this.Text = "Постановка";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theater_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постановкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постановкаBindingNavigator)).EndInit();
            this.постановкаBindingNavigator.ResumeLayout(false);
            this.постановкаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Theater_DBDataSet theater_DBDataSet;
        private System.Windows.Forms.BindingSource постановкаBindingSource;
        private Theater_DBDataSetTableAdapters.ПостановкаTableAdapter постановкаTableAdapter;
        private Theater_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator постановкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton постановкаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_performanceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox describtionTextBox;
        private System.Windows.Forms.TextBox producerTextBox;
        private System.Windows.Forms.TextBox iD_programTextBox;
        private System.Windows.Forms.Button button1;
    }
}