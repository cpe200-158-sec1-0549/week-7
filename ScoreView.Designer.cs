namespace twozerofoureight
{
    partial class ScoreView
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
            this.score_txt_scoreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score_txt_scoreview
            // 
            this.score_txt_scoreview.AutoSize = true;
            this.score_txt_scoreview.Location = new System.Drawing.Point(111, 100);
            this.score_txt_scoreview.Name = "score_txt_scoreview";
            this.score_txt_scoreview.Size = new System.Drawing.Size(35, 13);
            this.score_txt_scoreview.TabIndex = 0;
            this.score_txt_scoreview.Text = "label1";
            this.score_txt_scoreview.Click += new System.EventHandler(this.score_txt_scoreview_Click);
            // 
            // ScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.score_txt_scoreview);
            this.Name = "ScoreView";
            this.Text = "ScoreView";
            this.Load += new System.EventHandler(this.ScoreView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_txt_scoreview;
    }
}