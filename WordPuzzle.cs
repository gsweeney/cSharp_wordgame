using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace WordGame
{
    public partial class WordPuzzle : Form
    {
        // class variables
        Random random = new Random();
        private char[] user_word = {' ', ' ', ' ', ' ', ' '};// not really needed
        private int puzzle_num_letters = 5;
        List<TextBox> letters = new List<TextBox>();
        List<string> workingList, workingList_undo;
        List<TextBox> textboxes = new List<TextBox>();
        string FILE = "Words5.txt";// not really needed
        int last_move;
        bool game_over;

        // constuctor
        public WordPuzzle()
        {
            InitializeComponent();

            game_over = false;

            // Add all TextBox controls to a List for easy access
            textboxes.Add(textBox_0);
            textboxes.Add(textBox_1);
            textboxes.Add(textBox_2);
            textboxes.Add(textBox_3);
            textboxes.Add(textBox_4);

            // add words to listbox
            workingList = populate_listbox();
            workingList_undo = workingList;
        }

        #region Functions
        // ???
        private List<string> populate_listbox()
        {
            listBox_wordlist.Items.Clear();

            List<string> words = new List<string>();
            string word;
            
            using (StreamReader file = new StreamReader(FILE))
            {
                while (!file.EndOfStream)// read to the end of file
                {
                    word = file.ReadLine();// get the next list word
                    words.Add(word);
                }// close while
            }// close using
            listBox_wordlist.Items.AddRange(words.ToArray());
            return words;
        }

        // store letters chosen by user in char[] user_word
        private void set_user_word(char ch, int i)
        {
            user_word[i] = ch;
        }


        // find only the words that have the letter at the specified index
        private List<string> filterWords(int index, char letter)
        {
            List<string> filter = new List<string>();

            foreach(string word in workingList)
            {
                if (word[index] == letter)
                {
                    filter.Add(word);
                }
            }
            return filter;
        }

        // check letter in textbox against workingList of words
        private void check_letter(TextBox t)
        {
            // get index of letter in word
            int index = int.Parse(t.Tag.ToString());

            // Filter words based on the given letter at the specified index
            List<string> filtered = filterWords(index, t.Text[0]);
            if (filtered.Count > 0)// at least one match exists
            {
                // update the game's working List's
                workingList_undo = workingList;
                workingList = filtered;
                t.BackColor = Color.LightGreen;

                // update the listbox
                listBox_wordlist.Items.Clear();
                listBox_wordlist.Items.AddRange(workingList.ToArray());

                // update user_word with the new letter from TextBox
                set_user_word(t.Text[0], index);
                last_move = index;
            }
            else
            {
                t.BackColor = Color.Red;
                t.Enabled = true;
            }

            // there is only 1 match, then game over
            if (workingList.Count == 1)
            {

                string match = workingList[0];

                // fill in the puzzle
                foreach (TextBox b in textboxes)
                {
                    if (b.Enabled)
                    {
                        b.Text = match.Substring(int.Parse(b.Tag.ToString()), 1);
                        user_word[int.Parse(b.Tag.ToString())] = b.Text[0];
                        b.Enabled = false;
                        b.BackColor = Color.LightGreen;
                    }
                }
                game_over = true;
                MessageBox.Show("Match!");
            }
        }// close method

        #endregion



        #region Events
        // resets the word puzzle
        private void button_RESET_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button_GO.Text = "GO!";
            game_over = false;

            // add words to listbox
            workingList.Clear();
            workingList_undo.Clear();
            workingList = populate_listbox();
            workingList_undo = workingList;
            foreach (TextBox t in textboxes)
            {
                t.Enabled = false;
                t.Text = " ";
                t.BackColor = SystemColors.Control;
            }

            // reset characters in user_word[]
            for (int i = 0; i < puzzle_num_letters; i++)
            {
                user_word[i] = ' ';
            }
        }// close method


        // starts the generation of random letters
        private void button_GO_Click(object sender, EventArgs e)
        {
            if (button_GO.Text == "GO!")
            {
                // start a timer
                timer.Start();

                // change the text to STOP
                button_GO.Text = "STOP";

                timer.Interval = 2000;// 5000 is 5 sec

                foreach (TextBox t in textboxes)
                {
                    t.Enabled = true;
                }
            }
            else// button_GO.Text is "STOP"
            {
                // stop timer
                timer.Stop();
                button_GO.Text = "GO!";
            }
        }// close method


        // every tick of the timer (5 seconds), do something
        private void timer_Tick(object sender, EventArgs e)
        {
            // put random characters in all active textBox
            foreach (TextBox t in textboxes)
            {
                if (t.Enabled) { t.Text = ((char)(random.Next(65, 90))).ToString(); }
                if (t.BackColor == Color.Red) { t.BackColor = SystemColors.Control; }
            }

        }// close method


        // respond to textbox in puzzle being clicked 
        private void letter_Click(object sender, EventArgs e)
        {
            TextBox letter = (TextBox)sender;
            letter.Enabled = false;
            check_letter(letter);
        }


        // undo the last move
        private void button_undo_Click(object sender, EventArgs e)
        {
            if (!game_over)
            {
                // find last move
                foreach (TextBox t in textboxes)
                {
                    if (int.Parse(t.Tag.ToString()) == last_move)
                    {
                        t.Enabled = true;
                        t.BackColor = SystemColors.Control;
                    }
                }

                workingList = workingList_undo;
                listBox_wordlist.Items.Clear();
                listBox_wordlist.Items.AddRange(workingList_undo.ToArray());
            }        
        }// close method
        #endregion
       
    }// close class
}// close namespace
