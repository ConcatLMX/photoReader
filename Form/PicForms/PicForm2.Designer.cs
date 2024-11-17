namespace photoReader.Form.Picforms
{
    partial class PicForm2
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
            image3d2 = new AntdUI.Image3D();
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
            label1.Text = "    Pieces";
            // 
            // image3d1
            // 
            image3d1.Image = Properties.Resources.HARU_e104c6;
            image3d1.Location = new Point(396, 80);
            image3d1.Name = "image3d1";
            image3d1.Radius = 15;
            image3d1.Size = new Size(369, 234);
            image3d1.TabIndex = 4;
            image3d1.Text = "image3d1";
            image3d1.Click += image3d1_Click;
            // 
            // image3d2
            // 
            image3d2.Image = Properties.Resources.HARU_e107b;
            image3d2.Location = new Point(68, 279);
            image3d2.Name = "image3d2";
            image3d2.Radius = 15;
            image3d2.Size = new Size(369, 234);
            image3d2.TabIndex = 5;
            image3d2.Text = "image3d2";
            image3d2.Click += image3d2_Click;
            // 
            // PicForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(image3d2);
            Controls.Add(image3d1);
            Controls.Add(label1);
            Name = "PicForm2";
            Size = new Size(832, 568);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Image3D image3d1;
        private AntdUI.Image3D image3d2;
    }
}
