namespace CharacterCreatorForm

{
    partial class Form1
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
            this.numStrength = new System.Windows.Forms.NumericUpDown();
            this.numDexterity = new System.Windows.Forms.NumericUpDown();
            this.numEndurance = new System.Windows.Forms.NumericUpDown();
            this.numIntelligence = new System.Windows.Forms.NumericUpDown();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblCritChance = new System.Windows.Forms.Label();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // numStrength
            // 
            this.numStrength.Location = new System.Drawing.Point(115, 205);
            this.numStrength.Name = "numStrength";
            this.numStrength.Size = new System.Drawing.Size(35, 20);
            this.numStrength.TabIndex = 1;
            this.numStrength.Click += new System.EventHandler(this.CharacterStat_Changed);
            // 
            // numDexterity
            // 
            this.numDexterity.Location = new System.Drawing.Point(115, 234);
            this.numDexterity.Name = "numDexterity";
            this.numDexterity.Size = new System.Drawing.Size(35, 20);
            this.numDexterity.TabIndex = 2;
            this.numDexterity.Click += new System.EventHandler(this.CharacterStat_Changed);
            // 
            // numEndurance
            // 
            this.numEndurance.Location = new System.Drawing.Point(115, 261);
            this.numEndurance.Name = "numEndurance";
            this.numEndurance.Size = new System.Drawing.Size(35, 20);
            this.numEndurance.TabIndex = 3;
            this.numEndurance.Click += new System.EventHandler(this.CharacterStat_Changed);
            // 
            // numIntelligence
            // 
            this.numIntelligence.Location = new System.Drawing.Point(115, 288);
            this.numIntelligence.Name = "numIntelligence";
            this.numIntelligence.Size = new System.Drawing.Size(35, 20);
            this.numIntelligence.TabIndex = 4;
            this.numIntelligence.Click += new System.EventHandler(this.CharacterStat_Changed);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(103, 101);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(35, 13);
            this.lblHealth.TabIndex = 9;
            this.lblHealth.Text = "label2";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(103, 122);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(35, 13);
            this.lblDamage.TabIndex = 10;
            this.lblDamage.Text = "label3";
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(103, 147);
            this.lblCritChance.Name = "lblCritChance";
            this.lblCritChance.Size = new System.Drawing.Size(35, 13);
            this.lblCritChance.TabIndex = 11;
            this.lblCritChance.Text = "label4";
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.AutoSize = true;
            this.lblClassDescription.Location = new System.Drawing.Point(17, 51);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(35, 13);
            this.lblClassDescription.TabIndex = 12;
            this.lblClassDescription.Text = "label4";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(220, 364);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 13;
            this.btnAttack.Text = "Тест атаки";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FloralWhite;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.ForeColor = System.Drawing.Color.Black;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(23, 366);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 14;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Здоровье -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Крит шанс -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Урон -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Сила";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ловкость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Интелект";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Выносливость";
            // 
            // picClass
            // 
            this.picClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picClass.Location = new System.Drawing.Point(184, 101);
            this.picClass.Name = "picClass";
            this.picClass.Size = new System.Drawing.Size(150, 207);
            this.picClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClass.TabIndex = 25;
            this.picClass.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.picClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.lblCritChance);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.numIntelligence);
            this.Controls.Add(this.numEndurance);
            this.Controls.Add(this.numDexterity);
            this.Controls.Add(this.numStrength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numStrength;
        private System.Windows.Forms.NumericUpDown numDexterity;
        private System.Windows.Forms.NumericUpDown numEndurance;
        private System.Windows.Forms.NumericUpDown numIntelligence;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblCritChance;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picClass;
    }
}

