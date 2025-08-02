using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos.Service
{
    // Combine a TextBox or Button with a CheckedListBox that appears as a dropdown
    public class CheckedComboBox : UserControl
    {
        private TextBox textBox;
        private Button dropDownButton;
        private CheckedListBox checkedListBox;
        private Form dropDownForm;

        public CheckedComboBox()
        {
            textBox = new TextBox { ReadOnly = true, Dock = DockStyle.Fill, Anchor = AnchorStyles.Left };
            dropDownButton = new Button { Text = "▼", Dock = DockStyle.Right, Width = 20 };
            checkedListBox = new CheckedListBox { CheckOnClick = true, BorderStyle = BorderStyle.FixedSingle };

            this.Controls.Add(textBox);
            this.Controls.Add(dropDownButton);

            dropDownButton.Click += DropDownButton_Click;
            checkedListBox.ItemCheck += CheckedListBox_ItemCheck;
        }

        public CheckedListBox.ObjectCollection Items => checkedListBox.Items;
        public CheckedListBox.CheckedItemCollection CheckedItems => checkedListBox.CheckedItems;

        private void DropDownButton_Click(object sender, EventArgs e)
        {
            if (dropDownForm == null)
            {
                dropDownForm = new Form
                {
                    FormBorderStyle = FormBorderStyle.None,
                    ShowInTaskbar = false,
                    StartPosition = FormStartPosition.Manual,
                    Size = new Size(this.Width, 150)
                };
                dropDownForm.Deactivate += (s, args) => dropDownForm.Hide();
                dropDownForm.Controls.Add(checkedListBox);
                checkedListBox.Dock = DockStyle.Fill;
            }

            var location = this.PointToScreen(new Point(0, this.Height));
            dropDownForm.Location = location;
            dropDownForm.Width = this.Width;
            dropDownForm.Show();
            dropDownForm.BringToFront();
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((Action)UpdateText);
        }

        private void UpdateText()
        {
            textBox.Text = string.Join(", ", checkedListBox.CheckedItems.Cast<object>());
        }
    }
}
