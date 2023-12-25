namespace Diplom_Kartek_V2.Forms
{
    partial class FormOrderUslug
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonUpdData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelPoisk = new System.Windows.Forms.Panel();
            this.buttonNoFiltor = new System.Windows.Forms.Button();
            this.buttonFiltor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFiltor = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeFiltor = new System.Windows.Forms.ComboBox();
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.view_Order_UslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Order_UslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.View_Order_UslugTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.view_Order_UslugDataGridView = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ClientTableAdapter();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.OtdelTableAdapter();
            this.uslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.UslugTableAdapter();
            this.viewFiltorComplectOrdenUslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFiltor_Complect_OrdenUslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ViewFiltor_Complect_OrdenUslugTableAdapter();
            this.viewFiltorDataOrdenUslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFiltor_Data_OrdenUslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ViewFiltor_Data_OrdenUslugTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelPoisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_UslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_UslugDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorComplectOrdenUslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorDataOrdenUslugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonExport);
            this.panelControl.Controls.Add(this.buttonUpdData);
            this.panelControl.Controls.Add(this.groupBox1);
            this.panelControl.Controls.Add(this.panelLine);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(862, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(254, 532);
            this.panelControl.TabIndex = 1;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(16, 380);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(226, 38);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Экспорт в Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonUpdData
            // 
            this.buttonUpdData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdData.Location = new System.Drawing.Point(16, 317);
            this.buttonUpdData.Name = "buttonUpdData";
            this.buttonUpdData.Size = new System.Drawing.Size(226, 38);
            this.buttonUpdData.TabIndex = 2;
            this.buttonUpdData.Text = "Изменить Данные";
            this.buttonUpdData.UseVisualStyleBackColor = true;
            this.buttonUpdData.Click += new System.EventHandler(this.buttonUpdData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSort);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // buttonSort
            // 
            this.buttonSort.Enabled = false;
            this.buttonSort.Location = new System.Drawing.Point(23, 246);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(171, 39);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(6, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(214, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Сортировка по возрастанию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(6, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(193, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сортировка по убыванию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поле для сортировки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Название Клиента",
            "Услуга",
            "Отдел",
            "Выполненость",
            "Дата регистрации"});
            this.listBox1.Location = new System.Drawing.Point(6, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 124);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panelLine
            // 
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLine.Location = new System.Drawing.Point(0, 0);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(10, 532);
            this.panelLine.TabIndex = 0;
            // 
            // panelPoisk
            // 
            this.panelPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPoisk.Controls.Add(this.buttonNoFiltor);
            this.panelPoisk.Controls.Add(this.buttonFiltor);
            this.panelPoisk.Controls.Add(this.label3);
            this.panelPoisk.Controls.Add(this.buttonClear);
            this.panelPoisk.Controls.Add(this.buttonPoisk);
            this.panelPoisk.Controls.Add(this.textBox1);
            this.panelPoisk.Controls.Add(this.label2);
            this.panelPoisk.Controls.Add(this.comboBoxFiltor);
            this.panelPoisk.Controls.Add(this.comboBoxTypeFiltor);
            this.panelPoisk.Location = new System.Drawing.Point(0, 317);
            this.panelPoisk.Name = "panelPoisk";
            this.panelPoisk.Size = new System.Drawing.Size(862, 215);
            this.panelPoisk.TabIndex = 2;
            // 
            // buttonNoFiltor
            // 
            this.buttonNoFiltor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNoFiltor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNoFiltor.Location = new System.Drawing.Point(631, 73);
            this.buttonNoFiltor.Name = "buttonNoFiltor";
            this.buttonNoFiltor.Size = new System.Drawing.Size(184, 28);
            this.buttonNoFiltor.TabIndex = 27;
            this.buttonNoFiltor.Text = "Разфильтровать";
            this.buttonNoFiltor.UseVisualStyleBackColor = true;
            this.buttonNoFiltor.Click += new System.EventHandler(this.buttonNoFiltor_Click);
            // 
            // buttonFiltor
            // 
            this.buttonFiltor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFiltor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiltor.Location = new System.Drawing.Point(441, 73);
            this.buttonFiltor.Name = "buttonFiltor";
            this.buttonFiltor.Size = new System.Drawing.Size(184, 28);
            this.buttonFiltor.TabIndex = 26;
            this.buttonFiltor.Text = "Фильтровать";
            this.buttonFiltor.UseVisualStyleBackColor = true;
            this.buttonFiltor.Click += new System.EventHandler(this.buttonFiltor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Поиск";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(634, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(181, 27);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPoisk
            // 
            this.buttonPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoisk.Location = new System.Drawing.Point(444, 158);
            this.buttonPoisk.Name = "buttonPoisk";
            this.buttonPoisk.Size = new System.Drawing.Size(184, 27);
            this.buttonPoisk.TabIndex = 23;
            this.buttonPoisk.Text = "Поиск";
            this.buttonPoisk.UseVisualStyleBackColor = true;
            this.buttonPoisk.Click += new System.EventHandler(this.buttonPoisk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(34, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(781, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Фильтрация";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxFiltor
            // 
            this.comboBoxFiltor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFiltor.FormattingEnabled = true;
            this.comboBoxFiltor.Location = new System.Drawing.Point(185, 46);
            this.comboBoxFiltor.Name = "comboBoxFiltor";
            this.comboBoxFiltor.Size = new System.Drawing.Size(630, 21);
            this.comboBoxFiltor.TabIndex = 16;
            // 
            // comboBoxTypeFiltor
            // 
            this.comboBoxTypeFiltor.DisplayMember = "Title";
            this.comboBoxTypeFiltor.FormattingEnabled = true;
            this.comboBoxTypeFiltor.Items.AddRange(new object[] {
            "Название Клиента",
            "Услуга",
            "Отдел",
            "Выполненость",
            "Дата регистрации"});
            this.comboBoxTypeFiltor.Location = new System.Drawing.Point(34, 46);
            this.comboBoxTypeFiltor.Name = "comboBoxTypeFiltor";
            this.comboBoxTypeFiltor.Size = new System.Drawing.Size(134, 21);
            this.comboBoxTypeFiltor.TabIndex = 17;
            this.comboBoxTypeFiltor.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeFiltor_SelectedIndexChanged);
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Order_UslugBindingSource
            // 
            this.view_Order_UslugBindingSource.DataMember = "View_Order_Uslug";
            this.view_Order_UslugBindingSource.DataSource = this.diplomDataSet;
            // 
            // view_Order_UslugTableAdapter
            // 
            this.view_Order_UslugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LevelOpenTableAdapter = null;
            this.tableAdapterManager.Order_UslugTableAdapter = null;
            this.tableAdapterManager.OtdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugTableAdapter = null;
            this.tableAdapterManager.WorkedTableAdapter = null;
            // 
            // view_Order_UslugDataGridView
            // 
            this.view_Order_UslugDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_Order_UslugDataGridView.AutoGenerateColumns = false;
            this.view_Order_UslugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Order_UslugDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.view_Order_UslugDataGridView.DataSource = this.view_Order_UslugBindingSource;
            this.view_Order_UslugDataGridView.Location = new System.Drawing.Point(0, 0);
            this.view_Order_UslugDataGridView.Name = "view_Order_UslugDataGridView";
            this.view_Order_UslugDataGridView.Size = new System.Drawing.Size(863, 319);
            this.view_Order_UslugDataGridView.TabIndex = 3;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.diplomDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "Otdel";
            this.otdelBindingSource.DataSource = this.diplomDataSet;
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // uslugBindingSource
            // 
            this.uslugBindingSource.DataMember = "Uslug";
            this.uslugBindingSource.DataSource = this.diplomDataSet;
            // 
            // uslugTableAdapter
            // 
            this.uslugTableAdapter.ClearBeforeFill = true;
            // 
            // viewFiltorComplectOrdenUslugBindingSource
            // 
            this.viewFiltorComplectOrdenUslugBindingSource.DataMember = "ViewFiltor_Complect_OrdenUslug";
            this.viewFiltorComplectOrdenUslugBindingSource.DataSource = this.diplomDataSet;
            // 
            // viewFiltor_Complect_OrdenUslugTableAdapter
            // 
            this.viewFiltor_Complect_OrdenUslugTableAdapter.ClearBeforeFill = true;
            // 
            // viewFiltorDataOrdenUslugBindingSource
            // 
            this.viewFiltorDataOrdenUslugBindingSource.DataMember = "ViewFiltor_Data_OrdenUslug";
            this.viewFiltorDataOrdenUslugBindingSource.DataSource = this.diplomDataSet;
            // 
            // viewFiltor_Data_OrdenUslugTableAdapter
            // 
            this.viewFiltor_Data_OrdenUslugTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Order_Uslug";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Client";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название Клиента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title_Uslug";
            this.dataGridViewTextBoxColumn3.HeaderText = "Услуга";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title_Otdel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отдел";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Completed_Order_Uslug";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Выполненость";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Restration_Order_Uslug";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата регистрации";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormOrderUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 532);
            this.Controls.Add(this.view_Order_UslugDataGridView);
            this.Controls.Add(this.panelPoisk);
            this.Controls.Add(this.panelControl);
            this.Name = "FormOrderUslug";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrderUslug_Load);
            this.panelControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPoisk.ResumeLayout(false);
            this.panelPoisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_UslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_UslugDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorComplectOrdenUslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorDataOrdenUslugBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonUpdData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelPoisk;
        private System.Windows.Forms.Button buttonNoFiltor;
        private System.Windows.Forms.Button buttonFiltor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPoisk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltor;
        private System.Windows.Forms.ComboBox comboBoxTypeFiltor;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource view_Order_UslugBindingSource;
        private DiplomDataSetTableAdapters.View_Order_UslugTableAdapter view_Order_UslugTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_Order_UslugDataGridView;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DiplomDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private DiplomDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private System.Windows.Forms.BindingSource uslugBindingSource;
        private DiplomDataSetTableAdapters.UslugTableAdapter uslugTableAdapter;
        private System.Windows.Forms.BindingSource viewFiltorComplectOrdenUslugBindingSource;
        private DiplomDataSetTableAdapters.ViewFiltor_Complect_OrdenUslugTableAdapter viewFiltor_Complect_OrdenUslugTableAdapter;
        private System.Windows.Forms.BindingSource viewFiltorDataOrdenUslugBindingSource;
        private DiplomDataSetTableAdapters.ViewFiltor_Data_OrdenUslugTableAdapter viewFiltor_Data_OrdenUslugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}