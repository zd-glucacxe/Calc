using System.Windows.Forms;

namespace Calc {
    partial class CalcForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_cleanup = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(14, 306);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(78, 39);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(98, 306);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(78, 39);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(182, 306);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(78, 39);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(182, 261);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(78, 39);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(98, 261);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(78, 39);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(14, 261);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(78, 39);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(182, 216);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(78, 39);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(98, 216);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(78, 39);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(14, 216);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(78, 39);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(182, 171);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(78, 39);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_cleanup
            // 
            this.btn_cleanup.Location = new System.Drawing.Point(98, 171);
            this.btn_cleanup.Name = "btn_cleanup";
            this.btn_cleanup.Size = new System.Drawing.Size(78, 39);
            this.btn_cleanup.TabIndex = 10;
            this.btn_cleanup.Text = "C";
            this.btn_cleanup.UseVisualStyleBackColor = true;
            // 
            // btn_percent
            // 
            this.btn_percent.Location = new System.Drawing.Point(14, 171);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(78, 39);
            this.btn_percent.TabIndex = 9;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(266, 171);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(93, 39);
            this.btn_div.TabIndex = 12;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = true;
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(266, 216);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(93, 39);
            this.btn_mul.TabIndex = 13;
            this.btn_mul.Text = "×";
            this.btn_mul.UseVisualStyleBackColor = true;
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(266, 261);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(93, 39);
            this.btn_sub.TabIndex = 14;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(266, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 39);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(266, 351);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(93, 39);
            this.btn_equal.TabIndex = 18;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            // 
            // btn_point
            // 
            this.btn_point.Location = new System.Drawing.Point(182, 351);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(78, 39);
            this.btn_point.TabIndex = 17;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(98, 351);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(78, 39);
            this.btn_zero.TabIndex = 16;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(14, 351);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(78, 39);
            this.button20.TabIndex = 19;
            this.button20.Text = "+/-";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // tb_num2
            // 
            this.tb_num2.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_num2.Location = new System.Drawing.Point(14, 90);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(345, 50);
            this.tb_num2.TabIndex = 22;
            // 
            // tb_num1
            // 
            this.tb_num1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_num1.Location = new System.Drawing.Point(15, 23);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(345, 50);
            this.tb_num1.TabIndex = 23;
           
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 428);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_cleanup);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Name = "CalcForm";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_cleanup;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.TextBox tb_num1;
    }
}

