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
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pnlStats.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblHeroStats);
            this.pnlStats.Location = new System.Drawing.Point(509, 12);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(493, 145);
            this.pnlStats.TabIndex = 0;
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblHeroStats.Location = new System.Drawing.Point(3, 15);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(0, 31);
            this.lblHeroStats.TabIndex = 0;
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
            this.pnlDisplay.Location = new System.Drawing.Point(10, 12);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(493, 472);
            this.pnlDisplay.TabIndex = 1;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.richTextBox1);
            this.pnlText.Location = new System.Drawing.Point(509, 163);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(488, 401);
            this.pnlText.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 380);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnAttack);
            this.pnlControls.Controls.Add(this.btnRight);
            this.pnlControls.Controls.Add(this.btnDown);
            this.pnlControls.Controls.Add(this.btnUp);
            this.pnlControls.Controls.Add(this.btnLeft);
            this.pnlControls.Location = new System.Drawing.Point(10, 490);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(493, 74);
            this.pnlControls.TabIndex = 3;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnAttack.Location = new System.Drawing.Point(298, 3);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(192, 62);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnRight.Location = new System.Drawing.Point(224, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(68, 62);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnDown.Location = new System.Drawing.Point(150, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(68, 62);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "\\/";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnUp.Location = new System.Drawing.Point(73, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(71, 62);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "/\\";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnLeft.Location = new System.Drawing.Point(3, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(64, 62);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // frmARPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 578);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlStats);
            this.Name = "frmARPG";
            this.Text = "Action RPG";
            this.Load += new System.EventHandler(this.frmARPG_Load);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlText.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblHeroStats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
    }
}

