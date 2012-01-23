using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Workbench
{
    public class TextBoxTraceListener : TraceListener
    {
        static TextBox _textBox;
        static Action<string> _setter;

        public static void SetControl(TextBox textBox)
        {
            _textBox = textBox;
            _setter = message => textBox.Text += message;
        }
        public override void Write(string message)
        {
            if (_setter != null)
                _textBox.BeginInvoke(_setter, message);
        }

        public override void WriteLine(string message)
        {

            if (_setter != null)
                _textBox.BeginInvoke(_setter, message + "\r\n");
        }
    }
}