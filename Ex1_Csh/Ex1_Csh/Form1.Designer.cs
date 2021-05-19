namespace Ex1_Csh
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnRez = new System.Windows.Forms.Button();
            this.lblIncercari = new System.Windows.Forms.Label();
            this.btnJocNou = new System.Windows.Forms.Button();
            this.lblNrIncercari = new System.Windows.Forms.Label();
            this.lblTiltuIstoric = new System.Windows.Forms.Label();
            this.txtPlayerGuess = new System.Windows.Forms.TextBox();
            this.lblIstoric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(32, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score :";
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Location = new System.Drawing.Point(79, 52);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(13, 13);
            this.lblScorePlayer.TabIndex = 1;
            this.lblScorePlayer.Text = "0";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(120, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(92, 13);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Ghiceste numarul!";
            // 
            // btnRez
            // 
            this.btnRez.Location = new System.Drawing.Point(26, 140);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(75, 23);
            this.btnRez.TabIndex = 3;
            this.btnRez.Text = "Ghiceste!";
            this.btnRez.UseVisualStyleBackColor = true;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // lblIncercari
            // 
            this.lblIncercari.AutoSize = true;
            this.lblIncercari.Location = new System.Drawing.Point(133, 52);
            this.lblIncercari.Name = "lblIncercari";
            this.lblIncercari.Size = new System.Drawing.Size(102, 13);
            this.lblIncercari.TabIndex = 4;
            this.lblIncercari.Text = "Numar de incercari :";
            // 
            // btnJocNou
            // 
            this.btnJocNou.Location = new System.Drawing.Point(123, 140);
            this.btnJocNou.Name = "btnJocNou";
            this.btnJocNou.Size = new System.Drawing.Size(75, 23);
            this.btnJocNou.TabIndex = 5;
            this.btnJocNou.Text = "Joc Nou";
            this.btnJocNou.UseVisualStyleBackColor = true;
            this.btnJocNou.Click += new System.EventHandler(this.btnJocNou_Click);
            // 
            // lblNrIncercari
            // 
            this.lblNrIncercari.AutoSize = true;
            this.lblNrIncercari.Location = new System.Drawing.Point(237, 52);
            this.lblNrIncercari.Name = "lblNrIncercari";
            this.lblNrIncercari.Size = new System.Drawing.Size(13, 13);
            this.lblNrIncercari.TabIndex = 7;
            this.lblNrIncercari.Text = "0";
            // 
            // lblTiltuIstoric
            // 
            this.lblTiltuIstoric.AutoSize = true;
            this.lblTiltuIstoric.Location = new System.Drawing.Point(278, 94);
            this.lblTiltuIstoric.Name = "lblTiltuIstoric";
            this.lblTiltuIstoric.Size = new System.Drawing.Size(35, 13);
            this.lblTiltuIstoric.TabIndex = 8;
            this.lblTiltuIstoric.Text = "Istoric";
            // 
            // txtPlayerGuess
            // 
            this.txtPlayerGuess.Location = new System.Drawing.Point(35, 87);
            this.txtPlayerGuess.Name = "txtPlayerGuess";
            this.txtPlayerGuess.Size = new System.Drawing.Size(39, 20);
            this.txtPlayerGuess.TabIndex = 9;
            // 
            // lblIstoric
            // 
            this.lblIstoric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIstoric.Location = new System.Drawing.Point(237, 117);
            this.lblIstoric.Name = "lblIstoric";
            this.lblIstoric.Size = new System.Drawing.Size(146, 58);
            this.lblIstoric.TabIndex = 10;
            this.lblIstoric.Text = "Ghiceste!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 194);
            this.Controls.Add(this.lblIstoric);
            this.Controls.Add(this.txtPlayerGuess);
            this.Controls.Add(this.lblTiltuIstoric);
            this.Controls.Add(this.lblNrIncercari);
            this.Controls.Add(this.btnJocNou);
            this.Controls.Add(this.lblIncercari);
            this.Controls.Add(this.btnRez);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.Label lblIncercari;
        private System.Windows.Forms.Button btnJocNou;
        private System.Windows.Forms.Label lblNrIncercari;
        private System.Windows.Forms.Label lblTiltuIstoric;
        private System.Windows.Forms.TextBox txtPlayerGuess;
        private System.Windows.Forms.Label lblIstoric;
    }
}

