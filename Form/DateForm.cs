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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace photoReader
{
    public partial class DateForm : UserControl
    {
        private AntdUI.Window window;
        public DateForm(AntdUI.Window _window)
        {
            InitializeComponent();
            window = _window;
        }

        private void OpenFolder(string dir)
        {
            if (Directory.Exists(dir))
            {
                Process.Start("explorer.exe", dir);
            }
            else
            {
                AntdUI.Notification.error(window, "啊，好像出错了", "请检查下对应文件夹在不在，或者在设置中验证完整性", autoClose: 3, align: TAlignFrom.TR);
            }
        }

        private void timeline1_ItemClick(object sender, TimelineItemEventArgs e)
        {
            AntdUI.Config.ShowInWindow = true;
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            var click = e.Item.ID;
            switch (click)
            {
                case "itm1":
                    OpenFolder(dir + "2021年07月15日拿录取通知书");
                    break;
                case "itm2":
                    OpenFolder(dir + "2021年07月17日学生及家长大会");
                    break;
                case "itm3":
                    OpenFolder(dir + "2021年08月开学");
                    break;
                case "itm4":
                    OpenFolder(dir + "2021年09月21日中秋晚会");
                    break;
                case "itm5":
                    OpenFolder(dir + "2021年09月22日至2021年10月25日GAP");
                    break;
                case "itm6":
                    OpenFolder(dir + "2021年10月15（6）日课间操比赛及周边内容");
                    break;
                case "itm7":
                    OpenFolder(dir + "2021年10月26+27日体育节");
                    break;
                case "itm8":
                    OpenFolder(dir + "2021年10月28日至2021年11月03日GAP");
                    break;
                case "itm9":
                    OpenFolder(dir + "2021年11月04日语文课诗朗诵（比赛）");
                    break;
                case "itm10":
                    OpenFolder(dir + "2021年11月04日至高一上学期结束GAP");
                    break;
                case "itm11":
                    OpenFolder(dir + "2022年02月15日至高一下结束 高一下的日常生活");
                    break;
                case "itm12":
                    OpenFolder(dir + "2022年04月28日（高一）艺术节");
                    break;
                case "itm13":
                    OpenFolder(dir + "2022年4+5月第二届狮山杯球类联赛");
                    break;
                case "itm14":
                    OpenFolder(dir + "2022年06月23日音乐考试+语文课演讲（比赛）");
                    break;
                case "itm39":
                    OpenFolder(dir + "2022年暑假GAP");
                    break;
                case "itm15":
                    OpenFolder(dir + "2022年08月开学至2022年09月网课");
                    break;
                case "itm16":
                    OpenFolder(dir + "2022年08月开学至2022年09月网课");
                    break;
                case "itm17":
                    OpenFolder(dir + "2022年08月开学至2023年11月07日GAP");
                    break;
                case "itm18":
                    OpenFolder(dir + "2022年11月08日体育节");
                    break;
                case "itm19":
                    OpenFolder(dir + "2022年11月08日至高二上期结束GAP");
                    break;
                case "itm21":
                    OpenFolder(dir + "2023年02月12日至2023年03月14日GAP");
                    break;
                case "itm22":
                    OpenFolder(dir + "2023年03月15日大学研学（前往川大、电子科大）");
                    break;
                case "itm23":
                    OpenFolder(dir + "2023年03月15日至2023年04月26日GAP");
                    break;
                case "itm24":
                    OpenFolder(dir + "2023年04月10日第三届狮山杯球类联赛");
                    break;
                case "itm25":
                    OpenFolder(dir + "2023年04月25日高二戏剧节+2023年04月27日艺术节展演");
                    break;
                case "itm26":
                    OpenFolder(dir + "2023年04月25日高二戏剧节+2023年04月27日艺术节展演");
                    break;
                case "itm27":
                    OpenFolder(dir + "2023年04月27日至2023年07月08日GAP");
                    break;
                case "itm28":
                    OpenFolder(dir + "2023年07月09日逸夫楼入驻仪式");
                    break;
                case "itm29":
                    OpenFolder(dir + "2023年07月09日至高二下结束GAP");
                    break;
                case "itm31":
                    OpenFolder(dir + "2023年08月24日至2024年02月03日（高三上学期）GAP");
                    break;
                case "itm32":
                    OpenFolder(dir + "2024年02月04日至2024年02月27日GAP");
                    break;
                case "itm33":
                    OpenFolder(dir + "2024年02月04日至2024年02月27日GAP");
                    break;
                case "itm34":
                    OpenFolder(dir + "2024年02月28日至2024年04月26日GAP");
                    break;
                case "itm35":
                    OpenFolder(dir + "2024年04月27日成人礼至2024年04月29日艺术节");
                    break;
                case "itm36":
                    OpenFolder(dir + "2024年04月27日成人礼至2024年04月29日艺术节");
                    break;
                case "itm37":
                    OpenFolder(dir + "2024年04月27日成人礼至2024年04月29日艺术节");
                    break;
            }
        }
    }
}
