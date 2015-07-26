namespace Fitness_Minder
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TabControlSettings = new System.Windows.Forms.TabControl();
            this.TabPageActivity = new System.Windows.Forms.TabPage();
            this.ToolStripContainerActivity = new System.Windows.Forms.ToolStripContainer();
            this.ToolStripActivity = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonUp = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonDown = new System.Windows.Forms.ToolStripButton();
            this.ListViewActivity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelActivity = new System.Windows.Forms.Label();
            this.PictureBoxActivity = new System.Windows.Forms.PictureBox();
            this.TabPageReminder = new System.Windows.Forms.TabPage();
            this.LabelReminder = new System.Windows.Forms.Label();
            this.PictureBoxReminder = new System.Windows.Forms.PictureBox();
            this.GroupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.RadioButtonSplash = new System.Windows.Forms.RadioButton();
            this.RadioButtonBalloon = new System.Windows.Forms.RadioButton();
            this.GroupBoxSplash = new System.Windows.Forms.GroupBox();
            this.ButtonSplashBackColor = new System.Windows.Forms.Button();
            this.ButtonSplashFont = new System.Windows.Forms.Button();
            this.LabelSplashExample = new System.Windows.Forms.Label();
            this.TabPageDefaults = new System.Windows.Forms.TabPage();
            this.GroupBoxDefaults = new System.Windows.Forms.GroupBox();
            this.NumericReminderPost = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericReminderPre = new System.Windows.Forms.NumericUpDown();
            this.LabelReminderDuration = new System.Windows.Forms.Label();
            this.LabelReminderInterval = new System.Windows.Forms.Label();
            this.LabelReminderDurationSeconds = new System.Windows.Forms.Label();
            this.NumericReminderDuration = new System.Windows.Forms.NumericUpDown();
            this.LabelReminderIntervalMinutes = new System.Windows.Forms.Label();
            this.LabelDefaults = new System.Windows.Forms.Label();
            this.PictureBoxDefaults = new System.Windows.Forms.PictureBox();
            this.FitnessTimer = new System.Windows.Forms.Timer(this.components);
            this.FitnessNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageListActivity = new System.Windows.Forms.ImageList(this.components);
            this.FontDialogSplash = new System.Windows.Forms.FontDialog();
            this.ColorDialogSplash = new System.Windows.Forms.ColorDialog();
            this.TabControlSettings.SuspendLayout();
            this.TabPageActivity.SuspendLayout();
            this.ToolStripContainerActivity.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainerActivity.ContentPanel.SuspendLayout();
            this.ToolStripContainerActivity.SuspendLayout();
            this.ToolStripActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxActivity)).BeginInit();
            this.TabPageReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxReminder)).BeginInit();
            this.GroupBoxDisplay.SuspendLayout();
            this.GroupBoxSplash.SuspendLayout();
            this.TabPageDefaults.SuspendLayout();
            this.GroupBoxDefaults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDefaults)).BeginInit();
            this.ContextMenuStripNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOK.Location = new System.Drawing.Point(171, 329);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "&Run";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(252, 329);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "&Exit";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TabControlSettings
            // 
            this.TabControlSettings.Controls.Add(this.TabPageActivity);
            this.TabControlSettings.Controls.Add(this.TabPageReminder);
            this.TabControlSettings.Controls.Add(this.TabPageDefaults);
            this.TabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedIndex = 0;
            this.TabControlSettings.Size = new System.Drawing.Size(315, 310);
            this.TabControlSettings.TabIndex = 8;
            // 
            // TabPageActivity
            // 
            this.TabPageActivity.Controls.Add(this.ToolStripContainerActivity);
            this.TabPageActivity.Controls.Add(this.LabelActivity);
            this.TabPageActivity.Controls.Add(this.PictureBoxActivity);
            this.TabPageActivity.Location = new System.Drawing.Point(4, 22);
            this.TabPageActivity.Name = "TabPageActivity";
            this.TabPageActivity.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageActivity.Size = new System.Drawing.Size(307, 284);
            this.TabPageActivity.TabIndex = 0;
            this.TabPageActivity.Text = "Activity List";
            this.TabPageActivity.UseVisualStyleBackColor = true;
            // 
            // ToolStripContainerActivity
            // 
            // 
            // ToolStripContainerActivity.BottomToolStripPanel
            // 
            this.ToolStripContainerActivity.BottomToolStripPanel.Controls.Add(this.ToolStripActivity);
            // 
            // ToolStripContainerActivity.ContentPanel
            // 
            this.ToolStripContainerActivity.ContentPanel.Controls.Add(this.ListViewActivity);
            this.ToolStripContainerActivity.ContentPanel.Size = new System.Drawing.Size(283, 153);
            this.ToolStripContainerActivity.Location = new System.Drawing.Point(11, 67);
            this.ToolStripContainerActivity.Name = "ToolStripContainerActivity";
            this.ToolStripContainerActivity.Size = new System.Drawing.Size(283, 203);
            this.ToolStripContainerActivity.TabIndex = 12;
            this.ToolStripContainerActivity.Text = "ToolStripContainerActivity";
            // 
            // ToolStripActivity
            // 
            this.ToolStripActivity.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonAdd,
            this.toolStripButton1,
            this.ToolStripButtonDelete,
            this.toolStripSeparator2,
            this.ToolStripButtonUp,
            this.ToolStripButtonDown});
            this.ToolStripActivity.Location = new System.Drawing.Point(3, 0);
            this.ToolStripActivity.Name = "ToolStripActivity";
            this.ToolStripActivity.Size = new System.Drawing.Size(133, 25);
            this.ToolStripActivity.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            this.ToolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonAdd.Image")));
            this.ToolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonAdd.Text = "toolStripButton1";
            this.ToolStripButtonAdd.Click += new System.EventHandler(this.ToolStripButtonAdd_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ToolStripButtonDelete
            // 
            this.ToolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonDelete.Enabled = false;
            this.ToolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonDelete.Image")));
            this.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonDelete.Text = "toolStripButton4";
            this.ToolStripButtonDelete.Click += new System.EventHandler(this.ToolStripButtonDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButtonUp
            // 
            this.ToolStripButtonUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonUp.Enabled = false;
            this.ToolStripButtonUp.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonUp.Image")));
            this.ToolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonUp.Name = "ToolStripButtonUp";
            this.ToolStripButtonUp.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonUp.Text = "toolStripButton2";
            this.ToolStripButtonUp.Click += new System.EventHandler(this.ToolStripButtonUp_Click);
            // 
            // ToolStripButtonDown
            // 
            this.ToolStripButtonDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonDown.Enabled = false;
            this.ToolStripButtonDown.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonDown.Image")));
            this.ToolStripButtonDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDown.Name = "ToolStripButtonDown";
            this.ToolStripButtonDown.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonDown.Text = "toolStripButton3";
            this.ToolStripButtonDown.Click += new System.EventHandler(this.ToolStripButtonDown_Click);
            // 
            // ListViewActivity
            // 
            this.ListViewActivity.CheckBoxes = true;
            this.ListViewActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListViewActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewActivity.FullRowSelect = true;
            this.ListViewActivity.GridLines = true;
            this.ListViewActivity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewActivity.Location = new System.Drawing.Point(0, 0);
            this.ListViewActivity.MultiSelect = false;
            this.ListViewActivity.Name = "ListViewActivity";
            this.ListViewActivity.Size = new System.Drawing.Size(283, 153);
            this.ListViewActivity.TabIndex = 0;
            this.ListViewActivity.UseCompatibleStateImageBehavior = false;
            this.ListViewActivity.View = System.Windows.Forms.View.Details;
            this.ListViewActivity.SelectedIndexChanged += new System.EventHandler(this.ListViewActivity_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Activity";
            this.columnHeader1.Width = 257;
            // 
            // LabelActivity
            // 
            this.LabelActivity.Location = new System.Drawing.Point(65, 13);
            this.LabelActivity.Name = "LabelActivity";
            this.LabelActivity.Size = new System.Drawing.Size(229, 48);
            this.LabelActivity.TabIndex = 11;
            this.LabelActivity.Text = "List of activites that the reminder will display. Diplayed in order from top to b" +
    "ottom. Unchecked items will be skipped.";
            this.LabelActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxActivity
            // 
            this.PictureBoxActivity.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxActivity.Image")));
            this.PictureBoxActivity.Location = new System.Drawing.Point(11, 13);
            this.PictureBoxActivity.Name = "PictureBoxActivity";
            this.PictureBoxActivity.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxActivity.TabIndex = 10;
            this.PictureBoxActivity.TabStop = false;
            // 
            // TabPageReminder
            // 
            this.TabPageReminder.Controls.Add(this.LabelReminder);
            this.TabPageReminder.Controls.Add(this.PictureBoxReminder);
            this.TabPageReminder.Controls.Add(this.GroupBoxDisplay);
            this.TabPageReminder.Controls.Add(this.GroupBoxSplash);
            this.TabPageReminder.Location = new System.Drawing.Point(4, 22);
            this.TabPageReminder.Name = "TabPageReminder";
            this.TabPageReminder.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageReminder.Size = new System.Drawing.Size(307, 284);
            this.TabPageReminder.TabIndex = 1;
            this.TabPageReminder.Text = "Reminder Settings";
            this.TabPageReminder.UseVisualStyleBackColor = true;
            // 
            // LabelReminder
            // 
            this.LabelReminder.Location = new System.Drawing.Point(65, 13);
            this.LabelReminder.Name = "LabelReminder";
            this.LabelReminder.Size = new System.Drawing.Size(229, 48);
            this.LabelReminder.TabIndex = 17;
            this.LabelReminder.Text = "The reminder can be displayed in a balloon tip or as a Splash screen. Select the " +
    "Splash option to tweak the font and the background.";
            this.LabelReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxReminder
            // 
            this.PictureBoxReminder.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxReminder.Image")));
            this.PictureBoxReminder.Location = new System.Drawing.Point(11, 13);
            this.PictureBoxReminder.Name = "PictureBoxReminder";
            this.PictureBoxReminder.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxReminder.TabIndex = 16;
            this.PictureBoxReminder.TabStop = false;
            // 
            // GroupBoxDisplay
            // 
            this.GroupBoxDisplay.Controls.Add(this.RadioButtonSplash);
            this.GroupBoxDisplay.Controls.Add(this.RadioButtonBalloon);
            this.GroupBoxDisplay.Location = new System.Drawing.Point(11, 69);
            this.GroupBoxDisplay.Name = "GroupBoxDisplay";
            this.GroupBoxDisplay.Size = new System.Drawing.Size(283, 84);
            this.GroupBoxDisplay.TabIndex = 14;
            this.GroupBoxDisplay.TabStop = false;
            this.GroupBoxDisplay.Text = "Reminder Type";
            // 
            // RadioButtonSplash
            // 
            this.RadioButtonSplash.Location = new System.Drawing.Point(21, 51);
            this.RadioButtonSplash.Name = "RadioButtonSplash";
            this.RadioButtonSplash.Size = new System.Drawing.Size(234, 17);
            this.RadioButtonSplash.TabIndex = 1;
            this.RadioButtonSplash.Text = "Full Screen Splash";
            this.RadioButtonSplash.UseVisualStyleBackColor = true;
            this.RadioButtonSplash.CheckedChanged += new System.EventHandler(this.RadioButtonSplash_CheckedChanged);
            // 
            // RadioButtonBalloon
            // 
            this.RadioButtonBalloon.Checked = true;
            this.RadioButtonBalloon.Location = new System.Drawing.Point(21, 27);
            this.RadioButtonBalloon.Name = "RadioButtonBalloon";
            this.RadioButtonBalloon.Size = new System.Drawing.Size(234, 17);
            this.RadioButtonBalloon.TabIndex = 0;
            this.RadioButtonBalloon.TabStop = true;
            this.RadioButtonBalloon.Text = "Balloon Tip (Notification from Tray Icon)";
            this.RadioButtonBalloon.UseVisualStyleBackColor = true;
            this.RadioButtonBalloon.CheckedChanged += new System.EventHandler(this.RadioButtonBalloon_CheckedChanged);
            // 
            // GroupBoxSplash
            // 
            this.GroupBoxSplash.Controls.Add(this.ButtonSplashBackColor);
            this.GroupBoxSplash.Controls.Add(this.ButtonSplashFont);
            this.GroupBoxSplash.Controls.Add(this.LabelSplashExample);
            this.GroupBoxSplash.Location = new System.Drawing.Point(11, 161);
            this.GroupBoxSplash.Name = "GroupBoxSplash";
            this.GroupBoxSplash.Size = new System.Drawing.Size(283, 99);
            this.GroupBoxSplash.TabIndex = 16;
            this.GroupBoxSplash.TabStop = false;
            this.GroupBoxSplash.Text = "Full Screen Splash Options";
            this.GroupBoxSplash.Visible = false;
            // 
            // ButtonSplashBackColor
            // 
            this.ButtonSplashBackColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonSplashBackColor.Location = new System.Drawing.Point(171, 60);
            this.ButtonSplashBackColor.Name = "ButtonSplashBackColor";
            this.ButtonSplashBackColor.Size = new System.Drawing.Size(90, 23);
            this.ButtonSplashBackColor.TabIndex = 10;
            this.ButtonSplashBackColor.Text = "&Back color";
            this.ButtonSplashBackColor.UseVisualStyleBackColor = true;
            this.ButtonSplashBackColor.Click += new System.EventHandler(this.ButtonSplashBackColor_Click);
            // 
            // ButtonSplashFont
            // 
            this.ButtonSplashFont.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonSplashFont.Location = new System.Drawing.Point(171, 31);
            this.ButtonSplashFont.Name = "ButtonSplashFont";
            this.ButtonSplashFont.Size = new System.Drawing.Size(90, 23);
            this.ButtonSplashFont.TabIndex = 9;
            this.ButtonSplashFont.Text = "&Font";
            this.ButtonSplashFont.UseVisualStyleBackColor = true;
            this.ButtonSplashFont.Click += new System.EventHandler(this.ButtonSplashFont_Click);
            // 
            // LabelSplashExample
            // 
            this.LabelSplashExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSplashExample.Location = new System.Drawing.Point(21, 31);
            this.LabelSplashExample.Name = "LabelSplashExample";
            this.LabelSplashExample.Size = new System.Drawing.Size(132, 52);
            this.LabelSplashExample.TabIndex = 0;
            this.LabelSplashExample.Text = "Example";
            this.LabelSplashExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPageDefaults
            // 
            this.TabPageDefaults.Controls.Add(this.GroupBoxDefaults);
            this.TabPageDefaults.Controls.Add(this.LabelDefaults);
            this.TabPageDefaults.Controls.Add(this.PictureBoxDefaults);
            this.TabPageDefaults.Location = new System.Drawing.Point(4, 22);
            this.TabPageDefaults.Name = "TabPageDefaults";
            this.TabPageDefaults.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDefaults.Size = new System.Drawing.Size(307, 284);
            this.TabPageDefaults.TabIndex = 2;
            this.TabPageDefaults.Text = "Defaults";
            this.TabPageDefaults.UseVisualStyleBackColor = true;
            // 
            // GroupBoxDefaults
            // 
            this.GroupBoxDefaults.Controls.Add(this.NumericReminderPost);
            this.GroupBoxDefaults.Controls.Add(this.label2);
            this.GroupBoxDefaults.Controls.Add(this.label3);
            this.GroupBoxDefaults.Controls.Add(this.NumericReminderPre);
            this.GroupBoxDefaults.Controls.Add(this.LabelReminderDuration);
            this.GroupBoxDefaults.Controls.Add(this.LabelReminderInterval);
            this.GroupBoxDefaults.Controls.Add(this.LabelReminderDurationSeconds);
            this.GroupBoxDefaults.Controls.Add(this.NumericReminderDuration);
            this.GroupBoxDefaults.Controls.Add(this.LabelReminderIntervalMinutes);
            this.GroupBoxDefaults.Location = new System.Drawing.Point(11, 69);
            this.GroupBoxDefaults.Name = "GroupBoxDefaults";
            this.GroupBoxDefaults.Size = new System.Drawing.Size(283, 117);
            this.GroupBoxDefaults.TabIndex = 16;
            this.GroupBoxDefaults.TabStop = false;
            this.GroupBoxDefaults.Text = "Activities Reminder";
            // 
            // NumericReminderPost
            // 
            this.NumericReminderPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericReminderPost.Location = new System.Drawing.Point(111, 84);
            this.NumericReminderPost.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumericReminderPost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericReminderPost.Name = "NumericReminderPost";
            this.NumericReminderPost.Size = new System.Drawing.Size(93, 21);
            this.NumericReminderPost.TabIndex = 33;
            this.NumericReminderPost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Post-Delay :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(209, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "minutes";
            // 
            // NumericReminderPre
            // 
            this.NumericReminderPre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericReminderPre.Location = new System.Drawing.Point(111, 23);
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
            this.NumericReminderPre.TabIndex = 27;
            this.NumericReminderPre.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LabelReminderDuration
            // 
            this.LabelReminderDuration.Location = new System.Drawing.Point(16, 56);
            this.LabelReminderDuration.Name = "LabelReminderDuration";
            this.LabelReminderDuration.Size = new System.Drawing.Size(89, 13);
            this.LabelReminderDuration.TabIndex = 29;
            this.LabelReminderDuration.Text = "Duration :";
            this.LabelReminderDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelReminderInterval
            // 
            this.LabelReminderInterval.Location = new System.Drawing.Point(16, 25);
            this.LabelReminderInterval.Name = "LabelReminderInterval";
            this.LabelReminderInterval.Size = new System.Drawing.Size(89, 13);
            this.LabelReminderInterval.TabIndex = 26;
            this.LabelReminderInterval.Text = "Pre-Delay :";
            this.LabelReminderInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelReminderDurationSeconds
            // 
            this.LabelReminderDurationSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelReminderDurationSeconds.Location = new System.Drawing.Point(209, 56);
            this.LabelReminderDurationSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReminderDurationSeconds.Name = "LabelReminderDurationSeconds";
            this.LabelReminderDurationSeconds.Size = new System.Drawing.Size(58, 13);
            this.LabelReminderDurationSeconds.TabIndex = 31;
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
            this.NumericReminderDuration.Location = new System.Drawing.Point(111, 54);
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
            this.NumericReminderDuration.TabIndex = 30;
            this.NumericReminderDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelReminderIntervalMinutes
            // 
            this.LabelReminderIntervalMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelReminderIntervalMinutes.Location = new System.Drawing.Point(209, 25);
            this.LabelReminderIntervalMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReminderIntervalMinutes.Name = "LabelReminderIntervalMinutes";
            this.LabelReminderIntervalMinutes.Size = new System.Drawing.Size(57, 13);
            this.LabelReminderIntervalMinutes.TabIndex = 28;
            this.LabelReminderIntervalMinutes.Text = "minutes";
            // 
            // LabelDefaults
            // 
            this.LabelDefaults.Location = new System.Drawing.Point(65, 13);
            this.LabelDefaults.Name = "LabelDefaults";
            this.LabelDefaults.Size = new System.Drawing.Size(229, 48);
            this.LabelDefaults.TabIndex = 15;
            this.LabelDefaults.Text = "When creating a new activity in the activity list, these settings will be use as " +
    "defaults.";
            this.LabelDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxDefaults
            // 
            this.PictureBoxDefaults.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxDefaults.Image")));
            this.PictureBoxDefaults.Location = new System.Drawing.Point(11, 13);
            this.PictureBoxDefaults.Name = "PictureBoxDefaults";
            this.PictureBoxDefaults.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxDefaults.TabIndex = 14;
            this.PictureBoxDefaults.TabStop = false;
            // 
            // FitnessTimer
            // 
            this.FitnessTimer.Enabled = true;
            this.FitnessTimer.Interval = 1000;
            this.FitnessTimer.Tick += new System.EventHandler(this.FitnessTimer_Tick);
            // 
            // FitnessNotifyIcon
            // 
            this.FitnessNotifyIcon.ContextMenuStrip = this.ContextMenuStripNotify;
            this.FitnessNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("FitnessNotifyIcon.Icon")));
            this.FitnessNotifyIcon.Text = "Fitness Reminder";
            this.FitnessNotifyIcon.Visible = true;
            this.FitnessNotifyIcon.DoubleClick += new System.EventHandler(this.FitnessNotifyIcon_DoubleClick);
            // 
            // ContextMenuStripNotify
            // 
            this.ContextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.ContextMenuStripNotify.Name = "ContextMenuStripNotify";
            this.ContextMenuStripNotify.Size = new System.Drawing.Size(117, 104);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openSettingsToolStripMenuItem.Text = "Open";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(113, 6);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Visible = false;
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ImageListActivity
            // 
            this.ImageListActivity.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListActivity.ImageStream")));
            this.ImageListActivity.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListActivity.Images.SetKeyName(0, "Disaster.png");
            // 
            // FontDialogSplash
            // 
            this.FontDialogSplash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormSettings
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(337, 362);
            this.Controls.Add(this.TabControlSettings);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.TabControlSettings.ResumeLayout(false);
            this.TabPageActivity.ResumeLayout(false);
            this.ToolStripContainerActivity.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainerActivity.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainerActivity.ContentPanel.ResumeLayout(false);
            this.ToolStripContainerActivity.ResumeLayout(false);
            this.ToolStripContainerActivity.PerformLayout();
            this.ToolStripActivity.ResumeLayout(false);
            this.ToolStripActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxActivity)).EndInit();
            this.TabPageReminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxReminder)).EndInit();
            this.GroupBoxDisplay.ResumeLayout(false);
            this.GroupBoxSplash.ResumeLayout(false);
            this.TabPageDefaults.ResumeLayout(false);
            this.GroupBoxDefaults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericReminderDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDefaults)).EndInit();
            this.ContextMenuStripNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TabControl TabControlSettings;
        private System.Windows.Forms.TabPage TabPageActivity;
        private System.Windows.Forms.TabPage TabPageReminder;
        private System.Windows.Forms.Timer FitnessTimer;
        private System.Windows.Forms.NotifyIcon FitnessNotifyIcon;
        private System.Windows.Forms.PictureBox PictureBoxActivity;
        private System.Windows.Forms.ListView ListViewActivity;
        private System.Windows.Forms.ToolStripContainer ToolStripContainerActivity;
        private System.Windows.Forms.ToolStrip ToolStripActivity;
        private System.Windows.Forms.Label LabelActivity;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolStripButtonUp;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDown;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox GroupBoxDisplay;
        private System.Windows.Forms.RadioButton RadioButtonSplash;
        private System.Windows.Forms.RadioButton RadioButtonBalloon;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList ImageListActivity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.Label LabelReminder;
        private System.Windows.Forms.PictureBox PictureBoxReminder;
        private System.Windows.Forms.GroupBox GroupBoxSplash;
        private System.Windows.Forms.TabPage TabPageDefaults;
        private System.Windows.Forms.GroupBox GroupBoxDefaults;
        private System.Windows.Forms.NumericUpDown NumericReminderPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericReminderPre;
        private System.Windows.Forms.Label LabelReminderDuration;
        private System.Windows.Forms.Label LabelReminderInterval;
        private System.Windows.Forms.Label LabelReminderDurationSeconds;
        private System.Windows.Forms.NumericUpDown NumericReminderDuration;
        private System.Windows.Forms.Label LabelReminderIntervalMinutes;
        private System.Windows.Forms.Label LabelDefaults;
        private System.Windows.Forms.PictureBox PictureBoxDefaults;
        private System.Windows.Forms.Button ButtonSplashBackColor;
        private System.Windows.Forms.Button ButtonSplashFont;
        private System.Windows.Forms.Label LabelSplashExample;
        private System.Windows.Forms.FontDialog FontDialogSplash;
        private System.Windows.Forms.ColorDialog ColorDialogSplash;
    }
}

