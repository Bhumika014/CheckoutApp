using CheckoutApp.Model;

using System.Collections.ObjectModel;


namespace CheckoutApp.ViewModel
{
    public class MyListViewModel
    {
        public ObservableCollection<MyListModel> MyListCollector { get; set; }

        public MyListViewModel()
        {

            MyListCollector = new ObservableCollection<MyListModel>()
            {
                new MyListModel(){ MyName="Activia Yougurt" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Activia.jpg" },
                new MyListModel(){ MyName="Apple" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "Apple.jpg"},
                new MyListModel(){ MyName="Banana" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Banana.jpg" },
                new MyListModel(){ MyName="Beans" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "Beans.png"},
                
                new MyListModel(){ MyName="Black Berry" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Black.jpg" },
                new MyListModel(){ MyName="Black Grapes" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "BlackGrape.jpg"},
                new MyListModel(){ MyName="Bread" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Bread.jpg" },
                new MyListModel(){ MyName="Brinjal" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "brinjal.jpg"},

                new MyListModel(){ MyName="Butter" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Butter.jpg" },
                new MyListModel(){ MyName="Cabbage" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "Cabbage.jpg"},
                new MyListModel(){ MyName="Cauli Flower" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Cauli.webp" },
                new MyListModel(){ MyName="EnergyBar" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "EnergyBar.jpg"},

                new MyListModel(){ MyName="Green Grapes" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "GreenGrape.png" },
                new MyListModel(){ MyName="Ice-Cream" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "IceCream.jpg"},
                new MyListModel(){ MyName="Oranges" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Orange.jpeg" },
                new MyListModel(){ MyName="Potatoes" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "Potato.jpg"},

                new MyListModel(){ MyName="Rasberry" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Rasbarry.jpg" },
                new MyListModel(){ MyName="Red Beans" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "RedBeans.jpg"},
                new MyListModel(){ MyName="Red Grapes" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "RedGrapes.jpg" },
                new MyListModel(){ MyName="Strawberry" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "strawberries.jpg"},

                new MyListModel(){ MyName="Tomato" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Tomato.jpg" },
                new MyListModel(){ MyName="WaterMelon" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "WaterMelon.jpg"},
                new MyListModel(){ MyName="Corn" , MyDetail="Lorem ipsum dolor sit amet, consectetur adipiscing elit.  " , Image = "Corn.jpg" },
                new MyListModel(){ MyName="Spinach" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "Spinach.png"},
                new MyListModel(){ MyName="Plain Yogurt" ,   MyDetail="Etiam vitae nulla sagittis, fermentum odio quis, consectetur nisl." , Image = "Yougert1.jpg"},

            };


        }
    }
}
