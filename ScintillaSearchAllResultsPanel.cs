using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScintillaSearch
{
    public partial class ScintillaSearchAllResultsPanel : UserControl
    {
        public Scintilla? Scintilla { get; set; } = null;
        private List<ScintillaSearchResultLine>? _Results;
        public List<ScintillaSearchResultLine>? Results {
            get { return _Results; }
            set {
                _Results = value;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _Results;
            }
        }

        private string _ColumnLineText = "Line";
        public string ColumnLineText
        {
            get { return _ColumnLineText; }
            set
            {
                _ColumnLineText = value;
                ColumnLine.HeaderText = _ColumnLineText;
                ColumnLine.ToolTipText = _ColumnLineText;
            }
        }

        private string _ColumnPositionText = "Position";
        public string ColumnPositionText
        {
            get { return _ColumnPositionText; }
            set
            {
                _ColumnPositionText = value;
                ColumnPosition.HeaderText = _ColumnPositionText;
                ColumnPosition.ToolTipText = _ColumnPositionText;
            }
        }

        private string _ColumnTextText = "Text";
        public string ColumnTextText
        {
            get { return _ColumnTextText; }
            set
            {
                _ColumnTextText = value;
                ColumnText.HeaderText = _ColumnTextText;
                ColumnText.ToolTipText = _ColumnTextText;
            }
        }


        public ScintillaSearchAllResultsPanel()
        {
            InitializeComponent();
            MinimumSize = new Size(100, 100);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _Results;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (Scintilla == null) { return; }
            try
            {
                Scintilla.SelectionStart = _Results[e.RowIndex].Start;
                Scintilla.SelectionEnd = _Results[e.RowIndex].End;
                Scintilla.ScrollRange(_Results[e.RowIndex].Start, _Results[e.RowIndex].End);
            }
            catch (Exception ex) { }
        }
    }

    public class ScintillaSearchResultLine {
        public string Text { get; set; } = "";
        public int Line { get; set; } = 0;
        public int Start { get; set; } = 0;
        public int End { get; set; } = 0;
        public string Position { get { return "" + Start + ", " + End; } }
    }
}
