namespace McGinn_Joseph_Analyzers
{
    partial class GameForm
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
            this.PlayArea = new System.Windows.Forms.Panel();
            this.PlayBox = new System.Windows.Forms.GroupBox();
            this.Guesses = new System.Windows.Forms.Label();
            this.GuessIndic = new System.Windows.Forms.Label();
            this.GuessButton = new System.Windows.Forms.Button();
            this.RowBox = new System.Windows.Forms.TextBox();
            this.ColBox = new System.Windows.Forms.TextBox();
            this.RowPrompt = new System.Windows.Forms.Label();
            this.ColumnPropt = new System.Windows.Forms.Label();
            this.ConfigBox = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.RadioFingerprints = new System.Windows.Forms.RadioButton();
            this.RadioDNA = new System.Windows.Forms.RadioButton();
            this.RadioWeapons = new System.Windows.Forms.RadioButton();
            this.TAnalyzerPrompt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RowMarker = new System.Windows.Forms.Label();
            this.ColMarkers = new System.Windows.Forms.Label();
            this.PlayText = new System.Windows.Forms.Label();
            this.CollectedLabel = new System.Windows.Forms.Label();
            this.FileNameLable = new System.Windows.Forms.Label();
            this.CaseLabel = new System.Windows.Forms.Label();
            this.CaseInfoBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayBox.SuspendLayout();
            this.ConfigBox.SuspendLayout();
            this.CaseInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayArea
            // 
            this.PlayArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayArea.Location = new System.Drawing.Point(54, 38);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(500, 500);
            this.PlayArea.TabIndex = 0;
            // 
            // PlayBox
            // 
            this.PlayBox.Controls.Add(this.Guesses);
            this.PlayBox.Controls.Add(this.GuessIndic);
            this.PlayBox.Controls.Add(this.GuessButton);
            this.PlayBox.Controls.Add(this.RowBox);
            this.PlayBox.Controls.Add(this.ColBox);
            this.PlayBox.Controls.Add(this.RowPrompt);
            this.PlayBox.Controls.Add(this.ColumnPropt);
            this.PlayBox.Location = new System.Drawing.Point(593, 47);
            this.PlayBox.Name = "PlayBox";
            this.PlayBox.Size = new System.Drawing.Size(276, 151);
            this.PlayBox.TabIndex = 1;
            this.PlayBox.TabStop = false;
            this.PlayBox.Text = "Play";
            // 
            // Guesses
            // 
            this.Guesses.AutoSize = true;
            this.Guesses.Location = new System.Drawing.Point(112, 118);
            this.Guesses.Name = "Guesses";
            this.Guesses.Size = new System.Drawing.Size(0, 13);
            this.Guesses.TabIndex = 6;
            // 
            // GuessIndic
            // 
            this.GuessIndic.AutoSize = true;
            this.GuessIndic.Location = new System.Drawing.Point(41, 118);
            this.GuessIndic.Name = "GuessIndic";
            this.GuessIndic.Size = new System.Drawing.Size(51, 13);
            this.GuessIndic.TabIndex = 5;
            this.GuessIndic.Text = "Guesses:";
            // 
            // GuessButton
            // 
            this.GuessButton.Enabled = false;
            this.GuessButton.Location = new System.Drawing.Point(177, 50);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(80, 45);
            this.GuessButton.TabIndex = 4;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // RowBox
            // 
            this.RowBox.Location = new System.Drawing.Point(115, 80);
            this.RowBox.MaxLength = 2;
            this.RowBox.Name = "RowBox";
            this.RowBox.Size = new System.Drawing.Size(28, 20);
            this.RowBox.TabIndex = 3;
            // 
            // ColBox
            // 
            this.ColBox.Location = new System.Drawing.Point(115, 46);
            this.ColBox.MaxLength = 2;
            this.ColBox.Name = "ColBox";
            this.ColBox.Size = new System.Drawing.Size(28, 20);
            this.ColBox.TabIndex = 2;
            // 
            // RowPrompt
            // 
            this.RowPrompt.AutoSize = true;
            this.RowPrompt.Location = new System.Drawing.Point(41, 83);
            this.RowPrompt.Name = "RowPrompt";
            this.RowPrompt.Size = new System.Drawing.Size(47, 13);
            this.RowPrompt.TabIndex = 1;
            this.RowPrompt.Text = "= Row =";
            // 
            // ColumnPropt
            // 
            this.ColumnPropt.AutoSize = true;
            this.ColumnPropt.Location = new System.Drawing.Point(41, 45);
            this.ColumnPropt.Name = "ColumnPropt";
            this.ColumnPropt.Size = new System.Drawing.Size(52, 13);
            this.ColumnPropt.TabIndex = 0;
            this.ColumnPropt.Text = "| Column |";
            // 
            // ConfigBox
            // 
            this.ConfigBox.Controls.Add(this.LoadButton);
            this.ConfigBox.Controls.Add(this.FileLocation);
            this.ConfigBox.Controls.Add(this.RadioFingerprints);
            this.ConfigBox.Controls.Add(this.RadioDNA);
            this.ConfigBox.Controls.Add(this.RadioWeapons);
            this.ConfigBox.Controls.Add(this.TAnalyzerPrompt);
            this.ConfigBox.Controls.Add(this.label1);
            this.ConfigBox.Location = new System.Drawing.Point(593, 378);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(276, 160);
            this.ConfigBox.TabIndex = 2;
            this.ConfigBox.TabStop = false;
            this.ConfigBox.Text = "config";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(94, 121);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(81, 32);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(26, 39);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(232, 20);
            this.FileLocation.TabIndex = 5;
            this.FileLocation.Text = "Q:\\c projects\\C# projects\\McGinn-Joseph-Analyzers\\McGinn-Joseph-Analyzers\\input.t" +
    "xt";
            // 
            // RadioFingerprints
            // 
            this.RadioFingerprints.AutoSize = true;
            this.RadioFingerprints.Location = new System.Drawing.Point(165, 98);
            this.RadioFingerprints.Name = "RadioFingerprints";
            this.RadioFingerprints.Size = new System.Drawing.Size(76, 17);
            this.RadioFingerprints.TabIndex = 4;
            this.RadioFingerprints.TabStop = true;
            this.RadioFingerprints.Text = "fingerprints";
            this.RadioFingerprints.UseVisualStyleBackColor = true;
            // 
            // RadioDNA
            // 
            this.RadioDNA.AutoSize = true;
            this.RadioDNA.Location = new System.Drawing.Point(111, 98);
            this.RadioDNA.Name = "RadioDNA";
            this.RadioDNA.Size = new System.Drawing.Size(48, 17);
            this.RadioDNA.TabIndex = 3;
            this.RadioDNA.TabStop = true;
            this.RadioDNA.Text = "DNA";
            this.RadioDNA.UseVisualStyleBackColor = true;
            // 
            // RadioWeapons
            // 
            this.RadioWeapons.AutoSize = true;
            this.RadioWeapons.Location = new System.Drawing.Point(26, 98);
            this.RadioWeapons.Name = "RadioWeapons";
            this.RadioWeapons.Size = new System.Drawing.Size(68, 17);
            this.RadioWeapons.TabIndex = 2;
            this.RadioWeapons.TabStop = true;
            this.RadioWeapons.Text = "weapons";
            this.RadioWeapons.UseVisualStyleBackColor = true;
            // 
            // TAnalyzerPrompt
            // 
            this.TAnalyzerPrompt.AutoSize = true;
            this.TAnalyzerPrompt.Location = new System.Drawing.Point(23, 71);
            this.TAnalyzerPrompt.Name = "TAnalyzerPrompt";
            this.TAnalyzerPrompt.Size = new System.Drawing.Size(202, 13);
            this.TAnalyzerPrompt.TabIndex = 1;
            this.TAnalyzerPrompt.Text = "Which type of data do you want to scan?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter File Location";
            // 
            // RowMarker
            // 
            this.RowMarker.AutoSize = true;
            this.RowMarker.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowMarker.Location = new System.Drawing.Point(25, 47);
            this.RowMarker.Name = "RowMarker";
            this.RowMarker.Size = new System.Drawing.Size(23, 21);
            this.RowMarker.TabIndex = 5;
            this.RowMarker.Text = "0";
            // 
            // ColMarkers
            // 
            this.ColMarkers.AutoSize = true;
            this.ColMarkers.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColMarkers.Location = new System.Drawing.Point(32, 14);
            this.ColMarkers.Name = "ColMarkers";
            this.ColMarkers.Size = new System.Drawing.Size(75, 21);
            this.ColMarkers.TabIndex = 6;
            this.ColMarkers.Text = "+  0 ";
            // 
            // PlayText
            // 
            this.PlayText.AutoSize = true;
            this.PlayText.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayText.Location = new System.Drawing.Point(461, 565);
            this.PlayText.Name = "PlayText";
            this.PlayText.Size = new System.Drawing.Size(0, 24);
            this.PlayText.TabIndex = 0;
            this.PlayText.Visible = false;
            // 
            // CollectedLabel
            // 
            this.CollectedLabel.AutoSize = true;
            this.CollectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectedLabel.Location = new System.Drawing.Point(6, 16);
            this.CollectedLabel.Name = "CollectedLabel";
            this.CollectedLabel.Size = new System.Drawing.Size(184, 20);
            this.CollectedLabel.TabIndex = 7;
            this.CollectedLabel.Text = "No samples collected yet";
            // 
            // FileNameLable
            // 
            this.FileNameLable.AutoSize = true;
            this.FileNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLable.Location = new System.Drawing.Point(64, 90);
            this.FileNameLable.Name = "FileNameLable";
            this.FileNameLable.Size = new System.Drawing.Size(79, 20);
            this.FileNameLable.TabIndex = 8;
            this.FileNameLable.Text = "awaiting...";
            // 
            // CaseLabel
            // 
            this.CaseLabel.AutoSize = true;
            this.CaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseLabel.Location = new System.Drawing.Point(6, 90);
            this.CaseLabel.Name = "CaseLabel";
            this.CaseLabel.Size = new System.Drawing.Size(50, 20);
            this.CaseLabel.TabIndex = 9;
            this.CaseLabel.Text = "Case:";
            // 
            // CaseInfoBox
            // 
            this.CaseInfoBox.Controls.Add(this.CaseLabel);
            this.CaseInfoBox.Controls.Add(this.CollectedLabel);
            this.CaseInfoBox.Controls.Add(this.FileNameLable);
            this.CaseInfoBox.Location = new System.Drawing.Point(593, 221);
            this.CaseInfoBox.Name = "CaseInfoBox";
            this.CaseInfoBox.Size = new System.Drawing.Size(275, 129);
            this.CaseInfoBox.TabIndex = 7;
            this.CaseInfoBox.TabStop = false;
            this.CaseInfoBox.Text = "Case Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "More Analyzers Project";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaseInfoBox);
            this.Controls.Add(this.PlayText);
            this.Controls.Add(this.ColMarkers);
            this.Controls.Add(this.RowMarker);
            this.Controls.Add(this.ConfigBox);
            this.Controls.Add(this.PlayBox);
            this.Controls.Add(this.PlayArea);
            this.Name = "GameForm";
            this.Text = "Find Samples";
            this.PlayBox.ResumeLayout(false);
            this.PlayBox.PerformLayout();
            this.ConfigBox.ResumeLayout(false);
            this.ConfigBox.PerformLayout();
            this.CaseInfoBox.ResumeLayout(false);
            this.CaseInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PlayArea;
        private System.Windows.Forms.GroupBox PlayBox;
        private System.Windows.Forms.Label RowPrompt;
        private System.Windows.Forms.Label ColumnPropt;
        private System.Windows.Forms.GroupBox ConfigBox;
        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.RadioButton RadioFingerprints;
        private System.Windows.Forms.RadioButton RadioDNA;
        private System.Windows.Forms.RadioButton RadioWeapons;
        private System.Windows.Forms.Label TAnalyzerPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RowMarker;
        private System.Windows.Forms.TextBox RowBox;
        private System.Windows.Forms.TextBox ColBox;
        private System.Windows.Forms.Label ColMarkers;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label Guesses;
        private System.Windows.Forms.Label GuessIndic;
        private System.Windows.Forms.Label PlayText;
        private System.Windows.Forms.Label CollectedLabel;
        private System.Windows.Forms.Label FileNameLable;
        private System.Windows.Forms.Label CaseLabel;
        private System.Windows.Forms.GroupBox CaseInfoBox;
        private System.Windows.Forms.Label label2;
    }
}

