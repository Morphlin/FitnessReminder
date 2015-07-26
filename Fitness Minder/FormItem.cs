using System;
using System.Windows.Forms;

namespace Fitness_Minder
{
    internal partial class FormItem : Form
    {
        private FormSettings _SettingsForm;
        internal FormItem(FormSettings SettingsForm)
        {
            _SettingsForm = SettingsForm;
            InitializeComponent();
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            NumericReminderPre.Value = _SettingsForm.DefaultDelayPre/60;
            NumericReminderDuration.Value = _SettingsForm.DefaultDuration;
            NumericReminderPost.Value = _SettingsForm.DefaultDelayPost/60;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxActivityName.Text != String.Empty)
            {
                _SettingsForm.AddLviActivity(TextBoxActivityName.Text, Convert.ToInt32(NumericReminderPre.Value*60),
                    Convert.ToInt32(NumericReminderDuration.Value), Convert.ToInt32(NumericReminderPost.Value*60));
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Name!");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
