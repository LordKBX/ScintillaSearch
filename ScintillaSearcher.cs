using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScintillaSearch
{
    public partial class ScintillaSearcher : UserControl
    {
        public Scintilla? Scintilla { get; set; } = null;
        public ScintillaSearchAllResultsPanel? ScintillaSearchAllResultsPanel { get; set; } = null;

        private List<int> positions = new List<int>();
        private List<ScintillaSearchResultLine> ress = new List<ScintillaSearchResultLine>();
        private int searchCurrentIndex = 0;
        private string searchText = "";

        private string _SearchAllButtonToolTip = "Search all occurences";
        public string SearchAllButtonToolTip { 
            get { return _SearchAllButtonToolTip; } 
            set { 
                _SearchAllButtonToolTip = value;
                Common.RemoveToolTip(buttonAll);
                Common.SetToolTip(buttonAll, _SearchAllButtonToolTip);
            }
        }

        public ScintillaSearcher()
        {
            InitializeComponent();
            textBox1.ContextMenuStrip = new ContextMenuStrip();
            //textBox1.ShortcutsEnabled = false;
            textBox1.KeyUp += TextBox1_KeyUp;
            buttonUp.Click += ButtonUp_Click;
            buttonDown.Click += ButtonDown_Click;
            buttonAll.Click += ButtonAll_Click;
            this.GotFocus += ScintillaSearcher_GotFocus;

            Common.SetToolTip(buttonAll, _SearchAllButtonToolTip);
        }

        private void ScintillaSearcher_GotFocus(object? sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Select();
        }

        private void SearchClear() {
            positions.Clear();
            ress.Clear();
            searchCurrentIndex = 0;
            searchText = "";
            if (ScintillaSearchAllResultsPanel != null) { ScintillaSearchAllResultsPanel.Visible = false; }
        }

        private void Search(bool all = false) {
            if (Scintilla == null) { return; }
            string needle = textBox1.Text.Trim();
            if (needle.Length <= 0) { SearchClear(); return; }
            string tx = Scintilla.Text;
            SearchClear();
            searchText = needle;

            List<int> newLines = new List<int>();
            

            int index = 0;
            if (all)
            {
                do
                {
                    index = tx.IndexOf("\n", index);
                    if (index != -1) { newLines.Add(index); index++; }
                } while (index != -1);
                index = 0;
            }
            do
            {
                index = tx.IndexOf(needle, index);
                if (index != -1)
                {
                    positions.Add(index);
                    if (all)
                    {
                        int min = 0; int max = tx.Length;
                        foreach (int no in newLines)
                        {
                            if (no < index) { min = no; }
                            if (no > index) { max = no; break; }
                        }
                        ress.Add(new ScintillaSearchResultLine() { 
                            Text = tx.Substring(min, max - min), 
                            Line = newLines.IndexOf(min) + 2, 
                            Start = index, End = index + needle.Length 
                        });
                    }
                    index++;
                }
            } while (index != -1);

            if (all) {
                if (ScintillaSearchAllResultsPanel == null) { return; }
                ScintillaSearchAllResultsPanel.Results = ress;
                ScintillaSearchAllResultsPanel.Visible = true;
            }
            else
            {
                ScintillaSearchAllResultsPanel.Visible = false;
                if (positions.Count <= 0) { return; }
                try { NavigateToSearchPosition(0); }
                catch (Exception ex) { Debug.WriteLine(ex.Message + "\r\n" + ex.StackTrace); /*Program.log.Write(ex);*/ }
            }
        }

        private void TextBox1_KeyUp(object? sender, KeyEventArgs e) { Search(false);  }

        private void NavigateToSearchPosition(int pos)
        {
            if (positions.Count == 0) { return; }
            if (pos < 0) { return; }
            if (pos > positions.Count) { return; }

            try
            {
                searchCurrentIndex = pos;
                Scintilla.SelectionStart = positions[pos];
                Scintilla.SelectionEnd = positions[pos] + searchText.Length;
                Scintilla.ScrollRange(positions[pos], positions[pos] + searchText.Length);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message + "\r\n" + ex.StackTrace); /*Program.log.Write(ex);*/ }
        }


        private void ButtonUp_Click(object? sender, EventArgs e)
        {
            NavigateToSearchPosition(searchCurrentIndex - 1);
        }

        private void ButtonDown_Click(object? sender, EventArgs e)
        {
            NavigateToSearchPosition(searchCurrentIndex + 1);
        }

        private void ButtonAll_Click(object? sender, EventArgs e)
        {
            Search(true);
        }

    }
}
