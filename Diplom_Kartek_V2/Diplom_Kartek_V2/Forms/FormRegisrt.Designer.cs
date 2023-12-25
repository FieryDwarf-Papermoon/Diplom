namespace Diplom_Kartek_V2.Forms
{
    partial class FormRegisrt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diplomDataSet = new Diplom_Kartek_V2.DiplomDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new Diplom_Kartek_V2.DiplomDataSetTableAdapters.TableAdapterManager();
            this.login_AccountTextBox = new System.Windows.Forms.TextBox();
            this.passrole_AccountTextBox = new System.Windows.Forms.TextBox();
            this.levelOpen_AccountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(122, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.accountBindingNavigatorSaveItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин";
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
            this.login_AccountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_AccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Login_Account", true));
            this.login_AccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_AccountTextBox.Location = new System.Drawing.Point(154, 80);
            this.login_AccountTextBox.Name = "login_AccountTextBox";
            this.login_AccountTextBox.Size = new System.Drawing.Size(222, 26);
            this.login_AccountTextBox.TabIndex = 18;
            // 
            // passrole_AccountTextBox
            // 
            this.passrole_AccountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passrole_AccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Passrole_Account", true));
            this.passrole_AccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passrole_AccountTextBox.Location = new System.Drawing.Point(154, 127);
            this.passrole_AccountTextBox.Name = "passrole_AccountTextBox";
            this.passrole_AccountTextBox.Size = new System.Drawing.Size(222, 26);
            this.passrole_AccountTextBox.TabIndex = 19;
            // 
            // levelOpen_AccountTextBox
            // 
            this.levelOpen_AccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "LevelOpen_Account", true));
            this.levelOpen_AccountTextBox.Location = new System.Drawing.Point(109, 286);
            this.levelOpen_AccountTextBox.Name = "levelOpen_AccountTextBox";
            this.levelOpen_AccountTextBox.Size = new System.Drawing.Size(172, 20);
            this.levelOpen_AccountTextBox.TabIndex = 20;
            this.levelOpen_AccountTextBox.Visible = false;
            // 
            // FormRegisrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levelOpen_AccountTextBox);
            this.Controls.Add(this.passrole_AccountTextBox);
            this.Controls.Add(this.login_AccountTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegisrt";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegisrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DiplomDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox login_AccountTextBox;
        private System.Windows.Forms.TextBox passrole_AccountTextBox;
        private System.Windows.Forms.TextBox levelOpen_AccountTextBox;
    }
}