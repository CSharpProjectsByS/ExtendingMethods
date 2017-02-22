namespace MetodyRozszerzające
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
            this.InputPhraseTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainOptionGB = new System.Windows.Forms.GroupBox();
            this.StringTypeRB = new System.Windows.Forms.RadioButton();
            this.IntegerTypeRB = new System.Windows.Forms.RadioButton();
            this.StringOptionsGB = new System.Windows.Forms.GroupBox();
            this.LetterTB = new System.Windows.Forms.TextBox();
            this.PositionTB = new System.Windows.Forms.TextBox();
            this.ShowByNByNRB = new System.Windows.Forms.RadioButton();
            this.CountLettersRB = new System.Windows.Forms.RadioButton();
            this.CountWordRB = new System.Windows.Forms.RadioButton();
            this.IsCapitalizedRB = new System.Windows.Forms.RadioButton();
            this.CapitalizeRB = new System.Windows.Forms.RadioButton();
            this.IntegerOptionsGB = new System.Windows.Forms.GroupBox();
            this.PowRB = new System.Windows.Forms.RadioButton();
            this.IsNegativeRB = new System.Windows.Forms.RadioButton();
            this.IsOneDigitRB = new System.Windows.Forms.RadioButton();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultDisplay = new System.Windows.Forms.Label();
            this.PowValueTB = new System.Windows.Forms.TextBox();
            this.MainOptionGB.SuspendLayout();
            this.StringOptionsGB.SuspendLayout();
            this.IntegerOptionsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPhraseTB
            // 
            this.InputPhraseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputPhraseTB.Location = new System.Drawing.Point(23, 35);
            this.InputPhraseTB.Name = "InputPhraseTB";
            this.InputPhraseTB.Size = new System.Drawing.Size(275, 26);
            this.InputPhraseTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz przykładowy tekst:";
            // 
            // MainOptionGB
            // 
            this.MainOptionGB.Controls.Add(this.StringTypeRB);
            this.MainOptionGB.Controls.Add(this.IntegerTypeRB);
            this.MainOptionGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainOptionGB.Location = new System.Drawing.Point(23, 78);
            this.MainOptionGB.Name = "MainOptionGB";
            this.MainOptionGB.Size = new System.Drawing.Size(275, 106);
            this.MainOptionGB.TabIndex = 2;
            this.MainOptionGB.TabStop = false;
            this.MainOptionGB.Text = "Wybierz domyślny rodzaj tekstu";
            // 
            // StringTypeRB
            // 
            this.StringTypeRB.AutoSize = true;
            this.StringTypeRB.Location = new System.Drawing.Point(24, 45);
            this.StringTypeRB.Name = "StringTypeRB";
            this.StringTypeRB.Size = new System.Drawing.Size(74, 24);
            this.StringTypeRB.TabIndex = 1;
            this.StringTypeRB.TabStop = true;
            this.StringTypeRB.Text = "String";
            this.StringTypeRB.UseVisualStyleBackColor = true;
            this.StringTypeRB.CheckedChanged += new System.EventHandler(this.StringTypeRB_CheckedChanged);
            // 
            // IntegerTypeRB
            // 
            this.IntegerTypeRB.AutoSize = true;
            this.IntegerTypeRB.Location = new System.Drawing.Point(24, 75);
            this.IntegerTypeRB.Name = "IntegerTypeRB";
            this.IntegerTypeRB.Size = new System.Drawing.Size(81, 24);
            this.IntegerTypeRB.TabIndex = 0;
            this.IntegerTypeRB.TabStop = true;
            this.IntegerTypeRB.Text = "Integer";
            this.IntegerTypeRB.UseVisualStyleBackColor = true;
            this.IntegerTypeRB.CheckedChanged += new System.EventHandler(this.IntegerTypeRB_CheckedChanged);
            // 
            // StringOptionsGB
            // 
            this.StringOptionsGB.Controls.Add(this.LetterTB);
            this.StringOptionsGB.Controls.Add(this.PositionTB);
            this.StringOptionsGB.Controls.Add(this.ShowByNByNRB);
            this.StringOptionsGB.Controls.Add(this.CountLettersRB);
            this.StringOptionsGB.Controls.Add(this.CountWordRB);
            this.StringOptionsGB.Controls.Add(this.IsCapitalizedRB);
            this.StringOptionsGB.Controls.Add(this.CapitalizeRB);
            this.StringOptionsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StringOptionsGB.Location = new System.Drawing.Point(23, 199);
            this.StringOptionsGB.Name = "StringOptionsGB";
            this.StringOptionsGB.Size = new System.Drawing.Size(274, 181);
            this.StringOptionsGB.TabIndex = 3;
            this.StringOptionsGB.TabStop = false;
            this.StringOptionsGB.Text = "Opcja dla Stringa";
            // 
            // LetterTB
            // 
            this.LetterTB.Location = new System.Drawing.Point(199, 113);
            this.LetterTB.Name = "LetterTB";
            this.LetterTB.Size = new System.Drawing.Size(60, 26);
            this.LetterTB.TabIndex = 6;
            // 
            // PositionTB
            // 
            this.PositionTB.Location = new System.Drawing.Point(199, 141);
            this.PositionTB.Name = "PositionTB";
            this.PositionTB.Size = new System.Drawing.Size(60, 26);
            this.PositionTB.TabIndex = 5;
            // 
            // ShowByNByNRB
            // 
            this.ShowByNByNRB.AutoSize = true;
            this.ShowByNByNRB.Location = new System.Drawing.Point(24, 142);
            this.ShowByNByNRB.Name = "ShowByNByNRB";
            this.ShowByNByNRB.Size = new System.Drawing.Size(134, 24);
            this.ShowByNByNRB.TabIndex = 4;
            this.ShowByNByNRB.TabStop = true;
            this.ShowByNByNRB.Text = "Wyświelt co n";
            this.ShowByNByNRB.UseVisualStyleBackColor = true;
            this.ShowByNByNRB.CheckedChanged += new System.EventHandler(this.ShowByNByNRB_CheckedChanged);
            // 
            // CountLettersRB
            // 
            this.CountLettersRB.AutoSize = true;
            this.CountLettersRB.Location = new System.Drawing.Point(24, 115);
            this.CountLettersRB.Name = "CountLettersRB";
            this.CountLettersRB.Size = new System.Drawing.Size(117, 24);
            this.CountLettersRB.TabIndex = 3;
            this.CountLettersRB.TabStop = true;
            this.CountLettersRB.Text = "Policz litery";
            this.CountLettersRB.UseVisualStyleBackColor = true;
            this.CountLettersRB.CheckedChanged += new System.EventHandler(this.CountLettersRB_CheckedChanged);
            // 
            // CountWordRB
            // 
            this.CountWordRB.AutoSize = true;
            this.CountWordRB.Location = new System.Drawing.Point(24, 88);
            this.CountWordRB.Name = "CountWordRB";
            this.CountWordRB.Size = new System.Drawing.Size(126, 24);
            this.CountWordRB.TabIndex = 2;
            this.CountWordRB.TabStop = true;
            this.CountWordRB.Text = "Policz Słowa";
            this.CountWordRB.UseVisualStyleBackColor = true;
            // 
            // IsCapitalizedRB
            // 
            this.IsCapitalizedRB.AutoSize = true;
            this.IsCapitalizedRB.Location = new System.Drawing.Point(24, 61);
            this.IsCapitalizedRB.Name = "IsCapitalizedRB";
            this.IsCapitalizedRB.Size = new System.Drawing.Size(223, 24);
            this.IsCapitalizedRB.TabIndex = 1;
            this.IsCapitalizedRB.TabStop = true;
            this.IsCapitalizedRB.Text = "Czy jest zkapitalizowane?";
            this.IsCapitalizedRB.UseVisualStyleBackColor = true;
            // 
            // CapitalizeRB
            // 
            this.CapitalizeRB.AutoSize = true;
            this.CapitalizeRB.Location = new System.Drawing.Point(24, 34);
            this.CapitalizeRB.Name = "CapitalizeRB";
            this.CapitalizeRB.Size = new System.Drawing.Size(113, 24);
            this.CapitalizeRB.TabIndex = 0;
            this.CapitalizeRB.TabStop = true;
            this.CapitalizeRB.Text = "Zkapitalizuj";
            this.CapitalizeRB.UseVisualStyleBackColor = true;
            // 
            // IntegerOptionsGB
            // 
            this.IntegerOptionsGB.Controls.Add(this.PowValueTB);
            this.IntegerOptionsGB.Controls.Add(this.PowRB);
            this.IntegerOptionsGB.Controls.Add(this.IsNegativeRB);
            this.IntegerOptionsGB.Controls.Add(this.IsOneDigitRB);
            this.IntegerOptionsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IntegerOptionsGB.Location = new System.Drawing.Point(21, 395);
            this.IntegerOptionsGB.Name = "IntegerOptionsGB";
            this.IntegerOptionsGB.Size = new System.Drawing.Size(276, 127);
            this.IntegerOptionsGB.TabIndex = 4;
            this.IntegerOptionsGB.TabStop = false;
            this.IntegerOptionsGB.Text = "Opcje dla Integera";
            // 
            // PowRB
            // 
            this.PowRB.AutoSize = true;
            this.PowRB.Location = new System.Drawing.Point(18, 89);
            this.PowRB.Name = "PowRB";
            this.PowRB.Size = new System.Drawing.Size(82, 24);
            this.PowRB.TabIndex = 2;
            this.PowRB.TabStop = true;
            this.PowRB.Text = "Potęga";
            this.PowRB.UseVisualStyleBackColor = true;
            this.PowRB.CheckedChanged += new System.EventHandler(this.PowRB_CheckedChanged);
            // 
            // IsNegativeRB
            // 
            this.IsNegativeRB.AutoSize = true;
            this.IsNegativeRB.Location = new System.Drawing.Point(18, 62);
            this.IsNegativeRB.Name = "IsNegativeRB";
            this.IsNegativeRB.Size = new System.Drawing.Size(159, 24);
            this.IsNegativeRB.TabIndex = 1;
            this.IsNegativeRB.TabStop = true;
            this.IsNegativeRB.Text = "Czy jest ujemna?";
            this.IsNegativeRB.UseVisualStyleBackColor = true;
            // 
            // IsOneDigitRB
            // 
            this.IsOneDigitRB.AutoSize = true;
            this.IsOneDigitRB.Location = new System.Drawing.Point(18, 32);
            this.IsOneDigitRB.Name = "IsOneDigitRB";
            this.IsOneDigitRB.Size = new System.Drawing.Size(194, 24);
            this.IsOneDigitRB.TabIndex = 0;
            this.IsOneDigitRB.TabStop = true;
            this.IsOneDigitRB.Text = "Czy tylko jedna cyfra?";
            this.IsOneDigitRB.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResultButton.Location = new System.Drawing.Point(15, 607);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(276, 44);
            this.ResultButton.TabIndex = 5;
            this.ResultButton.Text = "Rezultat";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wynik Operacji:";
            // 
            // ResultDisplay
            // 
            this.ResultDisplay.AutoSize = true;
            this.ResultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResultDisplay.Location = new System.Drawing.Point(19, 574);
            this.ResultDisplay.Name = "ResultDisplay";
            this.ResultDisplay.Size = new System.Drawing.Size(115, 20);
            this.ResultDisplay.TabIndex = 7;
            this.ResultDisplay.Text = "Brak Wyników";
            // 
            // PowValueTB
            // 
            this.PowValueTB.Location = new System.Drawing.Point(201, 87);
            this.PowValueTB.Name = "PowValueTB";
            this.PowValueTB.Size = new System.Drawing.Size(60, 26);
            this.PowValueTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 663);
            this.Controls.Add(this.ResultDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.IntegerOptionsGB);
            this.Controls.Add(this.StringOptionsGB);
            this.Controls.Add(this.MainOptionGB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputPhraseTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainOptionGB.ResumeLayout(false);
            this.MainOptionGB.PerformLayout();
            this.StringOptionsGB.ResumeLayout(false);
            this.StringOptionsGB.PerformLayout();
            this.IntegerOptionsGB.ResumeLayout(false);
            this.IntegerOptionsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputPhraseTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MainOptionGB;
        private System.Windows.Forms.RadioButton StringTypeRB;
        private System.Windows.Forms.RadioButton IntegerTypeRB;
        private System.Windows.Forms.GroupBox StringOptionsGB;
        private System.Windows.Forms.RadioButton ShowByNByNRB;
        private System.Windows.Forms.RadioButton CountLettersRB;
        private System.Windows.Forms.RadioButton CountWordRB;
        private System.Windows.Forms.RadioButton IsCapitalizedRB;
        private System.Windows.Forms.RadioButton CapitalizeRB;
        private System.Windows.Forms.TextBox LetterTB;
        private System.Windows.Forms.TextBox PositionTB;
        private System.Windows.Forms.GroupBox IntegerOptionsGB;
        private System.Windows.Forms.RadioButton PowRB;
        private System.Windows.Forms.RadioButton IsNegativeRB;
        private System.Windows.Forms.RadioButton IsOneDigitRB;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultDisplay;
        private System.Windows.Forms.TextBox PowValueTB;
    }
}

