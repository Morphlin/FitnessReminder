using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Fitness_Minder
{
    internal partial class FormSettings : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private bool InitialStart = true;
        /// <summary>
        /// 
        /// </summary>
        private bool CanExit;
        /// <summary>
        /// 
        /// </summary>
        private bool TimerEnabled;

        /// <summary>
        /// 
        /// </summary>
        private RegistrySettings RegSettings;

        /// <summary>
        /// 
        /// </summary>
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
        private System.Media.SoundPlayer MediaPlayer;

        private const string AutoStartKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        private bool AutoStartAtLogon
        {
            get
            {
                try
                {
                    var AutoStartRegistry = Registry.CurrentUser.OpenSubKey(AutoStartKey);
                    var _AutoStartup = AutoStartRegistry.GetValue("Fitness Reminder");
                    return (_AutoStartup != null);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                return false;
            }
            set
            {
                try
                {
                    var AutoStartRegistry = Registry.CurrentUser.OpenSubKey(AutoStartKey, true);
                    if (value)
                    {
                        AutoStartRegistry.SetValue("Fitness Reminder", Application.ExecutablePath, RegistryValueKind.String);
                    }
                    else
                    {
                        AutoStartRegistry.DeleteValue("Fitness Reminder", false);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        internal FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            RegSettings = new RegistrySettings();

            switch (Convert.ToChar(RegSettings.GetCommandPanel()))
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

            Activities = RegSettings.GetActivityList();
            ListViewActivity.Items.AddRange(Activities.ToLviRange());

            NumericReminderPre.Value = RegSettings.GetDefaultDelayPre();
            NumericReminderDuration.Value = RegSettings.GetDefaultDuration();
            NumericReminderPost.Value = RegSettings.GetDefaultDelayPost();

            switch (RegSettings.GetDisplayType())
            {
                case 1:
                    RadioButtonSplash.Checked = true;
                    break;
                case 2:
                    RadioButtonBalloon.Checked = true;
                    break;
            }

            LabelSplashExample.Font = RegSettings.GetDisplayFont() ?? LabelSplashExample.Font;
            LabelSplashExample.BackColor = RegSettings.GetDisplayBackColor();
            CheckBoxSound.Checked = RegSettings.GetDisplaySound();

            var SoundFile = RegSettings.GetDisplaySoundFile();
            if (SoundFile != null)
            {
                LabelSound.Text = SoundFile.Name;
                MediaPlayer = new System.Media.SoundPlayer(SoundFile.FullName);
            }

            CheckBoxWindowsStart.Checked = AutoStartAtLogon;
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

        private void LabelSound_Click(object sender, EventArgs e)
        {
            if (MediaPlayer!= null ) MediaPlayer.Play();
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
            if (MediaPlayer != null) OpenFileDialogSound.FileName = MediaPlayer.SoundLocation;
            if (OpenFileDialogSound.ShowDialog() == DialogResult.OK)
            {
                var SoundFile = new FileInfo(OpenFileDialogSound.FileName);
                if (SoundFile.Exists)
                {
                    LabelSound.Text = SoundFile.Name;
                    MediaPlayer = new System.Media.SoundPlayer(SoundFile.FullName);
                }
            }
        }

        private void ButtonResetSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("App must close to take effect.", "Fitness Reminder", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RegSettings.Close();
                try
                {
                    //Initialises the registry or simply opens a handle.
                    Registry.CurrentUser.DeleteSubKeyTree("Software\\Gartech\\Fitness Reminder");
                    CanExit = true;
                    Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (ListViewActivity.Items.Count > 0)
            {
                Activities.Clear();
                Activities.AddLviRange(ListViewActivity.Items);

                RegSettings.SetCommandPanel(ToolStripActivity.Parent);

                RegSettings.SetActivityList(Activities);

                RegSettings.SetDefaultDelayPre(NumericReminderPre.Value);
                RegSettings.SetDefaultDuration(NumericReminderDuration.Value);
                RegSettings.SetDefaultDelayPost(NumericReminderPost.Value);

                RegSettings.SetDisplayType((RadioButtonSplash.Checked ? 1 : 2));
                RegSettings.SetDisplayFont(LabelSplashExample.Font);
                RegSettings.SetDisplayBackColor(LabelSplashExample.BackColor);

                RegSettings.SetDisplaySound(CheckBoxSound.Checked);
                RegSettings.SetDisplaySoundFile(MediaPlayer);

                AutoStartAtLogon = CheckBoxWindowsStart.Checked;
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
                                if (CheckBoxSound.Checked) MediaPlayer.Play();
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
        /// <summary>
        /// 
        /// </summary>
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
                    return _Activities.Count;
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

    internal class RegistrySettings
    {
        /// <summary>
        /// Registry key for settings.
        /// </summary>
        private RegistryKey RegistryAccess;

        /// <summary>
        /// 
        /// </summary>
        internal RegistrySettings()
        {
            //Registry initialization.
            try
            {
                //Initialises the registry or simply opens a handle.
                RegistryAccess = Registry.CurrentUser.CreateSubKey("Software\\Gartech\\Fitness Reminder");
            }
            catch (Exception Ex)
            {
                //If access failed, prevent registry access and give user a warning.
                RegistryAccess = null;
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        internal void Close()
        {
            RegistryAccess.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private const string CommandPanelName = "CommandPanel";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal char GetCommandPanel()
        {
            try
            {
                var _CommandPanel = RegistryAccess.GetValue(CommandPanelName);
                if (_CommandPanel != null)
                {
                    return (Convert.ToChar(_CommandPanel));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return 'B'; //Default Bottom Value
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetCommandPanel(Control PanelParent)
        {
            try
            {
                RegistryAccess.SetValue(CommandPanelName, Convert.ToString(PanelParent.Tag), RegistryValueKind.String);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private const string ActivityListName = "ActivityList";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal Activity.ActivityList GetActivityList()
        {
            try
            {
                var _ActivityList = RegistryAccess.GetValue(ActivityListName);
                if (_ActivityList != null)
                {
                    using (var MemStream = new MemoryStream((byte[])_ActivityList))
                    {
                        var BinFormatter = new BinaryFormatter();
                        return (Activity.ActivityList)BinFormatter.Deserialize(MemStream);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return new Activity.ActivityList(); //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetActivityList(Activity.ActivityList Activities)
        {
            try
            {
                using (var MemStream = new MemoryStream())
                {
                    var BinFormatter = new BinaryFormatter();
                    BinFormatter.Serialize(MemStream, Activities);
                    RegistryAccess.SetValue(ActivityListName, MemStream.ToArray(), RegistryValueKind.Binary);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private const string DefaultDelayPreName = "DefaultDelayPre";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal int GetDefaultDelayPre()
        {
            try
            {
                var _DefaultDelayPre = RegistryAccess.GetValue(DefaultDelayPreName);
                if (_DefaultDelayPre != null)
                {
                    return Convert.ToInt32(_DefaultDelayPre);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return 10; //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDefaultDelayPre(decimal DefaultDelayPre)
        {
            try
            {
                RegistryAccess.SetValue(DefaultDelayPreName, Convert.ToInt32(DefaultDelayPre), RegistryValueKind.DWord);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private const string DefaultDurationName = "DefaultDuration";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal int GetDefaultDuration()
        {
            try
            {
                var _DefaultDuration = RegistryAccess.GetValue(DefaultDurationName);
                if (_DefaultDuration != null)
                {
                    return Convert.ToInt32(_DefaultDuration);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return 30; //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDefaultDuration(decimal DefaultDuration)
        {
            try
            {
                RegistryAccess.SetValue(DefaultDurationName, Convert.ToInt32(DefaultDuration), RegistryValueKind.DWord);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private const string DefaultDelayPostName = "DefaultDelayPost";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal int GetDefaultDelayPost()
        {
            try
            {
                var _DefaultDelayPre = RegistryAccess.GetValue(DefaultDelayPostName);
                if (_DefaultDelayPre != null)
                {
                    return Convert.ToInt32(_DefaultDelayPre);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return 1; //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDefaultDelayPost(decimal DefaultDelayPost)
        {
            try
            {
                RegistryAccess.SetValue(DefaultDelayPostName, Convert.ToInt32(DefaultDelayPost), RegistryValueKind.DWord);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private const string DisplayTypeName = "DisplayType";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal int GetDisplayType()
        {
            try
            {
                var _DisplayType = RegistryAccess.GetValue(DisplayTypeName);
                if (_DisplayType != null)
                {
                    return (Convert.ToInt32(_DisplayType));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return 1; //Default Bottom Value
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDisplayType(int DisplayType)
        {
            try
            {
                RegistryAccess.SetValue(DisplayTypeName, DisplayType, RegistryValueKind.DWord);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private const string DisplayFontName = "DisplayFont";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal System.Drawing.Font GetDisplayFont()
        {
            try
            {
                var _DisplayFont = RegistryAccess.GetValue(DisplayFontName);
                if (_DisplayFont != null)
                {
                    using (var ms = new MemoryStream((byte[])_DisplayFont))
                    {
                        var formatter = new BinaryFormatter();
                        return (System.Drawing.Font)formatter.Deserialize(ms);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return null; //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDisplayFont(System.Drawing.Font DisplayFont)
        {
            try
            {
                using (var MemStream = new MemoryStream())
                {
                    var BinFormatter = new BinaryFormatter();
                    BinFormatter.Serialize(MemStream, DisplayFont);
                    RegistryAccess.SetValue(DisplayFontName, MemStream.ToArray(), RegistryValueKind.Binary);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private const string DisplayBackColorName = "DisplayBackColor";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal System.Drawing.Color GetDisplayBackColor()
        {
            try
            {
                var _DisplayBackColor = RegistryAccess.GetValue(DisplayBackColorName);
                if (_DisplayBackColor != null)
                {
                    using (var ms = new MemoryStream((byte[])_DisplayBackColor))
                    {
                        var formatter = new BinaryFormatter();
                        return (System.Drawing.Color)formatter.Deserialize(ms);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return System.Drawing.Color.Orange; //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDisplayBackColor(System.Drawing.Color DisplayBackColor)
        {
            try
            {
                using (var MemStream = new MemoryStream())
                {
                    var BinFormatter = new BinaryFormatter();
                    BinFormatter.Serialize(MemStream, DisplayBackColor);
                    RegistryAccess.SetValue(DisplayBackColorName, MemStream.ToArray(), RegistryValueKind.Binary);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        private const string DisplaySoundName = "DisplaySound";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal bool GetDisplaySound()
        {
            try
            {
                var _DisplaySound = RegistryAccess.GetValue(DisplaySoundName);
                if (_DisplaySound != null)
                {
                    return (Convert.ToInt32(_DisplaySound) == 1);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return false; //Default Value
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDisplaySound(bool DisplaySound)
        {
            try
            {
                RegistryAccess.SetValue(DisplaySoundName, DisplaySound ? 1 : 0, RegistryValueKind.DWord);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private const string DisplaySoundFileName = "DisplaySoundFile";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal FileInfo GetDisplaySoundFile()
        {
            try
            {
                var _DisplaySoundFile = RegistryAccess.GetValue(DisplaySoundFileName);
                if (_DisplaySoundFile != null)
                {
                    if (_DisplaySoundFile != string.Empty)
                    {
                        var SoundFile = new FileInfo(_DisplaySoundFile.ToString());
                        if (SoundFile.Exists) return SoundFile;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return null; //Default Value
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal void SetDisplaySoundFile(System.Media.SoundPlayer SoundPlayer)
        {
            try
            {
                RegistryAccess.SetValue(DisplaySoundFileName, SoundPlayer != null ? (new FileInfo(SoundPlayer.SoundLocation).Exists ? SoundPlayer.SoundLocation : String.Empty) : String.Empty, RegistryValueKind.String);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
