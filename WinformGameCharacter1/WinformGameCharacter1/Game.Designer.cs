namespace WinformGameCharacter1
{
    partial class Game
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbWarrior = new System.Windows.Forms.PictureBox();
            this.pbMage = new System.Windows.Forms.PictureBox();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(14, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Intelligence";
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "Warrior",
            "Mage"});
            this.cmbCharacterType.Location = new System.Drawing.Point(85, 101);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(121, 21);
            this.cmbCharacterType.TabIndex = 27;
            this.cmbCharacterType.SelectedIndexChanged += new System.EventHandler(this.cmbCharacterType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(85, 203);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(100, 20);
            this.txtIntelligence.TabIndex = 20;
            this.txtIntelligence.TextChanged += new System.EventHandler(this.txtIntelligence_TextChanged);
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(85, 133);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(100, 20);
            this.txtStrength.TabIndex = 19;
            this.txtStrength.TextChanged += new System.EventHandler(this.txtStrength_TextChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(85, 42);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 18;
            this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(85, 73);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(100, 20);
            this.txtHealth.TabIndex = 17;
            this.txtHealth.TextChanged += new System.EventHandler(this.txtHealth_TextChanged);
            // 
            // txtMana
            // 
            this.txtMana.Location = new System.Drawing.Point(85, 171);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(100, 20);
            this.txtMana.TabIndex = 16;
            this.txtMana.TextChanged += new System.EventHandler(this.txtMana_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // battleLog
            // 
            this.battleLog.BackColor = System.Drawing.Color.Black;
            this.battleLog.ForeColor = System.Drawing.Color.SpringGreen;
            this.battleLog.FormattingEnabled = true;
            this.battleLog.Location = new System.Drawing.Point(795, 9);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(157, 316);
            this.battleLog.TabIndex = 30;
            this.battleLog.SelectedIndexChanged += new System.EventHandler(this.battleLog_SelectedIndexChanged);
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.BackColor = System.Drawing.Color.Black;
            this.txtCharacterDetails.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtCharacterDetails.Location = new System.Drawing.Point(631, 9);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterDetails.Size = new System.Drawing.Size(149, 130);
            this.txtCharacterDetails.TabIndex = 29;
            this.txtCharacterDetails.Text = "Character details will appear here.";
            this.txtCharacterDetails.TextChanged += new System.EventHandler(this.txtCharacterDetails_TextChanged);
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.Location = new System.Drawing.Point(65, 519);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(101, 23);
            this.btnSelectCharacter.TabIndex = 33;
            this.btnSelectCharacter.Text = "Select Character";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(65, 389);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(101, 23);
            this.btnAddCharacter.TabIndex = 32;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.BackColor = System.Drawing.Color.Black;
            this.listBoxCharacters.ForeColor = System.Drawing.Color.SpringGreen;
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.Location = new System.Drawing.Point(46, 418);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(120, 95);
            this.listBoxCharacters.TabIndex = 31;
            this.listBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.listBoxCharacters_SelectedIndexChanged);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.BackColor = System.Drawing.Color.Black;
            this.btnLevelUp.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.download__9_;
            this.btnLevelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelUp.Location = new System.Drawing.Point(499, 485);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(75, 57);
            this.btnLevelUp.TabIndex = 36;
            this.btnLevelUp.UseVisualStyleBackColor = false;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.Black;
            this.btnDefend.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.Shield_pixel_art1;
            this.btnDefend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefend.Location = new System.Drawing.Point(405, 485);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(75, 57);
            this.btnDefend.TabIndex = 35;
            this.btnDefend.UseVisualStyleBackColor = false;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Black;
            this.btnAttack.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.Big_Diamond_Sword___item_Texture___NovaSkin1;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.Location = new System.Drawing.Point(310, 485);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 57);
            this.btnAttack.TabIndex = 34;
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinformGameCharacter1.Properties.Resources.Skeleton;
            this.pictureBox1.Location = new System.Drawing.Point(499, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pbWarrior
            // 
            this.pbWarrior.BackColor = System.Drawing.Color.Transparent;
            this.pbWarrior.Image = global::WinformGameCharacter1.Properties.Resources.WarriorMoving;
            this.pbWarrior.Location = new System.Drawing.Point(358, 291);
            this.pbWarrior.Name = "pbWarrior";
            this.pbWarrior.Size = new System.Drawing.Size(202, 188);
            this.pbWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarrior.TabIndex = 38;
            this.pbWarrior.TabStop = false;
            // 
            // pbMage
            // 
            this.pbMage.BackColor = System.Drawing.Color.Transparent;
            this.pbMage.Image = global::WinformGameCharacter1.Properties.Resources.MageMoving;
            this.pbMage.Location = new System.Drawing.Point(278, 330);
            this.pbMage.Name = "pbMage";
            this.pbMage.Size = new System.Drawing.Size(127, 130);
            this.pbMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMage.TabIndex = 39;
            this.pbMage.TabStop = false;
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 50;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.Screenshot_2024_12_01_173958;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.pbMage);
            this.Controls.Add(this.pbWarrior);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.listBoxCharacters);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.txtCharacterDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtName);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox battleLog;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbWarrior;
        private System.Windows.Forms.PictureBox pbMage;
        private System.Windows.Forms.Timer movementTimer;
    }
}

