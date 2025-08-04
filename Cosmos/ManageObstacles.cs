using Cosmos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class ManageObstacles : Form
    {
        public ManageObstacles()
        {
            InitializeComponent();
        }

        private void HandleNumericInput(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace)
            if (char.IsControl(e.KeyChar))
                return;
            // Allow digits and decimal point
            if (!Regex.IsMatch((sender as TextBox).Text + e.KeyChar, @"^[1-9]\d*[.]?(\d+)?$"))
                e.Handled = true;
        }

        private void ntbBaseSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseTech_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseGrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseStrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseEndurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseAgility_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseLache_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseStamina_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseIntelligence_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }
    }
}
