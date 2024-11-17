namespace photoReader
{
    partial class Mainwindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem4 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem6 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            divider1 = new AntdUI.Divider();
            menu1 = new AntdUI.Menu();
            panel1 = new AntdUI.Panel();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            pageHeader1 = new AntdUI.PageHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // divider1
            // 
            divider1.BackColor = SystemColors.Control;
            divider1.ColorSplit = Color.DarkSlateGray;
            divider1.Location = new Point(236, 37);
            divider1.Name = "divider1";
            divider1.Size = new Size(10, 571);
            divider1.TabIndex = 4;
            divider1.Text = "";
            divider1.Thickness = 0.5F;
            divider1.Vertical = true;
            // 
            // menu1
            // 
            menu1.Font = new Font("微软雅黑", 12F);
            menuItem1.ID = "menu_itm1";
            menuItem1.PARENTITEM = null;
            menuItem1.Text = "        ⚪回溯   Timeline";
            menuItem2.Expand = false;
            menuItem2.ID = "menu_itm2";
            menuItem2.PARENTITEM = null;
            menuItem3.ID = "p1";
            menuItem3.PARENTITEM = menuItem2;
            menuItem3.Text = "            Page1";
            menuItem4.ID = "p2";
            menuItem4.PARENTITEM = menuItem2;
            menuItem4.Text = "            Page2";
            menuItem5.ID = "p3";
            menuItem5.PARENTITEM = menuItem2;
            menuItem5.Text = "            Page3";
            menuItem2.Sub.Add(menuItem3);
            menuItem2.Sub.Add(menuItem4);
            menuItem2.Sub.Add(menuItem5);
            menuItem2.Text = "        ⚪瞬间   Pieces";
            menuItem6.Expand = false;
            menuItem6.ID = "menu_itm4";
            menuItem6.PARENTITEM = null;
            menuItem7.ID = "statistics";
            menuItem7.PARENTITEM = menuItem6;
            menuItem7.Text = "            去向统计";
            menuItem8.ID = "emoji";
            menuItem8.PARENTITEM = menuItem6;
            menuItem8.Text = "            表情包";
            menuItem6.Sub.Add(menuItem7);
            menuItem6.Sub.Add(menuItem8);
            menuItem6.Text = "        ⚪其它   Else";
            menuItem9.ID = "menu_itm3";
            menuItem9.PARENTITEM = null;
            menuItem9.Text = "        ⚪设置   Settings";
            menu1.Items.Add(menuItem1);
            menu1.Items.Add(menuItem2);
            menu1.Items.Add(menuItem6);
            menu1.Items.Add(menuItem9);
            menu1.Location = new Point(-1, 126);
            menu1.Name = "menu1";
            menu1.Size = new Size(244, 482);
            menu1.TabIndex = 2;
            menu1.Text = "menu1";
            menu1.SelectChanged += menu1_SelectChanged;
            // 
            // panel1
            // 
            panel1.Back = SystemColors.Control;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(252, 40);
            panel1.Name = "panel1";
            panel1.ShadowColor = Color.Azure;
            panel1.Size = new Size(832, 568);
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            panel1.SizeChanged += panel1_SizeChanged;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.BackgroundImageLayout = ImageLayout.None;
            label2.Font = new Font("微软雅黑", 11F);
            label2.Location = new Point(58, 106);
            label2.Name = "label2";
            label2.Size = new Size(687, 143);
            label2.TabIndex = 5;
            label2.Text = "第一次打开的话，请先按照以下步骤操作：\r\n\r\n        1）为方便使用，请先确认软件（即此exe文件）和数字记忆的文件夹在同一目录下\r\n\r\n        2）到设置Settings，点击验证文件完整性\r\n\r\n        3）Enjoy！\r\n";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(832, 74);
            label1.TabIndex = 4;
            label1.Text = "    Welcome   ：）";
            // 
            // pageHeader1
            // 
            pageHeader1.Location = new Point(-1, 1);
            pageHeader1.MaximizeBox = false;
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.ShowIcon = true;
            pageHeader1.Size = new Size(1100, 30);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "photoReader";
            // 
            // Mainwindow
            // 
            ClientSize = new Size(1096, 615);
            Controls.Add(pageHeader1);
            Controls.Add(divider1);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "Mainwindow";
            Opacity = 0.95D;
            Resizable = false;
            Text = "Form1";
            Load += Mainwindow_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Menu menu1;
        private AntdUI.Panel panel1;
        private AntdUI.Divider divider1;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
    }
}
