using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatern{

    public class Caretaker{

        VolkswagonMemento memento;

        public VolkswagonMemento getMememto() { return memento; }

        public void setMemento(VolkswagonMemento vm) { this.memento = vm; }

    }

}
