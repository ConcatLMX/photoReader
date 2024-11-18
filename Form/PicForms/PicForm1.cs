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
using photoReader.Form.Picforms;

namespace photoReader
{
    public partial class PicForm1 : UserControl
    {
        private Window window;
        public PicForm1(Window _window)
        {
            window = _window;
            InitializeComponent();
        }

        private void image3d1_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.CHIWA_e102c1));
        }

        private void image3d2_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.HARU_e031b));
        }

    }
}
