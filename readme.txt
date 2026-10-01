ScintillaSearch

A module for adding Search module on a Scintilla TextZone in WinForms

How to use:

using ScintillaSearch;

// this is a WinForm Control do not forget to include it in the GUI
ScintillaSearcher searcher = new ScintillaSearcher(); 
searcher.Scintilla = scintilla1; // your Scintilla control


if you whant to add the zone for search all results you can do it like this:

// this is a WinForm Control do not forget to include it in the GUI
ScintillaSearchAllResultsPanel searchAllResultsPanel = new ScintillaSearchAllResultsPanel();
searcher.ScintillaSearchAllResultsPanel = ScintillaSearchAllResultsPanel; // associate the searcher with the results panel
searchAllResultsPanel.Scintilla = scintilla1; // your Scintilla control


if you whant to personalize texts use:
searcher.SearchAllButtonToolTip = "texte"; // automaticaly replace text when changed
searchAllResultsPanel.ColumnLineText = "txt1"
searchAllResultsPanel.ColumnPositionText = "txt2"
searchAllResultsPanel.ColumnTextText = "txt3"
