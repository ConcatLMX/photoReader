namespace photoReader.Form.SetForm
{
    partial class CplCheckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            windowBar1 = new AntdUI.WindowBar();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(320, 49);
            label1.TabIndex = 4;
            label1.Text = "    以下文件夹缺失，请找数字记忆负责人获取";
            // 
            // windowBar1
            // 
            windowBar1.Location = new Point(-1, -1);
            windowBar1.MaximizeBox = false;
            windowBar1.MinimizeBox = false;
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(831, 33);
            windowBar1.TabIndex = 5;
            windowBar1.Text = "Info";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(54, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(714, 391);
            listBox1.TabIndex = 6;
            // 
            // CplCheckForm
            // 
            ClientSize = new Size(830, 510);
            Controls.Add(listBox1);
            Controls.Add(windowBar1);
            Controls.Add(label1);
            Name = "CplCheckForm";
            Opacity = 0.95D;
            Resizable = false;
            Text = "Form1";
            Load += CplCheckForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.WindowBar windowBar1;
        private ListBox listBox1;
    }
}