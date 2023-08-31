namespace ContactManager_ZBW.View_Cyril
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LslSearchResult = new System.Windows.Forms.ListBox();
            this.TxtSearchTerm = new System.Windows.Forms.TextBox();
            this.CmbSearchField = new System.Windows.Forms.ComboBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.LblSearchTerm = new System.Windows.Forms.Label();
            this.LblSearchIn = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.CmdOk = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LslSearchResult
            // 
            this.LslSearchResult.FormattingEnabled = true;
            this.LslSearchResult.Location = new System.Drawing.Point(12, 111);
            this.LslSearchResult.Name = "LslSearchResult";
            this.LslSearchResult.ScrollAlwaysVisible = true;
            this.LslSearchResult.Size = new System.Drawing.Size(391, 134);
            this.LslSearchResult.TabIndex = 4;
            this.LslSearchResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // TxtSearchTerm
            // 
            this.TxtSearchTerm.Location = new System.Drawing.Point(12, 35);
            this.TxtSearchTerm.Name = "TxtSearchTerm";
            this.TxtSearchTerm.Size = new System.Drawing.Size(225, 20);
            this.TxtSearchTerm.TabIndex = 1;
            this.TxtSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // CmbSearchField
            // 
            this.CmbSearchField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbSearchField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbSearchField.Items.AddRange(new object[] {
            "Vorname",
            "Nachname",
            "E-Mail",
            "AHV-Nummer",
            "Titel",
            "Geburtsdatum",
            "Strasse",
            "PLZ",
            "Ort",
            "Tel. Geschäft",
            "Mobile",
            "Firmenname",
            "Abteilung",
            "Rolle"});
            this.CmbSearchField.Location = new System.Drawing.Point(286, 35);
            this.CmbSearchField.MaxDropDownItems = 10;
            this.CmbSearchField.Name = "CmbSearchField";
            this.CmbSearchField.Size = new System.Drawing.Size(117, 21);
            this.CmbSearchField.TabIndex = 2;
            this.CmbSearchField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(12, 62);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(391, 30);
            this.CmdSearch.TabIndex = 3;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            this.CmdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // LblSearchTerm
            // 
            this.LblSearchTerm.AutoSize = true;
            this.LblSearchTerm.Location = new System.Drawing.Point(9, 16);
            this.LblSearchTerm.Name = "LblSearchTerm";
            this.LblSearchTerm.Size = new System.Drawing.Size(64, 13);
            this.LblSearchTerm.TabIndex = 7;
            this.LblSearchTerm.Text = "Suchbegriff:";
            // 
            // LblSearchIn
            // 
            this.LblSearchIn.AutoSize = true;
            this.LblSearchIn.Location = new System.Drawing.Point(283, 16);
            this.LblSearchIn.Name = "LblSearchIn";
            this.LblSearchIn.Size = new System.Drawing.Size(58, 13);
            this.LblSearchIn.TabIndex = 8;
            this.LblSearchIn.Text = "Suchen in:";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(9, 95);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(75, 13);
            this.LblResult.TabIndex = 9;
            this.LblResult.Text = "Suchergebnis:";
            // 
            // CmdOk
            // 
            this.CmdOk.Location = new System.Drawing.Point(263, 251);
            this.CmdOk.Name = "CmdOk";
            this.CmdOk.Size = new System.Drawing.Size(67, 30);
            this.CmdOk.TabIndex = 5;
            this.CmdOk.Text = "OK";
            this.CmdOk.UseVisualStyleBackColor = true;
            this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
            this.CmdOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(336, 251);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(67, 30);
            this.CmdCancel.TabIndex = 6;
            this.CmdCancel.Text = "Abbrechen";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            this.CmdCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 292);
            this.ControlBox = false;
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdOk);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblSearchIn);
            this.Controls.Add(this.LblSearchTerm);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.CmbSearchField);
            this.Controls.Add(this.TxtSearchTerm);
            this.Controls.Add(this.LslSearchResult);
            this.Name = "Search";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Suche";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LslSearchResult;
        private System.Windows.Forms.TextBox TxtSearchTerm;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.Label LblSearchTerm;
        private System.Windows.Forms.Label LblSearchIn;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button CmdOk;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.ComboBox CmbSearchField;
    }
}