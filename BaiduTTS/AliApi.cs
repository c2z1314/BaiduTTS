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
using System.Runtime.InteropServices;
using System.Reflection;

namespace BaiduTTS
{
    public partial class AliApi : Form
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
        string Url = null;
        public static AliApi form;
        Requests.RootUrlType AuType = new Requests.RootUrlType();
        public AliApi()
        {
            InitializeComponent();

            form = this;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            cBoxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //cBoxPit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //cBoxSpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //cBoxAue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // cBoxVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;


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
            //cBoxVol.DataSource = ListVol;
            //cBoxVol.DisplayMember = "Key";
            //cBoxVol.ValueMember = "Value";

            //朗诵员数据 度小宇=1，度小美=0，度逍遥=3，度丫丫=4 
            //精品音库 度博文=106，度小童=110，度小萌=111，度米朵=103，度小娇=5
            ArrayList ListPer = new ArrayList();
            ListPer.Add(new DictionaryEntry("小云(标准女声)", "Xiaoyun"));
            ListPer.Add(new DictionaryEntry("小刚(标准男声)", "Xiaogang"));
            ListPer.Add(new DictionaryEntry("若兮(温柔女声)", "Ruoxi"));
            ListPer.Add(new DictionaryEntry("思琪(温柔女声)", "Siqi"));
            ListPer.Add(new DictionaryEntry("思佳(标准女声)", "Sijia"));
            ListPer.Add(new DictionaryEntry("思诚(标准男声)", "Sicheng"));
            ListPer.Add(new DictionaryEntry("艾琪(温柔女声)", "Aiqi"));
            ListPer.Add(new DictionaryEntry("艾佳(标准女声)", "Aijia"));
            ListPer.Add(new DictionaryEntry("艾诚(标准男声)", "Aicheng"));
            ListPer.Add(new DictionaryEntry("艾达(标准男声)", "Aida"));
            ListPer.Add(new DictionaryEntry("宁儿(标准女声)", "Ninger"));
            ListPer.Add(new DictionaryEntry("瑞琳(标准女声)", "Ruilin"));
            ListPer.Add(new DictionaryEntry("思悦(温柔女声)", "Siyue"));
            ListPer.Add(new DictionaryEntry("艾雅(严厉女声)", "Aiya"));
            ListPer.Add(new DictionaryEntry("艾夏(亲和女声)", "Aixia"));
            ListPer.Add(new DictionaryEntry("艾美(甜美女声)", "Aimei"));
            ListPer.Add(new DictionaryEntry("艾雨(自然女声)", "Aiyu"));
            ListPer.Add(new DictionaryEntry("艾悦(温柔女声)", "Aiyue"));
            ListPer.Add(new DictionaryEntry("艾婧(严厉女声)", "Aijing"));
            ListPer.Add(new DictionaryEntry("小美(甜美女声)", "Xiaomei"));
            ListPer.Add(new DictionaryEntry("艾娜(浙普女声)", "Aina"));
            ListPer.Add(new DictionaryEntry("伊娜(浙普女声)", "Yina"));
            ListPer.Add(new DictionaryEntry("思婧(严厉女声)", "Sijing"));
            ListPer.Add(new DictionaryEntry("思彤(儿童音)", "Sitong"));
            ListPer.Add(new DictionaryEntry("小北(萝莉女声)", "Xiaobei"));
            ListPer.Add(new DictionaryEntry("艾彤(儿童音)", "Aitong"));
            ListPer.Add(new DictionaryEntry("艾薇(萝莉女声)", "Aiwei"));
            ListPer.Add(new DictionaryEntry("艾宝(萝莉女声)", "Aibao"));
            ListPer.Add(new DictionaryEntry("Harry(英音男声)", "Harry"));
            ListPer.Add(new DictionaryEntry("Abby(美音女声)", "Abby"));
            ListPer.Add(new DictionaryEntry("Andy(美音男声)", "Andy"));
            ListPer.Add(new DictionaryEntry("Eric(英音男声)", "Eric"));
            ListPer.Add(new DictionaryEntry("Emily(英音女声)", "Emily"));
            ListPer.Add(new DictionaryEntry("Luna(英音女声)", "Luna"));
            ListPer.Add(new DictionaryEntry("Luca(英音男声)", "Luca"));
            ListPer.Add(new DictionaryEntry("Wendy(英音女声)", "Wendy"));
            ListPer.Add(new DictionaryEntry("William(英音男声)", "William"));
            ListPer.Add(new DictionaryEntry("Olivia(英音女声)", "Olivia"));
            ListPer.Add(new DictionaryEntry("姗姗(粤语女声)", "Shanshan"));
            ListPer.Add(new DictionaryEntry("小玥(四川话女声)", "Xiaoyue"));
            ListPer.Add(new DictionaryEntry("Lydia(英中双语女声)", "Lydia"));
            ListPer.Add(new DictionaryEntry("艾硕(自然男声)", "Aishuo"));
            ListPer.Add(new DictionaryEntry("青青(台湾话女声)", "Qingqing"));
            ListPer.Add(new DictionaryEntry("翠姐(东北话女声)", "Cuijie"));
            ListPer.Add(new DictionaryEntry("小泽(湖南重口音男声)", "Xiaoze"));

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
            //cBoxSpd.DataSource = ListSpd;
            //cBoxSpd.DisplayMember = "Key";
            //cBoxSpd.ValueMember = "Value";

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
            //cBoxPit.DataSource = ListPit;
            //cBoxPit.DisplayMember = "Key";
            //cBoxPit.ValueMember = "Value";

            //音质 3为mp3格式(默认)； 4为pcm-16k；5为pcm-8k；6为wav（内容同pcm-16k）
            ArrayList ListAue = new ArrayList();
            ListAue.Add(new DictionaryEntry("MP3", "3"));
            ListAue.Add(new DictionaryEntry("pcm-16k", "4"));
            ListAue.Add(new DictionaryEntry("pcm-8k", "5"));
            ListAue.Add(new DictionaryEntry("wav", "6"));
            //cBoxAue.DataSource = ListAue;
            //cBoxAue.DisplayMember = "Key";
            //cBoxAue.ValueMember = "Value";

            //cBoxPit.SelectedIndex = 4; //默认音调为4
            //cBoxSpd.SelectedIndex = 4; //默认语速
            //cBoxVol.SelectedIndex = 4; //默认音量
        }


        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("需要正确获取AppKey和Token。", label2, new Point(e.X + 10, e.Y - 10), 500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://nls-gateway.cn-shanghai.aliyuncs.com/stream/v1/tts?appkey=" + txtAppkey.Text.Trim() + "&token=" + txtToken.Text.Trim() + "&format=wav&sample_rate=16000&text=" + txtTex.Text.Trim();
                //Requests.JsonEn json = Requests.Text2JsonObj(url);
                //AuType.tok = json.access_token; //给音频对象中的tok赋值。
                toolStripStatusLabel1.Text = "初始化完成";
                //textBox2.Text = "正确请求" + Requests.Url2Text(url);
                //HttpWebResponse res = Requests.GetRes(url);
                textBox2.Text = url;
                Url = "https://nls-gateway.cn-shanghai.aliyuncs.com/stream/v1/tts?appkey=" + txtAppkey.Text.Trim() + "&token=" + txtToken.Text.Trim() + "&format=wav&sample_rate=16000&text=";
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
            //AuType.aue = cBoxAue.SelectedValue.ToString();
            //AuType.cuid = Requests.GetRandomString(10);
            //AuType.per = cBoxPer.SelectedValue.ToString();
            //AuType.pit = cBoxPit.SelectedValue.ToString();
            //AuType.tex = txtTex.Text.Trim();
            //AuType.vol = cBoxVol.SelectedValue.ToString();
            //AuType.spd = cBoxSpd.SelectedValue.ToString();
            //string url = "http://tsn.baidu.com/text2audio?lan=zh&ctp=1&cuid=" +
            //    AuType.cuid +
            //    "&tok=" + AuType.tok +
            //    "&tex=" + AuType.tex +
            //    "&vol=" + AuType.vol +
            //    "&per=" + AuType.per +
            //    "&spd=" + AuType.spd +
            //    "&pit=" + AuType.pit +
            //    "&aue=" + 6;
            string url = Url + Uri.EscapeDataString(txtTex.Text.Trim()) + "&voice=" + cBoxPer.SelectedValue.ToString();
            textBox2.Text = url;

            //PlayRes = Requests.GetRes(url);
            //SoundPlayer sound = new SoundPlayer("ali.wav");
            //sound.PlaySync();
            System.Threading.Thread.Sleep(2000);
            axWindowsMediaPlayer2.URL = url;
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }


        private void button3_Click(object sender, EventArgs e)
        {
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
            bool IsOk = Requests.DlFile(Url + Uri.EscapeDataString(txtTex.Text.Trim()) + "&voice=" + cBoxPer.SelectedValue.ToString(), localFilePath);
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
            Process.Start("https://nls-portal.console.aliyun.com/overview"); //申请阿里的语音合成api
        }
    }
}
