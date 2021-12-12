using DesignPatterns.Models;
using DesignPatterns.Models.BRIDGE;
using DesignPatterns.Models.ChainOfResponsibilty;
using DesignPatterns.Models.Command;
using DesignPatterns.Models.COMPOSITE;
using DesignPatterns.Models.DECORATOR;
using DesignPatterns.Models.Iterator;
using DesignPatterns.Models.MEDIATOR;
using DesignPatterns.Models.MEMENTO;
using DesignPatterns.Models.OBSERVER;
using DesignPatterns.Models.PROTOTYPE;
using DesignPatterns.Models.STATE;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //STATE DESIGN PATTERN

            AtmMachine atmMachine = new AtmMachine();

            atmMachine.insertCard();
            atmMachine.EjectCard();
            atmMachine.insertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(2000);
            atmMachine.insertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(5);
            atmMachine.insertCard();
            Console.ReadLine();

            //STATE DESIGN PATTERN
            //OBSERVER DESIGN PATTERN

            WheaterSubject wheater = new WheaterSubject();
            WeatherObserver observer1 = new WeatherObserver(wheater);
            WeatherObserver observer2 = new WeatherObserver(wheater);
            WeatherObserver observer3 = new WeatherObserver(wheater);
            wheater.Unregister(observer2);
            wheater.Unregister(observer2);
            wheater.SetCelsius(12);
            wheater.SetFahrenheit(70);
       

            Console.ReadLine();

            //OBSERVER DESIGN PATTERN

            // MEMENTO DESIGN PATTERN
            CareTaker careTaker = new CareTaker();
            Originator originator = new Originator();
            originator.Artical = "hello";
            careTaker.AddMemento(originator.SaveArticalInMemento());
            originator.Artical += " ely";
            careTaker.AddMemento(originator.SaveArticalInMemento());
            originator.Artical += " the one";
            careTaker.AddMemento(originator.SaveArticalInMemento());
            foreach(Memento m in careTaker.savedMementos)
            {
                Console.WriteLine(m.GetMemento());
            }

            originator.Artical = careTaker.GetMemento(1).GetMemento();
            Console.WriteLine(originator.Artical);

            Console.ReadLine();
            // MEMENTO DESIGN PATTERN

            // DECORATOR DESIGN PATTERN

            Pizza pizza = new PlainPizza();
            ExtraCheeseTopping cheeseTopping = new ExtraCheeseTopping(pizza);
            OlivesTopping oliveTopping = new OlivesTopping(cheeseTopping);
            OnionTopping onionTopping = new OnionTopping(oliveTopping);
           
            Console.WriteLine(onionTopping.GetDescription());
            Console.WriteLine(onionTopping.GetCost());

            Console.ReadLine();

            // DECORATOR DESIGN PATTERN

            // COMPOSITE DESIGN PATTERN

            Branch mainTree = new Branch("mainTree");
            Leaf leaf1 = new Leaf("leaf1");
            Leaf leaf2 = new Leaf("leaf2");
            Leaf leaf3 = new Leaf("leaf3");
            Branch secTree = new Branch("secTree");
            Leaf leaf4 = new Leaf("leaf4");
            Leaf leaf5 = new Leaf("leaf5");
            mainTree.Add(leaf1);
            mainTree.Add(leaf2);
            mainTree.Add(leaf3);
            mainTree.Add(secTree);
            secTree.Add(leaf4);
            secTree.Add(leaf5);
            mainTree.DisplayLeaf();

            Console.ReadLine();

            // COMPOSITE DESIGN PATTERN

            // PROTOTYPE DESIGN PATTERN
            Beast doly = new Sheep("doly");
            Beast wolfy = new Wolf("wolfy");
            List<Sheep> copySheeps = new List<Sheep>();
            List<Wolf> copyWolfs = new List<Wolf>();
            for (int i = 0; i < 2; i++)
            {
                copySheeps.Add((Sheep)AnimalCloneFactory.CloneAnimal(doly));
            }
            for (int i = 0; i < 2; i++)
            {
                copyWolfs.Add((Wolf)AnimalCloneFactory.CloneAnimal(wolfy));
            }
            foreach(Sheep s in copySheeps)
            {
                Console.WriteLine(s.Name);
            }
            foreach (Wolf w in copyWolfs)
            {
                Console.WriteLine(w.Name);
            }
            Console.ReadLine();
            // PROTOTYPE DESIGN PATTERN

            // MEDIATOR DESIGN PATTERN
            StockMediator nyse = new StockMediator();

            FBB broker = new FBB(nyse);
            ILS broker2 = new ILS(nyse);

            broker.SaleOffer("MSFT", 100);
            broker.SaleOffer("GOOG", 50);
            broker2.BuyOffer("GOOG", 50);
            broker2.SaleOffer("NRG", 10);
            broker.BuyOffer("NRG", 10);

            nyse.GetStockOffers();

            Console.ReadLine();
            // MEDIATOR DESIGN PATTERN

            //ORDERED LIST
            MyNewList<int> intList = new MyNewList<int>();
            MyNewList<string> stringList = new MyNewList<string>();
            intList.AddItem(12);
            intList.AddItem(22);
            intList.AddItem(14);
            intList.AddItem(41);
            intList.AddItem(8);
            intList.AddItem(35);
            intList.AddItem(1);
            intList.AddItem(8);
            intList.AddItem(-5);
            intList.AddItem(-8);    
            intList.Remove(-5);
            stringList.AddItem("hello");
            stringList.AddItem("great");
            stringList.Remove("great");
            stringList.Remove("YES");

            intList.LogList();

            foreach (string s in stringList.MyListToArray())
            {
                Console.WriteLine(s);
            }
           // intList.ClearList();
            foreach (int x in intList.MyListToArray())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($" numbers in the list: {intList.listCount}");
            Console.WriteLine(intList.MyListToArray().Length);
            Console.ReadLine();
            //ORDERED LIST


            // ITERATOR DESIGN PATTERN
            Item sword = new Item("sword", "slice");
            Item shield = new Item("shield", "protect");
            Item apple = new Item("apple", "restoreLife");
            Item book = new Item("book", "fireBolt");
            Inventory hendInventory = new HandHeldInventroy(sword, shield);
            HandleBagInventory begInventory = new HandleBagInventory();
            InventoryItrator begIterator = begInventory.GetIterator();
            begInventory.AddItem(shield);
            begInventory.AddItem(sword);
            begInventory.AddItem(apple);
            begInventory.AddItem(book);
            while (!begIterator.IsDone())
            {
                Console.WriteLine(begIterator.Current());
                begIterator.Next();
            }
            InventoryItrator hendIterator = hendInventory.GetIterator();
            while (!hendIterator.IsDone())
            {
                Item item = hendIterator.Current();
                Console.WriteLine(item);
                hendIterator.Next();
            }

            Console.ReadLine();
            // ITERATOR DESIGN PATTERN


            // COMMAND DESIGN PATTERN
            Device screen = new Screen();
            Device phone = new Phone();
            Command onCommand = new TurnOn(screen);
            Button button = new Button(onCommand);
            button.Press();
            button.UndoPress();
            Command offCommand = new TurnOff(screen);
            button = new Button(offCommand);
            button.Press();
            Command moreBright = new BrightUp(phone);
            button = new Button(moreBright);
            button.Press();
            button.Press();
            button.UndoPress();
            Command lessBright = new BrightDown(phone);
            button = new Button(lessBright);
            button.Press();

            Console.ReadLine();
            // COMMAND DESIGN PATTERN

            // FACTORY DESIGN PATTERN
            AnimalFactory animalFactory = new AnimalFactory();
            Animal dog = animalFactory.CreateAnimal("dog");
            Animal cat = animalFactory.CreateAnimal("cat");

            AnimalDoStuff(dog);
            AnimalDoStuff(cat);


            Console.ReadLine();
            // FACTORY DESIGN PATTERN


            // ADAPTER DESIGN PATTERN
            EnemyMonster monster = new EnemyMonster();

            EnemyShedow shedow = new EnemyShedow();

            EnemyIntrface shedowAdapter = new EnemyShedowAdapter(shedow);

            Console.WriteLine("Enemy Monster");
            monster.EnemyName("DidO Monster");
            monster.Attck();
            monster.Walk();
            Console.WriteLine("Enemy ShedowAdapter");
            shedowAdapter.EnemyName("Shedow Wisp");
            shedowAdapter.Attck();
            shedowAdapter.Walk();
            Console.WriteLine("Enemy Shedow");
            shedow.ShedowName("Shedow Guard");
            shedow.ShedowAttack();
            shedow.ShedowWalk();
            
            Console.ReadLine();
            // ADAPTER DESIGN PATTERN

            //BUILDER DESIGN PATTERN
            RobotBuilderInterface marcuryStyleRobot = new MarcuryRobotBuilder();
            RobotBuilderInterface oldStyleRobot = new OldRobotBuilde();
            RobotEngineer MarcuryRobotBuilder = new RobotEngineer(marcuryStyleRobot);
            RobotEngineer OldRobotBuilder = new RobotEngineer(oldStyleRobot);

            OldRobotBuilder.MakeRobot();
            MarcuryRobotBuilder.MakeRobot();
            Robot robot  =  MarcuryRobotBuilder.GetRobot();
            Robot oldRobot = OldRobotBuilder.GetRobot();

            Console.WriteLine(robot.RobotHead);
            Console.WriteLine(robot.RobotTorso);
            Console.WriteLine(robot.RobotArms);
            Console.WriteLine(robot.RobotLegs);
            Console.WriteLine(robot.ToString());
            Console.WriteLine(oldRobot.ToString());
            Console.ReadLine();
            //BUILDER DESIGN PATTERN


            //BRIDGE DESIGN PATTERN
            Remote radioRemote = new RadioRemote(new Radio(1,10));
            Remote dvdRemote = new DvdRemote(new Dvd(1, 5));

            radioRemote.GetCurrentChannle();
            radioRemote.ButtonSixPressed();
            radioRemote.ButtonSixPressed();
            radioRemote.ButtonSixPressed();
            radioRemote.ButtonFourPressed();
            radioRemote.ButtonFivePressed();
            radioRemote.GetCurrentChannle();
            dvdRemote.ButtonFivePressed();
            Console.ReadLine();
            //BRIDGE DESIGN PATTERN


            //CHAIN OF RESPONSIBILTY  DESIGN PATTERN

            Chain addChain = new Add();
            Chain subChain = new Subtract();
            Chain multChain = new Multiply();
            Chain divChain = new Divide();

            addChain.SetNexthain(subChain);
            subChain.SetNexthain(multChain);
            multChain.SetNexthain(divChain);

            NumbersCulc numbersToCulc = new NumbersCulc(4, 4, "asd");
            addChain.Calculation(numbersToCulc);

            Console.ReadLine();
            //CHAIN OF RESPONSIBILTY  DESIGN PATTERN


        }
        // factory design pattern
        public static void AnimalDoStuff(Animal animal)
        {
            animal.ToString();
            animal.DisplayAnimal();
            animal.MakeSound();
        }
        // factory design pattern

     
    }
}
