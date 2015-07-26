namespace Fitness_Minder
{
    partial class FormRemind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemind));
            this.LabelActivity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelActivity
            // 
            this.LabelActivity.BackColor = System.Drawing.Color.Orange;
            this.LabelActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelActivity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelActivity.Location = new System.Drawing.Point(0, 0);
            this.LabelActivity.Name = "LabelActivity";
            this.LabelActivity.Size = new System.Drawing.Size(551, 283);
            this.LabelActivity.TabIndex = 1;
            this.LabelActivity.Text = "FITNESS!";
            this.LabelActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelActivity.Click += new System.EventHandler(this.LabelActivity_Click);
            // 
            // FormRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(551, 283);
            this.Controls.Add(this.LabelActivity);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRemind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness Minder";
            this.Load += new System.EventHandler(this.FormRemind_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelActivity;
    }
}