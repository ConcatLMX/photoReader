namespace photoReader.Form.OtherForm
{
    partial class StatisticsForm
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
            image3d1 = new AntdUI.Image3D();
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
            label1.Text = "    Statistics";
            // 
            // image3d1
            // 
            image3d1.Image = Properties.Resources.毕业去向统计;
            image3d1.ImageFit = AntdUI.TFit.Fill;
            image3d1.Location = new Point(17, 69);
            image3d1.Name = "image3d1";
            image3d1.Radius = 15;
            image3d1.Size = new Size(795, 507);
            image3d1.TabIndex = 4;
            image3d1.Text = "image3d1";
            image3d1.Click += image3d1_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(image3d1);
            Controls.Add(label1);
            Name = "StatisticsForm";
            Size = new Size(832, 568);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Image3D image3d1;
    }
}
