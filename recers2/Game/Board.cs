using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recers2.Game
{
    public class Board
    {
        private Random random = new Random();

        public Label LabelCharacter { get; set; }
        public Button ButtonStart { get; set; }
        public Button ButtonStop { get; set; }
        public TextBox TextBoxPutChar { get; set; }
        public Label LabelScore { get; set; }
        public int Points { get; set; } = 0;
        public bool Result { get; set; }

        public Board(Label labelCharacter, Button buttonStart, Button buttonStop, TextBox textBoxPutChar, Label labelScore)
        {
            LabelCharacter = labelCharacter;
            ButtonStart = buttonStart;
            ButtonStop = buttonStop;
            TextBoxPutChar = textBoxPutChar;
            LabelScore = labelScore;
        }

        public string GetCharacter()
        {
            char character = (char)random.Next(97, 122);
            LabelCharacter.Text = character.ToString();
            return LabelCharacter.Text.ToString();
        }

        public bool AreTheSame()
        {
            while (true)
            {
                if (LabelCharacter.Text == TextBoxPutChar.Text)
                {
                    TextBoxPutChar.Text = null;
                    return true;

                }
                else
                    return false;
            }

        }

        public void AddScore()
        {
            Points += 100;

            LabelScore.Text = Points.ToString();
        }

        public void ResetPoints()
        {
            Points = 0;
            LabelScore.Text = 0.ToString();
        }
    }
}
