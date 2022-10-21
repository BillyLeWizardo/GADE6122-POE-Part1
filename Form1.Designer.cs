namespace GADE6122_POE_Part1
{
    partial class frmARPG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblAttackMessage = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnNoMove = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lstEnemies = new System.Windows.Forms.ListBox();
            this.pnlStats.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 96);
            this.panel1.TabIndex = 0;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Location = new System.Drawing.Point(13, 15);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(657, 581);
            this.pnlDisplay.TabIndex = 1;
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblHeroStats.Location = new System.Drawing.Point(4, 9);
            this.lblHeroStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(186, 36);
            this.lblHeroStats.TabIndex = 0;
            this.lblHeroStats.Text = "Stat Go Here";
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblAttackMessage);
            this.pnlStats.Controls.Add(this.lblHeroStats);
            this.pnlStats.Location = new System.Drawing.Point(679, 15);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(673, 461);
            this.pnlStats.TabIndex = 0;
            // 
            // lblAttackMessage
            // 
            this.lblAttackMessage.AutoSize = true;
            this.lblAttackMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.lblAttackMessage.Location = new System.Drawing.Point(4, 271);
            this.lblAttackMessage.Name = "lblAttackMessage";
            this.lblAttackMessage.Size = new System.Drawing.Size(328, 32);
            this.lblAttackMessage.TabIndex = 1;
            this.lblAttackMessage.Text = "Attack Message Go Here";
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnLeft.Location = new System.Drawing.Point(4, 4);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(85, 76);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnUp.Location = new System.Drawing.Point(97, 4);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(95, 76);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "/\\";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnDown.Location = new System.Drawing.Point(200, 4);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(91, 76);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "\\/";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnRight.Location = new System.Drawing.Point(299, 4);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(91, 76);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnNoMove
            // 
            this.btnNoMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnNoMove.Location = new System.Drawing.Point(397, 4);
            this.btnNoMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoMove.Name = "btnNoMove";
            this.btnNoMove.Size = new System.Drawing.Size(256, 76);
            this.btnNoMove.TabIndex = 4;
            this.btnNoMove.Text = "No Move";
            this.btnNoMove.UseVisualStyleBackColor = true;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnNoMove);
            this.pnlControls.Controls.Add(this.btnRight);
            this.pnlControls.Controls.Add(this.btnDown);
            this.pnlControls.Controls.Add(this.btnUp);
            this.pnlControls.Controls.Add(this.btnLeft);
            this.pnlControls.Location = new System.Drawing.Point(13, 603);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(657, 92);
            this.pnlControls.TabIndex = 3;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.btnAttack);
            this.pnlText.Controls.Add(this.lstEnemies);
            this.pnlText.Location = new System.Drawing.Point(679, 484);
            this.pnlText.Margin = new System.Windows.Forms.Padding(4);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(673, 211);
            this.pnlText.TabIndex = 2;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAttack.Location = new System.Drawing.Point(4, 4);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(133, 196);
            this.btnAttack.TabIndex = 5;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // lstEnemies
            // 
            this.lstEnemies.FormattingEnabled = true;
            this.lstEnemies.ItemHeight = 16;
            this.lstEnemies.Location = new System.Drawing.Point(144, 4);
            this.lstEnemies.Name = "lstEnemies";
            this.lstEnemies.Size = new System.Drawing.Size(526, 196);
            this.lstEnemies.TabIndex = 0;
            // 
            // frmARPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 708);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlStats);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmARPG";
            this.Text = "Action RPG";
            this.Load += new System.EventHandler(this.frmARPG_Load);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblHeroStats;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnNoMove;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.ListBox lstEnemies;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblAttackMessage;
    }
}

