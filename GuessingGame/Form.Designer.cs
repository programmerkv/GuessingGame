namespace GuessingGame
{
    partial class Form
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
            this.tb = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(16, 20);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(190, 26);
            this.tb.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(218, 18);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(80, 36);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(304, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(9, 59);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(192, 20);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "> Please enter your guess";
            // 
            // lbHighscore
            // 
            this.lbHighscore.AutoSize = true;
            this.lbHighscore.Location = new System.Drawing.Point(9, 91);
            this.lbHighscore.Name = "lbHighscore";
            this.lbHighscore.Size = new System.Drawing.Size(130, 20);
            this.lbHighscore.TabIndex = 4;
            this.lbHighscore.Text = "> Highscore - 0%";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 124);
            this.Controls.Add(this.lbHighscore);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tb);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbHighscore;
    }
}

