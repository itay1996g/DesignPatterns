using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> mementos = new List<TextMemento>();
        private int index = 0;

        public void AddMemento(TextMemento memento)
        {
            if (index - mementos.Count < 0)
                this.mementos.RemoveRange(index + 1, this.mementos.Count - index - 1);
            else
                this.mementos.RemoveRange(index, this.mementos.Count - index);

            this.mementos.Add(memento);
            this.index++;
            
        }

        public TextMemento GetLast()
        {
            if (index >= 1)
                this.index--;
            return this.mementos[index];
        }

        public TextMemento Redo()
        {
            if(index <= mementos.Count - 2)
                this.index++;
            
            return this.mementos[index];
        }
    }
}
