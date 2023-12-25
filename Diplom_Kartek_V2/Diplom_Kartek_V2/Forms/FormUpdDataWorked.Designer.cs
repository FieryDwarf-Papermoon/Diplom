namespace Diplom_Kartek_V2.Forms
{
    partial class FormUpdDataWorked
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
            System.Windows.Forms.Label addres_ClientLabel;
            System.Windows.Forms.Label email_ClientLabel;
            System.Windows.Forms.Label phone_ClientLabel;
            System.Windows.Forms.Label familia_ClientLabel;
            System.Windows.Forms.Label nameDad_ClientLabel;
            System.Windows.Forms.Label name_ClientLabel;
            System.Windows.Forms.Label restration_WorkedLabel;
            System.Windows.Forms.Label otdel_WorkedLabel;
            System.Windows.Forms.Label iD_ClientLabel;
            System.Windows.Forms.Label gender_ClientLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.workedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_WorkedTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workedTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.WorkedTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.name_WorkedTextBox1 = new System.Windows.Forms.TextBox();
            this.nameDad_WorkedTextBox = new System.Windows.Forms.TextBox();
            this.familia_WorkedTextBox = new System.Windows.Forms.TextBox();
            this.phone_WorkedTextBox = new System.Windows.Forms.TextBox();
            this.email_WorkedTextBox = new System.Windows.Forms.TextBox();
            this.addres_WorkedTextBox = new System.Windows.Forms.TextBox();
            this.restration_WorkedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.otdelTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.OtdelTableAdapter();
            this.genderTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.GenderTableAdapter();
            addres_ClientLabel = new System.Windows.Forms.Label();
            email_ClientLabel = new System.Windows.Forms.Label();
            phone_ClientLabel = new System.Windows.Forms.Label();
            familia_ClientLabel = new System.Windows.Forms.Label();
            nameDad_ClientLabel = new System.Windows.Forms.Label();
            name_ClientLabel = new System.Windows.Forms.Label();
            restration_WorkedLabel = new System.Windows.Forms.Label();
            otdel_WorkedLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            gender_ClientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addres_ClientLabel
            // 
            addres_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            addres_ClientLabel.AutoSize = true;
            addres_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addres_ClientLabel.Location = new System.Drawing.Point(81, 238);
            addres_ClientLabel.Name = "addres_ClientLabel";
            addres_ClientLabel.Size = new System.Drawing.Size(61, 20);
            addres_ClientLabel.TabIndex = 55;
            addres_ClientLabel.Text = "Адрес:";
            // 
            // email_ClientLabel
            // 
            email_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            email_ClientLabel.AutoSize = true;
            email_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            email_ClientLabel.Location = new System.Drawing.Point(51, 196);
            email_ClientLabel.Name = "email_ClientLabel";
            email_ClientLabel.Size = new System.Drawing.Size(91, 20);
            email_ClientLabel.TabIndex = 54;
            email_ClientLabel.Text = "Эл. Почта:";
            // 
            // phone_ClientLabel
            // 
            phone_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            phone_ClientLabel.AutoSize = true;
            phone_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_ClientLabel.Location = new System.Drawing.Point(59, 152);
            phone_ClientLabel.Name = "phone_ClientLabel";
            phone_ClientLabel.Size = new System.Drawing.Size(83, 20);
            phone_ClientLabel.TabIndex = 53;
            phone_ClientLabel.Text = "Телефон:";
            // 
            // familia_ClientLabel
            // 
            familia_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            familia_ClientLabel.AutoSize = true;
            familia_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            familia_ClientLabel.Location = new System.Drawing.Point(57, 108);
            familia_ClientLabel.Name = "familia_ClientLabel";
            familia_ClientLabel.Size = new System.Drawing.Size(85, 20);
            familia_ClientLabel.TabIndex = 52;
            familia_ClientLabel.Text = "Фамилия:";
            // 
            // nameDad_ClientLabel
            // 
            nameDad_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nameDad_ClientLabel.AutoSize = true;
            nameDad_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameDad_ClientLabel.Location = new System.Drawing.Point(55, 66);
            nameDad_ClientLabel.Name = "nameDad_ClientLabel";
            nameDad_ClientLabel.Size = new System.Drawing.Size(87, 20);
            nameDad_ClientLabel.TabIndex = 51;
            nameDad_ClientLabel.Text = "Отчество:";
            // 
            // name_ClientLabel
            // 
            name_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            name_ClientLabel.AutoSize = true;
            name_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_ClientLabel.Location = new System.Drawing.Point(98, 21);
            name_ClientLabel.Name = "name_ClientLabel";
            name_ClientLabel.Size = new System.Drawing.Size(44, 20);
            name_ClientLabel.TabIndex = 50;
            name_ClientLabel.Text = "Имя:";
            // 
            // restration_WorkedLabel
            // 
            restration_WorkedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            restration_WorkedLabel.AutoSize = true;
            restration_WorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            restration_WorkedLabel.Location = new System.Drawing.Point(32, 375);
            restration_WorkedLabel.Name = "restration_WorkedLabel";
            restration_WorkedLabel.Size = new System.Drawing.Size(110, 20);
            restration_WorkedLabel.TabIndex = 47;
            restration_WorkedLabel.Text = "Регистрация:";
            // 
            // otdel_WorkedLabel
            // 
            otdel_WorkedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            otdel_WorkedLabel.AutoSize = true;
            otdel_WorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            otdel_WorkedLabel.Location = new System.Drawing.Point(78, 281);
            otdel_WorkedLabel.Name = "otdel_WorkedLabel";
            otdel_WorkedLabel.Size = new System.Drawing.Size(64, 20);
            otdel_WorkedLabel.TabIndex = 46;
            otdel_WorkedLabel.Text = "Отдел:";
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
            // gender_ClientLabel
            // 
            gender_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            gender_ClientLabel.AutoSize = true;
            gender_ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gender_ClientLabel.Location = new System.Drawing.Point(98, 333);
            gender_ClientLabel.Name = "gender_ClientLabel";
            gender_ClientLabel.Size = new System.Drawing.Size(44, 20);
            gender_ClientLabel.TabIndex = 56;
            gender_ClientLabel.Text = "Пол:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workedBindingSource, "Otdel_Worked", true));
            this.comboBox1.DataSource = this.otdelBindingSource;
            this.comboBox1.DisplayMember = "Title_Otdel";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 28);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.ValueMember = "ID_Otdel";
            // 
            // workedBindingSource
            // 
            this.workedBindingSource.DataMember = "Worked";
            this.workedBindingSource.DataSource = this.diplomDataSet;
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "Otdel";
            this.otdelBindingSource.DataSource = this.diplomDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iD_WorkedTextBox);
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
            this.panel1.Location = new System.Drawing.Point(542, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 462);
            this.panel1.TabIndex = 39;
            // 
            // iD_WorkedTextBox
            // 
            this.iD_WorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "ID_Worked", true));
            this.iD_WorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_WorkedTextBox.Location = new System.Drawing.Point(16, 50);
            this.iD_WorkedTextBox.Name = "iD_WorkedTextBox";
            this.iD_WorkedTextBox.ReadOnly = true;
            this.iD_WorkedTextBox.Size = new System.Drawing.Size(125, 26);
            this.iD_WorkedTextBox.TabIndex = 66;
            this.iD_WorkedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.button7.Click += new System.EventHandler(this.workedBindingNavigatorSaveItem_Click);
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
            this.panelLine.Size = new System.Drawing.Size(10, 462);
            this.panelLine.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workedBindingSource, "Gender_Worked", true));
            this.comboBox2.DataSource = this.genderBindingSource;
            this.comboBox2.DisplayMember = "Title_Gender";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 330);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(348, 28);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "ID_Gender";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.diplomDataSet;
            // 
            // workedTableAdapter
            // 
            this.workedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LevelOpenTableAdapter = null;
            this.tableAdapterManager.Order_UslugTableAdapter = null;
            this.tableAdapterManager.OtdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugTableAdapter = null;
            this.tableAdapterManager.WorkedTableAdapter = this.workedTableAdapter;
            // 
            // name_WorkedTextBox1
            // 
            this.name_WorkedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_WorkedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "Name_Worked", true));
            this.name_WorkedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_WorkedTextBox1.Location = new System.Drawing.Point(174, 20);
            this.name_WorkedTextBox1.Name = "name_WorkedTextBox1";
            this.name_WorkedTextBox1.Size = new System.Drawing.Size(348, 26);
            this.name_WorkedTextBox1.TabIndex = 59;
            // 
            // nameDad_WorkedTextBox
            // 
            this.nameDad_WorkedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameDad_WorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "NameDad_Worked", true));
            this.nameDad_WorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDad_WorkedTextBox.Location = new System.Drawing.Point(174, 62);
            this.nameDad_WorkedTextBox.Name = "nameDad_WorkedTextBox";
            this.nameDad_WorkedTextBox.Size = new System.Drawing.Size(348, 26);
            this.nameDad_WorkedTextBox.TabIndex = 60;
            // 
            // familia_WorkedTextBox
            // 
            this.familia_WorkedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.familia_WorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "Familia_Worked", true));
            this.familia_WorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familia_WorkedTextBox.Location = new System.Drawing.Point(174, 102);
            this.familia_WorkedTextBox.Name = "familia_WorkedTextBox";
            this.familia_WorkedTextBox.Size = new System.Drawing.Size(348, 26);
            this.familia_WorkedTextBox.TabIndex = 61;
            // 
            // phone_WorkedTextBox
            // 
            this.phone_WorkedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_WorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "phone_Worked", true));
            this.phone_WorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_WorkedTextBox.Location = new System.Drawing.Point(174, 148);
            this.phone_WorkedTextBox.Name = "phone_WorkedTextBox";
            this.phone_WorkedTextBox.Size = new System.Drawing.Size(348, 26);
            this.phone_WorkedTextBox.TabIndex = 62;
            // 
            // email_WorkedTextBox
            // 
            this.email_WorkedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email_WorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "email_Worked", true));
            this.email_WorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_WorkedTextBox.Location = new System.Drawing.Point(174, 190);
            this.email_WorkedTextBox.Name = "email_WorkedTextBox";
            this.email_WorkedTextBox.Size = new System.Drawing.Size(348, 26);
            this.email_WorkedTextBox.TabIndex = 63;
            // 
            // addres_WorkedTextBox
            // 
            this.addres_WorkedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addres_WorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workedBindingSource, "Addres_Worked", true));
            this.addres_WorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addres_WorkedTextBox.Location = new System.Drawing.Point(174, 232);
            this.addres_WorkedTextBox.Name = "addres_WorkedTextBox";
            this.addres_WorkedTextBox.Size = new System.Drawing.Size(348, 26);
            this.addres_WorkedTextBox.TabIndex = 64;
            // 
            // restration_WorkedDateTimePicker
            // 
            this.restration_WorkedDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restration_WorkedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restration_WorkedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workedBindingSource, "Restration_Worked", true));
            this.restration_WorkedDateTimePicker.Location = new System.Drawing.Point(174, 375);
            this.restration_WorkedDateTimePicker.Name = "restration_WorkedDateTimePicker";
            this.restration_WorkedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.restration_WorkedDateTimePicker.TabIndex = 65;
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdDataWorked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 462);
            this.Controls.Add(this.restration_WorkedDateTimePicker);
            this.Controls.Add(this.addres_WorkedTextBox);
            this.Controls.Add(this.email_WorkedTextBox);
            this.Controls.Add(this.phone_WorkedTextBox);
            this.Controls.Add(this.familia_WorkedTextBox);
            this.Controls.Add(this.nameDad_WorkedTextBox);
            this.Controls.Add(this.name_WorkedTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(gender_ClientLabel);
            this.Controls.Add(addres_ClientLabel);
            this.Controls.Add(email_ClientLabel);
            this.Controls.Add(phone_ClientLabel);
            this.Controls.Add(familia_ClientLabel);
            this.Controls.Add(nameDad_ClientLabel);
            this.Controls.Add(name_ClientLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(restration_WorkedLabel);
            this.Controls.Add(otdel_WorkedLabel);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdDataWorked";
            this.Text = "Изменение данных Работника";
            this.Load += new System.EventHandler(this.FormUpdDataWorked_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.ComboBox comboBox2;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource workedBindingSource;
        private DiplomDataSetTableAdapters.WorkedTableAdapter workedTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox name_WorkedTextBox1;
        private System.Windows.Forms.TextBox nameDad_WorkedTextBox;
        private System.Windows.Forms.TextBox familia_WorkedTextBox;
        private System.Windows.Forms.TextBox phone_WorkedTextBox;
        private System.Windows.Forms.TextBox email_WorkedTextBox;
        private System.Windows.Forms.TextBox addres_WorkedTextBox;
        private System.Windows.Forms.DateTimePicker restration_WorkedDateTimePicker;
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private DiplomDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private DiplomDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.TextBox iD_WorkedTextBox;
    }
}