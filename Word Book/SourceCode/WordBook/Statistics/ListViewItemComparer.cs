using System;
using System.Windows.Forms;

namespace WordBook
{
    class ListViewItemComparer : System.Collections.IComparer
    {
        private int col;
        private string sort = "asc";

        #region 建構子
        public ListViewItemComparer()
        {
        }

        public ListViewItemComparer(int column, string Sort)
        {
            col = column;
            sort = Sort;
        }
        #endregion

        public void SetItemColumn(int Value)
        {
            col = Value;
        }

        public void SetItemSort(string Value)
        {
            sort = Value;
        }

        public int Compare(object x, object y)
        {
            if (sort == "asc")
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            else
                return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
        }
    }
}