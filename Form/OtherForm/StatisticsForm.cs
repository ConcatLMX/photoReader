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

namespace photoReader.Form.OtherForm
{
    public partial class StatisticsForm : UserControl
    {
        private AntdUI.Window window;
        public StatisticsForm(AntdUI.Window _window)
        {
            InitializeComponent();
            window =_window;
        }

        private void image3d1_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.毕业去向统计));
        }
    }
}
