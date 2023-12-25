namespace Diplom_Kartek_V2.Forms
{
    partial class FormUpdDataOrderUslug
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
            System.Windows.Forms.Label iD_ClientLabel;
            System.Windows.Forms.Label restration_Order_UslugLabel;
            System.Windows.Forms.Label completed_Order_UslugLabel;
            System.Windows.Forms.Label otdel_Order_UslugLabel;
            System.Windows.Forms.Label client_Order_UslugLabel;
            System.Windows.Forms.Label uslug_Order_UslugLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_Order_UslugTextBox = new System.Windows.Forms.TextBox();
            this.order_UslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_UslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.Order_UslugTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.uslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.UslugTableAdapter();
            this.clientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ClientTableAdapter();
            this.otdelTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.OtdelTableAdapter();
            this.completed_Order_UslugCheckBox = new System.Windows.Forms.CheckBox();
            this.restration_Order_UslugDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_ClientLabel = new System.Windows.Forms.Label();
            restration_Order_UslugLabel = new System.Windows.Forms.Label();
            completed_Order_UslugLabel = new System.Windows.Forms.Label();
            otdel_Order_UslugLabel = new System.Windows.Forms.Label();
            client_Order_UslugLabel = new System.Windows.Forms.Label();
            uslug_Order_UslugLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_UslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ClientLabel
            // 
            iD_ClientLabel.AutoSize = true;
            iD_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ClientLabel.Location = new System.Drawing.Point(58, 23);
            iD_ClientLabel.Name = "iD_ClientLabel";
            iD_ClientLabel.Size = new System.Drawing.Size(40, 20);
            iD_ClientLabel.TabIndex = 8;
            iD_ClientLabel.Text = "(ID)";
            // 
            // restration_Order_UslugLabel
            // 
            restration_Order_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            restration_Order_UslugLabel.AutoSize = true;
            restration_Order_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            restration_Order_UslugLabel.Location = new System.Drawing.Point(56, 275);
            restration_Order_UslugLabel.Name = "restration_Order_UslugLabel";
            restration_Order_UslugLabel.Size = new System.Drawing.Size(152, 20);
            restration_Order_UslugLabel.TabIndex = 28;
            restration_Order_UslugLabel.Text = "Дата регистрации:";
            // 
            // completed_Order_UslugLabel
            // 
            completed_Order_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            completed_Order_UslugLabel.AutoSize = true;
            completed_Order_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            completed_Order_UslugLabel.Location = new System.Drawing.Point(83, 224);
            completed_Order_UslugLabel.Name = "completed_Order_UslugLabel";
            completed_Order_UslugLabel.Size = new System.Drawing.Size(125, 20);
            completed_Order_UslugLabel.TabIndex = 26;
            completed_Order_UslugLabel.Text = "Выполненость:";
            // 
            // otdel_Order_UslugLabel
            // 
            otdel_Order_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            otdel_Order_UslugLabel.AutoSize = true;
            otdel_Order_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            otdel_Order_UslugLabel.Location = new System.Drawing.Point(140, 172);
            otdel_Order_UslugLabel.Name = "otdel_Order_UslugLabel";
            otdel_Order_UslugLabel.Size = new System.Drawing.Size(64, 20);
            otdel_Order_UslugLabel.TabIndex = 25;
            otdel_Order_UslugLabel.Text = "Отдел:";
            // 
            // client_Order_UslugLabel
            // 
            client_Order_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            client_Order_UslugLabel.AutoSize = true;
            client_Order_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_Order_UslugLabel.Location = new System.Drawing.Point(52, 78);
            client_Order_UslugLabel.Name = "client_Order_UslugLabel";
            client_Order_UslugLabel.Size = new System.Drawing.Size(156, 20);
            client_Order_UslugLabel.TabIndex = 24;
            client_Order_UslugLabel.Text = "Название Клиента:";
            // 
            // uslug_Order_UslugLabel
            // 
            uslug_Order_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            uslug_Order_UslugLabel.AutoSize = true;
            uslug_Order_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            uslug_Order_UslugLabel.Location = new System.Drawing.Point(140, 126);
            uslug_Order_UslugLabel.Name = "uslug_Order_UslugLabel";
            uslug_Order_UslugLabel.Size = new System.Drawing.Size(64, 20);
            uslug_Order_UslugLabel.TabIndex = 23;
            uslug_Order_UslugLabel.Text = "Услуга:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iD_Order_UslugTextBox);
            this.panel1.Controls.Add(iD_ClientLabel);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(504, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 450);
            this.panel1.TabIndex = 37;
            // 
            // iD_Order_UslugTextBox
            // 
            this.iD_Order_UslugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_UslugBindingSource, "ID_Order_Uslug", true));
            this.iD_Order_UslugTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_Order_UslugTextBox.Location = new System.Drawing.Point(16, 46);
            this.iD_Order_UslugTextBox.Name = "iD_Order_UslugTextBox";
            this.iD_Order_UslugTextBox.ReadOnly = true;
            this.iD_Order_UslugTextBox.Size = new System.Drawing.Size(125, 26);
            this.iD_Order_UslugTextBox.TabIndex = 38;
            this.iD_Order_UslugTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // order_UslugBindingSource
            // 
            this.order_UslugBindingSource.DataMember = "Order_Uslug";
            this.order_UslugBindingSource.DataSource = this.diplomDataSet;
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(151, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 43);
            this.button7.TabIndex = 8;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.order_UslugBindingNavigatorSaveItem_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(151, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 43);
            this.button5.TabIndex = 6;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(16, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(151, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Последняя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Первая";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(151, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Предыдущая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLine
            // 
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLine.Location = new System.Drawing.Point(0, 0);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(10, 450);
            this.panelLine.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_UslugBindingSource, "Otdel_Order_Uslug", true));
            this.comboBox3.DataSource = this.otdelBindingSource;
            this.comboBox3.DisplayMember = "Title_Otdel";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(214, 174);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(252, 28);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.ValueMember = "ID_Otdel";
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "Otdel";
            this.otdelBindingSource.DataSource = this.diplomDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_UslugBindingSource, "Client_Order_Uslug", true));
            this.comboBox2.DataSource = this.clientBindingSource;
            this.comboBox2.DisplayMember = "Name_Client";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 28);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.ValueMember = "ID_Client";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.diplomDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_UslugBindingSource, "Uslug_Order_Uslug", true));
            this.comboBox1.DataSource = this.uslugBindingSource;
            this.comboBox1.DisplayMember = "Title_Uslug";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 28);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "ID_Uslug";
            // 
            // uslugBindingSource
            // 
            this.uslugBindingSource.DataMember = "Uslug";
            this.uslugBindingSource.DataSource = this.diplomDataSet;
            // 
            // order_UslugTableAdapter
            // 
            this.order_UslugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LevelOpenTableAdapter = null;
            this.tableAdapterManager.Order_UslugTableAdapter = this.order_UslugTableAdapter;
            this.tableAdapterManager.OtdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugTableAdapter = null;
            this.tableAdapterManager.WorkedTableAdapter = null;
            // 
            // uslugTableAdapter
            // 
            this.uslugTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // completed_Order_UslugCheckBox
            // 
            this.completed_Order_UslugCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.completed_Order_UslugCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.order_UslugBindingSource, "Completed_Order_Uslug", true));
            this.completed_Order_UslugCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completed_Order_UslugCheckBox.Location = new System.Drawing.Point(214, 224);
            this.completed_Order_UslugCheckBox.Name = "completed_Order_UslugCheckBox";
            this.completed_Order_UslugCheckBox.Size = new System.Drawing.Size(104, 24);
            this.completed_Order_UslugCheckBox.TabIndex = 38;
            this.completed_Order_UslugCheckBox.UseVisualStyleBackColor = true;
            // 
            // restration_Order_UslugDateTimePicker
            // 
            this.restration_Order_UslugDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restration_Order_UslugDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_UslugBindingSource, "Restration_Order_Uslug", true));
            this.restration_Order_UslugDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restration_Order_UslugDateTimePicker.Location = new System.Drawing.Point(214, 275);
            this.restration_Order_UslugDateTimePicker.Name = "restration_Order_UslugDateTimePicker";
            this.restration_Order_UslugDateTimePicker.Size = new System.Drawing.Size(252, 26);
            this.restration_Order_UslugDateTimePicker.TabIndex = 39;
            // 
            // FormUpdDataOrderUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restration_Order_UslugDateTimePicker);
            this.Controls.Add(this.completed_Order_UslugCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(restration_Order_UslugLabel);
            this.Controls.Add(completed_Order_UslugLabel);
            this.Controls.Add(otdel_Order_UslugLabel);
            this.Controls.Add(client_Order_UslugLabel);
            this.Controls.Add(uslug_Order_UslugLabel);
            this.Name = "FormUpdDataOrderUslug";
            this.Text = "Изменение данных Заказа";
            this.Load += new System.EventHandler(this.FormUpdDataOrderUslug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_UslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource order_UslugBindingSource;
        private DiplomDataSetTableAdapters.Order_UslugTableAdapter order_UslugTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_Order_UslugTextBox;
        private System.Windows.Forms.BindingSource uslugBindingSource;
        private DiplomDataSetTableAdapters.UslugTableAdapter uslugTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DiplomDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private DiplomDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private System.Windows.Forms.CheckBox completed_Order_UslugCheckBox;
        private System.Windows.Forms.DateTimePicker restration_Order_UslugDateTimePicker;
    }
}