namespace EXE7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.women = new System.Windows.Forms.RichTextBox();
            this.Couple = new System.Windows.Forms.RichTextBox();
            this.singleWomen = new System.Windows.Forms.RichTextBox();
            this.SingleMen = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Women :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Single women ( num of kids ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Single men ( distance of work ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Couples :";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.find.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(446, 133);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(166, 50);
            this.find.TabIndex = 4;
            this.find.Text = "Find a match";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(96, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Save to file :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(89, 588);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 38);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Single men";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(89, 658);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 38);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "couples";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(89, 623);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 38);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Single women";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.save.Location = new System.Drawing.Point(365, 588);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(98, 45);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            // 
            // women
            // 
            this.women.Location = new System.Drawing.Point(89, 77);
            this.women.Name = "women";
            this.women.ReadOnly = true;
            this.women.Size = new System.Drawing.Size(198, 193);
            this.women.TabIndex = 14;
            this.women.Text = "";
          //  this.women.TextChanged += new System.EventHandler(this.women_TextChanged);
            // 
            // Couple
            // 
            this.Couple.Location = new System.Drawing.Point(89, 343);
            this.Couple.Name = "Couple";
            this.Couple.ReadOnly = true;
            this.Couple.Size = new System.Drawing.Size(245, 164);
            this.Couple.TabIndex = 15;
            this.Couple.Text = "";
           // this.Couple.TextChanged += new System.EventHandler(this.Couple_TextChanged);
            // 
            // singleWomen
            // 
            this.singleWomen.Location = new System.Drawing.Point(431, 344);
            this.singleWomen.Name = "singleWomen";
            this.singleWomen.ReadOnly = true;
            this.singleWomen.Size = new System.Drawing.Size(235, 163);
            this.singleWomen.TabIndex = 16;
            this.singleWomen.Text = "";
          //  this.singleWomen.TextChanged += new System.EventHandler(this.singleWomen_TextChanged);
            // 
            // SingleMen
            // 
            this.SingleMen.Location = new System.Drawing.Point(783, 344);
            this.SingleMen.Name = "SingleMen";
            this.SingleMen.ReadOnly = true;
            this.SingleMen.Size = new System.Drawing.Size(232, 163);
            this.SingleMen.TabIndex = 17;
            this.SingleMen.Text = "";
           // this.SingleMen.TextChanged += new System.EventHandler(this.SingleMen_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 759);
            this.Controls.Add(this.SingleMen);
            this.Controls.Add(this.singleWomen);
            this.Controls.Add(this.Couple);
            this.Controls.Add(this.women);
            this.Controls.Add(this.save);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox women;
        private System.Windows.Forms.RichTextBox Couple;
        private System.Windows.Forms.RichTextBox singleWomen;
        private System.Windows.Forms.RichTextBox SingleMen;
    }
}

