using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using WordBook.Inclusion_of_Words;

namespace WordBook {
    public partial class InclusionWords : UserControl {
        #region private Var
        private Google Translate = new Google (); // Google翻譯轉換宣告
        private Thread Advance; // Google翻譯第一次使用會較緩慢，故加入背景執行：預處理
        private string FileWordSet = ""; // 存放外部TxT檔案內容
        private List<List<string>> TwoArrary = new List<List<string>> (); // 存放外部單字本的單字訊息 - 單字本格式：English,中文,次數,成功,測試次數 初始化

        private bool ButtonSwitch {
            get {
                return btnSave.Enabled;
            }
            set {
                btnSave.Enabled = value;
                btnTranslation.Enabled = value;
            }
        }
        #endregion

        public InclusionWords () {
            InitializeComponent ();
            CheckForIllegalCrossThreadCalls = false; // 讓執行緒可以存取UI
        }

        #region Form Load
        private void InclusionWords_Load (object sender, EventArgs e) {
            #region Check File
            if (File.Exists ("./WordSet.txt")) // 如果根目錄的單字本存在的話
            {
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "File is exist will read ./WordSet.txt");
                FileWordSet = File.ReadAllText ("./WordSet.txt"); // 讀取單字本
            } else {
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "File is not exist will create ./WordSet.txt");
                File.Create ("./WordSet.txt"); // 創立單字本File
            }

            if (File.Exists ("./gettk.js") == false) {
                #region gettk.js 的內容
                string gettk = @"  
var b = function (a, b) {
  for (var d = 0; d < b.length - 2; d += 3) {
    var c = b.charAt(d + 2),
      c = ""a"" <= c ? c.charCodeAt(0) - 87 : Number(c),
      c = ""+"" == b.charAt(d + 1) ? a >>> c : a << c;
    a = ""+"" == b.charAt(d) ? a + c & 4294967295 : a ^ c
  }
  return a
}
 
var tk = function (a,TKK) {
  for (var e = TKK.split("".""), h = Number(e[0]) || 0, g = [], d = 0, f = 0; f < a.length; f++) {
    var c = a.charCodeAt(f);
    128 > c ? g[d++] = c : (2048 > c ? g[d++] = c >> 6 | 192 : (55296 == (c & 64512) && f + 1 < a.length && 56320 == (a.charCodeAt(f + 1) & 64512) ? (c = 65536 + ((c & 1023) << 10) + (a.charCodeAt(++f) & 1023), g[d++] = c >> 18 | 240, g[d++] = c >> 12 & 63 | 128) : g[d++] = c >> 12 | 224, g[d++] = c >> 6 & 63 | 128), g[d++] = c & 63 | 128)
  }
  a = h;
  for (d = 0; d < g.length; d++) a += g[d], a = b(a, ""+-a^+6"");
  a = b(a, ""+-3^+b+-f"");
  a ^= Number(e[1]) || 0;
  0 > a && (a = (a & 2147483647) + 2147483648);
  a %= 1E6;
  return a.toString() + ""."" + (a ^ h)
} 
                    ";
                #endregion
                File.WriteAllText ("./gettk.js", gettk);
            }
            #endregion

            Thread.Sleep (200); // 緩衝時間，避免開始時候貼上動作過快，然而物件並尚未Show出來，等同無作為

            #region  模擬Ctrl+V 至 txtEnglish
            txtEnglish.Focus ();
            SendKeys.Send ("^{v}");
            #endregion
            if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + txtEnglish.Text);

            #region 預處理的屬性設定
            Advance = new Thread (AdvanceProcess); // 背景執行的內容為AdvanceProcess函數
            Advance.IsBackground = true; // 設定為背景執行，使程式可以正常重複開啟關閉
            Advance.Start (); // 背景執行續預處理
            #endregion
        }

        private void AdvanceProcess () {
            // 背景預處理提高效能，第一次執行需較長時間才能反映，故預處理之
            Thread.Sleep (200);
            try {
                ButtonSwitch = false;
                txtChinese.Text = Translate.GoogleTranslate (txtEnglish.Text, "auto", "zh-tw"); // 偵測語言Auto翻譯成繁體中文
                ButtonSwitch = true;
            } catch (Exception ex) {
                ButtonSwitch = true;
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Advance Process Error : " + ex.Message);
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Advance Process mabye paste illegal words");
            }
        }
        #endregion

        #region Button Translation_Click
        private void btnTranslation_Click (object sender, EventArgs e) {
            try {
                ButtonSwitch = false;
                txtChinese.Text = Translate.GoogleTranslate (txtEnglish.Text, Main.SourceText, Main.TrageText); // 偵測語言Auto翻譯成繁體中文
                ButtonSwitch = true;
            } catch (Exception ex) {
                ButtonSwitch = true;
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Error in Translate : " + ex.Message);
                MessageBox.Show ("Error in Translate please check " + txtEnglish.Text + " + is legal ");
            }

            Thread playThread = new Thread (() => PlayMp3FromUrl ("http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&&q=" + txtEnglish.Text + "&tl=en-us"));
            playThread.IsBackground = true;
            playThread.Start ();
        }

        private void PlayMp3FromUrl (string url) {
            try {
                AutoResetEvent stop = new AutoResetEvent (false); // 使當前主執行續暫停
                MemoryStream ms = new MemoryStream (); // for NAudio的資料Type
                Stream stream = WebRequest.Create (url).GetResponse ().GetResponseStream (); // 獲取Google音訊檔的原始頁

                byte[] buffer = new byte[32768];
                int read;
                #region Stream to Memory Stream
                while ((read = stream.Read (buffer, 0, buffer.Length)) > 0)
                    ms.Write (buffer, 0, read);
                #endregion
                ms.Position = 0; // 指定0開始
                #region NAudio 的 WaveOut 設定啟動
                WaveOut waveOut = new WaveOut ();
                waveOut.Init (new Mp3FileReader (ms)); // Waveout只支援Mp3FileReader by MemorySteam 類型
                waveOut.Play ();
                #endregion
                stop.WaitOne (5000); // 5 sec timeout
            } catch (Exception ex) {
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Error in Play Translate Url = " + url);
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Error message = " + ex.Message);
            }
        }
        #endregion

        #region Button Save_Click
        private void btnSave_Click (object sender, EventArgs e) {
            #region 單字本格式：English,中文,次數,成功,測試次數 初始化
            string English = txtEnglish.Text.Substring (0, 1).ToUpper () + txtEnglish.Text.Substring (1).ToLower ();
            string Chinese = txtChinese.Text;
            int Count = 1;
            int Success = 0;
            int TestCount = 0;
            #endregion

            if (txtChinese.Text == "")
                btnTranslation.PerformClick ();
            ButtonSwitch = false;
            #region 函數區 初始化
            int location = 0;
            string StringLine = "";
            TwoArrary = new List<List<string>> ();
            #endregion
            if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Button Save click");
            if (FileWordSet != "") {
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Words book is exist");
                #region 如果單字本已存在，即不是第一次使用本系統 
                if (IsWordExist (English, ref location)) {
                    if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "The Word is exsist in WordsBook");
                    #region 該單字已存在於單字本的話
                    TwoArrary[location][2] = (Convert.ToInt32 (TwoArrary[location][2]) + 1).ToString ();
                    foreach (var temp in TwoArrary) {
                        string oneLine = temp[0] + "," + temp[1] + "," + temp[2] + "," + temp[3] + "," + temp[4] + "\r\n";
                        StringLine += oneLine;
                    }
                    StringLine = StringLine.Substring (0, StringLine.Length - 2);

                    File.WriteAllText ("./WordSet.txt", StringLine); // 創立單字本File
                    FileWordSet = File.ReadAllText ("./WordSet.txt");

                    #endregion
                } else {
                    if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "The Word not exsist in WordsBook");
                    #region 該單字不存在於單字本的話
                    File.WriteAllText ("./WordSet.txt", FileWordSet + "\r\n" + English + "," + Chinese + "," + Count + "," + Success + "," + TestCount);
                    FileWordSet = File.ReadAllText ("./WordSet.txt");
                    #endregion
                }

                #endregion
            } else {
                if (Main.IsDebugMode) Trace.WriteLine ("[WordBook] " + "[InclusionWords_Load] " + "Words Book is not exist");
                #region 如果單字本不存在，建立Write並更新Key Value
                string WriteLine = English + "," + Chinese + "," + Count + "," + Success + "," + TestCount;
                File.WriteAllText ("./WordSet.txt", WriteLine); // 創立單字本File
                FileWordSet = File.ReadAllText ("./WordSet.txt");
                #endregion
            }
            ButtonSwitch = true;
            txtChinese.Text = "";
            txtEnglish.Text = "";
        }

        private bool IsWordExist (string source, ref int location) {
            bool returnAns = false;

            List<string> OneArrary = new List<string> ();

            foreach (string temp in FileWordSet.Split ('\n')) {
                OneArrary = new List<string> ();
                OneArrary.AddRange (temp.Split (','));
                TwoArrary.Add (OneArrary);
                if (OneArrary[0] == source) {
                    location = TwoArrary.Count - 1;
                    returnAns = true;
                }

            }
            return returnAns;
        }
        #endregion
    }
}