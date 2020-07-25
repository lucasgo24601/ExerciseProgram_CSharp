using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WordBook {
    public partial class Main : Form {
        #region Form Object
        private InclusionWords FormInclusionWords = new InclusionWords ();
        private TestWord FormTestWord = new TestWord ();
        private Statistics FormStatistics = new Statistics ();
        private Language FormLanguage = new Language ();
        #endregion

        #region Config
        public static string SourceText = "auto";
        public static string TrageText = "zh-tw";
        public static bool IsDebugMode = false;
        #endregion

        #region API
        [DllImport ("kernel32")]
        private static extern int GetPrivateProfileString (string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion

        #region Form Move
        private bool IsDoMove = false;
        private Point FormPoint = new Point ();
        private Point MousPoint = new Point ();
        #endregion

        public Main () => InitializeComponent ();

        #region Form Main Load
        private void Main_Load (object sender, EventArgs e) {
            if (File.Exists ("./WordBookConfig.ini")) {
                if (IsDebugMode) Trace.WriteLine ("[WordBook] " + "[Main_Load] " + "Config Exist");
                #region Exist
                SourceText = getKeyValue ("Main", "Source");
                TrageText = getKeyValue ("Main", "Trage");
                IsDebugMode = ConvertToBoolean (getKeyValue ("Main", "IsDebugMode"));
                #endregion
            } else {
                if (IsDebugMode) Trace.WriteLine ("[WordBook] " + "[Main_Load] " + "Config Not Exist");
                #region Exist
                SourceText = "auto";
                TrageText = "zh-tw";
                IsDebugMode = false;
                #endregion
            }
        }

        private bool ConvertToBoolean (string temp) {
            if (temp == "1" | temp == "ture" | temp == "True" | temp == "Y" | temp == "y")
                return true;
            return false;
        }

        public string getKeyValue (string IN_Section, string IN_Key) {
            StringBuilder temp = new StringBuilder (255);
            int i = GetPrivateProfileString (IN_Section, IN_Key, "", temp, 255, "./WordBookConfig.ini");
            return temp.ToString ();
        }
        #endregion

        private void btnAll_Click (object sender, EventArgs e) {
            BunifuFlatButton temp = sender as BunifuFlatButton;
            lblNowPage.Text = temp.Text;

            #region Panel Controls
            panel4.Controls.Clear ();
            switch (temp.Text) {
                case "Enter":
                    panel4.Controls.Add (FormInclusionWords);
                    break;
                case "Test":
                    panel4.Controls.Add (FormTestWord);
                    if (temp.selected == false)
                        FormTestWord.ReadFileIntoList ();
                    break;
                case "Statistics":
                    panel4.Controls.Add (FormStatistics);
                    break;
                case "Language":
                    panel4.Controls.Add (FormLanguage);
                    break;
            }
            #endregion

            #region Button Selected
            btnEnter.selected = false;
            btnLanguage.selected = false;
            btnStatistics.selected = false;
            btnTest.selected = false;

            #endregion

            temp.selected = true;
        }

        #region Picture Click
        private void picMinimized_Click (object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click (object sender, EventArgs e) {
            this.Close ();
        }
        #endregion

        #region Form Panel Mouse Move
        private void FormAllPanel_MouseDown (object sender, MouseEventArgs e) {
            IsDoMove = true;
            FormPoint = new Point (this.Location.X, this.Location.Y);
            MousPoint = new Point (MousePosition.X, MousePosition.Y);
        }

        private void FormAllPanel_MouseUp (object sender, MouseEventArgs e) {
            IsDoMove = false;
        }

        private void FormAllPanel_MouseMove (object sender, MouseEventArgs e) {
            if (IsDoMove == false)
                return;

            this.Location = new Point (FormPoint.X + (MousePosition.X - MousPoint.X),
                FormPoint.Y + (MousePosition.Y - MousPoint.Y));
        }
        #endregion
    }
}