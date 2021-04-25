namespace Dark_Souls_2_Trainer
{
    partial class FeatureControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labDescript = new System.Windows.Forms.Label();
            this.labValue = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.butSet = new System.Windows.Forms.Button();
            this.checkFreeze = new System.Windows.Forms.CheckBox();
            this.timerFreeze = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labDescript
            // 
            this.labDescript.AutoSize = true;
            this.labDescript.Location = new System.Drawing.Point(2, 5);
            this.labDescript.Name = "labDescript";
            this.labDescript.Size = new System.Drawing.Size(54, 13);
            this.labDescript.TabIndex = 4;
            this.labDescript.Text = "labelDesc";
            // 
            // labValue
            // 
            this.labValue.AutoSize = true;
            this.labValue.Location = new System.Drawing.Point(105, 5);
            this.labValue.Name = "labValue";
            this.labValue.Size = new System.Drawing.Size(61, 13);
            this.labValue.TabIndex = 1;
            this.labValue.Text = "                  ";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(172, 2);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(84, 20);
            this.textValue.TabIndex = 1;
            // 
            // butSet
            // 
            this.butSet.Location = new System.Drawing.Point(273, 0);
            this.butSet.Name = "butSet";
            this.butSet.Size = new System.Drawing.Size(75, 23);
            this.butSet.TabIndex = 3;
            this.butSet.Text = "Set";
            this.butSet.UseVisualStyleBackColor = true;
            this.butSet.Click += new System.EventHandler(this.butSet_Click);
            // 
            // checkFreeze
            // 
            this.checkFreeze.AutoSize = true;
            this.checkFreeze.Location = new System.Drawing.Point(354, 4);
            this.checkFreeze.Name = "checkFreeze";
            this.checkFreeze.Size = new System.Drawing.Size(58, 17);
            this.checkFreeze.TabIndex = 4;
            this.checkFreeze.Text = "Freeze";
            this.checkFreeze.UseVisualStyleBackColor = true;
            this.checkFreeze.CheckedChanged += new System.EventHandler(this.checkFreeze_CheckedChanged);
            // 
            // timerFreeze
            // 
            this.timerFreeze.Interval = 200;
            this.timerFreeze.Tick += new System.EventHandler(this.timerFreeze_Tick);
            // 
            // FeatureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkFreeze);
            this.Controls.Add(this.butSet);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.labValue);
            this.Controls.Add(this.labDescript);
            this.Name = "FeatureControl";
            this.Size = new System.Drawing.Size(416, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDescript;
        private System.Windows.Forms.Label labValue;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button butSet;
        private System.Windows.Forms.CheckBox checkFreeze;
        private System.Windows.Forms.Timer timerFreeze;
    }
}
