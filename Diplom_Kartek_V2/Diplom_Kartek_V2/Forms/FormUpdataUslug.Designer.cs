namespace Diplom_Kartek_V2.Forms
{
    partial class FormUpdataUslug
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
            System.Windows.Forms.Label popular_UslugLabel;
            System.Windows.Forms.Label prise_UslugLabel;
            System.Windows.Forms.Label title_UslugLabel;
            System.Windows.Forms.Label iD_ClientLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_UslugTextBox1 = new System.Windows.Forms.TextBox();
            this.uslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.title_UslugTextBox1 = new System.Windows.Forms.TextBox();
            this.prise_UslugTextBox1 = new System.Windows.Forms.TextBox();
            this.popular_UslugTextBox1 = new System.Windows.Forms.TextBox();
            this.uslugTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.UslugTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            popular_UslugLabel = new System.Windows.Forms.Label();
            prise_UslugLabel = new System.Windows.Forms.Label();
            title_UslugLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // popular_UslugLabel
            // 
            popular_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            popular_UslugLabel.AutoSize = true;
            popular_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            popular_UslugLabel.Location = new System.Drawing.Point(2, 106);
            popular_UslugLabel.Name = "popular_UslugLabel";
            popular_UslugLabel.Size = new System.Drawing.Size(122, 20);
            popular_UslugLabel.TabIndex = 33;
            popular_UslugLabel.Text = "Популярность:";
            // 
            // prise_UslugLabel
            // 
            prise_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            prise_UslugLabel.AutoSize = true;
            prise_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            prise_UslugLabel.Location = new System.Drawing.Point(24, 70);
            prise_UslugLabel.Name = "prise_UslugLabel";
            prise_UslugLabel.Size = new System.Drawing.Size(97, 20);
            prise_UslugLabel.TabIndex = 31;
            prise_UslugLabel.Text = "Стоимость:";
            // 
            // title_UslugLabel
            // 
            title_UslugLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            title_UslugLabel.AutoSize = true;
            title_UslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title_UslugLabel.Location = new System.Drawing.Point(34, 33);
            title_UslugLabel.Name = "title_UslugLabel";
            title_UslugLabel.Size = new System.Drawing.Size(87, 20);
            title_UslugLabel.TabIndex = 30;
            title_UslugLabel.Text = "Название:";
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
            this.panel1.Controls.Add(this.iD_UslugTextBox1);
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
            // iD_UslugTextBox1
            // 
            this.iD_UslugTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugBindingSource, "ID_Uslug", true));
            this.iD_UslugTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_UslugTextBox1.Location = new System.Drawing.Point(16, 50);
            this.iD_UslugTextBox1.Name = "iD_UslugTextBox1";
            this.iD_UslugTextBox1.ReadOnly = true;
            this.iD_UslugTextBox1.Size = new System.Drawing.Size(125, 26);
            this.iD_UslugTextBox1.TabIndex = 40;
            this.iD_UslugTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uslugBindingSource
            // 
            this.uslugBindingSource.DataMember = "Uslug";
            this.uslugBindingSource.DataSource = this.diplomDataSet;
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
            this.button7.Click += new System.EventHandler(this.uslugBindingNavigatorSaveItem_Click);
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
            // title_UslugTextBox1
            // 
            this.title_UslugTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_UslugTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugBindingSource, "Title_Uslug", true));
            this.title_UslugTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_UslugTextBox1.Location = new System.Drawing.Point(127, 30);
            this.title_UslugTextBox1.Name = "title_UslugTextBox1";
            this.title_UslugTextBox1.Size = new System.Drawing.Size(238, 26);
            this.title_UslugTextBox1.TabIndex = 37;
            // 
            // prise_UslugTextBox1
            // 
            this.prise_UslugTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prise_UslugTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugBindingSource, "Prise_Uslug", true));
            this.prise_UslugTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prise_UslugTextBox1.Location = new System.Drawing.Point(127, 64);
            this.prise_UslugTextBox1.Name = "prise_UslugTextBox1";
            this.prise_UslugTextBox1.Size = new System.Drawing.Size(238, 26);
            this.prise_UslugTextBox1.TabIndex = 38;
            // 
            // popular_UslugTextBox1
            // 
            this.popular_UslugTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.popular_UslugTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugBindingSource, "Popular_Uslug", true));
            this.popular_UslugTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popular_UslugTextBox1.Location = new System.Drawing.Point(127, 100);
            this.popular_UslugTextBox1.Name = "popular_UslugTextBox1";
            this.popular_UslugTextBox1.Size = new System.Drawing.Size(100, 26);
            this.popular_UslugTextBox1.TabIndex = 39;
            // 
            // uslugTableAdapter
            // 
            this.uslugTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UslugTableAdapter = this.uslugTableAdapter;
            this.tableAdapterManager.WorkedTableAdapter = null;
            // 
            // FormUpdataUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.popular_UslugTextBox1);
            this.Controls.Add(this.prise_UslugTextBox1);
            this.Controls.Add(this.title_UslugTextBox1);
            this.Controls.Add(popular_UslugLabel);
            this.Controls.Add(prise_UslugLabel);
            this.Controls.Add(title_UslugLabel);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdataUslug";
            this.Text = "Изменение данных Услуги";
            this.Load += new System.EventHandler(this.FormUpdataUslug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource uslugBindingSource;
        private DiplomDataSetTableAdapters.UslugTableAdapter uslugTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox title_UslugTextBox1;
        private System.Windows.Forms.TextBox prise_UslugTextBox1;
        private System.Windows.Forms.TextBox popular_UslugTextBox1;
        private System.Windows.Forms.TextBox iD_UslugTextBox1;
    }
}