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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IntegerTypeRB = new System.Windows.Forms.RadioButton();
            this.StringTypeRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CapitalizeRB = new System.Windows.Forms.RadioButton();
            this.IsCapitalizedRB = new System.Windows.Forms.RadioButton();
            this.CountWordRB = new System.Windows.Forms.RadioButton();
            this.CountLettersRB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz przykładowy tekst:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StringTypeRB);
            this.groupBox1.Controls.Add(this.IntegerTypeRB);
            this.groupBox1.Location = new System.Drawing.Point(15, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz domyślny rodzaj tekstu";
            // 
            // IntegerTypeRB
            // 
            this.IntegerTypeRB.AutoSize = true;
            this.IntegerTypeRB.Location = new System.Drawing.Point(6, 41);
            this.IntegerTypeRB.Name = "IntegerTypeRB";
            this.IntegerTypeRB.Size = new System.Drawing.Size(73, 21);
            this.IntegerTypeRB.TabIndex = 0;
            this.IntegerTypeRB.TabStop = true;
            this.IntegerTypeRB.Text = "Integer";
            this.IntegerTypeRB.UseVisualStyleBackColor = true;
            // 
            // StringTypeRB
            // 
            this.StringTypeRB.AutoSize = true;
            this.StringTypeRB.Location = new System.Drawing.Point(6, 68);
            this.StringTypeRB.Name = "StringTypeRB";
            this.StringTypeRB.Size = new System.Drawing.Size(66, 21);
            this.StringTypeRB.TabIndex = 1;
            this.StringTypeRB.TabStop = true;
            this.StringTypeRB.Text = "String";
            this.StringTypeRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.CountLettersRB);
            this.groupBox2.Controls.Add(this.CountWordRB);
            this.groupBox2.Controls.Add(this.IsCapitalizedRB);
            this.groupBox2.Controls.Add(this.CapitalizeRB);
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcja dla Stringa";
            // 
            // CapitalizeRB
            // 
            this.CapitalizeRB.AutoSize = true;
            this.CapitalizeRB.Location = new System.Drawing.Point(6, 21);
            this.CapitalizeRB.Name = "CapitalizeRB";
            this.CapitalizeRB.Size = new System.Drawing.Size(100, 21);
            this.CapitalizeRB.TabIndex = 0;
            this.CapitalizeRB.TabStop = true;
            this.CapitalizeRB.Text = "Zkapitalizuj";
            this.CapitalizeRB.UseVisualStyleBackColor = true;
            // 
            // IsCapitalizedRB
            // 
            this.IsCapitalizedRB.AutoSize = true;
            this.IsCapitalizedRB.Location = new System.Drawing.Point(6, 48);
            this.IsCapitalizedRB.Name = "IsCapitalizedRB";
            this.IsCapitalizedRB.Size = new System.Drawing.Size(189, 21);
            this.IsCapitalizedRB.TabIndex = 1;
            this.IsCapitalizedRB.TabStop = true;
            this.IsCapitalizedRB.Text = "Czy jest zkapitalizowane?";
            this.IsCapitalizedRB.UseVisualStyleBackColor = true;
            // 
            // CountWordRB
            // 
            this.CountWordRB.AutoSize = true;
            this.CountWordRB.Location = new System.Drawing.Point(6, 75);
            this.CountWordRB.Name = "CountWordRB";
            this.CountWordRB.Size = new System.Drawing.Size(107, 21);
            this.CountWordRB.TabIndex = 2;
            this.CountWordRB.TabStop = true;
            this.CountWordRB.Text = "Policz Słowa";
            this.CountWordRB.UseVisualStyleBackColor = true;
            // 
            // CountLettersRB
            // 
            this.CountLettersRB.AutoSize = true;
            this.CountLettersRB.Location = new System.Drawing.Point(6, 102);
            this.CountLettersRB.Name = "CountLettersRB";
            this.CountLettersRB.Size = new System.Drawing.Size(100, 21);
            this.CountLettersRB.TabIndex = 3;
            this.CountLettersRB.TabStop = true;
            this.CountLettersRB.Text = "Policz litery";
            this.CountLettersRB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 129);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton StringTypeRB;
        private System.Windows.Forms.RadioButton IntegerTypeRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton CountLettersRB;
        private System.Windows.Forms.RadioButton CountWordRB;
        private System.Windows.Forms.RadioButton IsCapitalizedRB;
        private System.Windows.Forms.RadioButton CapitalizeRB;
    }
}

