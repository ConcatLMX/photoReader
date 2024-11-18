using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;

namespace photoReader.Form.Picforms
{
    public partial class PicForm3 : UserControl
    {
        private Window window;
        public PicForm3(Window _window)
        {
            window = _window;
            InitializeComponent();
        }

        private void image3d1_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.KURO_e021c));
        }

        private void image3d2_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.KURO_e202d));
        }
    }
}
