namespace CalcTest
{
    public partial class frmCalc
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDisp = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Pro = new System.Windows.Forms.Button();
            this.Quoti = new System.Windows.Forms.Button();
            this.Diff = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.PorM = new System.Windows.Forms.Button();
            this.Dummy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainDisp
            // 
            this.MainDisp.BackColor = System.Drawing.Color.White;
            this.MainDisp.Enabled = false;
            this.MainDisp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainDisp.Location = new System.Drawing.Point(6, 44);
            this.MainDisp.Name = "MainDisp";
            this.MainDisp.ReadOnly = true;
            this.MainDisp.Size = new System.Drawing.Size(302, 36);
            this.MainDisp.TabIndex = 0;
            this.MainDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Num1
            // 
            this.Num1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num1.Location = new System.Drawing.Point(34, 285);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(64, 45);
            this.Num1.TabIndex = 1;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num2.Location = new System.Drawing.Point(100, 285);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(64, 45);
            this.Num2.TabIndex = 2;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num3.Location = new System.Drawing.Point(166, 285);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(64, 45);
            this.Num3.TabIndex = 3;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num6
            // 
            this.Num6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num6.Location = new System.Drawing.Point(166, 238);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(64, 45);
            this.Num6.TabIndex = 6;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num5
            // 
            this.Num5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num5.Location = new System.Drawing.Point(100, 238);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(64, 45);
            this.Num5.TabIndex = 5;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num4
            // 
            this.Num4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num4.Location = new System.Drawing.Point(34, 238);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(64, 45);
            this.Num4.TabIndex = 4;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num9
            // 
            this.Num9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num9.Location = new System.Drawing.Point(166, 191);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(64, 45);
            this.Num9.TabIndex = 9;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num8
            // 
            this.Num8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num8.Location = new System.Drawing.Point(100, 191);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(64, 45);
            this.Num8.TabIndex = 8;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num7
            // 
            this.Num7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num7.Location = new System.Drawing.Point(34, 191);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(64, 45);
            this.Num7.TabIndex = 7;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num0
            // 
            this.Num0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Num0.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num0.Location = new System.Drawing.Point(100, 331);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(64, 45);
            this.Num0.TabIndex = 10;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Pro
            // 
            this.Pro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Pro.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pro.Location = new System.Drawing.Point(232, 191);
            this.Pro.Name = "Pro";
            this.Pro.Size = new System.Drawing.Size(64, 45);
            this.Pro.TabIndex = 11;
            this.Pro.Text = "×";
            this.Pro.UseVisualStyleBackColor = true;
            this.Pro.Click += new System.EventHandler(this.Pro_Click);
            // 
            // Quoti
            // 
            this.Quoti.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Quoti.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Quoti.Location = new System.Drawing.Point(232, 144);
            this.Quoti.Name = "Quoti";
            this.Quoti.Size = new System.Drawing.Size(64, 45);
            this.Quoti.TabIndex = 12;
            this.Quoti.Text = "÷";
            this.Quoti.UseVisualStyleBackColor = true;
            this.Quoti.Click += new System.EventHandler(this.Quoti_Click);
            // 
            // Diff
            // 
            this.Diff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Diff.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Diff.Location = new System.Drawing.Point(232, 238);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(64, 45);
            this.Diff.TabIndex = 13;
            this.Diff.Text = "－";
            this.Diff.UseVisualStyleBackColor = true;
            this.Diff.Click += new System.EventHandler(this.Diff_Click);
            // 
            // Sum
            // 
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sum.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sum.Location = new System.Drawing.Point(232, 285);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(64, 45);
            this.Sum.TabIndex = 14;
            this.Sum.Text = "＋";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Equal
            // 
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Equal.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Equal.Location = new System.Drawing.Point(232, 331);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(64, 45);
            this.Equal.TabIndex = 15;
            this.Equal.Text = "＝";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equals_Click);
            // 
            // ClearEntry
            // 
            this.ClearEntry.BackColor = System.Drawing.SystemColors.Control;
            this.ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearEntry.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClearEntry.Location = new System.Drawing.Point(34, 144);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(64, 45);
            this.ClearEntry.TabIndex = 16;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = false;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Clear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Clear.Location = new System.Drawing.Point(100, 144);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(64, 45);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Dot
            // 
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dot.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Dot.Location = new System.Drawing.Point(166, 331);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(64, 45);
            this.Dot.TabIndex = 18;
            this.Dot.Text = "．";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // PorM
            // 
            this.PorM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PorM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PorM.Location = new System.Drawing.Point(34, 331);
            this.PorM.Name = "PorM";
            this.PorM.Size = new System.Drawing.Size(64, 45);
            this.PorM.TabIndex = 19;
            this.PorM.Text = "±";
            this.PorM.UseVisualStyleBackColor = true;
            this.PorM.Click += new System.EventHandler(this.PorM_Click);
            // 
            // Dummy
            // 
            this.Dummy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dummy.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Dummy.Location = new System.Drawing.Point(34, 440);
            this.Dummy.Name = "Dummy";
            this.Dummy.Size = new System.Drawing.Size(64, 45);
            this.Dummy.TabIndex = 20;
            this.Dummy.UseVisualStyleBackColor = true;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 386);
            this.Controls.Add(this.Dummy);
            this.Controls.Add(this.PorM);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.Quoti);
            this.Controls.Add(this.Pro);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.MainDisp);
            this.KeyPreview = true;
            this.Name = "frmCalc";
            this.Text = "電卓";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalc_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainDisp;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Pro;
        private System.Windows.Forms.Button Quoti;
        private System.Windows.Forms.Button Diff;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button PorM;
        private System.Windows.Forms.Button Dummy;
    }
}

