using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatern{

    public class VolkswagonMemento{

        float value;

        string model;

        bool workingEngine;

        public VolkswagonMemento(float val, string model, bool engine){ 
        
            this.value = val;
            this.model = model;
            this.workingEngine = engine;
        
        }

        public float getVal() { return value; }

        public string getModel() { return model; }

        public bool getEng() { return workingEngine; }
        
        public void setVal(float val) { this.value = val; }

        public void setModel(string model) { this.model = model; }

        public void setEng(bool engine) { this.workingEngine = engine; }

    }

}
