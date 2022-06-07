namespace CHET_WPF
{
    partial class FeelingsCheckPoint
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
            this.Checkpoint = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Checkpoint
            // 
            this.Checkpoint.AutoSize = true;
            this.Checkpoint.BackColor = System.Drawing.Color.Transparent;
            this.Checkpoint.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Checkpoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Checkpoint.Location = new System.Drawing.Point(12, 29);
            this.Checkpoint.Name = "Checkpoint";
            this.Checkpoint.Size = new System.Drawing.Size(776, 54);
            this.Checkpoint.TabIndex = 0;
            this.Checkpoint.Text = "Did that decision help you feel better?";
            this.Checkpoint.Click += new System.EventHandler(this.Yes_Click);
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Chartreuse;
            this.Yes.Font = new System.Drawing.Font("Berlin Sans FB", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yes.Location = new System.Drawing.Point(320, 113);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(163, 126);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "YES! ";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click_1);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Salmon;
            this.No.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.No.Location = new System.Drawing.Point(57, 272);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(716, 126);
            this.No.TabIndex = 2;
            this.No.Text = "Not yet, I\'d like to choose again.";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // FeelingsCheckPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Checkpoint);
            this.Name = "FeelingsCheckPoint";
            this.Text = "FeelingsCheckPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Checkpoint;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
    }
}