namespace ContactManager_ZBW.View_Cyril
{
    partial class PickPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickPerson));
            this.LstShowMatchingPersons = new System.Windows.Forms.ListBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.LblList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstShowMatchingPersons
            // 
            this.LstShowMatchingPersons.FormattingEnabled = true;
            this.LstShowMatchingPersons.ItemHeight = 16;
            this.LstShowMatchingPersons.Location = new System.Drawing.Point(29, 69);
            this.LstShowMatchingPersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstShowMatchingPersons.Name = "LstShowMatchingPersons";
            this.LstShowMatchingPersons.Size = new System.Drawing.Size(392, 420);
            this.LstShowMatchingPersons.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(63, 511);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(317, 37);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Selektierte Person übernehmen";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Location = new System.Drawing.Point(29, 30);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(137, 16);
            this.LblList.TabIndex = 2;
            this.LblList.Text = "Gefundene Personen:";
            // 
            // PickPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 575);
            this.Controls.Add(this.LblList);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.LstShowMatchingPersons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PickPerson";
            this.Text = "Suchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox LstShowMatchingPersons;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label LblList;
    }
}