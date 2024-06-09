using System.Windows.Forms;

namespace TimeSprout.Core.Util
{
    internal class ReadOnlyDateTimePicker : DateTimePicker
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            e.Handled = true; // ignore key press
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            //MouseEventHandler. = true; // ignore mouse click
        }

        protected override void WndProc(ref Message m)
        {
            // prevent the drop-down calendar from appearing
            if (m.Msg == 0x201) // WM_LBUTTONDOWN{
                return;
            base.WndProc(ref m);
        }
    }
}
