namespace FindNumber
{
    partial class MainForm
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguageSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTurkish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRulesAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRules = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbComputerSide = new System.Windows.Forms.GroupBox();
            this.btnCSEnterResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCSNeg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCSPos = new System.Windows.Forms.TextBox();
            this.tbCSGuess = new System.Windows.Forms.TextBox();
            this.lblCSResultListCap = new System.Windows.Forms.Label();
            this.lblCSBasTahmin = new System.Windows.Forms.Label();
            this.rtbCSResult = new System.Windows.Forms.RichTextBox();
            this.gbUserSide = new System.Windows.Forms.GroupBox();
            this.lblUSResultListCap = new System.Windows.Forms.Label();
            this.btnUSCheck = new System.Windows.Forms.Button();
            this.lblUSResult = new System.Windows.Forms.Label();
            this.lblUSBasTahmin = new System.Windows.Forms.Label();
            this.tbUSGuess = new System.Windows.Forms.TextBox();
            this.rtbUSResultList = new System.Windows.Forms.RichTextBox();
            this.msMenu.SuspendLayout();
            this.gbComputerSide.SuspendLayout();
            this.gbUserSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOperations,
            this.tsmiLanguageSettings,
            this.tsmiRulesAbout});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(495, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiOperations
            // 
            this.tsmiOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tsmiPlayAgain,
            this.tsmiExit});
            this.tsmiOperations.Name = "tsmiOperations";
            this.tsmiOperations.Size = new System.Drawing.Size(60, 20);
            this.tsmiOperations.Text = "Islemler";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(148, 22);
            this.tsmiStart.Text = "Oyuna Başla";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // tsmiPlayAgain
            // 
            this.tsmiPlayAgain.Enabled = false;
            this.tsmiPlayAgain.Name = "tsmiPlayAgain";
            this.tsmiPlayAgain.Size = new System.Drawing.Size(148, 22);
            this.tsmiPlayAgain.Text = "Yeniden Oyna";
            this.tsmiPlayAgain.Click += new System.EventHandler(this.tsmiPlayAgain_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiExit.Text = "Çıkış";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiLanguageSettings
            // 
            this.tsmiLanguageSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTurkish,
            this.tsmiEnglish});
            this.tsmiLanguageSettings.Name = "tsmiLanguageSettings";
            this.tsmiLanguageSettings.Size = new System.Drawing.Size(63, 20);
            this.tsmiLanguageSettings.Text = "Dil Ayarı";
            // 
            // tsmiTurkish
            // 
            this.tsmiTurkish.Name = "tsmiTurkish";
            this.tsmiTurkish.Size = new System.Drawing.Size(117, 22);
            this.tsmiTurkish.Text = "Türkçe";
            this.tsmiTurkish.Click += new System.EventHandler(this.tsmiTurkish_Click);
            // 
            // tsmiEnglish
            // 
            this.tsmiEnglish.Name = "tsmiEnglish";
            this.tsmiEnglish.Size = new System.Drawing.Size(117, 22);
            this.tsmiEnglish.Text = "İngilizce";
            this.tsmiEnglish.Click += new System.EventHandler(this.tsmiEnglish_Click);
            // 
            // tsmiRulesAbout
            // 
            this.tsmiRulesAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRules,
            this.tsmiAbout});
            this.tsmiRulesAbout.Name = "tsmiRulesAbout";
            this.tsmiRulesAbout.Size = new System.Drawing.Size(57, 20);
            this.tsmiRulesAbout.Text = "Yardım";
            // 
            // tsmiRules
            // 
            this.tsmiRules.Name = "tsmiRules";
            this.tsmiRules.Size = new System.Drawing.Size(163, 22);
            this.tsmiRules.Text = "Oyunun Kuralları";
            this.tsmiRules.Click += new System.EventHandler(this.tsmiRules_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(163, 22);
            this.tsmiAbout.Text = "Hakkında";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // gbComputerSide
            // 
            this.gbComputerSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbComputerSide.Controls.Add(this.btnCSEnterResult);
            this.gbComputerSide.Controls.Add(this.label3);
            this.gbComputerSide.Controls.Add(this.tbCSNeg);
            this.gbComputerSide.Controls.Add(this.label2);
            this.gbComputerSide.Controls.Add(this.tbCSPos);
            this.gbComputerSide.Controls.Add(this.tbCSGuess);
            this.gbComputerSide.Controls.Add(this.lblCSResultListCap);
            this.gbComputerSide.Controls.Add(this.lblCSBasTahmin);
            this.gbComputerSide.Controls.Add(this.rtbCSResult);
            this.gbComputerSide.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbComputerSide.Location = new System.Drawing.Point(0, 30);
            this.gbComputerSide.Name = "gbComputerSide";
            this.gbComputerSide.Size = new System.Drawing.Size(495, 210);
            this.gbComputerSide.TabIndex = 1;
            this.gbComputerSide.TabStop = false;
            this.gbComputerSide.Text = "Bilgisayar Bölümü";
            // 
            // btnCSEnterResult
            // 
            this.btnCSEnterResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCSEnterResult.Location = new System.Drawing.Point(16, 148);
            this.btnCSEnterResult.Name = "btnCSEnterResult";
            this.btnCSEnterResult.Size = new System.Drawing.Size(149, 32);
            this.btnCSEnterResult.TabIndex = 4;
            this.btnCSEnterResult.Text = "Sonucu İşle";
            this.btnCSEnterResult.UseVisualStyleBackColor = true;
            this.btnCSEnterResult.Click += new System.EventHandler(this.btnCSEnterResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            // 
            // tbCSNeg
            // 
            this.tbCSNeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCSNeg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCSNeg.Location = new System.Drawing.Point(120, 112);
            this.tbCSNeg.MaxLength = 1;
            this.tbCSNeg.Name = "tbCSNeg";
            this.tbCSNeg.Size = new System.Drawing.Size(45, 23);
            this.tbCSNeg.TabIndex = 3;
            this.tbCSNeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCSNeg_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "+";
            // 
            // tbCSPos
            // 
            this.tbCSPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCSPos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCSPos.Location = new System.Drawing.Point(37, 112);
            this.tbCSPos.MaxLength = 1;
            this.tbCSPos.Name = "tbCSPos";
            this.tbCSPos.Size = new System.Drawing.Size(45, 23);
            this.tbCSPos.TabIndex = 2;
            this.tbCSPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCSPos_KeyPress);
            // 
            // tbCSGuess
            // 
            this.tbCSGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCSGuess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCSGuess.Location = new System.Drawing.Point(74, 70);
            this.tbCSGuess.Name = "tbCSGuess";
            this.tbCSGuess.ReadOnly = true;
            this.tbCSGuess.Size = new System.Drawing.Size(91, 23);
            this.tbCSGuess.TabIndex = 99;
            this.tbCSGuess.TabStop = false;
            // 
            // lblCSResultListCap
            // 
            this.lblCSResultListCap.AutoSize = true;
            this.lblCSResultListCap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCSResultListCap.Location = new System.Drawing.Point(205, 18);
            this.lblCSResultListCap.Name = "lblCSResultListCap";
            this.lblCSResultListCap.Size = new System.Drawing.Size(73, 16);
            this.lblCSResultListCap.TabIndex = 7;
            this.lblCSResultListCap.Text = "Sonuçlar :";
            // 
            // lblCSBasTahmin
            // 
            this.lblCSBasTahmin.AutoSize = true;
            this.lblCSBasTahmin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCSBasTahmin.Location = new System.Drawing.Point(6, 75);
            this.lblCSBasTahmin.Name = "lblCSBasTahmin";
            this.lblCSBasTahmin.Size = new System.Drawing.Size(62, 16);
            this.lblCSBasTahmin.TabIndex = 4;
            this.lblCSBasTahmin.Text = "Tahmin :";
            // 
            // rtbCSResult
            // 
            this.rtbCSResult.BackColor = System.Drawing.Color.White;
            this.rtbCSResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCSResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbCSResult.Location = new System.Drawing.Point(205, 42);
            this.rtbCSResult.Name = "rtbCSResult";
            this.rtbCSResult.ReadOnly = true;
            this.rtbCSResult.Size = new System.Drawing.Size(280, 160);
            this.rtbCSResult.TabIndex = 99;
            this.rtbCSResult.TabStop = false;
            this.rtbCSResult.Text = "";
            // 
            // gbUserSide
            // 
            this.gbUserSide.Controls.Add(this.lblUSResultListCap);
            this.gbUserSide.Controls.Add(this.btnUSCheck);
            this.gbUserSide.Controls.Add(this.lblUSResult);
            this.gbUserSide.Controls.Add(this.lblUSBasTahmin);
            this.gbUserSide.Controls.Add(this.tbUSGuess);
            this.gbUserSide.Controls.Add(this.rtbUSResultList);
            this.gbUserSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUserSide.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUserSide.Location = new System.Drawing.Point(0, 249);
            this.gbUserSide.Name = "gbUserSide";
            this.gbUserSide.Size = new System.Drawing.Size(495, 210);
            this.gbUserSide.TabIndex = 5;
            this.gbUserSide.TabStop = false;
            this.gbUserSide.Text = "Kullanıcı Bölümü";
            // 
            // lblUSResultListCap
            // 
            this.lblUSResultListCap.AutoSize = true;
            this.lblUSResultListCap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUSResultListCap.Location = new System.Drawing.Point(205, 20);
            this.lblUSResultListCap.Name = "lblUSResultListCap";
            this.lblUSResultListCap.Size = new System.Drawing.Size(73, 16);
            this.lblUSResultListCap.TabIndex = 6;
            this.lblUSResultListCap.Text = "Sonuçlar :";
            // 
            // btnUSCheck
            // 
            this.btnUSCheck.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUSCheck.Location = new System.Drawing.Point(16, 107);
            this.btnUSCheck.Name = "btnUSCheck";
            this.btnUSCheck.Size = new System.Drawing.Size(149, 32);
            this.btnUSCheck.TabIndex = 7;
            this.btnUSCheck.Text = "Kontrol Et";
            this.btnUSCheck.UseVisualStyleBackColor = true;
            this.btnUSCheck.Click += new System.EventHandler(this.btnUSCheck_Click);
            // 
            // lblUSResult
            // 
            this.lblUSResult.AutoSize = true;
            this.lblUSResult.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUSResult.Location = new System.Drawing.Point(61, 151);
            this.lblUSResult.Name = "lblUSResult";
            this.lblUSResult.Size = new System.Drawing.Size(75, 33);
            this.lblUSResult.TabIndex = 4;
            this.lblUSResult.Text = "-----";
            this.lblUSResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUSBasTahmin
            // 
            this.lblUSBasTahmin.AutoSize = true;
            this.lblUSBasTahmin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUSBasTahmin.Location = new System.Drawing.Point(6, 75);
            this.lblUSBasTahmin.Name = "lblUSBasTahmin";
            this.lblUSBasTahmin.Size = new System.Drawing.Size(62, 16);
            this.lblUSBasTahmin.TabIndex = 3;
            this.lblUSBasTahmin.Text = "Tahmin :";
            // 
            // tbUSGuess
            // 
            this.tbUSGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUSGuess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUSGuess.Location = new System.Drawing.Point(77, 68);
            this.tbUSGuess.MaxLength = 4;
            this.tbUSGuess.Name = "tbUSGuess";
            this.tbUSGuess.Size = new System.Drawing.Size(87, 23);
            this.tbUSGuess.TabIndex = 6;
            this.tbUSGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUSGuess_KeyPress);
            // 
            // rtbUSResultList
            // 
            this.rtbUSResultList.BackColor = System.Drawing.Color.White;
            this.rtbUSResultList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbUSResultList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbUSResultList.Location = new System.Drawing.Point(205, 42);
            this.rtbUSResultList.Name = "rtbUSResultList";
            this.rtbUSResultList.ReadOnly = true;
            this.rtbUSResultList.Size = new System.Drawing.Size(280, 160);
            this.rtbUSResultList.TabIndex = 99;
            this.rtbUSResultList.TabStop = false;
            this.rtbUSResultList.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 459);
            this.Controls.Add(this.gbUserSide);
            this.Controls.Add(this.gbComputerSide);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Bulma Oyunu";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbComputerSide.ResumeLayout(false);
            this.gbComputerSide.PerformLayout();
            this.gbUserSide.ResumeLayout(false);
            this.gbUserSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperations;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayAgain;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguageSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurkish;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnglish;
        private System.Windows.Forms.ToolStripMenuItem tsmiRulesAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiRules;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.GroupBox gbComputerSide;
        private System.Windows.Forms.Button btnCSEnterResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCSNeg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCSPos;
        private System.Windows.Forms.TextBox tbCSGuess;
        private System.Windows.Forms.Label lblCSResultListCap;
        private System.Windows.Forms.Label lblCSBasTahmin;
        private System.Windows.Forms.RichTextBox rtbCSResult;
        private System.Windows.Forms.GroupBox gbUserSide;
        private System.Windows.Forms.Label lblUSResultListCap;
        private System.Windows.Forms.Button btnUSCheck;
        private System.Windows.Forms.Label lblUSResult;
        private System.Windows.Forms.Label lblUSBasTahmin;
        private System.Windows.Forms.TextBox tbUSGuess;
        private System.Windows.Forms.RichTextBox rtbUSResultList;
    }
}

