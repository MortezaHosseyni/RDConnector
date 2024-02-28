using System.Drawing;
using System.Windows.Forms;

namespace RDConnector
{
    public partial class frmMain : Form
    {
        private Point offset;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Header
        private void pnl_Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void pnl_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void pnl_Header_MouseUp(object sender, MouseEventArgs e)
        {
            offset = Point.Empty;
        }
        #endregion


    }
}
