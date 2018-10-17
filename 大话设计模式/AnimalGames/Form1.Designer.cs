namespace AnimalGames
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CatBtn = new System.Windows.Forms.Button();
            this.DogBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.BeginBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatBtn
            // 
            this.CatBtn.Location = new System.Drawing.Point(113, 49);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(75, 23);
            this.CatBtn.TabIndex = 0;
            this.CatBtn.Text = "猫叫";
            this.CatBtn.UseVisualStyleBackColor = true;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // DogBtn
            // 
            this.DogBtn.Location = new System.Drawing.Point(113, 93);
            this.DogBtn.Name = "DogBtn";
            this.DogBtn.Size = new System.Drawing.Size(75, 23);
            this.DogBtn.TabIndex = 1;
            this.DogBtn.Text = "狗叫";
            this.DogBtn.UseVisualStyleBackColor = true;
            this.DogBtn.Click += new System.EventHandler(this.DogBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(113, 139);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpBtn.TabIndex = 2;
            this.SignUpBtn.Text = "报名参赛";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // BeginBtn
            // 
            this.BeginBtn.Location = new System.Drawing.Point(113, 185);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(75, 23);
            this.BeginBtn.TabIndex = 3;
            this.BeginBtn.Text = "开始比赛";
            this.BeginBtn.UseVisualStyleBackColor = true;
            this.BeginBtn.Click += new System.EventHandler(this.BeginBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(113, 232);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 4;
            this.ChangeBtn.Text = "变";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 390);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.BeginBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.DogBtn);
            this.Controls.Add(this.CatBtn);
            this.Name = "Form1";
            this.Text = "动物运动会";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button DogBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button BeginBtn;
        private System.Windows.Forms.Button ChangeBtn;
    }
}

