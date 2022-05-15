using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonEvent
{
    class Button
    {
        public delegate void ButtonHandler();
        public event ButtonHandler onClicked;
        public string Label { get; set; }

        public Button(string label)
        {
            this.Label = label;
        }

        public void click()
        {
            if (onClicked!=null)
            {
                onClicked();
            }
        }
    }
}
