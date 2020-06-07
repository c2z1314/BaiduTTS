using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace HttpHelp
{
    public class Requests
    {
        public static HttpWebResponse GetRes(string url) //Get请求返回response
        {
                HttpWebRequest request;
                // 创建一个HTTP请求
                request = (HttpWebRequest)WebRequest.Create(url);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return response;
            
        }
        public static string Res2Text(HttpWebResponse res) //把response转换成字符串
        {
            System.IO.StreamReader myreader = new System.IO.StreamReader(res.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            return responseText;
        }
        public static JsonEn GetJsonObj(string json) //返回的是自定义jsonEn对象
        {
            JsonEn rb = JsonConvert.DeserializeObject<JsonEn>(json);
            return rb;
        }
        public static string Url2Text(string url)
        {
            return Res2Text(GetRes(url));
        }
        public static JsonEn Text2JsonObj(string url)
        {
            return GetJsonObj(Res2Text(GetRes(url))); //持续套娃，把网址获取res再转text再转json
        }
        public static string GetRandomString(int length, string availableChars = null)
        {
            if (availableChars == null) availableChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


            var id = new char[length];
            Random random = new Random();
            for (var i = 0; i < length; i++)
            {
                id[i] = availableChars[random.Next(0, availableChars.Length)];
            }

            return new string(id);
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="URL">下载文件地址</param>
        /// <param name="Filename">下载后另存为（全路径）</param>
        public static bool DlFile(string url, string filename)
        {
            try
            {
                HttpWebResponse res= GetRes(url);
                System.IO.Stream st = res.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    so.Write(by, 0, osize);
                    osize = st.Read(by, 0, (int)by.Length);
                }
                so.Close();
                st.Close();
                return true;
            }
            catch (Exception e)
            {
                BaiduTTS.BaiduApi.form.textBox2.Text = e.Message.ToString();
                return false;
            }
        }
        public class JsonEn
        {
            public string refresh_token { get; set; }
            public string expires_in { get; set; }
            public string session_key { get; set; }
            public string access_token { get; set; }
            public string scope { get; set; }
            public string session_secret { get; set; }
        }
        public class RootUrlType
        {
            /// <summary>
            /// 
            /// </summary>
            public string cuid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tok { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tex { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string vol { get; set; }
            /// <summary>
            /// audio_voice_assistant_get brain_enhanced_asr audio_tts_post public brain_all_scope picchain_test_picchain_api_scope brain_asr_async wise_adapt lebo_resource_base lightservice_public hetu_basic lightcms_map_poi kaidian_kaidian ApsMisTest_Test权限 vis-classify_flower lpq_开放 cop_helloScope ApsMis_fangdi_permission smartapp_snsapi_base iop_autocar oauth_tp_app smartapp_smart_game_openapi oauth_sessionkey smartapp_swanid_verify smartapp_opensource_openapi smartapp_opensource_recapi fake_face_detect_开放Scope vis-ocr_虚拟人物助理 idl-video_虚拟人物助理
            /// </summary>
            public string per { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string spd { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string pit { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string aue { get; set; }
        }


    }
}
