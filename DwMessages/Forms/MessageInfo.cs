using System;
using System.Drawing;
using System.Windows.Forms;

namespace DwMessages
{
    internal partial class MessageInfo : Form
    {
        public MessageInfo(string mensagem, Image image)
        {
            InitializeComponent();
            txMessage.Text = mensagem;
            imgMensagem.Image = image;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageOk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;
            Close();
        }
    }
}
