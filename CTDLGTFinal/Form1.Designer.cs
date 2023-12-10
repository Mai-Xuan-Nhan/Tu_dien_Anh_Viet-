namespace CTDLGTFinal
{
    partial class Form1
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
            this.Search = new System.Windows.Forms.Button();
            this.Meaning = new System.Windows.Forms.Button();
            this.Syn = new System.Windows.Forms.Button();
            this.Ant = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MyDict = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(809, 159);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(110, 48);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Meaning
            // 
            this.Meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning.Location = new System.Drawing.Point(302, 249);
            this.Meaning.Name = "Meaning";
            this.Meaning.Size = new System.Drawing.Size(117, 42);
            this.Meaning.TabIndex = 1;
            this.Meaning.Text = "Meaning";
            this.Meaning.UseVisualStyleBackColor = true;
            this.Meaning.Click += new System.EventHandler(this.Meaning_Click);
            // 
            // Syn
            // 
            this.Syn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Syn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Syn.Location = new System.Drawing.Point(465, 249);
            this.Syn.Name = "Syn";
            this.Syn.Size = new System.Drawing.Size(115, 42);
            this.Syn.TabIndex = 2;
            this.Syn.Text = "Syn";
            this.Syn.UseVisualStyleBackColor = true;
            this.Syn.Click += new System.EventHandler(this.Syn_Click);
            // 
            // Ant
            // 
            this.Ant.BackColor = System.Drawing.Color.White;
            this.Ant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant.ForeColor = System.Drawing.Color.Red;
            this.Ant.Location = new System.Drawing.Point(624, 249);
            this.Ant.Name = "Ant";
            this.Ant.Size = new System.Drawing.Size(119, 42);
            this.Ant.TabIndex = 3;
            this.Ant.Text = "Ant";
            this.Ant.UseVisualStyleBackColor = false;
            this.Ant.Click += new System.EventHandler(this.Ant_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(441, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 5;
            // 
            // MyDict
            // 
            this.MyDict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyDict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDict.Location = new System.Drawing.Point(809, 323);
            this.MyDict.Name = "MyDict";
            this.MyDict.Size = new System.Drawing.Size(110, 49);
            this.MyDict.TabIndex = 6;
            this.MyDict.Text = "MyDict";
            this.MyDict.UseVisualStyleBackColor = true;
            this.MyDict.Click += new System.EventHandler(this.MyDict_Click);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(194, 336);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(302, 323);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 248);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTDLGTFinal.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 704);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.MyDict);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Ant);
            this.Controls.Add(this.Syn);
            this.Controls.Add(this.Meaning);
            this.Controls.Add(this.Search);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Từ Điển";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Meaning;
        private System.Windows.Forms.Button Syn;
        private System.Windows.Forms.Button Ant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button MyDict;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

