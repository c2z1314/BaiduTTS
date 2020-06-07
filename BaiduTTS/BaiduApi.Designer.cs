namespace BaiduTTS
{
    partial class BaiduApi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaiduApi));
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtTex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxAue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxPit = new System.Windows.Forms.ComboBox();
            this.cBoxSpdlab = new System.Windows.Forms.Label();
            this.cBoxSpd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxPer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxVol = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Secret_Key = new System.Windows.Forms.Label();
            this.API_Key = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.Location = new System.Drawing.Point(286, 231);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 44);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTex
            // 
            this.txtTex.Font = new System.Drawing.Font("宋体", 8F);
            this.txtTex.Location = new System.Drawing.Point(32, 45);
            this.txtTex.Multiline = true;
            this.txtTex.Name = "txtTex";
            this.txtTex.Size = new System.Drawing.Size(379, 64);
            this.txtTex.TabIndex = 2;
            this.txtTex.Text = "这是一个语音合成的范例。";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBoxAue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxPit);
            this.groupBox1.Controls.Add(this.cBoxSpdlab);
            this.groupBox1.Controls.Add(this.cBoxSpd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBoxPer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxVol);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtTex);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 20F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合成";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label5.Location = new System.Drawing.Point(28, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "音质";
            // 
            // cBoxAue
            // 
            this.cBoxAue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cBoxAue.FormattingEnabled = true;
            this.cBoxAue.Location = new System.Drawing.Point(91, 275);
            this.cBoxAue.Name = "cBoxAue";
            this.cBoxAue.Size = new System.Drawing.Size(121, 31);
            this.cBoxAue.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(28, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "音调";
            // 
            // cBoxPit
            // 
            this.cBoxPit.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cBoxPit.FormattingEnabled = true;
            this.cBoxPit.Location = new System.Drawing.Point(91, 238);
            this.cBoxPit.Name = "cBoxPit";
            this.cBoxPit.Size = new System.Drawing.Size(121, 31);
            this.cBoxPit.TabIndex = 10;
            // 
            // cBoxSpdlab
            // 
            this.cBoxSpdlab.AutoSize = true;
            this.cBoxSpdlab.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cBoxSpdlab.Location = new System.Drawing.Point(28, 204);
            this.cBoxSpdlab.Name = "cBoxSpdlab";
            this.cBoxSpdlab.Size = new System.Drawing.Size(44, 23);
            this.cBoxSpdlab.TabIndex = 9;
            this.cBoxSpdlab.Text = "语速";
            // 
            // cBoxSpd
            // 
            this.cBoxSpd.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cBoxSpd.FormattingEnabled = true;
            this.cBoxSpd.Location = new System.Drawing.Point(91, 201);
            this.cBoxSpd.Name = "cBoxSpd";
            this.cBoxSpd.Size = new System.Drawing.Size(121, 31);
            this.cBoxSpd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "朗诵员";
            // 
            // cBoxPer
            // 
            this.cBoxPer.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cBoxPer.FormattingEnabled = true;
            this.cBoxPer.Location = new System.Drawing.Point(91, 164);
            this.cBoxPer.Name = "cBoxPer";
            this.cBoxPer.Size = new System.Drawing.Size(121, 31);
            this.cBoxPer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(28, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "音量";
            // 
            // cBoxVol
            // 
            this.cBoxVol.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cBoxVol.FormattingEnabled = true;
            this.cBoxVol.Location = new System.Drawing.Point(91, 127);
            this.cBoxVol.Name = "cBoxVol";
            this.cBoxVol.Size = new System.Drawing.Size(121, 31);
            this.cBoxVol.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(286, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel1.Text = "正在初始化";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.Secret_Key);
            this.groupBox2.Controls.Add(this.API_Key);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtSecretKey);
            this.groupBox2.Controls.Add(this.txtApiKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 419);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "https://baidu.com";
            this.groupBox2.Text = "调试";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(259, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "123";
            this.linkLabel1.Text = "申请百度API？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Secret_Key
            // 
            this.Secret_Key.AutoSize = true;
            this.Secret_Key.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Secret_Key.Location = new System.Drawing.Point(112, 345);
            this.Secret_Key.Name = "Secret_Key";
            this.Secret_Key.Size = new System.Drawing.Size(100, 23);
            this.Secret_Key.TabIndex = 5;
            this.Secret_Key.Text = "Secret Key:";
            // 
            // API_Key
            // 
            this.API_Key.AutoSize = true;
            this.API_Key.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.API_Key.Location = new System.Drawing.Point(136, 263);
            this.API_Key.Name = "API_Key";
            this.API_Key.Size = new System.Drawing.Size(76, 23);
            this.API_Key.TabIndex = 4;
            this.API_Key.Text = "API Key:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(6, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 121);
            this.button2.TabIndex = 3;
            this.button2.Text = "初始化token";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSecretKey.Location = new System.Drawing.Point(220, 328);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(189, 44);
            this.txtSecretKey.TabIndex = 3;
            // 
            // txtApiKey
            // 
            this.txtApiKey.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApiKey.Location = new System.Drawing.Point(220, 251);
            this.txtApiKey.Multiline = true;
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(189, 44);
            this.txtApiKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label2.Location = new System.Drawing.Point(69, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "提示：";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox2.Location = new System.Drawing.Point(193, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 146);
            this.textBox2.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightSalmon;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(12, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 95);
            this.panel1.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(431, 95);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // BaiduApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaiduApi";
            this.Text = "(百度接口)语音合成";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtTex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Secret_Key;
        private System.Windows.Forms.Label API_Key;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cBoxVol;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cBoxSpdlab;
        private System.Windows.Forms.ComboBox cBoxSpd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxPit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxAue;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        //private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

