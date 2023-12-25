namespace Diplom_Kartek_V2.Forms
{
    partial class FormUpdDataAccount
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
            System.Windows.Forms.Label login_AccountLabel;
            System.Windows.Forms.Label passrole_AccountLabel;
            System.Windows.Forms.Label levelOpen_AccountLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_AccountTextBox = new System.Windows.Forms.TextBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.accountTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.login_AccountTextBox = new System.Windows.Forms.TextBox();
            this.passrole_AccountTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.levelOpenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelOpenTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.LevelOpenTableAdapter();
            iD_ClientLabel = new System.Windows.Forms.Label();
            login_AccountLabel = new System.Windows.Forms.Label();
            passrole_AccountLabel = new System.Windows.Forms.Label();
            levelOpen_AccountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOpenBindingSource)).BeginInit();
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
            // login_AccountLabel
            // 
            login_AccountLabel.AutoSize = true;
            login_AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            login_AccountLabel.Location = new System.Drawing.Point(116, 55);
            login_AccountLabel.Name = "login_AccountLabel";
            login_AccountLabel.Size = new System.Drawing.Size(59, 20);
            login_AccountLabel.TabIndex = 58;
            login_AccountLabel.Text = "Логин:";
            // 
            // passrole_AccountLabel
            // 
            passrole_AccountLabel.AutoSize = true;
            passrole_AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passrole_AccountLabel.Location = new System.Drawing.Point(104, 108);
            passrole_AccountLabel.Name = "passrole_AccountLabel";
            passrole_AccountLabel.Size = new System.Drawing.Size(71, 20);
            passrole_AccountLabel.TabIndex = 59;
            passrole_AccountLabel.Text = "Пароль:";
            // 
            // levelOpen_AccountLabel
            // 
            levelOpen_AccountLabel.AutoSize = true;
            levelOpen_AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            levelOpen_AccountLabel.Location = new System.Drawing.Point(31, 167);
            levelOpen_AccountLabel.Name = "levelOpen_AccountLabel";
            levelOpen_AccountLabel.Size = new System.Drawing.Size(144, 20);
            levelOpen_AccountLabel.TabIndex = 60;
            levelOpen_AccountLabel.Text = "Уровень Доступа:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iD_AccountTextBox);
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
            this.panel1.Location = new System.Drawing.Point(506, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 450);
            this.panel1.TabIndex = 57;
            // 
            // iD_AccountTextBox
            // 
            this.iD_AccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "ID_Account", true));
            this.iD_AccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_AccountTextBox.Location = new System.Drawing.Point(16, 46);
            this.iD_AccountTextBox.Name = "iD_AccountTextBox";
            this.iD_AccountTextBox.ReadOnly = true;
            this.iD_AccountTextBox.Size = new System.Drawing.Size(125, 26);
            this.iD_AccountTextBox.TabIndex = 10;
            this.iD_AccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.diplomDataSet;
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
            this.button7.Click += new System.EventHandler(this.accountBindingNavigatorSaveItem_Click);
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
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LevelOpenTableAdapter = null;
            this.tableAdapterManager.Order_UslugTableAdapter = null;
            this.tableAdapterManager.OtdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugTableAdapter = null;
            this.tableAdapterManager.WorkedTableAdapter = null;
            // 
            // login_AccountTextBox
            // 
            this.login_AccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Login_Account", true));
            this.login_AccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_AccountTextBox.Location = new System.Drawing.Point(205, 55);
            this.login_AccountTextBox.Name = "login_AccountTextBox";
            this.login_AccountTextBox.Size = new System.Drawing.Size(215, 26);
            this.login_AccountTextBox.TabIndex = 59;
            // 
            // passrole_AccountTextBox
            // 
            this.passrole_AccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Passrole_Account", true));
            this.passrole_AccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passrole_AccountTextBox.Location = new System.Drawing.Point(205, 108);
            this.passrole_AccountTextBox.Name = "passrole_AccountTextBox";
            this.passrole_AccountTextBox.Size = new System.Drawing.Size(215, 26);
            this.passrole_AccountTextBox.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountBindingSource, "LevelOpen_Account", true));
            this.comboBox1.DataSource = this.levelOpenBindingSource;
            this.comboBox1.DisplayMember = "Title_LevelOpen";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 28);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "ID_LevelOpen";
            // 
            // levelOpenBindingSource
            // 
            this.levelOpenBindingSource.DataMember = "LevelOpen";
            this.levelOpenBindingSource.DataSource = this.diplomDataSet;
            // 
            // levelOpenTableAdapter
            // 
            this.levelOpenTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdDataAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(levelOpen_AccountLabel);
            this.Controls.Add(passrole_AccountLabel);
            this.Controls.Add(this.passrole_AccountTextBox);
            this.Controls.Add(login_AccountLabel);
            this.Controls.Add(this.login_AccountTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdDataAccount";
            this.Text = "Изменение Аккаунтов";
            this.Load += new System.EventHandler(this.FormUpdDataAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOpenBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DiplomDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox login_AccountTextBox;
        private System.Windows.Forms.TextBox passrole_AccountTextBox;
        private System.Windows.Forms.TextBox iD_AccountTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource levelOpenBindingSource;
        private DiplomDataSetTableAdapters.LevelOpenTableAdapter levelOpenTableAdapter;
    }
}