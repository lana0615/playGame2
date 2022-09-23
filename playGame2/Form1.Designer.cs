namespace playGame2
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
            this.playGameButton = new System.Windows.Forms.Button();
            this.countdownLabel2 = new System.Windows.Forms.Label();
            this.countdownLabel3 = new System.Windows.Forms.Label();
            this.countdowwnLabel1 = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.Location = new System.Drawing.Point(80, 97);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(132, 48);
            this.playGameButton.TabIndex = 0;
            this.playGameButton.Text = "Start Game";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // countdownLabel2
            // 
            this.countdownLabel2.AutoSize = true;
            this.countdownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel2.ForeColor = System.Drawing.Color.White;
            this.countdownLabel2.Location = new System.Drawing.Point(60, 173);
            this.countdownLabel2.Name = "countdownLabel2";
            this.countdownLabel2.Size = new System.Drawing.Size(169, 25);
            this.countdownLabel2.TabIndex = 1;
            this.countdownLabel2.Text = "Game starts in 2";
            // 
            // countdownLabel3
            // 
            this.countdownLabel3.AutoSize = true;
            this.countdownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel3.ForeColor = System.Drawing.Color.White;
            this.countdownLabel3.Location = new System.Drawing.Point(60, 148);
            this.countdownLabel3.Name = "countdownLabel3";
            this.countdownLabel3.Size = new System.Drawing.Size(169, 25);
            this.countdownLabel3.TabIndex = 2;
            this.countdownLabel3.Text = "Game starts in 3";
            // 
            // countdowwnLabel1
            // 
            this.countdowwnLabel1.AutoSize = true;
            this.countdowwnLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdowwnLabel1.ForeColor = System.Drawing.Color.White;
            this.countdowwnLabel1.Location = new System.Drawing.Point(60, 198);
            this.countdowwnLabel1.Name = "countdowwnLabel1";
            this.countdowwnLabel1.Size = new System.Drawing.Size(172, 25);
            this.countdowwnLabel1.TabIndex = 3;
            this.countdowwnLabel1.Text = "Game Starts in 1";
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.White;
            this.goLabel.Location = new System.Drawing.Point(126, 52);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(46, 25);
            this.goLabel.TabIndex = 4;
            this.goLabel.Text = "Go!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(304, 274);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdowwnLabel1);
            this.Controls.Add(this.countdownLabel3);
            this.Controls.Add(this.countdownLabel2);
            this.Controls.Add(this.playGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Label countdownLabel2;
        private System.Windows.Forms.Label countdownLabel3;
        private System.Windows.Forms.Label countdowwnLabel1;
        private System.Windows.Forms.Label goLabel;
    }
}

