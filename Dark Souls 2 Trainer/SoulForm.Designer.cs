namespace Dark_Souls_2_Trainer
{
    partial class SoulForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoulForm));
			this.labStatus = new System.Windows.Forms.Label();
			this.labStatusInfo = new System.Windows.Forms.Label();
			this.timerProcessWait = new System.Windows.Forms.Timer(this.components);
			this.labCopyright = new System.Windows.Forms.Label();
			this.checkInfSpells = new System.Windows.Forms.CheckBox();
			this.groupItems = new System.Windows.Forms.GroupBox();
			this.radioItemsReverse = new System.Windows.Forms.RadioButton();
			this.radioItemsNoCons = new System.Windows.Forms.RadioButton();
			this.radioItemsOff = new System.Windows.Forms.RadioButton();
			this.groupSouls = new System.Windows.Forms.GroupBox();
			this.checkSoulsReverse = new System.Windows.Forms.CheckBox();
			this.featureSouls = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureGainedSouls = new Dark_Souls_2_Trainer.FeatureControl();
			this.labReverseWarn = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupItemSlots = new System.Windows.Forms.GroupBox();
			this.featureSlot4 = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureSlot3 = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureSlot2 = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureSlot1 = new Dark_Souls_2_Trainer.FeatureControl();
			this.butUpdate = new System.Windows.Forms.Button();
			this.labGameVer = new System.Windows.Forms.Label();
			this.groupTestFeature = new System.Windows.Forms.GroupBox();
			this.comboNullDmgOnHP = new System.Windows.Forms.ComboBox();
			this.checkNullDmgOnHP = new System.Windows.Forms.CheckBox();
			this.checkInfHeath = new System.Windows.Forms.CheckBox();
			this.featureStamina = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureHealth = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureTorchlight = new Dark_Souls_2_Trainer.FeatureControl();
			this.timerCheckHP = new System.Windows.Forms.Timer(this.components);
			this.featureMaxHealth = new Dark_Souls_2_Trainer.FeatureControl();
			this.featureMaxStamina = new Dark_Souls_2_Trainer.FeatureControl();
			this.groupItems.SuspendLayout();
			this.groupSouls.SuspendLayout();
			this.groupItemSlots.SuspendLayout();
			this.groupTestFeature.SuspendLayout();
			this.SuspendLayout();
			// 
			// labStatus
			// 
			this.labStatus.AutoSize = true;
			this.labStatus.Location = new System.Drawing.Point(4, 9);
			this.labStatus.Name = "labStatus";
			this.labStatus.Size = new System.Drawing.Size(40, 13);
			this.labStatus.TabIndex = 2;
			this.labStatus.Text = "Status:";
			// 
			// labStatusInfo
			// 
			this.labStatusInfo.AutoSize = true;
			this.labStatusInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labStatusInfo.ForeColor = System.Drawing.Color.Red;
			this.labStatusInfo.Location = new System.Drawing.Point(42, 9);
			this.labStatusInfo.Name = "labStatusInfo";
			this.labStatusInfo.Size = new System.Drawing.Size(156, 13);
			this.labStatusInfo.TabIndex = 3;
			this.labStatusInfo.Text = "Waiting for the game...";
			// 
			// timerProcessWait
			// 
			this.timerProcessWait.Enabled = true;
			this.timerProcessWait.Tick += new System.EventHandler(this.timerProcessWait_Tick);
			// 
			// labCopyright
			// 
			this.labCopyright.AutoSize = true;
			this.labCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCopyright.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labCopyright.Location = new System.Drawing.Point(225, 7);
			this.labCopyright.Name = "labCopyright";
			this.labCopyright.Size = new System.Drawing.Size(196, 15);
			this.labCopyright.TabIndex = 11;
			this.labCopyright.Text = "Copyright © 2014-2015 applusplus";
			// 
			// checkInfSpells
			// 
			this.checkInfSpells.AutoSize = true;
			this.checkInfSpells.Location = new System.Drawing.Point(7, 336);
			this.checkInfSpells.Name = "checkInfSpells";
			this.checkInfSpells.Size = new System.Drawing.Size(163, 17);
			this.checkInfSpells.TabIndex = 9;
			this.checkInfSpells.Text = "No Spells consume (freeze**)";
			this.checkInfSpells.UseVisualStyleBackColor = true;
			this.checkInfSpells.CheckedChanged += new System.EventHandler(this.checkInfSpells_CheckedChanged);
			// 
			// groupItems
			// 
			this.groupItems.Controls.Add(this.radioItemsReverse);
			this.groupItems.Controls.Add(this.radioItemsNoCons);
			this.groupItems.Controls.Add(this.radioItemsOff);
			this.groupItems.Location = new System.Drawing.Point(2, 290);
			this.groupItems.Name = "groupItems";
			this.groupItems.Size = new System.Drawing.Size(409, 39);
			this.groupItems.TabIndex = 14;
			this.groupItems.TabStop = false;
			this.groupItems.Text = "Items";
			// 
			// radioItemsReverse
			// 
			this.radioItemsReverse.AutoSize = true;
			this.radioItemsReverse.Location = new System.Drawing.Point(251, 16);
			this.radioItemsReverse.Name = "radioItemsReverse";
			this.radioItemsReverse.Size = new System.Drawing.Size(110, 17);
			this.radioItemsReverse.TabIndex = 8;
			this.radioItemsReverse.TabStop = true;
			this.radioItemsReverse.Text = "reverse consume*";
			this.radioItemsReverse.UseVisualStyleBackColor = true;
			this.radioItemsReverse.CheckedChanged += new System.EventHandler(this.radioItemsReverse_CheckedChanged);
			// 
			// radioItemsNoCons
			// 
			this.radioItemsNoCons.AutoSize = true;
			this.radioItemsNoCons.Location = new System.Drawing.Point(113, 16);
			this.radioItemsNoCons.Name = "radioItemsNoCons";
			this.radioItemsNoCons.Size = new System.Drawing.Size(129, 17);
			this.radioItemsNoCons.TabIndex = 7;
			this.radioItemsNoCons.TabStop = true;
			this.radioItemsNoCons.Text = "no consume (freeze**)";
			this.radioItemsNoCons.UseVisualStyleBackColor = true;
			this.radioItemsNoCons.CheckedChanged += new System.EventHandler(this.radioItemsNoCons_CheckedChanged);
			// 
			// radioItemsOff
			// 
			this.radioItemsOff.AutoSize = true;
			this.radioItemsOff.Checked = true;
			this.radioItemsOff.Location = new System.Drawing.Point(5, 16);
			this.radioItemsOff.Name = "radioItemsOff";
			this.radioItemsOff.Size = new System.Drawing.Size(39, 17);
			this.radioItemsOff.TabIndex = 6;
			this.radioItemsOff.TabStop = true;
			this.radioItemsOff.Text = "Off";
			this.radioItemsOff.UseVisualStyleBackColor = true;
			this.radioItemsOff.CheckedChanged += new System.EventHandler(this.radioItemsOff_CheckedChanged);
			// 
			// groupSouls
			// 
			this.groupSouls.Controls.Add(this.checkSoulsReverse);
			this.groupSouls.Controls.Add(this.featureSouls);
			this.groupSouls.Controls.Add(this.featureGainedSouls);
			this.groupSouls.Location = new System.Drawing.Point(2, 25);
			this.groupSouls.Name = "groupSouls";
			this.groupSouls.Size = new System.Drawing.Size(416, 107);
			this.groupSouls.TabIndex = 15;
			this.groupSouls.TabStop = false;
			this.groupSouls.Text = "Souls";
			// 
			// checkSoulsReverse
			// 
			this.checkSoulsReverse.AutoSize = true;
			this.checkSoulsReverse.Location = new System.Drawing.Point(10, 50);
			this.checkSoulsReverse.Name = "checkSoulsReverse";
			this.checkSoulsReverse.Size = new System.Drawing.Size(143, 17);
			this.checkSoulsReverse.TabIndex = 1;
			this.checkSoulsReverse.Text = "Reverse souls consume*";
			this.checkSoulsReverse.UseVisualStyleBackColor = true;
			this.checkSoulsReverse.CheckedChanged += new System.EventHandler(this.checkSoulsReverse_CheckedChanged);
			// 
			// featureSouls
			// 
			this.featureSouls.Location = new System.Drawing.Point(5, 19);
			this.featureSouls.Name = "featureSouls";
			this.featureSouls.Size = new System.Drawing.Size(409, 25);
			this.featureSouls.TabIndex = 0;
			// 
			// featureGainedSouls
			// 
			this.featureGainedSouls.Location = new System.Drawing.Point(5, 73);
			this.featureGainedSouls.Name = "featureGainedSouls";
			this.featureGainedSouls.Size = new System.Drawing.Size(409, 24);
			this.featureGainedSouls.TabIndex = 2;
			// 
			// labReverseWarn
			// 
			this.labReverseWarn.AutoSize = true;
			this.labReverseWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labReverseWarn.Location = new System.Drawing.Point(4, 389);
			this.labReverseWarn.Name = "labReverseWarn";
			this.labReverseWarn.Size = new System.Drawing.Size(376, 15);
			this.labReverseWarn.TabIndex = 16;
			this.labReverseWarn.Text = "*Be careful, it is reversing subtraction but also addition. Use it wisely!";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 408);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "**Freeze means that the current value stay unchanged. Use it wisely!";
			// 
			// groupItemSlots
			// 
			this.groupItemSlots.Controls.Add(this.featureSlot4);
			this.groupItemSlots.Controls.Add(this.featureSlot3);
			this.groupItemSlots.Controls.Add(this.featureSlot2);
			this.groupItemSlots.Controls.Add(this.featureSlot1);
			this.groupItemSlots.Location = new System.Drawing.Point(424, 28);
			this.groupItemSlots.Name = "groupItemSlots";
			this.groupItemSlots.Size = new System.Drawing.Size(421, 128);
			this.groupItemSlots.TabIndex = 18;
			this.groupItemSlots.TabStop = false;
			this.groupItemSlots.Text = "Chosen Items";
			// 
			// featureSlot4
			// 
			this.featureSlot4.Location = new System.Drawing.Point(2, 98);
			this.featureSlot4.Name = "featureSlot4";
			this.featureSlot4.Size = new System.Drawing.Size(416, 24);
			this.featureSlot4.TabIndex = 13;
			// 
			// featureSlot3
			// 
			this.featureSlot3.Location = new System.Drawing.Point(2, 72);
			this.featureSlot3.Name = "featureSlot3";
			this.featureSlot3.Size = new System.Drawing.Size(416, 24);
			this.featureSlot3.TabIndex = 12;
			// 
			// featureSlot2
			// 
			this.featureSlot2.Location = new System.Drawing.Point(2, 46);
			this.featureSlot2.Name = "featureSlot2";
			this.featureSlot2.Size = new System.Drawing.Size(416, 24);
			this.featureSlot2.TabIndex = 11;
			// 
			// featureSlot1
			// 
			this.featureSlot1.Location = new System.Drawing.Point(2, 20);
			this.featureSlot1.Name = "featureSlot1";
			this.featureSlot1.Size = new System.Drawing.Size(416, 24);
			this.featureSlot1.TabIndex = 10;
			// 
			// butUpdate
			// 
			this.butUpdate.Location = new System.Drawing.Point(281, 356);
			this.butUpdate.Name = "butUpdate";
			this.butUpdate.Size = new System.Drawing.Size(132, 23);
			this.butUpdate.TabIndex = 20;
			this.butUpdate.Text = "Update edit boxes";
			this.butUpdate.UseVisualStyleBackColor = true;
			this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
			// 
			// labGameVer
			// 
			this.labGameVer.AutoSize = true;
			this.labGameVer.Location = new System.Drawing.Point(421, 9);
			this.labGameVer.Name = "labGameVer";
			this.labGameVer.Size = new System.Drawing.Size(112, 13);
			this.labGameVer.TabIndex = 99;
			this.labGameVer.Text = "For game version 1.02";
			// 
			// groupTestFeature
			// 
			this.groupTestFeature.Controls.Add(this.comboNullDmgOnHP);
			this.groupTestFeature.Controls.Add(this.checkNullDmgOnHP);
			this.groupTestFeature.Controls.Add(this.checkInfHeath);
			this.groupTestFeature.Location = new System.Drawing.Point(424, 156);
			this.groupTestFeature.Name = "groupTestFeature";
			this.groupTestFeature.Size = new System.Drawing.Size(421, 189);
			this.groupTestFeature.TabIndex = 100;
			this.groupTestFeature.TabStop = false;
			this.groupTestFeature.Text = "Test Features";
			// 
			// comboNullDmgOnHP
			// 
			this.comboNullDmgOnHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboNullDmgOnHP.FormattingEnabled = true;
			this.comboNullDmgOnHP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboNullDmgOnHP.Location = new System.Drawing.Point(190, 40);
			this.comboNullDmgOnHP.Name = "comboNullDmgOnHP";
			this.comboNullDmgOnHP.Size = new System.Drawing.Size(45, 21);
			this.comboNullDmgOnHP.TabIndex = 2;
			// 
			// checkNullDmgOnHP
			// 
			this.checkNullDmgOnHP.AutoSize = true;
			this.checkNullDmgOnHP.Location = new System.Drawing.Point(6, 42);
			this.checkNullDmgOnHP.Name = "checkNullDmgOnHP";
			this.checkNullDmgOnHP.Size = new System.Drawing.Size(181, 17);
			this.checkNullDmgOnHP.TabIndex = 1;
			this.checkNullDmgOnHP.Text = "Withdraw damage if HP is under:";
			this.checkNullDmgOnHP.UseVisualStyleBackColor = true;
			this.checkNullDmgOnHP.CheckedChanged += new System.EventHandler(this.checkNullDmgOnHP_CheckedChanged);
			// 
			// checkInfHeath
			// 
			this.checkInfHeath.AutoSize = true;
			this.checkInfHeath.Location = new System.Drawing.Point(6, 19);
			this.checkInfHeath.Name = "checkInfHeath";
			this.checkInfHeath.Size = new System.Drawing.Size(295, 17);
			this.checkInfHeath.TabIndex = 0;
			this.checkInfHeath.Text = "Withdraw damage for you and NPC´s (only good for PVP)";
			this.checkInfHeath.UseVisualStyleBackColor = true;
			this.checkInfHeath.CheckedChanged += new System.EventHandler(this.checkInfHeath_CheckedChanged);
			// 
			// featureStamina
			// 
			this.featureStamina.Location = new System.Drawing.Point(2, 258);
			this.featureStamina.Name = "featureStamina";
			this.featureStamina.Size = new System.Drawing.Size(416, 24);
			this.featureStamina.TabIndex = 5;
			// 
			// featureHealth
			// 
			this.featureHealth.Location = new System.Drawing.Point(2, 198);
			this.featureHealth.Name = "featureHealth";
			this.featureHealth.Size = new System.Drawing.Size(416, 24);
			this.featureHealth.TabIndex = 4;
			// 
			// featureTorchlight
			// 
			this.featureTorchlight.Location = new System.Drawing.Point(2, 138);
			this.featureTorchlight.Name = "featureTorchlight";
			this.featureTorchlight.Size = new System.Drawing.Size(409, 24);
			this.featureTorchlight.TabIndex = 3;
			// 
			// timerCheckHP
			// 
			this.timerCheckHP.Interval = 200;
			this.timerCheckHP.Tick += new System.EventHandler(this.timerCheckHP_Tick);
			// 
			// featureMaxHealth
			// 
			this.featureMaxHealth.Location = new System.Drawing.Point(2, 168);
			this.featureMaxHealth.Name = "featureMaxHealth";
			this.featureMaxHealth.Size = new System.Drawing.Size(416, 24);
			this.featureMaxHealth.TabIndex = 101;
			// 
			// featureMaxStamina
			// 
			this.featureMaxStamina.Location = new System.Drawing.Point(2, 228);
			this.featureMaxStamina.Name = "featureMaxStamina";
			this.featureMaxStamina.Size = new System.Drawing.Size(416, 24);
			this.featureMaxStamina.TabIndex = 102;
			// 
			// SoulForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 437);
			this.Controls.Add(this.featureMaxStamina);
			this.Controls.Add(this.featureMaxHealth);
			this.Controls.Add(this.groupTestFeature);
			this.Controls.Add(this.labGameVer);
			this.Controls.Add(this.butUpdate);
			this.Controls.Add(this.groupItemSlots);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labReverseWarn);
			this.Controls.Add(this.groupSouls);
			this.Controls.Add(this.groupItems);
			this.Controls.Add(this.checkInfSpells);
			this.Controls.Add(this.labCopyright);
			this.Controls.Add(this.featureStamina);
			this.Controls.Add(this.featureHealth);
			this.Controls.Add(this.featureTorchlight);
			this.Controls.Add(this.labStatusInfo);
			this.Controls.Add(this.labStatus);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SoulForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dark Souls 2: Scholar of the First Sin Trainer v1 :: Game Version 1.02";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoulForm_FormClosing);
			this.Load += new System.EventHandler(this.SoulForm_Load);
			this.groupItems.ResumeLayout(false);
			this.groupItems.PerformLayout();
			this.groupSouls.ResumeLayout(false);
			this.groupSouls.PerformLayout();
			this.groupItemSlots.ResumeLayout(false);
			this.groupTestFeature.ResumeLayout(false);
			this.groupTestFeature.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labStatusInfo;
        private System.Windows.Forms.Timer timerProcessWait;
        private FeatureControl featureSouls;
        private FeatureControl featureTorchlight;
        private FeatureControl featureGainedSouls;
        private FeatureControl featureHealth;
        private FeatureControl featureStamina;
        private System.Windows.Forms.Label labCopyright;
        private System.Windows.Forms.CheckBox checkInfSpells;
        private System.Windows.Forms.GroupBox groupItems;
        private System.Windows.Forms.RadioButton radioItemsOff;
        private System.Windows.Forms.RadioButton radioItemsReverse;
        private System.Windows.Forms.RadioButton radioItemsNoCons;
        private System.Windows.Forms.GroupBox groupSouls;
        private System.Windows.Forms.CheckBox checkSoulsReverse;
        private System.Windows.Forms.Label labReverseWarn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupItemSlots;
        private FeatureControl featureSlot1;
        private FeatureControl featureSlot3;
        private FeatureControl featureSlot2;
        private FeatureControl featureSlot4;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label labGameVer;
        private System.Windows.Forms.GroupBox groupTestFeature;
        private System.Windows.Forms.CheckBox checkInfHeath;
        private System.Windows.Forms.CheckBox checkNullDmgOnHP;
        private System.Windows.Forms.ComboBox comboNullDmgOnHP;
        private System.Windows.Forms.Timer timerCheckHP;
        private FeatureControl featureMaxHealth;
        private FeatureControl featureMaxStamina;
    }
}

