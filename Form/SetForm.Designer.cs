namespace photoReader
{
    partial class SetForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            label3 = new AntdUI.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(832, 74);
            label1.TabIndex = 3;
            label1.Text = "    Settings";
            // 
            // button1
            // 
            button1.Location = new Point(104, 96);
            button1.Name = "button1";
            button1.Size = new Size(118, 42);
            button1.TabIndex = 6;
            button1.Text = "点我";
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(29, 106);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 7;
            label3.Text = "验证完整性";
            // 
            // SetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SetForm";
            Size = new Size(832, 568);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Label label3;
    }
}
