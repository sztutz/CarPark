namespace VehicleRegistrationStation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ListBoxRegoList = new System.Windows.Forms.ListBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEnterRego = new System.Windows.Forms.Button();
            this.ButtonEditRego = new System.Windows.Forms.Button();
            this.ButtonDeleteRego = new System.Windows.Forms.Button();
            this.ButtonLinearSearch = new System.Windows.Forms.Button();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.ButtonTag = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.Fuchsia;
            this.StatusStrip.Location = new System.Drawing.Point(0, 305);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(342, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ListBoxRegoList
            // 
            this.ListBoxRegoList.BackColor = System.Drawing.Color.Fuchsia;
            this.ListBoxRegoList.FormattingEnabled = true;
            this.ListBoxRegoList.ItemHeight = 15;
            this.ListBoxRegoList.Location = new System.Drawing.Point(12, 12);
            this.ListBoxRegoList.Name = "ListBoxRegoList";
            this.ListBoxRegoList.Size = new System.Drawing.Size(97, 274);
            this.ListBoxRegoList.TabIndex = 1;
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBoxInput.Location = new System.Drawing.Point(166, 12);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(100, 23);
            this.TextBoxInput.TabIndex = 2;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.BackColor = System.Drawing.Color.Cyan;
            this.ButtonOpen.Location = new System.Drawing.Point(179, 41);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 3;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = false;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.Cyan;
            this.ButtonSave.Location = new System.Drawing.Point(179, 70);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonEnterRego
            // 
            this.ButtonEnterRego.BackColor = System.Drawing.Color.Cyan;
            this.ButtonEnterRego.Location = new System.Drawing.Point(179, 99);
            this.ButtonEnterRego.Name = "ButtonEnterRego";
            this.ButtonEnterRego.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnterRego.TabIndex = 5;
            this.ButtonEnterRego.Text = "Enter";
            this.ButtonEnterRego.UseVisualStyleBackColor = false;
            this.ButtonEnterRego.Click += new System.EventHandler(this.ButtonEnterRego_Click);
            // 
            // ButtonEditRego
            // 
            this.ButtonEditRego.BackColor = System.Drawing.Color.Cyan;
            this.ButtonEditRego.Location = new System.Drawing.Point(179, 128);
            this.ButtonEditRego.Name = "ButtonEditRego";
            this.ButtonEditRego.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditRego.TabIndex = 6;
            this.ButtonEditRego.Text = "Edit";
            this.ButtonEditRego.UseVisualStyleBackColor = false;
            this.ButtonEditRego.Click += new System.EventHandler(this.ButtonEditRego_Click);
            // 
            // ButtonDeleteRego
            // 
            this.ButtonDeleteRego.BackColor = System.Drawing.Color.Cyan;
            this.ButtonDeleteRego.Location = new System.Drawing.Point(179, 157);
            this.ButtonDeleteRego.Name = "ButtonDeleteRego";
            this.ButtonDeleteRego.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteRego.TabIndex = 7;
            this.ButtonDeleteRego.Text = "Delete";
            this.ButtonDeleteRego.UseVisualStyleBackColor = false;
            this.ButtonDeleteRego.Click += new System.EventHandler(this.ButtonDeleteRego_Click);
            // 
            // ButtonLinearSearch
            // 
            this.ButtonLinearSearch.BackColor = System.Drawing.Color.Cyan;
            this.ButtonLinearSearch.Location = new System.Drawing.Point(179, 186);
            this.ButtonLinearSearch.Name = "ButtonLinearSearch";
            this.ButtonLinearSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonLinearSearch.TabIndex = 8;
            this.ButtonLinearSearch.Text = "Linear";
            this.ButtonLinearSearch.UseVisualStyleBackColor = false;
            this.ButtonLinearSearch.Click += new System.EventHandler(this.ButtonLinearSearch_Click);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.BackColor = System.Drawing.Color.Cyan;
            this.ButtonBinarySearch.Location = new System.Drawing.Point(179, 215);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonBinarySearch.TabIndex = 9;
            this.ButtonBinarySearch.Text = "Binary";
            this.ButtonBinarySearch.UseVisualStyleBackColor = false;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // ButtonTag
            // 
            this.ButtonTag.BackColor = System.Drawing.Color.Cyan;
            this.ButtonTag.Location = new System.Drawing.Point(179, 244);
            this.ButtonTag.Name = "ButtonTag";
            this.ButtonTag.Size = new System.Drawing.Size(75, 23);
            this.ButtonTag.TabIndex = 10;
            this.ButtonTag.Text = "Tag";
            this.ButtonTag.UseVisualStyleBackColor = false;
            this.ButtonTag.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.Cyan;
            this.ButtonReset.Location = new System.Drawing.Point(179, 273);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 11;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 327);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonTag);
            this.Controls.Add(this.ButtonBinarySearch);
            this.Controls.Add(this.ButtonLinearSearch);
            this.Controls.Add(this.ButtonDeleteRego);
            this.Controls.Add(this.ButtonEditRego);
            this.Controls.Add(this.ButtonEnterRego);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ListBoxRegoList);
            this.Controls.Add(this.StatusStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip StatusStrip;
        private ListBox ListBoxRegoList;
        private TextBox TextBoxInput;
        private Button ButtonOpen;
        private Button ButtonSave;
        private Button ButtonEnterRego;
        private Button ButtonEditRego;
        private Button ButtonDeleteRego;
        private Button ButtonLinearSearch;
        private Button ButtonBinarySearch;
        private Button ButtonTag;
        private Button ButtonReset;
    }
}