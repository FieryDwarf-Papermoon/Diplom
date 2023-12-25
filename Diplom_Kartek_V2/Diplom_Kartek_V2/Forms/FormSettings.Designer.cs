namespace Diplom_Kartek_V2.Forms
{
    partial class FormSettings
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
            this.paSettingsAccount = new System.Windows.Forms.Panel();
            this.buttonSettingsAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBackGround = new System.Windows.Forms.Panel();
            this.radioButtonBlackBack = new System.Windows.Forms.RadioButton();
            this.radioButtonWhileBack = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcolumn1 = new System.Windows.Forms.Panel();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.buttonSelectSetting = new System.Windows.Forms.Button();
            this.paSettingsAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBackGround.SuspendLayout();
            this.panelcolumn1.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // paSettingsAccount
            // 
            this.paSettingsAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paSettingsAccount.Controls.Add(this.buttonSettingsAccount);
            this.paSettingsAccount.Controls.Add(this.label3);
            this.paSettingsAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSettingsAccount.Location = new System.Drawing.Point(0, 225);
            this.paSettingsAccount.Name = "paSettingsAccount";
            this.paSettingsAccount.Size = new System.Drawing.Size(800, 92);
            this.paSettingsAccount.TabIndex = 2;
            this.paSettingsAccount.Visible = false;
            // 
            // buttonSettingsAccount
            // 
            this.buttonSettingsAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettingsAccount.Location = new System.Drawing.Point(24, 42);
            this.buttonSettingsAccount.Name = "buttonSettingsAccount";
            this.buttonSettingsAccount.Size = new System.Drawing.Size(120, 32);
            this.buttonSettingsAccount.TabIndex = 1;
            this.buttonSettingsAccount.Text = "Настроить";
            this.buttonSettingsAccount.UseVisualStyleBackColor = true;
            this.buttonSettingsAccount.Click += new System.EventHandler(this.buttonSettingsAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Настройка аккаунтов";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8",
            "10",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(24, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер шрифта";
            // 
            // panelBackGround
            // 
            this.panelBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBackGround.Controls.Add(this.radioButtonBlackBack);
            this.panelBackGround.Controls.Add(this.radioButtonWhileBack);
            this.panelBackGround.Controls.Add(this.label1);
            this.panelBackGround.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackGround.Location = new System.Drawing.Point(0, 0);
            this.panelBackGround.Name = "panelBackGround";
            this.panelBackGround.Size = new System.Drawing.Size(800, 128);
            this.panelBackGround.TabIndex = 0;
            // 
            // radioButtonBlackBack
            // 
            this.radioButtonBlackBack.AutoSize = true;
            this.radioButtonBlackBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBlackBack.Location = new System.Drawing.Point(24, 88);
            this.radioButtonBlackBack.Name = "radioButtonBlackBack";
            this.radioButtonBlackBack.Size = new System.Drawing.Size(83, 24);
            this.radioButtonBlackBack.TabIndex = 2;
            this.radioButtonBlackBack.Text = "Тёмная";
            this.radioButtonBlackBack.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhileBack
            // 
            this.radioButtonWhileBack.AutoSize = true;
            this.radioButtonWhileBack.Checked = true;
            this.radioButtonWhileBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWhileBack.Location = new System.Drawing.Point(24, 45);
            this.radioButtonWhileBack.Name = "radioButtonWhileBack";
            this.radioButtonWhileBack.Size = new System.Drawing.Size(93, 24);
            this.radioButtonWhileBack.TabIndex = 1;
            this.radioButtonWhileBack.TabStop = true;
            this.radioButtonWhileBack.Text = "Светлая";
            this.radioButtonWhileBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема фона ";
            // 
            // panelcolumn1
            // 
            this.panelcolumn1.Controls.Add(this.paSettingsAccount);
            this.panelcolumn1.Controls.Add(this.panel1);
            this.panelcolumn1.Controls.Add(this.panelBackGround);
            this.panelcolumn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcolumn1.Location = new System.Drawing.Point(0, 0);
            this.panelcolumn1.Name = "panelcolumn1";
            this.panelcolumn1.Size = new System.Drawing.Size(800, 376);
            this.panelcolumn1.TabIndex = 3;
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.buttonSelectSetting);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelect.Location = new System.Drawing.Point(0, 376);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(800, 74);
            this.panelSelect.TabIndex = 2;
            // 
            // buttonSelectSetting
            // 
            this.buttonSelectSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectSetting.Location = new System.Drawing.Point(24, 17);
            this.buttonSelectSetting.Name = "buttonSelectSetting";
            this.buttonSelectSetting.Size = new System.Drawing.Size(354, 34);
            this.buttonSelectSetting.TabIndex = 0;
            this.buttonSelectSetting.Text = "Принять";
            this.buttonSelectSetting.UseVisualStyleBackColor = true;
            this.buttonSelectSetting.Click += new System.EventHandler(this.buttonSelectSetting_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcolumn1);
            this.Controls.Add(this.panelSelect);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.paSettingsAccount.ResumeLayout(false);
            this.paSettingsAccount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBackGround.ResumeLayout(false);
            this.panelBackGround.PerformLayout();
            this.panelcolumn1.ResumeLayout(false);
            this.panelSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paSettingsAccount;
        private System.Windows.Forms.Button buttonSettingsAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBackGround;
        private System.Windows.Forms.RadioButton radioButtonBlackBack;
        private System.Windows.Forms.RadioButton radioButtonWhileBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcolumn1;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Button buttonSelectSetting;
    }
}