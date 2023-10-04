using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;//für Thickness
using System.Windows.Controls;//für Label
using System.Windows.Media;//für SolidColorBrush

namespace WpfTicTacToeObjekt
{
    class Elemente
    {
        int i;
        Button button = new Button();


        public Button Button

        {
            get { return button; }
            set { button = value; }
        }


        public Elemente()
        {
            button.Width = 80;
            button.Height = 80;
            button.Background = new SolidColorBrush(Colors.BlueViolet);
            button.Foreground = new SolidColorBrush(Colors.White);
            button.FontFamily = new FontFamily("Comic Sans MS");
            button.FontSize = 40;
            button.BorderBrush = Brushes.Black;
            button.BorderThickness = new Thickness(2, 2, 2, 2);
            button.Content = "";//muss Inhalt zugewiesen bekommen, sonst Fehlermeldung 
            //button.Name = "Button"+i;
        }
   
        public void GitterErzeugen()//geht nicht mit Schleife, da keine genaue Bezeichnung pro Button möglich, es werden 9 Buttons erzeugt

        {
            {
             
            

                
            }
        }
    }
}
