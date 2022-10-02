namespace English_Translator
{
    partial class Form1
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
            this.sinisterLabel = new System.Windows.Forms.Button();
            this.dexterLabel = new System.Windows.Forms.Button();
            this.mediumLabel = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translatorLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sinisterLabel
            // 
            this.sinisterLabel.Location = new System.Drawing.Point(43, 259);
            this.sinisterLabel.Name = "sinisterLabel";
            this.sinisterLabel.Size = new System.Drawing.Size(112, 34);
            this.sinisterLabel.TabIndex = 0;
            this.sinisterLabel.Text = "Sinister";
            this.sinisterLabel.UseVisualStyleBackColor = true;
            this.sinisterLabel.Click += new System.EventHandler(this.sinisterLabel_Click);
            // 
            // dexterLabel
            // 
            this.dexterLabel.Location = new System.Drawing.Point(298, 259);
            this.dexterLabel.Name = "dexterLabel";
            this.dexterLabel.Size = new System.Drawing.Size(112, 34);
            this.dexterLabel.TabIndex = 1;
            this.dexterLabel.Text = "Dexter";
            this.dexterLabel.UseVisualStyleBackColor = true;
            this.dexterLabel.Click += new System.EventHandler(this.dexterLabel_Click);
            // 
            // mediumLabel
            // 
            this.mediumLabel.Location = new System.Drawing.Point(526, 259);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(112, 34);
            this.mediumLabel.TabIndex = 2;
            this.mediumLabel.Text = "Medium";
            this.mediumLabel.UseVisualStyleBackColor = true;
            this.mediumLabel.Click += new System.EventHandler(this.mediumLabel_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(43, 43);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(405, 25);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Select a Latin word and I will translate it to English";
            // 
            // translatorLabel
            // 
            this.translatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translatorLabel.Location = new System.Drawing.Point(43, 133);
            this.translatorLabel.Name = "translatorLabel";
            this.translatorLabel.Size = new System.Drawing.Size(503, 31);
            this.translatorLabel.TabIndex = 4;
            this.translatorLabel.Text = "Click on any word below to get the english translation.";
            this.translatorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 378);
            this.Controls.Add(this.translatorLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.dexterLabel);
            this.Controls.Add(this.sinisterLabel);
            this.Name = "Form1";
            this.Text = "English Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sinisterLabel;
        private Button dexterLabel;
        private Button mediumLabel;
        private Label instructionLabel;
        private TextBox translatorLabel;
    }
}