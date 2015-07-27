namespace FitnessReminder
{
    partial class FormItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItem));
            this.LabelActivity = new System.Windows.Forms.Label();
            this.PictureBoxActivity = new System.Windows.Forms.PictureBox();
            this.TextBoxActivityName = new System.Windows.Forms.TextBox();
            this.NumericReminderPre = new System.Windows.Forms.NumericUpDown();
            this.LabelReminderDuration = new System.Windows.Forms.Label();
            this.LabelReminderInterval = new System.Windows.Forms.Label();
            this.LabelReminderDurationSeconds = new System.Windows.Forms.Label();
            this.NumericReminderDuration = new System.Windows.Forms.NumericUpDown();
            this.LabelReminderIntervalMinutes = new System.Windows.Forms.Label();
            this.LabelActivityName = new System.Windows.Forms.Label();
            this.NumericReminderPost = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPost)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelActivity
            // 
            this.LabelActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelActivity.Location = new System.Drawing.Point(65, 10);
            this.LabelActivity.Name = "LabelActivity";
            this.LabelActivity.Size = new System.Drawing.Size(220, 48);
            this.LabelActivity.TabIndex = 13;
            this.LabelActivity.Text = "List of activites that the reminder will display. Diplayed in order from top to b" +
    "ottom. Unchecked items will be skipped.";
            this.LabelActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxActivity
            // 
            this.PictureBoxActivity.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxActivity.Image")));
            this.PictureBoxActivity.Location = new System.Drawing.Point(10, 10);
            this.PictureBoxActivity.Name = "PictureBoxActivity";
            this.PictureBoxActivity.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxActivity.TabIndex = 12;
            this.PictureBoxActivity.TabStop = false;
            // 
            // TextBoxActivityName
            // 
            this.TextBoxActivityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxActivityName.Location = new System.Drawing.Point(115, 67);
            this.TextBoxActivityName.Name = "TextBoxActivityName";
            this.TextBoxActivityName.Size = new System.Drawing.Size(138, 21);
            this.TextBoxActivityName.TabIndex = 15;
            // 
            // NumericReminderPre
            // 
            this.NumericReminderPre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericReminderPre.Location = new System.Drawing.Point(115, 100);
            this.NumericReminderPre.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumericReminderPre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericReminderPre.Name = "NumericReminderPre";
            this.NumericReminderPre.Size = new System.Drawing.Size(93, 21);
            this.NumericReminderPre.TabIndex = 17;
            this.NumericReminderPre.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LabelReminderDuration
            // 
            this.LabelReminderDuration.Location = new System.Drawing.Point(20, 133);
            this.LabelReminderDuration.Name = "LabelReminderDuration";
            this.LabelReminderDuration.Size = new System.Drawing.Size(89, 13);
            this.LabelReminderDuration.TabIndex = 19;
            this.LabelReminderDuration.Text = "Duration :";
            this.LabelReminderDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelReminderInterval
            // 
            this.LabelReminderInterval.Location = new System.Drawing.Point(20, 102);
            this.LabelReminderInterval.Name = "LabelReminderInterval";
            this.LabelReminderInterval.Size = new System.Drawing.Size(89, 13);
            this.LabelReminderInterval.TabIndex = 16;
            this.LabelReminderInterval.Text = "Pre-Delay :";
            this.LabelReminderInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelReminderDurationSeconds
            // 
            this.LabelReminderDurationSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelReminderDurationSeconds.Location = new System.Drawing.Point(213, 133);
            this.LabelReminderDurationSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReminderDurationSeconds.Name = "LabelReminderDurationSeconds";
            this.LabelReminderDurationSeconds.Size = new System.Drawing.Size(58, 13);
            this.LabelReminderDurationSeconds.TabIndex = 21;
            this.LabelReminderDurationSeconds.Text = "seconds";
            // 
            // NumericReminderDuration
            // 
            this.NumericReminderDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericReminderDuration.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericReminderDuration.Location = new System.Drawing.Point(115, 131);
            this.NumericReminderDuration.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.NumericReminderDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericReminderDuration.Name = "NumericReminderDuration";
            this.NumericReminderDuration.Size = new System.Drawing.Size(93, 21);
            this.NumericReminderDuration.TabIndex = 20;
            this.NumericReminderDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelReminderIntervalMinutes
            // 
            this.LabelReminderIntervalMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelReminderIntervalMinutes.Location = new System.Drawing.Point(213, 102);
            this.LabelReminderIntervalMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReminderIntervalMinutes.Name = "LabelReminderIntervalMinutes";
            this.LabelReminderIntervalMinutes.Size = new System.Drawing.Size(57, 13);
            this.LabelReminderIntervalMinutes.TabIndex = 18;
            this.LabelReminderIntervalMinutes.Text = "minutes";
            // 
            // LabelActivityName
            // 
            this.LabelActivityName.Location = new System.Drawing.Point(20, 70);
            this.LabelActivityName.Name = "LabelActivityName";
            this.LabelActivityName.Size = new System.Drawing.Size(89, 13);
            this.LabelActivityName.TabIndex = 22;
            this.LabelActivityName.Text = "Name :";
            this.LabelActivityName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericReminderPost
            // 
            this.NumericReminderPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericReminderPost.Location = new System.Drawing.Point(115, 161);
            this.NumericReminderPost.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumericReminderPost.Name = "NumericReminderPost";
            this.NumericReminderPost.Size = new System.Drawing.Size(93, 21);
            this.NumericReminderPost.TabIndex = 24;
            this.NumericReminderPost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Post-Delay :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(213, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "minutes";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(154, 203);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 27;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(73, 203);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 26;
            this.ButtonOK.Text = "&OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // FormItem
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(296, 237);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.NumericReminderPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelActivityName);
            this.Controls.Add(this.NumericReminderPre);
            this.Controls.Add(this.LabelReminderDuration);
            this.Controls.Add(this.LabelReminderInterval);
            this.Controls.Add(this.LabelReminderDurationSeconds);
            this.Controls.Add(this.NumericReminderDuration);
            this.Controls.Add(this.LabelReminderIntervalMinutes);
            this.Controls.Add(this.TextBoxActivityName);
            this.Controls.Add(this.LabelActivity);
            this.Controls.Add(this.PictureBoxActivity);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fitness Reminder";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelActivity;
        private System.Windows.Forms.PictureBox PictureBoxActivity;
        private System.Windows.Forms.TextBox TextBoxActivityName;
        private System.Windows.Forms.NumericUpDown NumericReminderPre;
        private System.Windows.Forms.Label LabelReminderDuration;
        private System.Windows.Forms.Label LabelReminderInterval;
        private System.Windows.Forms.Label LabelReminderDurationSeconds;
        private System.Windows.Forms.NumericUpDown NumericReminderDuration;
        private System.Windows.Forms.Label LabelReminderIntervalMinutes;
        private System.Windows.Forms.Label LabelActivityName;
        private System.Windows.Forms.NumericUpDown NumericReminderPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
    }
}