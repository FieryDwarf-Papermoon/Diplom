namespace Diplom_Kartek_V2.Forms
{
    partial class FormUpdDataOtdel
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
            System.Windows.Forms.Label restration_OtdelLabel;
            System.Windows.Forms.Label popular_OtdelLabel;
            System.Windows.Forms.Label count_Workers_OtdelLabel;
            System.Windows.Forms.Label title_OtdelLabel;
            System.Windows.Forms.Label iD_ClientLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_OtdelTextBox = new System.Windows.Forms.TextBox();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.otdelTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.OtdelTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.title_OtdelTextBox1 = new System.Windows.Forms.TextBox();
            this.count_Workers_OtdelTextBox = new System.Windows.Forms.TextBox();
            this.popular_OtdelTextBox = new System.Windows.Forms.TextBox();
            this.restration_OtdelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            restration_OtdelLabel = new System.Windows.Forms.Label();
            popular_OtdelLabel = new System.Windows.Forms.Label();
            count_Workers_OtdelLabel = new System.Windows.Forms.Label();
            title_OtdelLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // restration_OtdelLabel
            // 
            restration_OtdelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            restration_OtdelLabel.AutoSize = true;
            restration_OtdelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            restration_OtdelLabel.Location = new System.Drawing.Point(90, 146);
            restration_OtdelLabel.Name = "restration_OtdelLabel";
            restration_OtdelLabel.Size = new System.Drawing.Size(110, 20);
            restration_OtdelLabel.TabIndex = 35;
            restration_OtdelLabel.Text = "Регистрация:";
            // 
            // popular_OtdelLabel
            // 
            popular_OtdelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            popular_OtdelLabel.AutoSize = true;
            popular_OtdelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            popular_OtdelLabel.Location = new System.Drawing.Point(78, 108);
            popular_OtdelLabel.Name = "popular_OtdelLabel";
            popular_OtdelLabel.Size = new System.Drawing.Size(122, 20);
            popular_OtdelLabel.TabIndex = 33;
            popular_OtdelLabel.Text = "Популярность:";
            // 
            // count_Workers_OtdelLabel
            // 
            count_Workers_OtdelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            count_Workers_OtdelLabel.AutoSize = true;
            count_Workers_OtdelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            count_Workers_OtdelLabel.Location = new System.Drawing.Point(6, 73);
            count_Workers_OtdelLabel.Name = "count_Workers_OtdelLabel";
            count_Workers_OtdelLabel.Size = new System.Drawing.Size(198, 20);
            count_Workers_OtdelLabel.TabIndex = 31;
            count_Workers_OtdelLabel.Text = "Колличество работнико:";
            // 
            // title_OtdelLabel
            // 
            title_OtdelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            title_OtdelLabel.AutoSize = true;
            title_OtdelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title_OtdelLabel.Location = new System.Drawing.Point(113, 35);
            title_OtdelLabel.Name = "title_OtdelLabel";
            title_OtdelLabel.Size = new System.Drawing.Size(87, 20);
            title_OtdelLabel.TabIndex = 30;
            title_OtdelLabel.Text = "Название:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.iD_OtdelTextBox);
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
            this.panel1.TabIndex = 29;
            // 
            // iD_OtdelTextBox
            // 
            this.iD_OtdelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdelBindingSource, "ID_Otdel", true));
            this.iD_OtdelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_OtdelTextBox.Location = new System.Drawing.Point(16, 50);
            this.iD_OtdelTextBox.Name = "iD_OtdelTextBox";
            this.iD_OtdelTextBox.ReadOnly = true;
            this.iD_OtdelTextBox.Size = new System.Drawing.Size(125, 26);
            this.iD_OtdelTextBox.TabIndex = 43;
            this.iD_OtdelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "Otdel";
            this.otdelBindingSource.DataSource = this.diplomDataSet;
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
            this.button7.Click += new System.EventHandler(this.otdelBindingNavigatorSaveItem_Click);
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
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LevelOpenTableAdapter = null;
            this.tableAdapterManager.Order_UslugTableAdapter = null;
            this.tableAdapterManager.OtdelTableAdapter = this.otdelTableAdapter;
            this.tableAdapterManager.UpdateOrder = Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugTableAdapter = null;
            this.tableAdapterManager.WorkedTableAdapter = null;
            // 
            // title_OtdelTextBox1
            // 
            this.title_OtdelTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_OtdelTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdelBindingSource, "Title_Otdel", true));
            this.title_OtdelTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_OtdelTextBox1.Location = new System.Drawing.Point(206, 32);
            this.title_OtdelTextBox1.Name = "title_OtdelTextBox1";
            this.title_OtdelTextBox1.Size = new System.Drawing.Size(265, 26);
            this.title_OtdelTextBox1.TabIndex = 39;
            // 
            // count_Workers_OtdelTextBox
            // 
            this.count_Workers_OtdelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.count_Workers_OtdelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdelBindingSource, "Count_Workers_Otdel", true));
            this.count_Workers_OtdelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_Workers_OtdelTextBox.Location = new System.Drawing.Point(206, 69);
            this.count_Workers_OtdelTextBox.Name = "count_Workers_OtdelTextBox";
            this.count_Workers_OtdelTextBox.Size = new System.Drawing.Size(100, 26);
            this.count_Workers_OtdelTextBox.TabIndex = 40;
            // 
            // popular_OtdelTextBox
            // 
            this.popular_OtdelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.popular_OtdelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdelBindingSource, "Popular_Otdel", true));
            this.popular_OtdelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popular_OtdelTextBox.Location = new System.Drawing.Point(206, 108);
            this.popular_OtdelTextBox.Name = "popular_OtdelTextBox";
            this.popular_OtdelTextBox.Size = new System.Drawing.Size(100, 26);
            this.popular_OtdelTextBox.TabIndex = 41;
            // 
            // restration_OtdelDateTimePicker
            // 
            this.restration_OtdelDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restration_OtdelDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.otdelBindingSource, "Restration_Otdel", true));
            this.restration_OtdelDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restration_OtdelDateTimePicker.Location = new System.Drawing.Point(206, 149);
            this.restration_OtdelDateTimePicker.Name = "restration_OtdelDateTimePicker";
            this.restration_OtdelDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.restration_OtdelDateTimePicker.TabIndex = 42;
            // 
            // FormUpdDataOtdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restration_OtdelDateTimePicker);
            this.Controls.Add(this.popular_OtdelTextBox);
            this.Controls.Add(this.count_Workers_OtdelTextBox);
            this.Controls.Add(this.title_OtdelTextBox1);
            this.Controls.Add(restration_OtdelLabel);
            this.Controls.Add(popular_OtdelLabel);
            this.Controls.Add(count_Workers_OtdelLabel);
            this.Controls.Add(title_OtdelLabel);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdDataOtdel";
            this.Text = "Изменение данных Отдела";
            this.Load += new System.EventHandler(this.FormUpdDataOtdel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private DiplomDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox title_OtdelTextBox1;
        private System.Windows.Forms.TextBox iD_OtdelTextBox;
        private System.Windows.Forms.TextBox count_Workers_OtdelTextBox;
        private System.Windows.Forms.TextBox popular_OtdelTextBox;
        private System.Windows.Forms.DateTimePicker restration_OtdelDateTimePicker;
    }
}