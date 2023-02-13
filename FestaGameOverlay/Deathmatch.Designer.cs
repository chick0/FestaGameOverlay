namespace FestaGameOverlay
{
    partial class Deathmatch
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
            this.PlayerA = new System.Windows.Forms.Label();
            this.PlayerB = new System.Windows.Forms.Label();
            this.PlayerC = new System.Windows.Forms.Label();
            this.PlayerE = new System.Windows.Forms.Label();
            this.PlayerD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerA
            // 
            this.PlayerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PlayerA.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA.ForeColor = System.Drawing.Color.White;
            this.PlayerA.Location = new System.Drawing.Point(0, 0);
            this.PlayerA.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerA.Name = "PlayerA";
            this.PlayerA.Size = new System.Drawing.Size(200, 120);
            this.PlayerA.TabIndex = 0;
            this.PlayerA.Text = "1";
            this.PlayerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerB
            // 
            this.PlayerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.PlayerB.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB.ForeColor = System.Drawing.Color.White;
            this.PlayerB.Location = new System.Drawing.Point(200, 0);
            this.PlayerB.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerB.Name = "PlayerB";
            this.PlayerB.Size = new System.Drawing.Size(200, 120);
            this.PlayerB.TabIndex = 1;
            this.PlayerB.Text = "2";
            this.PlayerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerC
            // 
            this.PlayerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.PlayerC.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerC.ForeColor = System.Drawing.Color.White;
            this.PlayerC.Location = new System.Drawing.Point(400, 0);
            this.PlayerC.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerC.Name = "PlayerC";
            this.PlayerC.Size = new System.Drawing.Size(200, 120);
            this.PlayerC.TabIndex = 2;
            this.PlayerC.Text = "3";
            this.PlayerC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerE
            // 
            this.PlayerE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.PlayerE.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerE.ForeColor = System.Drawing.Color.White;
            this.PlayerE.Location = new System.Drawing.Point(800, 0);
            this.PlayerE.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerE.Name = "PlayerE";
            this.PlayerE.Size = new System.Drawing.Size(200, 120);
            this.PlayerE.TabIndex = 4;
            this.PlayerE.Text = "5";
            this.PlayerE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerD
            // 
            this.PlayerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(156)))));
            this.PlayerD.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerD.ForeColor = System.Drawing.Color.White;
            this.PlayerD.Location = new System.Drawing.Point(600, 0);
            this.PlayerD.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerD.Name = "PlayerD";
            this.PlayerD.Size = new System.Drawing.Size(200, 120);
            this.PlayerD.TabIndex = 3;
            this.PlayerD.Text = "4";
            this.PlayerD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deathmatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 120);
            this.Controls.Add(this.PlayerE);
            this.Controls.Add(this.PlayerD);
            this.Controls.Add(this.PlayerC);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.PlayerA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deathmatch";
            this.ShowIcon = false;
            this.Text = "데스메치 오버레이";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deathmatch_Closing);
            this.Load += new System.EventHandler(this.Deathmatch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label PlayerA;
        private Label PlayerB;
        private Label PlayerC;
        private Label PlayerE;
        private Label PlayerD;
    }
}
