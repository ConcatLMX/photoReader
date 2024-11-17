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
using photoReader.Class;
using photoReader.Form; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace photoReader
{
    public partial class SetForm : UserControl
    {
        private AntdUI.Window window;
        public SetForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.SetForm.CplCheckForm form = new Form.SetForm.CplCheckForm();
            form.ShowDialog();
        }
    }
}
