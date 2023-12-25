namespace Diplom_Kartek_V2.Forms
{
    partial class FormUpdDataClient
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
            System.Windows.Forms.Label restration_ClientLabel;
            System.Windows.Forms.Label allSpentMoneyLabel;
            System.Windows.Forms.Label allCount_UslugLabel;
            System.Windows.Forms.Label addres_ClientLabel;
            System.Windows.Forms.Label email_ClientLabel;
            System.Windows.Forms.Label phone_ClientLabel;
            System.Windows.Forms.Label name_ClientLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.name_ClientTextBox1 = new System.Windows.Forms.TextBox();
            this.phone_ClientTextBox = new System.Windows.Forms.TextBox();
            this.email_ClientTextBox = new System.Windows.Forms.TextBox();
            this.addres_ClientTextBox = new System.Windows.Forms.TextBox();
            this.allCount_UslugTextBox = new System.Windows.Forms.TextBox();
            this.allSpentMoneyTextBox = new System.Windows.Forms.TextBox();
            this.restration_ClientDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_ClientTextBox = new System.Windows.Forms.TextBox();
            iD_ClientLabel = new System.Windows.Forms.Label();
            restration_ClientLabel = new System.Windows.Forms.Label();
            allSpentMoneyLabel = new System.Windows.Forms.Label();
            allCount_UslugLabel = new System.Windows.Forms.Label();
            addres_ClientLabel = new System.Windows.Forms.Label();
            email_ClientLabel = new System.Windows.Forms.Label();
            phone_ClientLabel = new System.Windows.Forms.Label();
            name_ClientLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
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
            // restration_ClientLabel
            // 
            restration_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            restration_ClientLabel.AutoSize = true;
            restration_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            restration_ClientLabel.Location = new System.Drawing.Point(70, 328);
            restration_ClientLabel.Name = "restration_ClientLabel";
            restration_ClientLabel.Size = new System.Drawing.Size(153, 20);
            restration_ClientLabel.TabIndex = 40;
            restration_ClientLabel.Text = "Дата Регистрации:";
            // 
            // allSpentMoneyLabel
            // 
            allSpentMoneyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            allSpentMoneyLabel.AutoSize = true;
            allSpentMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            allSpentMoneyLabel.Location = new System.Drawing.Point(33, 286);
            allSpentMoneyLabel.Name = "allSpentMoneyLabel";
            allSpentMoneyLabel.Size = new System.Drawing.Size(190, 20);
            allSpentMoneyLabel.TabIndex = 37;
            allSpentMoneyLabel.Text = "Вся стоимость заказов:";
            // 
            // allCount_UslugLabel
            // 
            allCount_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            allCount_UslugLabel.AutoSize = true;
            allCount_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            allCount_UslugLabel.Location = new System.Drawing.Point(55, 241);
            allCount_UslugLabel.Name = "allCount_UslugLabel";
            allCount_UslugLabel.Size = new System.Drawing.Size(168, 20);
            allCount_UslugLabel.TabIndex = 35;
            allCount_UslugLabel.Text = "Количество заказов:";
            // 
            // addres_ClientLabel
            // 
            addres_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            addres_ClientLabel.AutoSize = true;
            addres_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addres_ClientLabel.Location = new System.Drawing.Point(156, 188);
            addres_ClientLabel.Name = "addres_ClientLabel";
            addres_ClientLabel.Size = new System.Drawing.Size(61, 20);
            addres_ClientLabel.TabIndex = 33;
            addres_ClientLabel.Text = "Адрес:";
            // 
            // email_ClientLabel
            // 
            email_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            email_ClientLabel.AutoSize = true;
            email_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            email_ClientLabel.Location = new System.Drawing.Point(126, 146);
            email_ClientLabel.Name = "email_ClientLabel";
            email_ClientLabel.Size = new System.Drawing.Size(91, 20);
            email_ClientLabel.TabIndex = 31;
            email_ClientLabel.Text = "Эл. Почта:";
            // 
            // phone_ClientLabel
            // 
            phone_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            phone_ClientLabel.AutoSize = true;
            phone_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_ClientLabel.Location = new System.Drawing.Point(134, 102);
            phone_ClientLabel.Name = "phone_ClientLabel";
            phone_ClientLabel.Size = new System.Drawing.Size(83, 20);
            phone_ClientLabel.TabIndex = 29;
            phone_ClientLabel.Text = "Телефон:";
            // 
            // name_ClientLabel
            // 
            name_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            name_ClientLabel.AutoSize = true;
            name_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_ClientLabel.Location = new System.Drawing.Point(173, 55);
            name_ClientLabel.Name = "name_ClientLabel";
            name_ClientLabel.Size = new System.Drawing.Size(44, 20);
            name_ClientLabel.TabIndex = 23;
            name_ClientLabel.Text = "Имя:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iD_ClientTextBox);
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
            this.panel1.Location = new System.Drawing.Point(686, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 450);
            this.panel1.TabIndex = 42;
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
            this.button7.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click);
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
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
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
            // name_ClientTextBox1
            // 
            this.name_ClientTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_ClientTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Name_Client", true));
            this.name_ClientTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_ClientTextBox1.Location = new System.Drawing.Point(236, 51);
            this.name_ClientTextBox1.Name = "name_ClientTextBox1";
            this.name_ClientTextBox1.Size = new System.Drawing.Size(396, 26);
            this.name_ClientTextBox1.TabIndex = 44;
            // 
            // phone_ClientTextBox
            // 
            this.phone_ClientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "phone_Client", true));
            this.phone_ClientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_ClientTextBox.Location = new System.Drawing.Point(236, 99);
            this.phone_ClientTextBox.Name = "phone_ClientTextBox";
            this.phone_ClientTextBox.Size = new System.Drawing.Size(200, 26);
            this.phone_ClientTextBox.TabIndex = 45;
            // 
            // email_ClientTextBox
            // 
            this.email_ClientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "email_Client", true));
            this.email_ClientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_ClientTextBox.Location = new System.Drawing.Point(236, 141);
            this.email_ClientTextBox.Name = "email_ClientTextBox";
            this.email_ClientTextBox.Size = new System.Drawing.Size(396, 26);
            this.email_ClientTextBox.TabIndex = 46;
            // 
            // addres_ClientTextBox
            // 
            this.addres_ClientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addres_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Addres_Client", true));
            this.addres_ClientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addres_ClientTextBox.Location = new System.Drawing.Point(236, 185);
            this.addres_ClientTextBox.Name = "addres_ClientTextBox";
            this.addres_ClientTextBox.Size = new System.Drawing.Size(396, 26);
            this.addres_ClientTextBox.TabIndex = 47;
            // 
            // allCount_UslugTextBox
            // 
            this.allCount_UslugTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allCount_UslugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AllCount_Uslug", true));
            this.allCount_UslugTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCount_UslugTextBox.Location = new System.Drawing.Point(236, 238);
            this.allCount_UslugTextBox.Name = "allCount_UslugTextBox";
            this.allCount_UslugTextBox.Size = new System.Drawing.Size(200, 26);
            this.allCount_UslugTextBox.TabIndex = 48;
            // 
            // allSpentMoneyTextBox
            // 
            this.allSpentMoneyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allSpentMoneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AllSpentMoney", true));
            this.allSpentMoneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allSpentMoneyTextBox.Location = new System.Drawing.Point(236, 283);
            this.allSpentMoneyTextBox.Name = "allSpentMoneyTextBox";
            this.allSpentMoneyTextBox.Size = new System.Drawing.Size(200, 26);
            this.allSpentMoneyTextBox.TabIndex = 49;
            // 
            // restration_ClientDateTimePicker
            // 
            this.restration_ClientDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restration_ClientDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "Restration_Client", true));
            this.restration_ClientDateTimePicker.Location = new System.Drawing.Point(236, 327);
            this.restration_ClientDateTimePicker.Name = "restration_ClientDateTimePicker";
            this.restration_ClientDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.restration_ClientDateTimePicker.TabIndex = 50;
            // 
            // iD_ClientTextBox
            // 
            this.iD_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ID_Client", true));
            this.iD_ClientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ClientTextBox.Location = new System.Drawing.Point(16, 50);
            this.iD_ClientTextBox.Name = "iD_ClientTextBox";
            this.iD_ClientTextBox.ReadOnly = true;
            this.iD_ClientTextBox.Size = new System.Drawing.Size(125, 26);
            this.iD_ClientTextBox.TabIndex = 51;
            this.iD_ClientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormUpdDataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.restration_ClientDateTimePicker);
            this.Controls.Add(this.allSpentMoneyTextBox);
            this.Controls.Add(this.allCount_UslugTextBox);
            this.Controls.Add(this.addres_ClientTextBox);
            this.Controls.Add(this.email_ClientTextBox);
            this.Controls.Add(this.phone_ClientTextBox);
            this.Controls.Add(this.name_ClientTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(restration_ClientLabel);
            this.Controls.Add(allSpentMoneyLabel);
            this.Controls.Add(allCount_UslugLabel);
            this.Controls.Add(addres_ClientLabel);
            this.Controls.Add(email_ClientLabel);
            this.Controls.Add(phone_ClientLabel);
            this.Controls.Add(name_ClientLabel);
            this.Name = "FormUpdDataClient";
            this.Text = "Изменение данных Клиента";
            this.Load += new System.EventHandler(this.FormUpdDataClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DiplomDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox name_ClientTextBox1;
        private System.Windows.Forms.TextBox phone_ClientTextBox;
        private System.Windows.Forms.TextBox email_ClientTextBox;
        private System.Windows.Forms.TextBox addres_ClientTextBox;
        private System.Windows.Forms.TextBox allCount_UslugTextBox;
        private System.Windows.Forms.TextBox allSpentMoneyTextBox;
        private System.Windows.Forms.DateTimePicker restration_ClientDateTimePicker;
        private System.Windows.Forms.TextBox iD_ClientTextBox;
    }
}