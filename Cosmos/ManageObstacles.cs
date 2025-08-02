using Cosmos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class ManageObstacles : Form
    {
        // manually add the CheckedComboBox control to the form
        private CheckedComboBox ccbTags;

        public ManageObstacles()
        {
            InitializeComponent();

            AddccbTagsField();
        }

        private void AddccbTagsField()
        {
            ccbTags = new CheckedComboBox
            {
                Name = "ccbTags",
                Size = new Size(150, 27),
                Anchor = AnchorStyles.Left,
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
            };

            tableLayoutPanel1.Controls.Add(ccbTags, 1, 4);

            // Item tags
            ccbTags.Items.Add("Tag1");
            ccbTags.Items.Add("Tag2");
        }
    }
}
