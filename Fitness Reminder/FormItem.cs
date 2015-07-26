using System;
using System.Windows.Forms;

namespace FitnessReminder
{
    internal partial class FormItem : Form
    {
        private ListView _ListView;
        private ListViewItem _ListViewItem;
        private bool ItemEdit;
        internal FormItem()
        {
            InitializeComponent();
        }

        internal void ShowIt(ListView ListView, int DelayPre, int Duration, int DelayPost)
        {
            _ListView = ListView;
            NumericReminderPre.Value = DelayPre / 60;
            NumericReminderDuration.Value = Duration;
            NumericReminderPost.Value = DelayPost / 60;
            ShowDialog();
        }
        internal void ShowIt(ListViewItem ListViewItem)
        {
            ItemEdit = true;
            _ListViewItem = ListViewItem;
            NumericReminderPre.Value = Convert.ToInt32(ListViewItem.SubItems[1].Text) / 60;
            NumericReminderDuration.Value = Convert.ToInt32(ListViewItem.SubItems[2].Text);
            NumericReminderPost.Value = Convert.ToInt32(ListViewItem.SubItems[3].Text) / 60;
            TextBoxActivityName.Text = ListViewItem.Text;
            ShowDialog();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxActivityName.Text != String.Empty)
            {
                if (ItemEdit)
                {
                    _ListViewItem.Text = TextBoxActivityName.Text;
                    _ListViewItem.SubItems[1].Text = Convert.ToInt32(NumericReminderPre.Value * 60).ToString();
                    _ListViewItem.SubItems[2].Text = Convert.ToInt32(NumericReminderDuration.Value).ToString();
                    _ListViewItem.SubItems[3].Text = Convert.ToInt32(NumericReminderPost.Value * 60).ToString();
                }
                else
                {
                    var NewLVI = new ListViewItem(TextBoxActivityName.Text);
                    NewLVI.SubItems.Add(Convert.ToInt32(NumericReminderPre.Value * 60).ToString());
                    NewLVI.SubItems.Add(Convert.ToInt32(NumericReminderDuration.Value).ToString());
                    NewLVI.SubItems.Add(Convert.ToInt32(NumericReminderPost.Value * 60).ToString());
                    _ListView.Items.Add(NewLVI);
                }
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
