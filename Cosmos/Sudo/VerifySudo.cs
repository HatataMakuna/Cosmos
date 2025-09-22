using Microsoft.VisualBasic;
using Cosmos.Service;
using System.Windows.Forms;

namespace Cosmos.Sudo
{
    public class VerifySudo
    {
        private EncodeDecode enc = new EncodeDecode();

        public bool isSudoModeActive()
        {
            string inputCode = Interaction.InputBox("Please enter the sudo code:", "Entering Sudo Mode");
            if (inputCode == "") return false;

            string sudoCode = "WTI5emJXOXpMV0o1TFdOM2NuQm5NREk9";
            if (inputCode == enc.Base64Decode(enc.Base64Decode(sudoCode))) return true;
            else {
                // Code is incorrect, show error message
                MessageBox.Show("Incorrect sudo code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
