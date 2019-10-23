namespace WallSwitch
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dispWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dispHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.normalImagePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fakeImagePath = new System.Windows.Forms.TextBox();
            this.normalImageSel = new System.Windows.Forms.Button();
            this.fakeImageSel = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.selStyle = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dispWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "基準解像度";
            this.toolTip1.SetToolTip(this.label1, "基準解像度にはプロジェクター未接続時のメインディスプレイ解像度を指定してください。");
            // 
            // dispWidth
            // 
            this.dispWidth.Location = new System.Drawing.Point(84, 11);
            this.dispWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.dispWidth.Name = "dispWidth";
            this.dispWidth.Size = new System.Drawing.Size(72, 19);
            this.dispWidth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // dispHeight
            // 
            this.dispHeight.Location = new System.Drawing.Point(179, 11);
            this.dispHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.dispHeight.Name = "dispHeight";
            this.dispHeight.Size = new System.Drawing.Size(81, 19);
            this.dispHeight.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "通常壁紙";
            // 
            // normalImagePath
            // 
            this.normalImagePath.Location = new System.Drawing.Point(84, 34);
            this.normalImagePath.Name = "normalImagePath";
            this.normalImagePath.Size = new System.Drawing.Size(176, 19);
            this.normalImagePath.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "フェイク壁紙";
            // 
            // fakeImagePath
            // 
            this.fakeImagePath.Location = new System.Drawing.Point(84, 59);
            this.fakeImagePath.Name = "fakeImagePath";
            this.fakeImagePath.Size = new System.Drawing.Size(176, 19);
            this.fakeImagePath.TabIndex = 9;
            // 
            // normalImageSel
            // 
            this.normalImageSel.Location = new System.Drawing.Point(263, 32);
            this.normalImageSel.Name = "normalImageSel";
            this.normalImageSel.Size = new System.Drawing.Size(75, 23);
            this.normalImageSel.TabIndex = 10;
            this.normalImageSel.Text = "選択";
            this.normalImageSel.UseVisualStyleBackColor = true;
            this.normalImageSel.Click += new System.EventHandler(this.normalImageSel_Click);
            // 
            // fakeImageSel
            // 
            this.fakeImageSel.Location = new System.Drawing.Point(263, 57);
            this.fakeImageSel.Name = "fakeImageSel";
            this.fakeImageSel.Size = new System.Drawing.Size(75, 23);
            this.fakeImageSel.TabIndex = 11;
            this.fakeImageSel.Text = "選択";
            this.fakeImageSel.UseVisualStyleBackColor = true;
            this.fakeImageSel.Click += new System.EventHandler(this.fakeImageSel_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(185, 115);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(263, 115);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "キャンセル";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "壁紙モード";
            // 
            // selStyle
            // 
            this.selStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selStyle.FormattingEnabled = true;
            this.selStyle.Location = new System.Drawing.Point(84, 85);
            this.selStyle.Name = "selStyle";
            this.selStyle.Size = new System.Drawing.Size(176, 20);
            this.selStyle.TabIndex = 15;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WallSwitch";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 115);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(49, 23);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "終了";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 147);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.selStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.fakeImageSel);
            this.Controls.Add(this.normalImageSel);
            this.Controls.Add(this.fakeImagePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.normalImagePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dispHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dispWidth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "設定";
            ((System.ComponentModel.ISupportInitialize)(this.dispWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dispWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dispHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox normalImagePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fakeImagePath;
        private System.Windows.Forms.Button normalImageSel;
        private System.Windows.Forms.Button fakeImageSel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selStyle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button exitBtn;
    }
}

