namespace ScintillaSearch
{
    partial class ScintillaSearcher
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            buttonAll = new Button();
            buttonDown = new Button();
            buttonUp = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonAll, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonDown, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonUp, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.MinimumSize = new Size(286, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(286, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(3, 6);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonAll
            // 
            buttonAll.BackgroundImage = Resources.magnify_icon_black_32;
            buttonAll.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAll.Location = new Point(248, 4);
            buttonAll.Margin = new Padding(3, 4, 3, 2);
            buttonAll.Name = "buttonAll";
            buttonAll.Size = new Size(31, 31);
            buttonAll.TabIndex = 1;
            buttonAll.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Image = Resources.goto_down_icon;
            buttonDown.Location = new Point(174, 4);
            buttonDown.Margin = new Padding(3, 4, 3, 2);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(31, 31);
            buttonDown.TabIndex = 1;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Image = Resources.goto_up_icon;
            buttonUp.Location = new Point(211, 4);
            buttonUp.Margin = new Padding(3, 4, 3, 2);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(31, 31);
            buttonUp.TabIndex = 1;
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // ScintillaSearcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            MinimumSize = new Size(286, 40);
            Name = "ScintillaSearcher";
            Size = new Size(286, 40);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Button buttonUp;
        private Button buttonDown;
        private Button buttonAll;
    }
}
