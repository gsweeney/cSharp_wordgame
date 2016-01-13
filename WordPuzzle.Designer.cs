namespace WordGame
{
    partial class WordPuzzle
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
            this.textBox_numLetters = new System.Windows.Forms.TextBox();
            this.label_numLetters = new System.Windows.Forms.Label();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.textBox_4 = new System.Windows.Forms.TextBox();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.button_RESET = new System.Windows.Forms.Button();
            this.button_GO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listBox_wordlist = new System.Windows.Forms.ListBox();
            this.panel_letters = new System.Windows.Forms.Panel();
            this.button_undo = new System.Windows.Forms.Button();
            this.panel_letters.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_numLetters
            // 
            this.textBox_numLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_numLetters.Enabled = false;
            this.textBox_numLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numLetters.Location = new System.Drawing.Point(137, 16);
            this.textBox_numLetters.MaxLength = 1;
            this.textBox_numLetters.Name = "textBox_numLetters";
            this.textBox_numLetters.ReadOnly = true;
            this.textBox_numLetters.Size = new System.Drawing.Size(35, 35);
            this.textBox_numLetters.TabIndex = 2;
            this.textBox_numLetters.Text = "5";
            this.textBox_numLetters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_numLetters
            // 
            this.label_numLetters.AutoSize = true;
            this.label_numLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numLetters.Location = new System.Drawing.Point(24, 19);
            this.label_numLetters.Name = "label_numLetters";
            this.label_numLetters.Size = new System.Drawing.Size(112, 13);
            this.label_numLetters.TabIndex = 0;
            this.label_numLetters.Text = "Number of Letters:";
            // 
            // textBox_2
            // 
            this.textBox_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_2.Enabled = false;
            this.textBox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_2.Location = new System.Drawing.Point(128, 27);
            this.textBox_2.MaxLength = 1;
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new System.Drawing.Size(47, 47);
            this.textBox_2.TabIndex = 5;
            this.textBox_2.Tag = "2";
            this.textBox_2.Text = " ";
            this.textBox_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_2.Click += new System.EventHandler(this.letter_Click);
            // 
            // textBox_1
            // 
            this.textBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_1.Enabled = false;
            this.textBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_1.Location = new System.Drawing.Point(75, 27);
            this.textBox_1.MaxLength = 1;
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new System.Drawing.Size(47, 47);
            this.textBox_1.TabIndex = 4;
            this.textBox_1.Tag = "1";
            this.textBox_1.Text = " ";
            this.textBox_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_1.Click += new System.EventHandler(this.letter_Click);
            // 
            // textBox_0
            // 
            this.textBox_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_0.Enabled = false;
            this.textBox_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_0.Location = new System.Drawing.Point(22, 27);
            this.textBox_0.MaxLength = 1;
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.ReadOnly = true;
            this.textBox_0.Size = new System.Drawing.Size(47, 47);
            this.textBox_0.TabIndex = 3;
            this.textBox_0.Tag = "0";
            this.textBox_0.Text = " ";
            this.textBox_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_0.Click += new System.EventHandler(this.letter_Click);
            // 
            // textBox_4
            // 
            this.textBox_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_4.Enabled = false;
            this.textBox_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_4.Location = new System.Drawing.Point(233, 27);
            this.textBox_4.MaxLength = 1;
            this.textBox_4.Name = "textBox_4";
            this.textBox_4.ReadOnly = true;
            this.textBox_4.Size = new System.Drawing.Size(47, 47);
            this.textBox_4.TabIndex = 7;
            this.textBox_4.Tag = "4";
            this.textBox_4.Text = " ";
            this.textBox_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_4.Click += new System.EventHandler(this.letter_Click);
            // 
            // textBox_3
            // 
            this.textBox_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_3.Enabled = false;
            this.textBox_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_3.Location = new System.Drawing.Point(180, 27);
            this.textBox_3.MaxLength = 1;
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.ReadOnly = true;
            this.textBox_3.Size = new System.Drawing.Size(47, 47);
            this.textBox_3.TabIndex = 6;
            this.textBox_3.Tag = "3";
            this.textBox_3.Text = " ";
            this.textBox_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_3.Click += new System.EventHandler(this.letter_Click);
            // 
            // button_RESET
            // 
            this.button_RESET.Location = new System.Drawing.Point(290, 256);
            this.button_RESET.Name = "button_RESET";
            this.button_RESET.Size = new System.Drawing.Size(75, 23);
            this.button_RESET.TabIndex = 12;
            this.button_RESET.Text = "RESET";
            this.button_RESET.UseVisualStyleBackColor = true;
            this.button_RESET.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // button_GO
            // 
            this.button_GO.Location = new System.Drawing.Point(290, 227);
            this.button_GO.Name = "button_GO";
            this.button_GO.Size = new System.Drawing.Size(75, 23);
            this.button_GO.TabIndex = 11;
            this.button_GO.Text = "GO!";
            this.button_GO.UseVisualStyleBackColor = true;
            this.button_GO.Click += new System.EventHandler(this.button_GO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Word List:";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listBox_wordlist
            // 
            this.listBox_wordlist.FormattingEnabled = true;
            this.listBox_wordlist.Location = new System.Drawing.Point(413, 35);
            this.listBox_wordlist.Name = "listBox_wordlist";
            this.listBox_wordlist.Size = new System.Drawing.Size(182, 381);
            this.listBox_wordlist.TabIndex = 17;
            // 
            // panel_letters
            // 
            this.panel_letters.Controls.Add(this.textBox_3);
            this.panel_letters.Controls.Add(this.textBox_0);
            this.panel_letters.Controls.Add(this.textBox_1);
            this.panel_letters.Controls.Add(this.textBox_2);
            this.panel_letters.Controls.Add(this.textBox_4);
            this.panel_letters.Location = new System.Drawing.Point(27, 126);
            this.panel_letters.Name = "panel_letters";
            this.panel_letters.Size = new System.Drawing.Size(316, 95);
            this.panel_letters.TabIndex = 20;
            // 
            // button_undo
            // 
            this.button_undo.Location = new System.Drawing.Point(290, 285);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(75, 23);
            this.button_undo.TabIndex = 21;
            this.button_undo.Text = "UNDO";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // WordPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 478);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.panel_letters);
            this.Controls.Add(this.listBox_wordlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_GO);
            this.Controls.Add(this.button_RESET);
            this.Controls.Add(this.label_numLetters);
            this.Controls.Add(this.textBox_numLetters);
            this.Name = "WordPuzzle";
            this.Text = "Word Puzzle";
            this.panel_letters.ResumeLayout(false);
            this.panel_letters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_numLetters;
        private System.Windows.Forms.Label label_numLetters;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox_0;
        private System.Windows.Forms.TextBox textBox_4;
        private System.Windows.Forms.TextBox textBox_3;
        private System.Windows.Forms.Button button_RESET;
        private System.Windows.Forms.Button button_GO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox listBox_wordlist;
        private System.Windows.Forms.Panel panel_letters;
        private System.Windows.Forms.Button button_undo;
    }
}

