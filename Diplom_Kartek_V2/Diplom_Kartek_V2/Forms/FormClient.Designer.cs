﻿namespace Diplom_Kartek_V2.Forms
{
    partial class FormClient
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
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ClientTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.view_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ClientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.View_ClientTableAdapter();
            this.view_ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.viewFiltorDataClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFiltor_Data_ClientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ViewFiltor_Data_ClientTableAdapter();
            this.viewFiltorEmailClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFiltor_Email_ClientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ViewFiltor_Email_ClientTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.panelControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelPoisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ClientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorDataClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorEmailClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.diplomDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LevelOpenTableAdapter = null;
            this.tableAdapterManager.Order_UslugTableAdapter = null;
            this.tableAdapterManager.OtdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugTableAdapter = null;
            this.tableAdapterManager.WorkedTableAdapter = null;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.diplomDataSet;
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
            this.panelControl.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(16, 380);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(226, 38);
            this.buttonExport.TabIndex = 3;
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
            "Название",
            "Телефон",
            "Электроная почта",
            "Адрес",
            "Колличество услуг",
            "Общая стоимость услуг",
            "Дата регитрации"});
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
            this.panelPoisk.TabIndex = 1;
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
            "Название",
            "Телефон",
            "Электроная почта",
            "Адрес",
            "Колличество услуг",
            "Общая стоимость услуг",
            "Дата регитрации"});
            this.comboBoxTypeFiltor.Location = new System.Drawing.Point(34, 46);
            this.comboBoxTypeFiltor.Name = "comboBoxTypeFiltor";
            this.comboBoxTypeFiltor.Size = new System.Drawing.Size(134, 21);
            this.comboBoxTypeFiltor.TabIndex = 17;
            this.comboBoxTypeFiltor.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeFiltor_SelectedIndexChanged);
            // 
            // view_ClientBindingSource
            // 
            this.view_ClientBindingSource.DataMember = "View_Client";
            this.view_ClientBindingSource.DataSource = this.diplomDataSet;
            // 
            // view_ClientTableAdapter
            // 
            this.view_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // view_ClientDataGridView
            // 
            this.view_ClientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_ClientDataGridView.AutoGenerateColumns = false;
            this.view_ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.view_ClientDataGridView.DataSource = this.view_ClientBindingSource;
            this.view_ClientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.view_ClientDataGridView.Name = "view_ClientDataGridView";
            this.view_ClientDataGridView.Size = new System.Drawing.Size(863, 319);
            this.view_ClientDataGridView.TabIndex = 2;
            // 
            // viewFiltorDataClientBindingSource
            // 
            this.viewFiltorDataClientBindingSource.DataMember = "ViewFiltor_Data_Client";
            this.viewFiltorDataClientBindingSource.DataSource = this.diplomDataSet;
            // 
            // viewFiltor_Data_ClientTableAdapter
            // 
            this.viewFiltor_Data_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // viewFiltorEmailClientBindingSource
            // 
            this.viewFiltorEmailClientBindingSource.DataMember = "ViewFiltor_Email_Client";
            this.viewFiltorEmailClientBindingSource.DataSource = this.diplomDataSet;
            // 
            // viewFiltor_Email_ClientTableAdapter
            // 
            this.viewFiltor_Email_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Client";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Client";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "phone_Client";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email_Client";
            this.dataGridViewTextBoxColumn4.HeaderText = "Электроная почта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Addres_Client";
            this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AllCount_Uslug";
            this.dataGridViewTextBoxColumn6.HeaderText = "Колличество услуг";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AllSpentMoney";
            this.dataGridViewTextBoxColumn7.HeaderText = "Общая стоимость услуг";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Restration_Client";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата регитрации";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 532);
            this.Controls.Add(this.view_ClientDataGridView);
            this.Controls.Add(this.panelPoisk);
            this.Controls.Add(this.panelControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormClient";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPoisk.ResumeLayout(false);
            this.panelPoisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ClientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorDataClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiltorEmailClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DiplomDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DiplomDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelPoisk;
        private System.Windows.Forms.BindingSource view_ClientBindingSource;
        private DiplomDataSetTableAdapters.View_ClientTableAdapter view_ClientTableAdapter;
        private System.Windows.Forms.DataGridView view_ClientDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonUpdData;
        private System.Windows.Forms.Button buttonNoFiltor;
        private System.Windows.Forms.Button buttonFiltor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPoisk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltor;
        private System.Windows.Forms.ComboBox comboBoxTypeFiltor;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.BindingSource viewFiltorDataClientBindingSource;
        private DiplomDataSetTableAdapters.ViewFiltor_Data_ClientTableAdapter viewFiltor_Data_ClientTableAdapter;
        private System.Windows.Forms.BindingSource viewFiltorEmailClientBindingSource;
        private DiplomDataSetTableAdapters.ViewFiltor_Email_ClientTableAdapter viewFiltor_Email_ClientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}