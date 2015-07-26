using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        private int CurrentActivity = 0;
        internal Activity.ActivityList Activities;
        private Form RemindForm = new FormRemind();

        internal FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey RegSettings = Registry.CurrentUser.OpenSubKey("Software\\Gartech\\Fitness Reminder");
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

                var ActivitiesReg = RegSettings.GetValue("ActivityList");
                if (ActivitiesReg != null)
                {
                    using (var ms = new MemoryStream((byte[]) ActivitiesReg))
                    {
                        var formatter = new BinaryFormatter();
                        Activities = (Activity.ActivityList)formatter.Deserialize(ms);
                    }
                }
                else
                {
                    Activities = new Activity.ActivityList();
                }
                ListViewActivity.Items.AddRange(Activities.ToLviRange());

                var _DefaultDelayPre = RegSettings.GetValue("DefaultDelayPre");
                if (_DefaultDelayPre != null)
                {
                    NumericReminderPre.Value = Convert.ToInt32(DefaultDelayPre);
                }
                var _DefaultDuration = RegSettings.GetValue("DefaultDuration");
                if (_DefaultDuration != null)
                {
                    NumericReminderDuration.Value = Convert.ToInt32(DefaultDelayPre);
                }
                var _DefaultDelayPost = RegSettings.GetValue("DefaultDelayPost");
                if (_DefaultDelayPost != null)
                {
                    NumericReminderPost.Value = Convert.ToInt32(DefaultDuration);
                }
                var _DisplayType = RegSettings.GetValue("DisplayType");
                if (_DisplayType != null)
                {
                    switch (Convert.ToInt32(_DisplayType))
                    {
                        case 1:
                            radioButton1.Checked = true;
                            break;
                        case 2:
                            radioButton2.Checked = true;
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
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

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var ItemForm = new FormItem(this);
            if (ItemForm.ShowDialog() == DialogResult.OK)
            {
                ListViewActivity.Items.Clear();
                ListViewActivity.Items.AddRange(Activities.ToLviRange());
            }
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

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (ListViewActivity.Items.Count > 0)
            {
                Activities.Clear();
                Activities.AddLviRange(ListViewActivity.Items);

                try
                {
                    RegistryKey RegSettings =
                        Registry.CurrentUser.CreateSubKey("Software\\Gartech\\Fitness Reminder");
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
                    RegSettings.SetValue("DisplayType", (radioButton1.Checked ? 1 : 2), RegistryValueKind.DWord);
                }
                catch (Exception Ex)
                {
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
                            RemindForm.Show();
                        }
                        break;
                    case 2: //Activity Reminder Duration
                        FitnessNotifyIcon.Text = "Fitness Reminder - Activity! [" + (((decimal)Activities[CurrentActivity].Duration - FitnessTimerTick)) + "s]";
                        if (FitnessTimerTick >= Activities[CurrentActivity].Duration)
                        {
                            FitnessTimerStep = 3;
                            FitnessTimerTick = 0;
                            RemindForm.Hide();
                        }
                        break;
                    case 3: //Activity Post-Delay
                        FitnessNotifyIcon.Text = "Fitness Reminder - Cooldown [" + (((decimal)Activities[CurrentActivity].DelayPost - FitnessTimerTick)) + "s]";
                        if (FitnessTimerTick >= Activities[CurrentActivity].DelayPost)
                        {
                            FitnessTimerStep = 1;
                            FitnessTimerTick = 0;
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
                    /*foreach (var Act in _Activities)
                    {
                        if (Act.Index == Index)
                        {
                            return Act;
                        }
                    }
                    return null;*/
                }
            }
            internal void Clear()
            {
                _Activities.Clear();
            }
            internal void Add(string Name, int DelayPre, int Duration, int DelayPost)
            {
                _Activities.Add(new ActivityItem(Name, DelayPre, Duration, DelayPost/*, _Activities.Count*/));
            }
            internal void AddLviRange(ListView.ListViewItemCollection LVIs)
            {
                foreach (ListViewItem LVI in LVIs)
                {
                    _Activities.Add(new ActivityItem(LVI.Text, Convert.ToInt32(LVI.SubItems[1].Text),
                        Convert.ToInt32(LVI.SubItems[2].Text), Convert.ToInt32(LVI.SubItems[3].Text)/*, Convert.ToInt32(LVI.SubItems[4].Text)*/));
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
                    //EntryLVI.SubItems.Add(Act.Index.ToString());
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
            /*private int _Index;
            internal int Index
            {
                get { return _Index; }
            }*/
            internal ActivityItem(string Name, int DelayPre, int Duration, int DelayPost/*, int Index*/)
            {
                _Name = Name;
                _DelayPre = DelayPre;
                _Duration = Duration;
                _DelayPost = DelayPost;
                /*_Index = Index;*/
            }
        }
    }
}
