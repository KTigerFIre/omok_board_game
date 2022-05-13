
namespace Client
{
    partial class MenuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.singleplaybutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplaybutton
            // 
            this.singleplaybutton.Location = new System.Drawing.Point(330, 122);
            this.singleplaybutton.Name = "singleplaybutton";
            this.singleplaybutton.Size = new System.Drawing.Size(129, 48);
            this.singleplaybutton.TabIndex = 0;
            this.singleplaybutton.Text = "Single play";
            this.singleplaybutton.UseVisualStyleBackColor = true;
            this.singleplaybutton.Click += new System.EventHandler(this.singleplaybutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(330, 260);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(129, 48);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.singleplaybutton);
            this.Name = "MenuForm";
            this.Text = "Omok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplaybutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

