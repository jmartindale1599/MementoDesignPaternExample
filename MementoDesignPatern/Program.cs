namespace MementoDesignPatern{

    internal class Program{

        static void Main(string[] args){

            Console.WriteLine("Bought new caahr \n");

            Volkswagon caahr = new Volkswagon(28000, "Slug-bug", true);

            Console.WriteLine(caahr.toString() + "\n");

            Caretaker caretaker = new Caretaker();

            caretaker.setMemento(caahr.saveMemento());

            Console.WriteLine("Uh oh your car met the front end of a drainage pipe \n");

            caahr.setVal(200.57f);

            caahr.setModel("Totaled " + caahr.getModel());

            caahr.setEng(false);

            Console.WriteLine(caahr.toString() + "\n");

            Console.WriteLine("*Quee lego guy hey sound* \n");

            caahr.restoreMemento(caretaker.getMememto());

            Console.WriteLine(caahr.toString() + "\n");

        }

    }

}

