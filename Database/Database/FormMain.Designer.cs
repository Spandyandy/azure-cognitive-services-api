namespace Database
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.LabelPerson = new System.Windows.Forms.Label();
            this.lstPerson = new System.Windows.Forms.ListBox();
            this.lstDiet = new System.Windows.Forms.ListBox();
            this.lblDiet = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.updatePerson = new System.Windows.Forms.Button();
            this.frequency = new System.Windows.Forms.RichTextBox();
            this.frequencylabel = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.MostRecentVisitText = new System.Windows.Forms.RichTextBox();
            this.MostRecentVisitLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPerson
            // 
            this.LabelPerson.AutoSize = true;
            this.LabelPerson.Location = new System.Drawing.Point(499, 14);
            this.LabelPerson.Name = "LabelPerson";
            this.LabelPerson.Size = new System.Drawing.Size(54, 15);
            this.LabelPerson.TabIndex = 0;
            this.LabelPerson.Text = "Person";
            // 
            // lstPerson
            // 
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.ItemHeight = 15;
            this.lstPerson.Location = new System.Drawing.Point(502, 32);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(116, 499);
            this.lstPerson.TabIndex = 1;
            this.lstPerson.SelectedIndexChanged += new System.EventHandler(this.lstPerson_SelectedIndexChanged);
            // 
            // lstDiet
            // 
            this.lstDiet.FormattingEnabled = true;
            this.lstDiet.ItemHeight = 15;
            this.lstDiet.Location = new System.Drawing.Point(624, 362);
            this.lstDiet.Name = "lstDiet";
            this.lstDiet.Size = new System.Drawing.Size(256, 169);
            this.lstDiet.TabIndex = 3;
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(621, 344);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(52, 15);
            this.lblDiet.TabIndex = 2;
            this.lblDiet.Text = "Dietary";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(218, 330);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 27);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(25, 332);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(187, 25);
            this.textPersonName.TabIndex = 5;
            // 
            // updatePerson
            // 
            this.updatePerson.Location = new System.Drawing.Point(218, 364);
            this.updatePerson.Name = "updatePerson";
            this.updatePerson.Size = new System.Drawing.Size(75, 27);
            this.updatePerson.TabIndex = 6;
            this.updatePerson.Text = "Update";
            this.updatePerson.UseVisualStyleBackColor = true;
            this.updatePerson.Click += new System.EventHandler(this.updatePerson_Click);
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(624, 202);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(255, 34);
            this.frequency.TabIndex = 8;
            this.frequency.Text = "";
            // 
            // frequencylabel
            // 
            this.frequencylabel.AutoSize = true;
            this.frequencylabel.Location = new System.Drawing.Point(625, 181);
            this.frequencylabel.Name = "frequencylabel";
            this.frequencylabel.Size = new System.Drawing.Size(154, 15);
            this.frequencylabel.TabIndex = 9;
            this.frequencylabel.Text = "How many time visited";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(25, 32);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(187, 25);
            this.textSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(219, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MostRecentVisitText
            // 
            this.MostRecentVisitText.Location = new System.Drawing.Point(624, 133);
            this.MostRecentVisitText.Name = "MostRecentVisitText";
            this.MostRecentVisitText.Size = new System.Drawing.Size(256, 36);
            this.MostRecentVisitText.TabIndex = 12;
            this.MostRecentVisitText.Text = "";
            // 
            // MostRecentVisitLabel
            // 
            this.MostRecentVisitLabel.AutoSize = true;
            this.MostRecentVisitLabel.Location = new System.Drawing.Point(624, 112);
            this.MostRecentVisitLabel.Name = "MostRecentVisitLabel";
            this.MostRecentVisitLabel.Size = new System.Drawing.Size(122, 15);
            this.MostRecentVisitLabel.TabIndex = 13;
            this.MostRecentVisitLabel.Text = "Most Recent Visit";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(25, 133);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(65, 15);
            this.clock.TabIndex = 14;
            this.clock.Text = "00:00:00";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(624, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 40);
            this.nameTextBox.TabIndex = 15;
            this.nameTextBox.Text = "";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(624, 48);
            this.namelbl.Name = "namelbl";
            this.namelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.namelbl.Size = new System.Drawing.Size(43, 15);
            this.namelbl.TabIndex = 16;
            this.namelbl.Text = "Name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 563);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.MostRecentVisitLabel);
            this.Controls.Add(this.MostRecentVisitText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.frequencylabel);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.updatePerson);
            this.Controls.Add(this.textPersonName);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lstDiet);
            this.Controls.Add(this.lblDiet);
            this.Controls.Add(this.lstPerson);
            this.Controls.Add(this.LabelPerson);
            this.Name = "FormMain";
            this.Text = "Person Data";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPerson;
        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.ListBox lstDiet;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.Button updatePerson;
        private System.Windows.Forms.RichTextBox frequency;
        private System.Windows.Forms.Label frequencylabel;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox MostRecentVisitText;
        private System.Windows.Forms.Label MostRecentVisitLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.Label namelbl;
    }
}

