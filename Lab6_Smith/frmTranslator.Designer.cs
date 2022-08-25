
namespace Lab6_Smith
{
    partial class frmTranslator
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.rbtnLatin = new System.Windows.Forms.RadioButton();
            this.rbtnGreek = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(30, 574);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(93, 26);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(149, 574);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(421, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(30, 49);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(484, 193);
            this.txtEnglish.TabIndex = 3;
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(30, 349);
            this.txtTranslation.Multiline = true;
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(484, 202);
            this.txtTranslation.TabIndex = 4;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(30, 24);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(116, 13);
            this.lblEnglish.TabIndex = 5;
            this.lblEnglish.Text = "Enter English text here:";
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(30, 324);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(0, 13);
            this.lblTranslation.TabIndex = 6;
            // 
            // rbtnLatin
            // 
            this.rbtnLatin.AutoSize = true;
            this.rbtnLatin.Location = new System.Drawing.Point(30, 280);
            this.rbtnLatin.Name = "rbtnLatin";
            this.rbtnLatin.Size = new System.Drawing.Size(66, 17);
            this.rbtnLatin.TabIndex = 7;
            this.rbtnLatin.TabStop = true;
            this.rbtnLatin.Text = "Pig Latin";
            this.rbtnLatin.UseVisualStyleBackColor = true;
            this.rbtnLatin.CheckedChanged += new System.EventHandler(this.rbtnLatin_CheckedChanged);
            // 
            // rbtnGreek
            // 
            this.rbtnGreek.AutoSize = true;
            this.rbtnGreek.Location = new System.Drawing.Point(140, 280);
            this.rbtnGreek.Name = "rbtnGreek";
            this.rbtnGreek.Size = new System.Drawing.Size(72, 17);
            this.rbtnGreek.TabIndex = 8;
            this.rbtnGreek.TabStop = true;
            this.rbtnGreek.Text = "Pig Greek";
            this.rbtnGreek.UseVisualStyleBackColor = true;
            this.rbtnGreek.CheckedChanged += new System.EventHandler(this.rbtnGreek_CheckedChanged);
            // 
            // frmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 624);
            this.Controls.Add(this.rbtnGreek);
            this.Controls.Add(this.rbtnLatin);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Name = "frmTranslator";
            this.Text = "Pig Latin & Greek Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.RadioButton rbtnLatin;
        private System.Windows.Forms.RadioButton rbtnGreek;
    }
}

