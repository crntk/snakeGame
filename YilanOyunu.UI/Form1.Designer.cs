namespace YilanOyunu.UI
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
            components = new System.ComponentModel.Container();
            pnlYilan = new Panel();
            btnBasla = new Button();
            lblSkor = new Label();
            lblHighSkor = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            lblHighScore = new Label();
            pnlGiris = new Panel();
            label1 = new Label();
            btnZor = new Button();
            btnOrta = new Button();
            btnKolay = new Button();
            lblGosterge = new Label();
            pnlGiris.SuspendLayout();
            SuspendLayout();
            // 
            // pnlYilan
            // 
            pnlYilan.BackColor = SystemColors.ScrollBar;
            pnlYilan.Location = new Point(12, 12);
            pnlYilan.Name = "pnlYilan";
            pnlYilan.Size = new Size(630, 580);
            pnlYilan.TabIndex = 0;
            pnlYilan.Paint += UpdatePictureBox;
            // 
            // btnBasla
            // 
            btnBasla.BackColor = Color.FromArgb(255, 128, 0);
            btnBasla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBasla.Location = new Point(693, 93);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(137, 122);
            btnBasla.TabIndex = 1;
            btnBasla.Text = "BAŞLA";
            btnBasla.UseVisualStyleBackColor = false;
            btnBasla.Click += btnBasla_Click;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSkor.Location = new Point(670, 336);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(75, 30);
            lblSkor.TabIndex = 3;
            lblSkor.Text = "SKOR ";
            // 
            // lblHighSkor
            // 
            lblHighSkor.AutoSize = true;
            lblHighSkor.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lblHighSkor.Location = new Point(670, 381);
            lblHighSkor.Name = "lblHighSkor";
            lblHighSkor.Size = new Size(135, 20);
            lblHighSkor.TabIndex = 4;
            lblHighSkor.Text = "EN YÜKSEK SKOR";
            // 
            // GameTimer
            // 
            GameTimer.Tick += GameTimer_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblScore.Location = new Point(751, 344);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(18, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHighScore.Location = new Point(812, 381);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(18, 20);
            lblHighScore.TabIndex = 6;
            lblHighScore.Text = "0";
            // 
            // pnlGiris
            // 
            pnlGiris.BackColor = Color.FromArgb(0, 64, 0);
            pnlGiris.Controls.Add(label1);
            pnlGiris.Controls.Add(btnZor);
            pnlGiris.Controls.Add(btnOrta);
            pnlGiris.Controls.Add(btnKolay);
            pnlGiris.Location = new Point(12, 12);
            pnlGiris.Name = "pnlGiris";
            pnlGiris.Size = new Size(872, 586);
            pnlGiris.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 173);
            label1.Name = "label1";
            label1.Size = new Size(796, 45);
            label1.TabIndex = 3;
            label1.Text = "YILAN OYUNU BAŞLIYORRRSSSsss";
            // 
            // btnZor
            // 
            btnZor.BackColor = Color.FromArgb(255, 128, 0);
            btnZor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnZor.Location = new Point(642, 305);
            btnZor.Name = "btnZor";
            btnZor.Size = new Size(103, 85);
            btnZor.TabIndex = 2;
            btnZor.Text = "ZOR";
            btnZor.UseVisualStyleBackColor = false;
            btnZor.Click += btnZor_Click;
            // 
            // btnOrta
            // 
            btnOrta.BackColor = Color.FromArgb(255, 128, 0);
            btnOrta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOrta.Location = new Point(363, 305);
            btnOrta.Name = "btnOrta";
            btnOrta.Size = new Size(102, 85);
            btnOrta.TabIndex = 1;
            btnOrta.Text = "ORTA";
            btnOrta.UseVisualStyleBackColor = false;
            btnOrta.Click += btnOrta_Click;
            // 
            // btnKolay
            // 
            btnKolay.BackColor = Color.FromArgb(255, 128, 0);
            btnKolay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKolay.Location = new Point(115, 305);
            btnKolay.Name = "btnKolay";
            btnKolay.Size = new Size(104, 85);
            btnKolay.TabIndex = 0;
            btnKolay.Text = "KOLAY";
            btnKolay.UseVisualStyleBackColor = false;
            btnKolay.Click += btnKolay_Click;
            // 
            // lblGosterge
            // 
            lblGosterge.AutoSize = true;
            lblGosterge.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGosterge.Location = new Point(670, 288);
            lblGosterge.Name = "lblGosterge";
            lblGosterge.Size = new Size(48, 25);
            lblGosterge.TabIndex = 4;
            lblGosterge.Text = "****";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(896, 610);
            Controls.Add(pnlGiris);
            Controls.Add(lblGosterge);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(lblHighSkor);
            Controls.Add(lblSkor);
            Controls.Add(pnlYilan);
            Controls.Add(btnBasla);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            pnlGiris.ResumeLayout(false);
            pnlGiris.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlYilan;
        private Button btnBasla;
        private Label lblSkor;
        private Label lblHighSkor;
        private System.Windows.Forms.Timer GameTimer;
        private Label lblScore;
        private Label lblHighScore;
        private Panel pnlGiris;
        private Button btnZor;
        private Button btnOrta;
        private Button btnKolay;
        private Label label1;
        private Label lblGosterge;
    }
}
