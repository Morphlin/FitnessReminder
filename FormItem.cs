using System;
using System.Windows.Forms;

namespace FitnessReminder
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class FormItem : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private ListView _ListView;
        /// <summary>
        /// 
        /// </summary>
        private ListViewItem _ListViewItem;
        /// <summary>
        /// 
        /// </summary>
        private bool ItemEdit;
        /// <summary>
        /// 
        /// </summary>
        internal FormItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormItem_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ListView"></param>
        /// <param name="Name"></param>
        /// <param name="DelayPre"></param>
        /// <param name="Duration"></param>
        /// <param name="DelayPost"></param>
        internal void ShowIt(ListView ListView, string Name, int DelayPre, int Duration, int DelayPost)
        {
            Text = Name;
            _ListView = ListView;
            NumericReminderPre.Value = DelayPre / 60;
            NumericReminderDuration.Value = Duration;
            NumericReminderPost.Value = DelayPost / 60;
            ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ListViewItem"></param>
        /// <param name="Name"></param>
        internal void ShowIt(ListViewItem ListViewItem, string Name)
        {
            Text = Name;
            ItemEdit = true;
            _ListViewItem = ListViewItem;
            NumericReminderPre.Value = Convert.ToInt32(ListViewItem.SubItems[1].Text) / 60;
            NumericReminderDuration.Value = Convert.ToInt32(ListViewItem.SubItems[2].Text);
            NumericReminderPost.Value = Convert.ToInt32(ListViewItem.SubItems[3].Text) / 60;
            TextBoxActivityName.Text = ListViewItem.Text;
            ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Name!");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
