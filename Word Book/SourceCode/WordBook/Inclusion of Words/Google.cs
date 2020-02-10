using System;
using System.IO;
using System.Net;
using System.Text;

namespace WordBook.Inclusion_of_Words
{
    class Google
    {
        public string GoogleTranslate(string text, string fromLanguage, string toLanguage)
        {
            // 自動檢測：auto
            // 中文：zh-CN，英文：en

            #region 宣告區
            CookieContainer cc = new CookieContainer();                         // 存放Cookie的變數
            string GoogleTransBaseUrl = "https://translate.google.cn/";         // Google URL 預設中文
            #endregion
            string BaseResultHtml = GetResultHtml(GoogleTransBaseUrl, cc, "");  // 獲取網頁原始碼，用於填入對應的翻譯參數 (https://translate.google.cn/)

            string temp = BaseResultHtml.Substring(BaseResultHtml.IndexOf("tkk")); // 獲取TKK值
            temp = temp.Split(',')[0];
            temp = temp.Split('\'')[1];
            temp = temp.Split('\'')[0];
            #region TK (翻譯Url的車票欄位破解)
            string TKK = temp;
            string GetTkkJS = File.ReadAllText("./gettk.js");                   // 讀取JS函數
            string tk = ExecuteScript("tk(\"" + text + "\",\"" + TKK + "\")", GetTkkJS);
            #endregion
            #region 翻譯轉換的URL格式填入
            string googleTransUrl = "https://translate.google.cn/translate_a/single?client=t&sl=" +
                                  fromLanguage + "&tl=" +
                                  toLanguage + "&hl=en&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&ie=UTF-8&oe=UTF-8&otf=1&ssel=0&tsel=0&kc=1&tk=" +
                                  tk + "&q=" + System.Web.HttpUtility.UrlEncode(text);

            #endregion
            string ResultHtml = GetResultHtml(googleTransUrl, cc, "https://translate.google.cn/"); // 獲取翻譯後的原始碼
            dynamic TempResult = Newtonsoft.Json.JsonConvert.DeserializeObject(ResultHtml); // 轉換

            return Convert.ToString(TempResult[0][0][0]); // 中文翻譯位於0,0,0
        }

        public string GetResultHtml(string url, CookieContainer cookie, string refer)
        {
            HttpWebRequest webRequest = WebRequest.Create(url) as HttpWebRequest;
            #region webRequest屬性設定
            webRequest.Method = "GET";
            webRequest.CookieContainer = cookie;
            webRequest.Referer = refer;
            webRequest.Timeout = 20000;
            webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            webRequest.UserAgent = " Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 6.0)";
            #endregion
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
            return reader.ReadToEnd();
        }

        private string ExecuteScript(string sExpression, string sCode)
        {
            MSScriptControl.ScriptControl scriptControl = new MSScriptControl.ScriptControl();
            scriptControl.UseSafeSubset = true;
            scriptControl.Language = "JScript";
            scriptControl.AddCode(sCode);
            try
            {
                string str = scriptControl.Eval(sExpression).ToString();
                return str;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            return null;
        }
    }
}
