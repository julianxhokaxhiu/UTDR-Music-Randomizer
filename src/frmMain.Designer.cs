namespace UTDR_Music_Randomizer
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrowsePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.cbOptSFX = new System.Windows.Forms.CheckBox();
            this.cbOptAmbience = new System.Windows.Forms.CheckBox();
            this.cbOptCredits = new System.Windows.Forms.CheckBox();
            this.cbOptMultiPart = new System.Windows.Forms.CheckBox();
            this.cbOptCyberBattle = new System.Windows.Forms.CheckBox();
            this.cbOptSpeedrunLegal = new System.Windows.Forms.CheckBox();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnRestoreFromBackup = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please locate Undertale/Deltarune\'s install path:";
            // 
            // txtBrowsePath
            // 
            this.txtBrowsePath.Location = new System.Drawing.Point(12, 36);
            this.txtBrowsePath.Name = "txtBrowsePath";
            this.txtBrowsePath.ReadOnly = true;
            this.txtBrowsePath.Size = new System.Drawing.Size(300, 23);
            this.txtBrowsePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(318, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.cbOptSFX);
            this.grpOptions.Controls.Add(this.cbOptAmbience);
            this.grpOptions.Controls.Add(this.cbOptCredits);
            this.grpOptions.Controls.Add(this.cbOptMultiPart);
            this.grpOptions.Controls.Add(this.cbOptCyberBattle);
            this.grpOptions.Controls.Add(this.cbOptSpeedrunLegal);
            this.grpOptions.Location = new System.Drawing.Point(12, 65);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(424, 182);
            this.grpOptions.TabIndex = 3;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // cbOptSFX
            // 
            this.cbOptSFX.AutoSize = true;
            this.cbOptSFX.Location = new System.Drawing.Point(6, 147);
            this.cbOptSFX.Name = "cbOptSFX";
            this.cbOptSFX.Size = new System.Drawing.Size(308, 19);
            this.cbOptSFX.TabIndex = 5;
            this.cbOptSFX.Text = "Include jingles and SFX ( may have VERY BAD results )";
            this.cbOptSFX.UseVisualStyleBackColor = true;
            // 
            // cbOptAmbience
            // 
            this.cbOptAmbience.AutoSize = true;
            this.cbOptAmbience.Location = new System.Drawing.Point(6, 122);
            this.cbOptAmbience.Name = "cbOptAmbience";
            this.cbOptAmbience.Size = new System.Drawing.Size(153, 19);
            this.cbOptAmbience.TabIndex = 4;
            this.cbOptAmbience.Text = "Include ambient sounds";
            this.cbOptAmbience.UseVisualStyleBackColor = true;
            // 
            // cbOptCredits
            // 
            this.cbOptCredits.AutoSize = true;
            this.cbOptCredits.Location = new System.Drawing.Point(6, 97);
            this.cbOptCredits.Name = "cbOptCredits";
            this.cbOptCredits.Size = new System.Drawing.Size(137, 19);
            this.cbOptCredits.TabIndex = 3;
            this.cbOptCredits.Text = "Include credits songs";
            this.cbOptCredits.UseVisualStyleBackColor = true;
            // 
            // cbOptMultiPart
            // 
            this.cbOptMultiPart.AutoSize = true;
            this.cbOptMultiPart.Location = new System.Drawing.Point(6, 72);
            this.cbOptMultiPart.Name = "cbOptMultiPart";
            this.cbOptMultiPart.Size = new System.Drawing.Size(279, 19);
            this.cbOptMultiPart.TabIndex = 2;
            this.cbOptMultiPart.Text = "Include Your Best Nightmare + Finale ( UT only )";
            this.cbOptMultiPart.UseVisualStyleBackColor = true;
            // 
            // cbOptCyberBattle
            // 
            this.cbOptCyberBattle.AutoSize = true;
            this.cbOptCyberBattle.Location = new System.Drawing.Point(6, 47);
            this.cbOptCyberBattle.Name = "cbOptCyberBattle";
            this.cbOptCyberBattle.Size = new System.Drawing.Size(371, 19);
            this.cbOptCyberBattle.TabIndex = 1;
            this.cbOptCyberBattle.Text = "Include cyber_battle_prelude.ogg ( DR only, may cause softlocks )";
            this.cbOptCyberBattle.UseVisualStyleBackColor = true;
            // 
            // cbOptSpeedrunLegal
            // 
            this.cbOptSpeedrunLegal.AutoSize = true;
            this.cbOptSpeedrunLegal.Location = new System.Drawing.Point(6, 22);
            this.cbOptSpeedrunLegal.Name = "cbOptSpeedrunLegal";
            this.cbOptSpeedrunLegal.Size = new System.Drawing.Size(329, 19);
            this.cbOptSpeedrunLegal.TabIndex = 0;
            this.cbOptSpeedrunLegal.Text = "Include cyber.ogg and mansion.ogg ( applies to DR only )";
            this.cbOptSpeedrunLegal.UseVisualStyleBackColor = true;
            // 
            // btnRandomize
            // 
            this.btnRandomize.Enabled = false;
            this.btnRandomize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandomize.Location = new System.Drawing.Point(12, 253);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(424, 32);
            this.btnRandomize.TabIndex = 4;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnRestoreFromBackup
            // 
            this.btnRestoreFromBackup.Enabled = false;
            this.btnRestoreFromBackup.Location = new System.Drawing.Point(12, 291);
            this.btnRestoreFromBackup.Name = "btnRestoreFromBackup";
            this.btnRestoreFromBackup.Size = new System.Drawing.Size(424, 23);
            this.btnRestoreFromBackup.TabIndex = 5;
            this.btnRestoreFromBackup.Text = "Restore from backup";
            this.btnRestoreFromBackup.UseVisualStyleBackColor = true;
            this.btnRestoreFromBackup.Click += new System.EventHandler(this.btnRestoreFromBackup_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(449, 321);
            this.Controls.Add(this.btnRestoreFromBackup);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBrowsePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "UTDR-Music-Randomizer";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBrowsePath;
        private Button btnBrowse;
        private GroupBox grpOptions;
        private CheckBox cbOptSFX;
        private CheckBox cbOptAmbience;
        private CheckBox cbOptCredits;
        private CheckBox cbOptMultiPart;
        private CheckBox cbOptCyberBattle;
        private CheckBox cbOptSpeedrunLegal;
        private Button btnRandomize;
        private Button btnRestoreFromBackup;
    }
}