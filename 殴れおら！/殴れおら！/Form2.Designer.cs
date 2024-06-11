namespace 殴れおら_
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(412, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "殴り方説明";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(940, 504);
            this.label2.TabIndex = 1;
            this.label2.Text = "心得　拳とは、魂の衝突。\r\n30メートルが一番ベスト！！！\r\nパンチの助走はスピードだけではなく、\r\nリズムが大切！\r\nリズムは「タン・タン・タタン・（パンチ）！" +
    "」\r\n\r\n助走のスピードを保ったまま、20歩程度で\r\n近づけ！\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ 明朝", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(270, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(764, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "※参考：走り幅跳び公式サイト";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(947, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::殴れおら_.Properties.Resources.OIP;
            this.ClientSize = new System.Drawing.Size(1228, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}