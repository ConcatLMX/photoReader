using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using photoReader;
using photoReader.Form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace photoReader
{
    public partial class Mainwindow : AntdUI.Window
    {
        public UserControl DateForm;
        public UserControl PicForm1;
        public UserControl PicForm2;
        public UserControl PicForm3;
        public UserControl SetForm;
        public UserControl StatisticsForm;
        public AntdUI.Window window;


        public Mainwindow()
        {
            InitializeComponent();
            window = this;
        }

        private void menu1_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            AntdUI.Config.ShowInWindow = true;
            var menu = e.Value.ID;
            switch (menu)
            {
                case "menu_itm1":
                    DateForm.Show();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(DateForm);
                    break;
                case "menu_itm3":
                    SetForm.Show();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(SetForm);
                    break;
                case "statistics":
                    StatisticsForm.Show();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(StatisticsForm);
                    break;
                case "emoji":
                    string dir1 = AppDomain.CurrentDomain.BaseDirectory + "01特色表情包收集";
                    if (Directory.Exists(dir1))
                    {
                        Process.Start("explorer.exe", dir1);
                    }
                    else
                    {
                        AntdUI.Notification.error(window, "呀，好像出错了", "请检查下你的表情包资料在不在，或者在设置中验证完整性", autoClose: 3, align: TAlignFrom.TR);
                    }
                    break;
                case "datas":
                    string dir2 = AppDomain.CurrentDomain.BaseDirectory + "00班务资料";
                    if (Directory.Exists(dir2))
                    {
                        Process.Start("explorer.exe", dir2);
                    }
                    else
                    {
                        AntdUI.Notification.error(window, "呀，好像出错了", "请检查下你的班务资料在不在，或者在设置中验证完整性", autoClose: 3, align: TAlignFrom.TR);
                    }
                    break;
                case "p1":
                    AntdUI.Notification.info(window, "看这里！", "Pieces目前还是demo哦，因为投稿还没收集完全", autoClose: 3, align: TAlignFrom.TR);
                    PicForm1.Show();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(PicForm1);
                    break;
                case "p2":
                    AntdUI.Notification.info(window, "看这里！", "Pieces目前还是demo哦，因为投稿还没收集完全", autoClose: 3, align: TAlignFrom.TR);
                    PicForm2.Show();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(PicForm2);
                    break;
                case "p3":
                    AntdUI.Notification.info(window, "看这里！", "Pieces目前还是demo哦，因为投稿还没收集完全", autoClose: 3, align: TAlignFrom.TR);
                    PicForm3.Show();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(PicForm3);
                    break;
            }

        }

        private void Mainwindow_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to photoReader!");
            DateForm = new DateForm(this);
            PicForm1 = new PicForm1(this);
            PicForm2 = new Form.Picforms.PicForm2(this);
            PicForm3 = new Form.Picforms.PicForm3(this);
            SetForm = new SetForm(this);
            StatisticsForm = new Form.OtherForm.StatisticsForm(this);

        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
        }

    }
}
