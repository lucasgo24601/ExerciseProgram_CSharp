using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WordBook
{
    public partial class TestWord : UserControl
    {
        #region Private Var 
        private string[] SourceLinesList;                 // 存放原始資料列
        private List<string> WordCountDistributed;    // 存放分佈資料列
        private string[] AnsWord;                     // 存放當前的答案
        Random Rnd = new Random();
        #endregion

        #region Define Const Integer
        private const int Word_English = 0;
        private const int Word_Chinese = 1;
        private const int Word_Count = 2;
        private const int Word_Sucess = 3;
        private const int Word_TestCount = 4;
        #endregion

        public TestWord() => InitializeComponent();

        #region Form Load
        private void TestWord_Load(object sender, EventArgs e)
        {
            // Englis,Chinese,Count,Succees,TestCount
            #region Check File Exist 
            if (File.Exists("./WordSet.txt") == false)
            {
                MessageBox.Show("WordSet.txt is not exist", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[TestWord_Load] " + "WordSet.txt is not exist");
                btnEnter.Enabled = false;
                return;
            }
            #endregion
        }

        public void ReadFileIntoList()
        {
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[ReadFileIntoList] " + "Read File Into List Start");
            WordCountDistributed = new List<string>();
            SourceLinesList = File.ReadAllText("./WordSet.txt").Split('\n'); // 將原始文字轉換成行列
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[ReadFileIntoList] " + "Word Lines Length = " + SourceLinesList.Length);
            for (int i = 0; i < SourceLinesList.Length; i++)
            {
                List<string> SourceLine = new List<string>();
                SourceLine.AddRange(SourceLinesList[i].Split(',')); // 將單行文字元素拆散

                if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[ReadFileIntoList] " + "Word " + i.ToString() + " = " + SourceLinesList[i]);
                #region 將次數元素加入到陣列裡 以實現次數越多越容易被呼叫

                SourceLine.Add(i.ToString()); // 用於辨認於原始字串行列的位置
                WordCountDistributed.Add(SourceLine[Word_English] + "," +
                                         SourceLine[Word_Chinese] + "," +
                                         SourceLine[Word_Count] + "," +
                                         SourceLine[Word_Sucess] + "," +
                                         SourceLine[Word_TestCount] + "," +
                                         SourceLine[5]);


                #endregion
            }

            if (WordCountDistributed.Count == 1)
            {
                MessageBox.Show("Please Save More Data");
                btnEnter.Enabled = false;
                txtEnglish.Enabled = false;
            }
            else
            {
                txtEnglish.Enabled = true;
                btnEnter.Enabled = true;
                RandWord();
            }
        }
        #endregion

        #region Button Enter_Click
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (WordCountDistributed.Count == 1)
                MessageBox.Show("Please Save More Data");
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[btnEnter_Click] " + "btnEnter Click Start");
            AnsWord[Word_TestCount] = (Convert.ToInt32(AnsWord[Word_TestCount]) + 1).ToString(); // TestCount ++ 
            if (txtEnglish.Text.ToLower() == AnsWord[Word_English].ToLower())
            {
                MessageBox.Show("Is Correct Ans");
                if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[btnEnter_Click] " + "Correct Ans");
                lblChineseTopic.Text = "";
                AnsWord[Word_Sucess] = (Convert.ToInt32(AnsWord[Word_Sucess]) + 1).ToString(); // Success ++ 
                RefreshSourceLinesList();
                RandWord();
                #region 持續尋找下個不同單字
                while (txtEnglish.Text == AnsWord[Word_English])
                    RandWord();
                #endregion
            }
            else
            {
                if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[btnEnter_Click] " + "Wrong Ans");
                RefreshSourceLinesList();
            }
            txtEnglish.Text = "";
        }

        private void RefreshSourceLinesList()
        {
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[RefreshSourceLinesList] " + "Refresh Start");

            SourceLinesList[Convert.ToInt32(AnsWord[5])] =
                   AnsWord[Word_English] + "," +
                   AnsWord[Word_Chinese] + "," +
                   AnsWord[Word_Count] + "," +
                   AnsWord[Word_Sucess] + "," +
                   AnsWord[Word_TestCount];
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[RefreshSourceLinesList] " + "Answer Word = " + SourceLinesList[Convert.ToInt32(AnsWord[5])]);

        }
        #endregion

        private void TestWord_Leave(object sender, EventArgs e)
        {
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[TestWord_FormClosed] " + "Form Close");
            string temp = "";
            for (int i = 0; i < SourceLinesList.Length; i++)
            {
                if (SourceLinesList[i].IndexOf('\r') != -1)
                    SourceLinesList[i] = SourceLinesList[i].Substring(0, SourceLinesList[i].IndexOf('\r'));
                if (i != SourceLinesList.Length - 1)
                    temp += SourceLinesList[i] + '\n';
                else
                    temp += SourceLinesList[i];
            }
            File.WriteAllText("./WordSet.txt", temp);
            Console.WriteLine();
        }

        private void RandWord()
        {
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[RandWord] " + "Rand Number of Words Start");
            int Rand = Rnd.Next(0, WordCountDistributed.Count);
            AnsWord = WordCountDistributed[Rand].Split(',');
            lblChineseTopic.Text = AnsWord[Word_Chinese];
            if (Main.IsDebugMode) Trace.WriteLine("[TestWord] " + "[RandWord] " + "Rand Number of Word = " + WordCountDistributed[Rand]);
        }
    }
}
