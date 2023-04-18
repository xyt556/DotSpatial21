namespace DotSpatial21
{
    partial class FormInputParams
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
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIntervalX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndX = new System.Windows.Forms.TextBox();
            this.txtEndY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntervalY = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnProj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "左下角X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "左下角Y:";
            // 
            // txtStartX
            // 
            this.txtStartX.Location = new System.Drawing.Point(79, 39);
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(100, 21);
            this.txtStartX.TabIndex = 2;
            this.txtStartX.Text = "500000";
            // 
            // txtStartY
            // 
            this.txtStartY.Location = new System.Drawing.Point(79, 71);
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(100, 21);
            this.txtStartY.TabIndex = 3;
            this.txtStartY.Text = "3700000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "间距X：";
            // 
            // txtIntervalX
            // 
            this.txtIntervalX.Location = new System.Drawing.Point(66, 29);
            this.txtIntervalX.Name = "txtIntervalX";
            this.txtIntervalX.Size = new System.Drawing.Size(100, 21);
            this.txtIntervalX.TabIndex = 5;
            this.txtIntervalX.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "右上角X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "右上角Y:";
            // 
            // txtEndX
            // 
            this.txtEndX.Location = new System.Drawing.Point(254, 43);
            this.txtEndX.Name = "txtEndX";
            this.txtEndX.Size = new System.Drawing.Size(100, 21);
            this.txtEndX.TabIndex = 2;
            this.txtEndX.Text = "600010";
            // 
            // txtEndY
            // 
            this.txtEndY.Location = new System.Drawing.Point(254, 70);
            this.txtEndY.Name = "txtEndY";
            this.txtEndY.Size = new System.Drawing.Size(100, 21);
            this.txtEndY.TabIndex = 3;
            this.txtEndY.Text = "3800000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "间距Y：";
            // 
            // txtIntervalY
            // 
            this.txtIntervalY.Location = new System.Drawing.Point(66, 64);
            this.txtIntervalY.Name = "txtIntervalY";
            this.txtIntervalY.Size = new System.Drawing.Size(100, 21);
            this.txtIntervalY.TabIndex = 5;
            this.txtIntervalY.Text = "10000";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(250, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStartY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStartX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEndY);
            this.groupBox1.Controls.Add(this.txtEndX);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "坐标设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIntervalX);
            this.groupBox2.Controls.Add(this.txtIntervalY);
            this.groupBox2.Location = new System.Drawing.Point(22, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "间距设置";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(250, 191);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnProj
            // 
            this.btnProj.Location = new System.Drawing.Point(341, 161);
            this.btnProj.Name = "btnProj";
            this.btnProj.Size = new System.Drawing.Size(75, 23);
            this.btnProj.TabIndex = 9;
            this.btnProj.Text = "设置投影";
            this.btnProj.UseVisualStyleBackColor = true;
            this.btnProj.Click += new System.EventHandler(this.btnProj_Click);
            // 
            // FormInputParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 239);
            this.Controls.Add(this.btnProj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "FormInputParams";
            this.Text = "绘制公里网";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIntervalX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndX;
        private System.Windows.Forms.TextBox txtEndY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIntervalY;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnProj;
    }
}