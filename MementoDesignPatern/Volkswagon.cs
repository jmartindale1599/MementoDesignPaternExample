using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatern{

    internal class Volkswagon{

        float value;

        string model;

        bool workingEngine;

        public Volkswagon(float val, string model, bool engine){ 
        
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

        public VolkswagonMemento saveMemento(){ return new VolkswagonMemento(value, model, workingEngine); }

        public string toString(){ 
        
            if(workingEngine == true){

                return model + " costs: " + value.ToString() + ", engine is in working order";
            
            }else return model + " costs: " + value.ToString() + ", engine is NOT in working order";


        }

        public void restoreMemento(VolkswagonMemento memento){

            this.value = memento.getVal();
            this.model = memento.getModel();
            this.workingEngine = memento.getEng();

        }

    }

}
