
namespace DesktopProject
{
    partial class Main
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
            this.txtToTranslate = new System.Windows.Forms.TextBox();
            this.addANewWord = new System.Windows.Forms.Button();
            this.lstWordsToLearn = new System.Windows.Forms.ListBox();
            this.btnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtToTranslate
            // 
            this.txtToTranslate.Location = new System.Drawing.Point(12, 12);
            this.txtToTranslate.Name = "txtToTranslate";
            this.txtToTranslate.Size = new System.Drawing.Size(100, 23);
            this.txtToTranslate.TabIndex = 0;
            // 
            // addANewWord
            // 
            this.addANewWord.Location = new System.Drawing.Point(12, 42);
            this.addANewWord.Name = "addANewWord";
            this.addANewWord.Size = new System.Drawing.Size(100, 23);
            this.addANewWord.TabIndex = 1;
            this.addANewWord.Text = "Translate";
            this.addANewWord.UseVisualStyleBackColor = true;
            this.addANewWord.Click += new System.EventHandler(this.addANewWord_Click);
            // 
            // lstWordsToLearn
            // 
            this.lstWordsToLearn.FormattingEnabled = true;
            this.lstWordsToLearn.ItemHeight = 15;
            this.lstWordsToLearn.Location = new System.Drawing.Point(12, 72);
            this.lstWordsToLearn.Name = "lstWordsToLearn";
            this.lstWordsToLearn.Size = new System.Drawing.Size(120, 94);
            this.lstWordsToLearn.TabIndex = 2;
            // 
            // btnBtn
            // 
            this.btnBtn.Location = new System.Drawing.Point(118, 42);
            this.btnBtn.Name = "btnBtn";
            this.btnBtn.Size = new System.Drawing.Size(100, 23);
            this.btnBtn.TabIndex = 3;
            this.btnBtn.Text = "Delete Item";
            this.btnBtn.UseVisualStyleBackColor = true;
            this.btnBtn.Click += new System.EventHandler(this.btnBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBtn);
            this.Controls.Add(this.lstWordsToLearn);
            this.Controls.Add(this.addANewWord);
            this.Controls.Add(this.txtToTranslate);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToTranslate;
        private System.Windows.Forms.Button addANewWord;
        private System.Windows.Forms.ListBox lstWordsToLearn;
        private System.Windows.Forms.Button btnBtn;
    }
}

