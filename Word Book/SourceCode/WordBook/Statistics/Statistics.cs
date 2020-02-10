using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace WordBook
{
    public partial class Statistics : UserControl
    {
        private string[] SourceLines;
        private double TotalCount = 0;
        private int TimerCount = 0;

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            if (File.Exists("./WordSet.txt") == false)
            {
                if (Main.IsDebugMode) Trace.WriteLine("[WrodBook] " + "[Statistics_Load] " + "WordSet.txt not exist");
                MessageBox.Show("Word Book File is not exist");
                return;
            }

            if (Main.IsDebugMode) Trace.WriteLine("[WrodBook] " + "[Statistics_Load] " + "WordSet.txt File is exist");
            SourceLines = File.ReadAllText("./WordSet.txt").Split('\n');
            lvWords.Items.Clear(); // 先清除lvWords所有資料再更新
            foreach (string OneLine in SourceLines)
            {
                if (Main.IsDebugMode) Trace.WriteLine("[WrodBook] " + "[Statistics_Load] " + "Line = " + OneLine);
                AddInList(OneLine.Split(','));
            }
        }

        private void AddInList(string[] LineSplit)
        {
            lvWords.Items.Add(LineSplit[0]);                                    // English
            lvWords.Items[lvWords.Items.Count - 1].SubItems.Add(LineSplit[1]);  // Chinese
            lvWords.Items[lvWords.Items.Count - 1].SubItems.Add(LineSplit[2]);  // Count
            lvWords.Items[lvWords.Items.Count - 1].SubItems.Add(LineSplit[3]);  // Success
            lvWords.Items[lvWords.Items.Count - 1].SubItems.Add(LineSplit[4]);  // Test Count
            TotalCount += Convert.ToInt32(LineSplit[2]);
        }

        private void lvWords_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            for (int i = 0; i < lvWords.Columns.Count; i++)
            {
                lvWords.Columns[i].Text = lvWords.Columns[i].Text.Replace(" △", "");
                lvWords.Columns[i].Text = lvWords.Columns[i].Text.Replace(" ▽", "");
            }

            ListViewItemComparer listViewItemComparer = new ListViewItemComparer();

            if (this.lvWords.Sorting == SortOrder.Ascending || lvWords.Sorting == SortOrder.None)
            {
                #region 大到小 DESC
                if (Main.IsDebugMode) Trace.WriteLine("[WrodBook] " + "[lvWords_ColumnClick] " + "Order by DESC");

                listViewItemComparer.SetItemSort("desc");
                lvWords.Sorting = SortOrder.Descending;
                lvWords.Columns[e.Column].Text = lvWords.Columns[e.Column].Text + " ▽";
                #endregion
            }
            else
            {
                #region 小到大 ASC 
                if (Main.IsDebugMode) Trace.WriteLine("[WrodBook] " + "[lvWords_ColumnClick] " + "Order by ASC");

                listViewItemComparer.SetItemSort("asc");
                lvWords.Sorting = SortOrder.Ascending;
                lvWords.Columns[e.Column].Text = lvWords.Columns[e.Column].Text + " △";
                #endregion
            }
            listViewItemComparer.SetItemColumn(e.Column);
            lvWords.ListViewItemSorter = listViewItemComparer;

            lvWords.Sort();
        }

        private void lvWords_ItemActivate(object sender, EventArgs e)
        {
            int HitRate = 0;
            int SuccessRate = 0;
            int FailRate = 0;
            #region Hit Rate
            try
            {
                double Count = Convert.ToDouble(lvWords.Items[lvWords.SelectedIndices[0]].SubItems[2].Text);
                HitRate = Convert.ToInt32((Count / TotalCount) * 100);
            }
            catch
            {
                HitRate = 0;
            }
            #endregion

            #region Success、TestCount Rate
            try
            {
                double Success = Convert.ToDouble(lvWords.Items[lvWords.SelectedIndices[0]].SubItems[3].Text);
                double TestCount = Convert.ToDouble(lvWords.Items[lvWords.SelectedIndices[0]].SubItems[4].Text);

                SuccessRate = Convert.ToInt32((Success / TestCount) * 100);
                FailRate = 100 - SuccessRate;
            }
            catch
            {
                SuccessRate = 0;
                FailRate = 0;
            }
            #endregion

            SetValue(SuccessRate, FailRate, HitRate);
        }

        private void SetValue(int Success, int Fail, int Hit)
        {
            CirPrgSuccessRate.Value = 0;
            CirPrgFailRate.Value = 0;
            CirPrgHitRate.Value = 0;

            int max = Math.Max(Math.Max(Success, Fail), Hit) + 1;

            while (--max > 0)
            {
                if (Success > 0)
                {
                    CirPrgSuccessRate.Value++;
                    Success--;
                }

                if (Fail > 0)
                {
                    CirPrgFailRate.Value++;
                    Fail--;
                }

                if (Hit > 0)
                {
                    CirPrgHitRate.Value++;
                    Hit--;
                }
                timeout(2);
            }
        }

        private void timeout(int count)
        {
            if (Main.IsDebugMode) Trace.WriteLine("[WordBook] " + "[timeout] " + "Will Stop " + count * 10 + "ms");
            TimerCount = count;
            AutoResetEvent AutoResetEvent = new AutoResetEvent(false);  //宣告一個執行續之間發送信號的物件
            TimerCallback TimerCallback = CheckStatus;      //timer執行的函數委派
            System.Threading.Timer Timer = new System.Threading.Timer(TimerCallback, AutoResetEvent, 0, 10);//延遲0.5秒後開始每一秒觸發
            AutoResetEvent.WaitOne();//hold住目前主執行緒，直到副執行緒(Timer)委派的事件(CheckStatus)同意(AutoResetEvent.Set();)主執行緒才可以行動
            Timer.Dispose();            //取消副執行續timer動作
        }

        public void CheckStatus(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;   //autoEvent物件用於傳送訊息給主執行續((AutoResetEvent)stateInfo)

            if (--TimerCount == 0)
            {
                autoEvent.Set();//執行WaitOne執行緒(讓等候的WaitOne執行緒繼續執行)
            }
        }

    }
}


