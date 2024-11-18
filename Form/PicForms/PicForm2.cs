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
    public partial class PicForm2 : UserControl
    {
        private Window window;
        public PicForm2(Window _window)
        {
            window = _window;
            InitializeComponent();
        }

        private void image3d1_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.HARU_e104c6));
        }

        private void image3d2_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.HARU_e107b));
        }
    }
}
