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

namespace photoReader.Form.SetForm
{
    public partial class CplCheckForm : Window
    {
        public CplCheckForm()
        {
            InitializeComponent();
        }

        private void CplCheckForm_Load(object sender, EventArgs e)
        {
            string[] errInfo = new string[40];
            string dir = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] alphaNames = new string[] { "00班务资料", "01特色表情包收集", "2021年07月15日拿录取通知书", "2021年07月17日学生及家长大会", "2021年08月开学", "2021年09月21日中秋晚会", "2021年09月22日至2021年10月25日GAP", "2021年10月15（6）日课间操比赛及周边内容", "2021年10月26+27日体育节", "2021年10月28日至2021年11月03日GAP", "2021年11月04日至高一上学期结束GAP", "2021年11月04日语文课诗朗诵（比赛）", "2022年02月15日至高一下结束 高一下的日常生活", "2022年04月28日（高一）艺术节", "2022年06月23日音乐考试+语文课演讲（比赛）", "2022年08月开学至2022年09月网课", "2022年08月开学至2023年11月07日GAP", "2022年11月08日体育节", "2022年11月08日至高二上期结束GAP", "2022年4+5月第二届狮山杯球类联赛", "2022年暑假GAP", "2023年02月12日至2023年03月14日GAP", "2023年03月15日大学研学（前往川大、电子科大）", "2023年03月15日至2023年04月26日GAP", "2023年04月10日第三届狮山杯球类联赛", "2023年04月25日高二戏剧节+2023年04月27日艺术节展演", "2023年04月27日至2023年07月08日GAP", "2023年07月09日至高二下结束GAP", "2023年07月09日逸夫楼入驻仪式", "2023年08月24日至2024年02月03日（高三上学期）GAP", "2024年02月04日至2024年02月27日GAP", "2024年02月28日至2024年04月26日GAP", "2024年02月28日高考百日誓师", "2024年04月27日成人礼至2024年04月29日艺术节", "去向统计", "高考时段（2024年06月05日至2024年06月09日）" };
            int i = 0;// 记录错误信息的下标
            foreach (string alphaname in alphaNames)
            {
                string filePath = dir + alphaname;
                if (!Directory.Exists(filePath))
                {
                    errInfo[i] = filePath; // 返回指定文件夹的路径
                    i++;
                }
            }
            if (i == 0)
            {
                listBox1.Items.Add("没发现缺失");
            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    listBox1.Items.Add(errInfo[j]);
                }
            }
        }
    }
}
