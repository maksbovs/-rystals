namespace Сrystals
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_casino = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_loss = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_bid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Сrystals.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(47, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Сrystals.Properties.Resources.dollar;
            this.pictureBox2.Location = new System.Drawing.Point(214, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Сrystals.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(376, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_casino
            // 
            this.lbl_casino.AutoSize = true;
            this.lbl_casino.Font = new System.Drawing.Font("High Tower Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casino.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_casino.Location = new System.Drawing.Point(47, 42);
            this.lbl_casino.Name = "lbl_casino";
            this.lbl_casino.Size = new System.Drawing.Size(167, 55);
            this.lbl_casino.TabIndex = 3;
            this.lbl_casino.Text = "Casino";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("High Tower Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_balance.Location = new System.Drawing.Point(47, 97);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(243, 55);
            this.lbl_balance.TabIndex = 4;
            this.lbl_balance.Text = "Balance : $";
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("High Tower Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_win.Location = new System.Drawing.Point(47, 423);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(163, 55);
            this.lbl_win.TabIndex = 5;
            this.lbl_win.Text = "Wins :";
            this.lbl_win.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_loss
            // 
            this.lbl_loss.AutoSize = true;
            this.lbl_loss.Font = new System.Drawing.Font("High Tower Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loss.ForeColor = System.Drawing.Color.Red;
            this.lbl_loss.Location = new System.Drawing.Point(47, 478);
            this.lbl_loss.Name = "lbl_loss";
            this.lbl_loss.Size = new System.Drawing.Size(142, 55);
            this.lbl_loss.TabIndex = 6;
            this.lbl_loss.Text = "Loss :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(276, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bid-amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(286, 447);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 62);
            this.textBox1.TabIndex = 8;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_play.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_play.Location = new System.Drawing.Point(57, 546);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(201, 63);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_bid
            // 
            this.btn_bid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_bid.Location = new System.Drawing.Point(281, 546);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(201, 63);
            this.btn_bid.TabIndex = 10;
            this.btn_bid.Text = "New Bid";
            this.btn_bid.UseVisualStyleBackColor = true;
            this.btn_bid.Click += new System.EventHandler(this.btn_bid_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(540, 621);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_loss);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_casino);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_casino;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_loss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.Timer timer1;
    }
}

