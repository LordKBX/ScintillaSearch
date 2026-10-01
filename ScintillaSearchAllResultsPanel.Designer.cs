namespace ScintillaSearch
{
    partial class ScintillaSearchAllResultsPanel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ColumnLine = new DataGridViewTextBoxColumn();
            ColumnPosition = new DataGridViewTextBoxColumn();
            ColumnText = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnLine, ColumnPosition, ColumnText });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(539, 200);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnLine
            // 
            ColumnLine.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnLine.DataPropertyName = "Line";
            ColumnLine.HeaderText = "Line";
            ColumnLine.MinimumWidth = 100;
            ColumnLine.Name = "ColumnLine";
            ColumnLine.ReadOnly = true;
            ColumnLine.Width = 125;
            // 
            // ColumnPosition
            // 
            ColumnPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnPosition.DataPropertyName = "Position";
            ColumnPosition.HeaderText = "Position";
            ColumnPosition.MinimumWidth = 100;
            ColumnPosition.Name = "ColumnPosition";
            ColumnPosition.ReadOnly = true;
            ColumnPosition.Width = 125;
            // 
            // ColumnText
            // 
            ColumnText.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnText.DataPropertyName = "Text";
            ColumnText.HeaderText = "Text";
            ColumnText.MinimumWidth = 100;
            ColumnText.Name = "ColumnText";
            ColumnText.ReadOnly = true;
            // 
            // ScintillaSearchAllResultsPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ScintillaSearchAllResultsPanel";
            Size = new Size(539, 200);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnLine;
        private DataGridViewTextBoxColumn ColumnPosition;
        private DataGridViewTextBoxColumn ColumnText;
    }
}
