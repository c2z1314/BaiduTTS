using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpHelp;
using Newtonsoft.Json;
using System.Collections;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace BaiduTTS
{
    public partial class BaiduApi : Form
    {
        string cuid = null; //随机数值
        string tok = null;  //请求的token
        string tex = null;  // 合成的文字

        string vol = null;  //音量
        string per = null;  //朗诵员
        string spd = null;  //语速
        string pit = null;  //语调
        string aue = null;  //音质
        HttpWebResponse PlayRes = null;
        public static BaiduApi form; //用来让静态方法控制控件属性
        Requests.RootUrlType AuType = new Requests.RootUrlType();
        public BaiduApi()
        {
            InitializeComponent();
            form = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cBoxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxPit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxSpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxAue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            //音量数据1-15
            ArrayList ListVol = new ArrayList();
            ListVol.Add(new DictionaryEntry("1", "1"));
            ListVol.Add(new DictionaryEntry("2", "2"));
            ListVol.Add(new DictionaryEntry("3", "3"));
            ListVol.Add(new DictionaryEntry("4", "4"));
            ListVol.Add(new DictionaryEntry("5", "5"));
            ListVol.Add(new DictionaryEntry("6", "6"));
            ListVol.Add(new DictionaryEntry("7", "7"));
            ListVol.Add(new DictionaryEntry("8", "8"));
            ListVol.Add(new DictionaryEntry("9", "9"));
            ListVol.Add(new DictionaryEntry("10", "10"));
            ListVol.Add(new DictionaryEntry("11", "11"));
            ListVol.Add(new DictionaryEntry("12", "12"));
            ListVol.Add(new DictionaryEntry("13", "13"));
            ListVol.Add(new DictionaryEntry("14", "14"));
            ListVol.Add(new DictionaryEntry("15", "15"));
            cBoxVol.DataSource = ListVol;
            cBoxVol.DisplayMember = "Key";
            cBoxVol.ValueMember = "Value";

            //朗诵员数据 度小宇=1，度小美=0，度逍遥=3，度丫丫=4 
            //精品音库 度博文=106，度小童=110，度小萌=111，度米朵=103，度小娇=5
            ArrayList ListPer = new ArrayList();
            ListPer.Add(new DictionaryEntry("度小宇", "1"));
            ListPer.Add(new DictionaryEntry("度小美", "0"));
            ListPer.Add(new DictionaryEntry("度逍遥", "3"));
            ListPer.Add(new DictionaryEntry("度丫丫", "4"));
            ListPer.Add(new DictionaryEntry("度博文(精品)", "106"));
            ListPer.Add(new DictionaryEntry("度小童(精品)", "110"));
            ListPer.Add(new DictionaryEntry("度小萌(精品)", "111"));
            ListPer.Add(new DictionaryEntry("度米朵(精品)", "103"));
            ListPer.Add(new DictionaryEntry("度小娇(精品)", "5"));
            cBoxPer.DataSource = ListPer;
            cBoxPer.DisplayMember = "Key";
            cBoxPer.ValueMember = "Value";

            //语速1-15
            ArrayList ListSpd = new ArrayList();
            ListSpd.Add(new DictionaryEntry("1", "1"));
            ListSpd.Add(new DictionaryEntry("2", "2"));
            ListSpd.Add(new DictionaryEntry("3", "3"));
            ListSpd.Add(new DictionaryEntry("4", "4"));
            ListSpd.Add(new DictionaryEntry("5", "5"));
            ListSpd.Add(new DictionaryEntry("6", "6"));
            ListSpd.Add(new DictionaryEntry("7", "7"));
            ListSpd.Add(new DictionaryEntry("8", "8"));
            ListSpd.Add(new DictionaryEntry("9", "9"));
            ListSpd.Add(new DictionaryEntry("10", "10"));
            ListSpd.Add(new DictionaryEntry("11", "11"));
            ListSpd.Add(new DictionaryEntry("12", "12"));
            ListSpd.Add(new DictionaryEntry("13", "13"));
            ListSpd.Add(new DictionaryEntry("14", "14"));
            ListSpd.Add(new DictionaryEntry("15", "15"));
            cBoxSpd.DataSource = ListSpd;
            cBoxSpd.DisplayMember = "Key";
            cBoxSpd.ValueMember = "Value";

            //音调1-15
            ArrayList ListPit = new ArrayList();
            ListPit.Add(new DictionaryEntry("1", "1"));
            ListPit.Add(new DictionaryEntry("2", "2"));
            ListPit.Add(new DictionaryEntry("3", "3"));
            ListPit.Add(new DictionaryEntry("4", "4"));
            ListPit.Add(new DictionaryEntry("5", "5"));
            ListPit.Add(new DictionaryEntry("6", "6"));
            ListPit.Add(new DictionaryEntry("7", "7"));
            ListPit.Add(new DictionaryEntry("8", "8"));
            ListPit.Add(new DictionaryEntry("9", "9"));
            ListPit.Add(new DictionaryEntry("10", "10"));
            ListPit.Add(new DictionaryEntry("11", "11"));
            ListPit.Add(new DictionaryEntry("12", "12"));
            ListPit.Add(new DictionaryEntry("13", "13"));
            ListPit.Add(new DictionaryEntry("14", "14"));
            ListPit.Add(new DictionaryEntry("15", "15"));
            cBoxPit.DataSource = ListPit;
            cBoxPit.DisplayMember = "Key";
            cBoxPit.ValueMember = "Value";

            //音质 3为mp3格式(默认)； 4为pcm-16k；5为pcm-8k；6为wav（内容同pcm-16k）
            ArrayList ListAue = new ArrayList();
            ListAue.Add(new DictionaryEntry("MP3", "3"));
            ListAue.Add(new DictionaryEntry("pcm-16k", "4"));
            ListAue.Add(new DictionaryEntry("pcm-8k", "5"));
            ListAue.Add(new DictionaryEntry("wav", "6"));
            cBoxAue.DataSource = ListAue;
            cBoxAue.DisplayMember = "Key";
            cBoxAue.ValueMember = "Value";

            cBoxPit.SelectedIndex = 4; //默认音调为4
            cBoxSpd.SelectedIndex = 4; //默认语速
            cBoxVol.SelectedIndex = 4; //默认音量
        }


        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("如果正确获取到Token会显示在右边，未显示说明秘钥失效。", label2, new Point(e.X + 10, e.Y - 10), 500);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AuType.aue = cBoxAue.SelectedValue.ToString();
                AuType.cuid = Requests.GetRandomString(10);
                AuType.per = cBoxPer.SelectedValue.ToString();
                AuType.pit = cBoxPit.SelectedValue.ToString();
                AuType.tex = txtTex.Text.Trim();
                AuType.vol = cBoxVol.SelectedValue.ToString();
                AuType.spd = cBoxSpd.SelectedValue.ToString();
                string url = "https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials&client_id=" + txtApiKey.Text.Trim() + "&client_secret=" + txtSecretKey.Text.Trim();
                Requests.JsonEn json = Requests.Text2JsonObj(url);
                AuType.tok = json.access_token; //给音频对象中的tok赋值。
                toolStripStatusLabel1.Text = "初始化完成";
                textBox2.Text = "正确请求" + Requests.Url2Text(url);
                btnSave.Enabled = true;
                btnPlay.Enabled = true;
            }
            catch (Exception q)
            {
                textBox2.Text = q.Message.ToString() + "秘钥失效，请自主申请API";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuType.aue = cBoxAue.SelectedValue.ToString();
            AuType.cuid = Requests.GetRandomString(10);
            AuType.per = cBoxPer.SelectedValue.ToString();
            AuType.pit = cBoxPit.SelectedValue.ToString();
            AuType.tex = txtTex.Text.Trim();
            AuType.vol = cBoxVol.SelectedValue.ToString();
            AuType.spd = cBoxSpd.SelectedValue.ToString();
            string url = "http://tsn.baidu.com/text2audio?lan=zh&ctp=1&cuid=" +
                AuType.cuid +
                "&tok=" + AuType.tok +
                "&tex=" + AuType.tex +
                "&vol=" + AuType.vol +
                "&per=" + AuType.per +
                "&spd=" + AuType.spd +
                "&pit=" + AuType.pit +
                "&aue=" + 6;
            textBox2.Text = url;
            //SoundPlayer sound = new SoundPlayer(url);
            //sound.PlaySync();
            //PlayRes= Requests.GetRes(url);
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //http://tsn.baidu.com/text2audio?lan=zh&ctp=1&cuid=abcdxxx&tok=1.a6b7dbd428f731035f771b8d****.86400.1292922000-2346678-124328&tex=%e7%99%be%e5%ba%a6%e4%bd%a0%e5%a5%bd&vol=9&per=0&spd=5&pit=5&aue=3

            //textBox2.Text = url;
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "音频文件（*.mp3 *.wav）|*.mp3;*.wav";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                //给文件名前加上时间 
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                //在文件名里加字符 
                //saveFileDialog1.FileName.Insert(1,"dameng"); 

                //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 

                ////fs输出带文字或图片的文件，就看需求了 
            }
            bool IsOk= Requests.DlFile("http://tsn.baidu.com/text2audio?lan=zh&ctp=1&cuid=" +
                AuType.cuid +
                "&tok=" + AuType.tok +
                "&tex=" + AuType.tex +
                "&vol=" + AuType.vol +
                "&per=" + AuType.per +
                "&spd=" + AuType.spd +
                "&pit=" + AuType.pit +
                "&aue=" + 6, localFilePath);
            if (IsOk)
            {
                toolTip1.Show("保存成功！", btnSave, 2000);
            }
            else
            {
                toolTip1.Show("保存失败！", btnSave, 2000);
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://console.bce.baidu.com/ai/#/ai/speech/overview/index"); //申请百度的语音合成api
        }
    }

}
