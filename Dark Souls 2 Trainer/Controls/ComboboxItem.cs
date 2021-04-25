using System;
using System.Collections.Generic;
using System.Text;

namespace Dark_Souls_2_Trainer.Controls
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboboxItem() : this("",0) { } 

        public ComboboxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
