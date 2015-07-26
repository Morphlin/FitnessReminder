using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Fitness_Minder
{
    internal partial class FormSettings : Form
    {
        private bool InitialStart = true;
        private bool CanExit;
        private bool TimerEnabled;
        internal int DefaultDelayPre
        {
            get { return (Convert.ToInt32(NumericReminderPre.Value)*60); }
        }
        internal int DefaultDuration
        {
            get { return Convert.ToInt32(NumericReminderDuration.Value); }
        }
        internal int DefaultDelayPost
        {
            get { return (Convert.ToInt32(NumericReminderPost.Value)*60); }
        }
        private Activity.ActivityList Activities;
        private FormRemind RemindForm = new FormRemind();
        private FileInfo SoundFile;

        internal FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey RegSettings = Registry.CurrentUser.OpenSubKey("Software\\Gartech\\Fitness Reminder");
                try
                {
                    var _CommandPanel = RegSettings.GetValue("CommandPanel");
                    if (_CommandPanel != null)
                    {
                        switch (Convert.ToChar(_CommandPanel))
                        {
                            case 'T':
                                ToolStripActivity.Parent = ToolStripContainerActivity.TopToolStripPanel;
                                break;
                            case 'B':
                                ToolStripActivity.Parent = ToolStripContainerActivity.BottomToolStripPanel;
                                break;
                            case 'L':
                                ToolStripActivity.Parent = ToolStripContainerActivity.LeftToolStripPanel;
                                break;
                            case 'R':
                                ToolStripActivity.Parent = ToolStripContainerActivity.RightToolStripPanel;
                                break;
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                try
                {
                    var ActivitiesReg = RegSettings.GetValue("ActivityList");
                    if (ActivitiesReg != null)
                    {
                        using (var ms = new MemoryStream((byte[]) ActivitiesReg))
                        {
                            var formatter = new BinaryFormatter();
                            Activities = (Activity.ActivityList) formatter.Deserialize(ms);
                        }
                    }
                    else
                    {
                        Activities = new Activity.ActivityList();
                    }
                    ListViewActivity.Items.AddRange(Activities.ToLviRange());
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
                try
                {
                var _DefaultDelayPre = RegSettings.GetValue("DefaultDelayPre");
                if (_DefaultDelayPre != null)
                {
                    NumericReminderPre.Value = Convert.ToInt32(_DefaultDelayPre);
                }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                    
                try
                {
                var _DefaultDuration = RegSettings.GetValue("DefaultDuration");
                if (_DefaultDuration != null)
                {
                    NumericReminderDuration.Value = Convert.ToInt32(_DefaultDuration);
                }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                    
                try
                {
                var _DefaultDelayPost = RegSettings.GetValue("DefaultDelayPost");
                if (_DefaultDelayPost != null)
                {
                    NumericReminderPost.Value = Convert.ToInt32(_DefaultDelayPost);
                }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                try
                {
                var _DisplayType = RegSettings.GetValue("DisplayType");
                if (_DisplayType != null)
                {
                    switch (Convert.ToInt32(_DisplayType))
                    {
                        case 1:
                            RadioButtonBalloon.Checked = true;
                            break;
                        case 2:
                            RadioButtonSplash.Checked = true;
                            break;
                    }
                }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                try
                {
                var _DisplayFont = RegSettings.GetValue("DisplayFont");
                if (_DisplayFont != null)
                {
                    using (var ms = new MemoryStream((byte[])_DisplayFont))
                    {
                        var formatter = new BinaryFormatter();
                        LabelSplashExample.Font = (System.Drawing.Font)formatter.Deserialize(ms);
                    }
                }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                try
                {
                    var _DisplayBackColor = RegSettings.GetValue("DisplayBackColor");
                    if (_DisplayBackColor != null)
                    {
                        using (var ms = new MemoryStream((byte[])_DisplayBackColor))
                        {
                            var formatter = new BinaryFormatter();
                            LabelSplashExample.BackColor = (System.Drawing.Color)formatter.Deserialize(ms);
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                //load PlaySound et PlaySoundFile from registry
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            try
            {
                RegistryKey RegSettings = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                var _AutoStartup = RegSettings.GetValue("Fitness Reminder");
                if (_AutoStartup != null)
                {
                    CheckBoxWindowsStart.Checked = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanExit)
            {
                HideIt();
                e.Cancel = true;
            }
        }

        private void ShowIt()
        {
            pauseToolStripMenuItem.Enabled = false;
            TimerEnabled = false;
            ListViewActivity.Items.AddRange(Activities.ToLviRange());
            Show();
        }

        private void HideIt()
        {
            pauseToolStripMenuItem.Enabled = true;
            ListViewActivity.Items.Clear();
            Hide();
        }

        private void FitnessNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowIt();
        }

        internal void AddLviActivity(string Name, int DelayPre, int Duration, int DelayPost)
        {
            var EntryLVI = new ListViewItem(Name);
            EntryLVI.ImageIndex = 0;
            EntryLVI.SubItems.Add(DelayPre.ToString());
            EntryLVI.SubItems.Add(Duration.ToString());
            EntryLVI.SubItems.Add(DelayPost.ToString());
            ListViewActivity.Items.Add(EntryLVI);
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var ItemForm = new FormItem(this);
            ItemForm.ShowDialog();
        }

        private void ToolStripButtonUp_Click(object sender, EventArgs e)
        {
            if (ListViewActivity.SelectedItems.Count > 0)
            {
                var currentIndex = ListViewActivity.SelectedItems[0].Index;
                var item = ListViewActivity.Items[currentIndex];
                if (currentIndex > 0)
                {
                    ListViewActivity.Items.RemoveAt(currentIndex);
                    ListViewActivity.Items.Insert(currentIndex - 1, item);
                }
            }
        }

        private void ToolStripButtonDown_Click(object sender, EventArgs e)
        {
            if (ListViewActivity.SelectedItems.Count > 0)
            {
                var currentIndex = ListViewActivity.SelectedItems[0].Index;
                var item = ListViewActivity.Items[currentIndex];
                if (currentIndex + 1 < ListViewActivity.Items.Count)
                {
                    ListViewActivity.Items.RemoveAt(currentIndex);
                    ListViewActivity.Items.Insert(currentIndex + 1, item);
                }
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListViewActivity.SelectedItems.Count > 0)
            {
                ListViewActivity.SelectedItems[0].Remove();
            }
        }

        private void ListViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripButtonUp.Enabled = (ListViewActivity.SelectedItems.Count > 0);
            ToolStripButtonDown.Enabled = (ListViewActivity.SelectedItems.Count > 0);
            ToolStripButtonDelete.Enabled = (ListViewActivity.SelectedItems.Count > 0);
        }

        private void RadioButtonBalloon_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxSplash.Visible = RadioButtonSplash.Checked;
        }

        private void RadioButtonSplash_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxSplash.Visible = RadioButtonSplash.Checked;
        }

        private void LabelSplashExample_Click(object sender, EventArgs e)
        {
            RemindForm.ShowIt("This is a test!", LabelSplashExample.Font, LabelSplashExample.BackColor, true);
        }

        private void ButtonSplashFont_Click(object sender, EventArgs e)
        {
            FontDialogSplash.Font = LabelSplashExample.Font;
            if (FontDialogSplash.ShowDialog() == DialogResult.OK)
            {
                LabelSplashExample.Font = FontDialogSplash.Font;
            }
        }

        private void ButtonSplashBackColor_Click(object sender, EventArgs e)
        {
            ColorDialogSplash.Color = LabelSplashExample.BackColor;
            if (ColorDialogSplash.ShowDialog() == DialogResult.OK)
            {
                LabelSplashExample.BackColor = ColorDialogSplash.Color;
            }
        }

        private void CheckBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            ButtonBrowseSound.Enabled = CheckBoxSound.Checked;
        }

        private void ButtonBrowseSound_Click(object sender, EventArgs e)
        {
            if (SoundFile != null) OpenFileDialogSound.FileName = SoundFile.FullName;
            if (OpenFileDialogSound.ShowDialog() == DialogResult.OK)
            {
                SoundFile = new FileInfo(OpenFileDialogSound.FileName);
                LabelSound.Text = SoundFile.Name;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (ListViewActivity.Items.Count > 0)
            {
                Activities.Clear();
                Activities.AddLviRange(ListViewActivity.Items);

                try
                {
                    var RegSettings = Registry.CurrentUser.CreateSubKey("Software\\Gartech\\Fitness Reminder");
                    if (ToolStripActivity.Parent == ToolStripContainerActivity.TopToolStripPanel)
                    {
                        RegSettings.SetValue("CommandPanel", 'T', RegistryValueKind.String);
                    }
                    if (ToolStripActivity.Parent == ToolStripContainerActivity.BottomToolStripPanel)
                    {
                        RegSettings.SetValue("CommandPanel", 'B', RegistryValueKind.String);
                    }
                    if (ToolStripActivity.Parent == ToolStripContainerActivity.LeftToolStripPanel)
                    {
                        RegSettings.SetValue("CommandPanel", 'L', RegistryValueKind.String);
                    }
                    if (ToolStripActivity.Parent == ToolStripContainerActivity.RightToolStripPanel)
                    {
                        RegSettings.SetValue("CommandPanel", 'R', RegistryValueKind.String);
                    }
                    using (var ms = new MemoryStream())
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(ms, Activities);
                        RegSettings.SetValue("ActivityList", ms.ToArray(), RegistryValueKind.Binary);
                    }
                    RegSettings.SetValue("DefaultDelayPre", NumericReminderPre.Value, RegistryValueKind.DWord);
                    RegSettings.SetValue("DefaultDuration", NumericReminderDuration.Value, RegistryValueKind.DWord);
                    RegSettings.SetValue("DefaultDelayPost", NumericReminderPost.Value, RegistryValueKind.DWord);
                    RegSettings.SetValue("DisplayType", (RadioButtonBalloon.Checked ? 1 : 2), RegistryValueKind.DWord);
                    using (var ms = new MemoryStream())
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(ms, LabelSplashExample.Font);
                        RegSettings.SetValue("DisplayFont", ms.ToArray(), RegistryValueKind.Binary);
                    }
                    using (var ms = new MemoryStream())
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(ms, LabelSplashExample.BackColor);
                        RegSettings.SetValue("DisplayBackColor", ms.ToArray(), RegistryValueKind.Binary);
                    }

                    //save PlaySound et PlaySoundFile to registry
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                try
                {
                    var RegSettings2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    if (CheckBoxWindowsStart.Checked)
                    {
                        RegSettings2.SetValue("Fitness Reminder", Application.ExecutablePath, RegistryValueKind.String);
                    }
                    else
                    {
                        RegSettings2.DeleteValue("Fitness Reminder", false);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No activity!");
                return;
            }
            if (InitialStart)
            {
                InitialStart = false;
                ButtonOK.Text = "&Ok";
                ButtonCancel.Text = "&Cancel";
            }
            TimerEnabled = true;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ListViewActivity.Items.Clear();
            if (InitialStart)
            {
                CanExit = true;
            }
            Close();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowIt();
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerEnabled = false;
            resumeToolStripMenuItem.Visible = true;
            pauseToolStripMenuItem.Visible = false;
        }
        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerEnabled = true;
            resumeToolStripMenuItem.Visible = false;
            pauseToolStripMenuItem.Visible = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanExit = true;
            Close();
        }

        private int FitnessTimerTick = 0;
        private int FitnessTimerStep = 1;
        private int CurrentActivity = 0;
        private void FitnessTimer_Tick(object sender, EventArgs e)
        {
            if (TimerEnabled)
            {
                FitnessTimerTick++;
                switch (FitnessTimerStep)
                {
                    case 1: //Activity Pre-Delay
                        FitnessNotifyIcon.Text = "Fitness Reminder - Countdown [" + (((decimal)Activities[CurrentActivity].DelayPre - FitnessTimerTick)) + "s]";
                        if (FitnessTimerTick >= Activities[CurrentActivity].DelayPre)
                        {
                            FitnessTimerStep = 2;
                            FitnessTimerTick = 0;
                            if (RadioButtonBalloon.Checked)
                            {
                                FitnessNotifyIcon.ShowBalloonTip(2000, "Fitness Reminder!", "It's time for " + Activities[CurrentActivity].Name + "!!!", ToolTipIcon.Warning);
                            }
                            if (RadioButtonSplash.Checked)
                            {
                                RemindForm.ShowIt(Activities[CurrentActivity].Name, LabelSplashExample.Font, LabelSplashExample.BackColor);
                            }
                        }
                        break;
                    case 2: //Activity Reminder Duration
                        FitnessNotifyIcon.Text = "Fitness Reminder - Activity! [" + (((decimal)Activities[CurrentActivity].Duration - FitnessTimerTick)) + "s]";
                        if (FitnessTimerTick >= Activities[CurrentActivity].Duration)
                        {
                            FitnessTimerStep = 3;
                            FitnessTimerTick = 0;
                            if (RadioButtonSplash.Checked)
                            {
                                RemindForm.Hide();
                            }
                        }
                        break;
                    case 3: //Activity Post-Delay
                        FitnessNotifyIcon.Text = "Fitness Reminder - Cooldown [" + (((decimal)Activities[CurrentActivity].DelayPost - FitnessTimerTick)) + "s]";
                        if (FitnessTimerTick >= Activities[CurrentActivity].DelayPost)
                        {
                            FitnessTimerStep = 1;
                            FitnessTimerTick = 0;
                            CurrentActivity++;
                            if (CurrentActivity > Activities.Count - 1)
                            {
                                CurrentActivity = 0;
                            }
                        }
                        break;
                    default:
                        throw new Exception("Invalid FitnessTimerStep at Switch");
                }
            }
            else
            {
                FitnessNotifyIcon.Text = "Fitness Reminder - Timer paused";
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class Activity
    {
        [Serializable]
        internal class ActivityList : IEnumerable<ActivityItem>
        {
            private List<ActivityItem> _Activities;
            internal ActivityList()
            {
                _Activities = new List<ActivityItem>();
            }
            internal ActivityItem this[int Index]
            {
                get
                {
                    return _Activities[Index];
                }
            }
            internal int Count
            {
                get
                {
                    return _Activities.Count();
                }
            }
            internal void Clear()
            {
                _Activities.Clear();
            }
            internal void Add(string Name, int DelayPre, int Duration, int DelayPost)
            {
                _Activities.Add(new ActivityItem(Name, DelayPre, Duration, DelayPost));
            }
            internal void AddLviRange(ListView.ListViewItemCollection LVIs)
            {
                foreach (ListViewItem LVI in LVIs)
                {
                    _Activities.Add(new ActivityItem(LVI.Text, Convert.ToInt32(LVI.SubItems[1].Text),
                        Convert.ToInt32(LVI.SubItems[2].Text), Convert.ToInt32(LVI.SubItems[3].Text)));
                }
            }
            internal ListViewItem[] ToLviRange()
            {
                var LVIs = new List<ListViewItem>();
                foreach (var Act in _Activities)
                {
                    var EntryLVI = new ListViewItem(Act.Name);
                    EntryLVI.ImageIndex = 0;
                    EntryLVI.SubItems.Add(Act.DelayPre.ToString());
                    EntryLVI.SubItems.Add(Act.Duration.ToString());
                    EntryLVI.SubItems.Add(Act.DelayPost.ToString());
                    LVIs.Add(EntryLVI);
                }
                return LVIs.ToArray();
            }
            public IEnumerator<ActivityItem> GetEnumerator()
            {
                return _Activities.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return _Activities.GetEnumerator();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Serializable]
        internal class ActivityItem
        {
            private string _Name;
            internal string Name
            {
                get { return _Name; }
            }
            private int _DelayPre;
            internal int DelayPre
            {
                get { return _DelayPre; }
            }
            private int _Duration;
            internal int Duration
            {
                get { return _Duration; }
            }
            private int _DelayPost;
            internal int DelayPost
            {
                get { return _DelayPost; }
            }
            internal ActivityItem(string Name, int DelayPre, int Duration, int DelayPost)
            {
                _Name = Name;
                _DelayPre = DelayPre;
                _Duration = Duration;
                _DelayPost = DelayPost;
            }
        }
    }
}
