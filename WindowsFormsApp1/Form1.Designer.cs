namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label medicine_NameLabel;
            System.Windows.Forms.Label consumption_TimeLabel;
            System.Windows.Forms.Label initial_TimeLabel;
            System.Windows.Forms.Label amount_of_medicineLabel;
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            this.table1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.table1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicine_NameTextBox = new System.Windows.Forms.TextBox();
            this.consumption_TimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initial_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amount_of_medicineNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.table1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            medicine_NameLabel = new System.Windows.Forms.Label();
            consumption_TimeLabel = new System.Windows.Forms.Label();
            initial_TimeLabel = new System.Windows.Forms.Label();
            amount_of_medicineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).BeginInit();
            this.table1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumption_TimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_of_medicineNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.database1DataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table1TableAdapter = this.table1TableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table1BindingNavigator
            // 
            this.table1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table1BindingNavigator.BindingSource = this.table1BindingSource;
            this.table1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.table1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table1BindingNavigatorSaveItem});
            this.table1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table1BindingNavigator.Name = "table1BindingNavigator";
            this.table1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table1BindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.table1BindingNavigator.TabIndex = 0;
            this.table1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // table1BindingNavigatorSaveItem
            // 
            this.table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table1BindingNavigatorSaveItem.Image")));
            this.table1BindingNavigatorSaveItem.Name = "table1BindingNavigatorSaveItem";
            this.table1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.table1BindingNavigatorSaveItem.Text = "Save Data";
            this.table1BindingNavigatorSaveItem.Click += new System.EventHandler(this.table1BindingNavigatorSaveItem_Click);
            // 
            // medicine_NameLabel
            // 
            medicine_NameLabel.AutoSize = true;
            medicine_NameLabel.Location = new System.Drawing.Point(182, 132);
            medicine_NameLabel.Name = "medicine_NameLabel";
            medicine_NameLabel.Size = new System.Drawing.Size(105, 16);
            medicine_NameLabel.TabIndex = 3;
            medicine_NameLabel.Text = "Medicine Name:";
            // 
            // medicine_NameTextBox
            // 
            this.medicine_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Medicine Name", true));
            this.medicine_NameTextBox.Location = new System.Drawing.Point(315, 129);
            this.medicine_NameTextBox.Name = "medicine_NameTextBox";
            this.medicine_NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicine_NameTextBox.TabIndex = 4;
            // 
            // consumption_TimeLabel
            // 
            consumption_TimeLabel.AutoSize = true;
            consumption_TimeLabel.Location = new System.Drawing.Point(182, 157);
            consumption_TimeLabel.Name = "consumption_TimeLabel";
            consumption_TimeLabel.Size = new System.Drawing.Size(122, 16);
            consumption_TimeLabel.TabIndex = 5;
            consumption_TimeLabel.Text = "Consumption Time:";
            // 
            // consumption_TimeNumericUpDown
            // 
            this.consumption_TimeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table1BindingSource, "Consumption Time", true));
            this.consumption_TimeNumericUpDown.Location = new System.Drawing.Point(315, 157);
            this.consumption_TimeNumericUpDown.Name = "consumption_TimeNumericUpDown";
            this.consumption_TimeNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.consumption_TimeNumericUpDown.TabIndex = 6;
            // 
            // initial_TimeLabel
            // 
            initial_TimeLabel.AutoSize = true;
            initial_TimeLabel.Location = new System.Drawing.Point(182, 189);
            initial_TimeLabel.Name = "initial_TimeLabel";
            initial_TimeLabel.Size = new System.Drawing.Size(74, 16);
            initial_TimeLabel.TabIndex = 7;
            initial_TimeLabel.Text = "Initial Time:";
            // 
            // initial_TimeDateTimePicker
            // 
            this.initial_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table1BindingSource, "Initial Time", true));
            this.initial_TimeDateTimePicker.Location = new System.Drawing.Point(315, 185);
            this.initial_TimeDateTimePicker.Name = "initial_TimeDateTimePicker";
            this.initial_TimeDateTimePicker.Size = new System.Drawing.Size(205, 22);
            this.initial_TimeDateTimePicker.TabIndex = 8;
            this.initial_TimeDateTimePicker.ValueChanged += new System.EventHandler(this.initial_TimeDateTimePicker_ValueChanged);
            // 
            // amount_of_medicineLabel
            // 
            amount_of_medicineLabel.AutoSize = true;
            amount_of_medicineLabel.Location = new System.Drawing.Point(182, 213);
            amount_of_medicineLabel.Name = "amount_of_medicineLabel";
            amount_of_medicineLabel.Size = new System.Drawing.Size(127, 16);
            amount_of_medicineLabel.TabIndex = 9;
            amount_of_medicineLabel.Text = "Amount of medicine:";
            // 
            // amount_of_medicineNumericUpDown
            // 
            this.amount_of_medicineNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table1BindingSource, "Amount of medicine", true));
            this.amount_of_medicineNumericUpDown.Location = new System.Drawing.Point(315, 213);
            this.amount_of_medicineNumericUpDown.Name = "amount_of_medicineNumericUpDown";
            this.amount_of_medicineNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.amount_of_medicineNumericUpDown.TabIndex = 10;
            // 
            // table1DataGridView
            // 
            this.table1DataGridView.AutoGenerateColumns = false;
            this.table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.table1DataGridView.DataSource = this.table1BindingSource;
            this.table1DataGridView.Location = new System.Drawing.Point(62, 273);
            this.table1DataGridView.Name = "table1DataGridView";
            this.table1DataGridView.RowHeadersWidth = 51;
            this.table1DataGridView.RowTemplate.Height = 24;
            this.table1DataGridView.Size = new System.Drawing.Size(669, 220);
            this.table1DataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Medicine Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Medicine Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Consumption Time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Consumption Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Initial Time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Initial Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount of medicine";
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount of medicine";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.table1DataGridView);
            this.Controls.Add(medicine_NameLabel);
            this.Controls.Add(this.medicine_NameTextBox);
            this.Controls.Add(consumption_TimeLabel);
            this.Controls.Add(this.consumption_TimeNumericUpDown);
            this.Controls.Add(initial_TimeLabel);
            this.Controls.Add(this.initial_TimeDateTimePicker);
            this.Controls.Add(amount_of_medicineLabel);
            this.Controls.Add(this.amount_of_medicineNumericUpDown);
            this.Controls.Add(this.table1BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).EndInit();
            this.table1BindingNavigator.ResumeLayout(false);
            this.table1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumption_TimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_of_medicineNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Database1DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox medicine_NameTextBox;
        private System.Windows.Forms.NumericUpDown consumption_TimeNumericUpDown;
        private System.Windows.Forms.DateTimePicker initial_TimeDateTimePicker;
        private System.Windows.Forms.NumericUpDown amount_of_medicineNumericUpDown;
        private System.Windows.Forms.DataGridView table1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

