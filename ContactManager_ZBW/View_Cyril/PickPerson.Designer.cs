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
            this.LstShowMatchingPersons = new System.Windows.Forms.ListBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.LblList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstShowMatchingPersons
            // 
            this.LstShowMatchingPersons.FormattingEnabled = true;
            this.LstShowMatchingPersons.ItemHeight = 20;
            this.LstShowMatchingPersons.Location = new System.Drawing.Point(33, 86);
            this.LstShowMatchingPersons.Name = "LstShowMatchingPersons";
            this.LstShowMatchingPersons.Size = new System.Drawing.Size(441, 524);
            this.LstShowMatchingPersons.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(71, 639);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(357, 46);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Selektierte Person übernehmen";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Location = new System.Drawing.Point(33, 37);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(166, 20);
            this.LblList.TabIndex = 2;
            this.LblList.Text = "Gefundene Personen:";
            // 
            // PickPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 719);
            this.Controls.Add(this.LblList);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.LstShowMatchingPersons);
            this.Name = "PickPerson";
            this.Text = "PickPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox LstShowMatchingPersons;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label LblList;
    }
}