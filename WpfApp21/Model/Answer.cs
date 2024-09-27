using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApp21.Model;

namespace WpfApp21.Model
{
    public class Answer
    {
        public int Index { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public SolidColorBrush Color { get; set; }

        private bool isSelected;

        public Answer(int index, string text, bool isCorrect)
        {
            Index = index;
            Text = text;
            IsCorrect = isCorrect;
            Color = new SolidColorBrush(Colors.Pink);
        }

        public void SetColor(bool isCorrect)
        {
            isSelected = isCorrect;

            if (isSelected)
            {
                Color = new SolidColorBrush(Colors.Blue);
            }
            else
            {
                Color = new SolidColorBrush(Colors.Orange);
            }
        }
    }
}