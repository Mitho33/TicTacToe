using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfTicTacToeObjekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        int z;//Zufallszahl word für eine Situation benötigt x in der Mitte
        int i;
        Rahmen rahmen;
        Random random = new Random();
        Elemente[] tttArray = new Elemente[9];//Array mit der größe 9 aus der Klasse elemente wird erzeugt
        private void Erstellen_Click(object sender, RoutedEventArgs e)
        {
            rahmen = new Rahmen();
            Grid1.Children.Add(rahmen.WrapPanel1);


            for (i = 0; i < 9; i++)
            {

                tttArray[i] = new Elemente();//Array wird erzeugt

                rahmen.WrapPanel1.Children.Add(tttArray[i].Button);//füge das Objekt mit dem Attribut i hinzu


                tttArray[i].Button.Click += new RoutedEventHandler(Spielen);//Hierdurch werden dem Button beim Anklicken x zugewiesen
                                                                            //Das Objekt mit der Eigenschaft Button , Click bekommt das Ereignis zugewiesen das aus der Klasse RoutedEventHandler das auf die Methode spielen reagiert
            }
        }

        private void Spielen(object sender, RoutedEventArgs e)//Spielerwechsel durch wechselnde Wertzuweisung/Initialisierung

        {

            //beliebiger Button wird benötigt, sobald ein Button sendet, wird die Anweisung ausgeführt
            //Button button;//variable aus der Klasse Button wird deklariert, es muss hier kein Obejekt erzeugt werden

            //button = (Button)sender;//das Objekt bekommt die Eigenschaft sender zugewiesen

            //if (button.Content.ToString() == "")//einfache Abfrage mit wenn ohne Verzweigung



            //button.Content = "X";//wenn der Button sendet, dass er leer ist, dann bekommt er den Inhalt X

            if (sender == tttArray[0].Button && tttArray[0].Button.Content.ToString() == "")
            {
                tttArray[0].Button.Content = "X";
            }

            else if (sender == tttArray[1].Button && tttArray[1].Button.Content.ToString() == "")
            {
                tttArray[1].Button.Content = "X";
            }


            else if (sender == tttArray[2].Button && tttArray[2].Button.Content.ToString() == "")
            {
                tttArray[2].Button.Content = "X";
            }

            else if (sender == tttArray[3].Button && tttArray[3].Button.Content.ToString() == "")
            {
                tttArray[3].Button.Content = "X";
            }

            else if (sender == tttArray[4].Button && tttArray[4].Button.Content.ToString() == "")
            {
                tttArray[4].Button.Content = "X";
            }

            else if (sender == tttArray[5].Button && tttArray[5].Button.Content.ToString() == "")
            {
                tttArray[5].Button.Content = "X";
            }

            else if (sender == tttArray[6].Button && tttArray[6].Button.Content.ToString() == "")
            {
                tttArray[6].Button.Content = "X";
            }

            else if (sender == tttArray[7].Button && tttArray[7].Button.Content.ToString() == "")
            {
                tttArray[7].Button.Content = "X";
            }

            else if (sender == tttArray[8].Button && tttArray[8].Button.Content.ToString() == "")

            {
                tttArray[8].Button.Content = "X";
            }

            // Suche nach 2 eigenen aus Sicht von KI 0; Ziel gewinnen

            if (tttArray[0].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "")//rechts oben waagerecht

                tttArray[2].Button.Content = "O";

            else if (tttArray[3].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "")//rechts mitte waagerecht

                tttArray[5].Button.Content = "O";//bei else if (sonst wenn wird bei der ersten zutreffeenden Variante die Abfrage beendet und geht zur nächsten Anweisung hier if
                                                 //alle else if gehören zu dem ersten if {} können müssen aber nicht sein

            else if (tttArray[6].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "")//rechts unten waagerecht

                tttArray[8].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "" && tttArray[1].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "O")//links oben waagerecht

                tttArray[0].Button.Content = "O";


            else if (tttArray[3].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "O")//links mitte waagerecht

                tttArray[3].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "" && tttArray[7].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "O")//links oben waagerecht

                tttArray[6].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "" && tttArray[2].Button.Content.ToString() == "O")//mitte oben waagerecht

                tttArray[1].Button.Content = "O";



            else if (tttArray[6].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "" && tttArray[8].Button.Content.ToString() == "O")//mitte unten waagerecht

                tttArray[7].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "" && tttArray[3].Button.Content.ToString() == "O" && tttArray[6].Button.Content.ToString() == "O")//links oben senkrecht

                tttArray[0].Button.Content = "O";


            else if (tttArray[1].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "O")//mitte oben senkrecht

                tttArray[1].Button.Content = "O";


            else if (tttArray[2].Button.Content.ToString() == "" && tttArray[5].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "O")//rechts oben senkrecht

                tttArray[2].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "O" && tttArray[6].Button.Content.ToString() == "")//links unten senkrecht

                tttArray[6].Button.Content = "O";


            else if (tttArray[1].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "")//mitte unten senkrecht

                tttArray[7].Button.Content = "O";


            else if (tttArray[2].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "")//rechts unten senkrecht

                tttArray[8].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "" && tttArray[6].Button.Content.ToString() == "O")//links mitte senkrecht

                tttArray[3].Button.Content = "O";


            else if (tttArray[1].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "" && tttArray[7].Button.Content.ToString() == "O")//mitte mitte senkrecht

                tttArray[4].Button.Content = "O";


            else if (tttArray[2].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "" && tttArray[8].Button.Content.ToString() == "O")//rechts mitte senkrecht

                tttArray[5].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "")//diagonal links nach rechts unten, unten leer

                tttArray[8].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "O")//diagonal links nach rechts unten, oben leer

                tttArray[0].Button.Content = "O";//geht


            else if (tttArray[6].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "O")//diagonal links nach rechts oben, unten leer

                tttArray[6].Button.Content = "O";//problem


            else if (tttArray[6].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "")//diagonal links nach rechts oben , oben leer

                tttArray[2].Button.Content = "O";//geht




            //Prüfung, ob X 2 hat, Ziel nicht verlieren
            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "")//rechts oben waagerecht

                tttArray[2].Button.Content = "O";


            else if (tttArray[3].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "")//rechts mitte waagerecht

                tttArray[5].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "")//rechts unten waagerecht

                tttArray[8].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "" && tttArray[1].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "X")//links oben waagerecht

                tttArray[0].Button.Content = "O";


            else if (tttArray[3].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X")//links mitte waagerecht

                tttArray[3].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "" && tttArray[7].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X")//links oben waagerecht

                tttArray[6].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "" && tttArray[2].Button.Content.ToString() == "X")//mitte oben waagerecht

                tttArray[1].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "" && tttArray[8].Button.Content.ToString() == "X")//mitte unten waagerecht

                tttArray[7].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "" && tttArray[3].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "X")//links oben senkrecht

                tttArray[0].Button.Content = "O";


            else if (tttArray[1].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "X")//mitte oben senkrecht

                tttArray[1].Button.Content = "O";


            else if (tttArray[2].Button.Content.ToString() == "" && tttArray[5].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X")//rechts oben senkrecht

                tttArray[2].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[3].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "")//links unten senkrecht

                tttArray[6].Button.Content = "O";


            else if (tttArray[1].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "")//mitte unten senkrecht


                tttArray[7].Button.Content = "O";


            else if (tttArray[2].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "")//rechts unten senkrecht

                tttArray[8].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[3].Button.Content.ToString() == "" && tttArray[6].Button.Content.ToString() == "X")//links mitte senkrecht

                tttArray[3].Button.Content = "O";


            else if (tttArray[1].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "" && tttArray[7].Button.Content.ToString() == "X")//mitte mitte senkrecht

                tttArray[4].Button.Content = "O";


            else if (tttArray[2].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "" && tttArray[8].Button.Content.ToString() == "X")//rechts mitte senkrecht

                tttArray[5].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "X")//diagonal links nach rechts unten

                tttArray[6].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "")//diagonal links nach rechts unten

                tttArray[2].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "")//diagonal links nach rechts oben

                tttArray[8].Button.Content = "O";


            else if (tttArray[0].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X")//diagonal links nach rechts oben

                tttArray[0].Button.Content = "O";
            //______________________________________________

       

          



            //Prüfen im 2. Zug, ob einer auf der rechten Seite ist
            else if (tttArray[3].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "")//diagonal rechts nach links unten

                tttArray[1].Button.Content = "O";


            else if (tttArray[3].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X"
                && tttArray[6].Button.Content.ToString() == "")//diagonal rechts nach links unten

                tttArray[3].Button.Content = "O";



            else if (tttArray[3].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "")//diagonal rechts nach links unten

                tttArray[1].Button.Content = "O";



            else if (tttArray[3].Button.Content.ToString() == "" && tttArray[4].Button.Content.ToString() == "0" && tttArray[5].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "O" &&
              tttArray[7].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "")

                tttArray[8].Button.Content = "O";



            else if (tttArray[6].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "" && tttArray[6].Button.Content.ToString() == ""
                && tttArray[2].Button.Content.ToString() == "")//diagonal links nach rechts unten mit unten links

                tttArray[8].Button.Content = "O";


            else if (tttArray[6].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "X" && tttArray[3].Button.Content.ToString() == "")//diagonal lins nach rechts oben mit oben links

                tttArray[3].Button.Content = "O";

            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "X")//diagonal links nach rechts unten

                tttArray[7].Button.Content = "O";



            //1. Zug Mitte mit x
            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[0].Button.Content.ToString() == "" && tttArray[1].Button.Content.ToString() == "" && tttArray[2].Button.Content.ToString() == ""
                && tttArray[3].Button.Content.ToString() == "" && tttArray[5].Button.Content.ToString() == "" && tttArray[6].Button.Content.ToString() == "" && tttArray[7].Button.Content.ToString() == ""
                && tttArray[8].Button.Content.ToString() == "")

            {
                //z = random.Next(0, 4);//Zufallszahl von bis 3, da 4 nicht geht ist bereits mit X belegt, der Mensch kann gewinnen wenn Zufall = 1 oder 2
                //tttArray[z].Button.Content = "O";
                tttArray[0].Button.Content = "O";
            }

            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "X"&& tttArray[6].Button.Content.ToString() == "")
                tttArray[6].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "X")
                tttArray[5].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[0].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "")
                tttArray[6].Button.Content = "O";


            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "O" && tttArray[6].Button.Content.ToString() == "X" && tttArray[0].Button.Content.ToString() == "")
                tttArray[0].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[0].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "")
                tttArray[1].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "")
                tttArray[5].Button.Content = "O";

            //2.Zug nur einer auf der rechten Seite in der Mitte 0

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" && tttArray[0].Button.Content.ToString() == ""
               && tttArray[6].Button.Content.ToString() == "")

                tttArray[0].Button.Content = "O";


            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == ""
               && tttArray[8].Button.Content.ToString() == "")

                tttArray[2].Button.Content = "O";


            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == ""
              && tttArray[8].Button.Content.ToString() == "")

                tttArray[2].Button.Content = "O";


            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "X" && tttArray[0].Button.Content.ToString() == ""
              && tttArray[8].Button.Content.ToString() == "")

                tttArray[0].Button.Content = "O";



            else if (tttArray[0].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "")

                tttArray[6].Button.Content = "O";



            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == ""
              && tttArray[8].Button.Content.ToString() == "")

                tttArray[2].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "" && tttArray[8].Button.Content.ToString() == "X")
             

                tttArray[6].Button.Content = "O";
        
            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "" && tttArray[6].Button.Content.ToString() == "X")


                tttArray[5].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "")


                tttArray[6].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "")


                tttArray[8].Button.Content = "O";


            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "" )
                tttArray[8].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "")
                tttArray[5].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString()=="")
                tttArray[5].Button.Content = "O";

            else if (tttArray[4].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "X")
                tttArray[2].Button.Content = "O";


            else if (tttArray[4].Button.Content.ToString() == "")//mitte 

                tttArray[4].Button.Content = "O";


       

                 if
                  (tttArray[0].Button.Content.ToString() == "X" && tttArray[1].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "X" ||
                     tttArray[3].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" ||
                     tttArray[6].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X" ||
                     tttArray[0].Button.Content.ToString() == "X" && tttArray[3].Button.Content.ToString() == "X" && tttArray[6].Button.Content.ToString() == "X" ||
                     tttArray[1].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[7].Button.Content.ToString() == "X" ||
                     tttArray[2].Button.Content.ToString() == "X" && tttArray[5].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X" ||
                     tttArray[0].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[8].Button.Content.ToString() == "X" ||
                     tttArray[6].Button.Content.ToString() == "X" && tttArray[4].Button.Content.ToString() == "X" && tttArray[2].Button.Content.ToString() == "X")


                MessageBox.Show("GEWINNER Mensch");




            else if
                 (tttArray[0].Button.Content.ToString() == "O" && tttArray[1].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "O" ||
                     tttArray[3].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "O" ||
                     tttArray[6].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "O" ||
                     tttArray[0].Button.Content.ToString() == "O" && tttArray[3].Button.Content.ToString() == "O" && tttArray[6].Button.Content.ToString() == "O" ||
                     tttArray[1].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[7].Button.Content.ToString() == "O" ||
                     tttArray[2].Button.Content.ToString() == "O" && tttArray[5].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "O" ||
                     tttArray[0].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[8].Button.Content.ToString() == "O" ||
                     tttArray[6].Button.Content.ToString() == "O" && tttArray[4].Button.Content.ToString() == "O" && tttArray[2].Button.Content.ToString() == "O")


                MessageBox.Show("GEWINNER Computer");
          

                //wenn alle Felder belegt sind, aber keiner drei hat
                else if (tttArray[0].Button.Content.ToString() != "" && tttArray[1].Button.Content.ToString() != "" && tttArray[2].Button.Content.ToString() != "" &&
                   tttArray[3].Button.Content.ToString() != "" && tttArray[4].Button.Content.ToString() != "" && tttArray[5].Button.Content.ToString() != "" &&
                   tttArray[6].Button.Content.ToString() != "" && tttArray[7].Button.Content.ToString() != "" && tttArray[8].Button.Content.ToString() != "")



                    MessageBox.Show("Patt");
            }

        


    

        private void Button_Click(object sender, RoutedEventArgs e)//Neues Spiel: leert die Button
        {
            tttArray[0].Button.Content = "";
            tttArray[1].Button.Content = "";
            tttArray[2].Button.Content = "";
            tttArray[3].Button.Content = "";
            tttArray[4].Button.Content = "";
            tttArray[5].Button.Content = "";
            tttArray[6].Button.Content = "";
            tttArray[7].Button.Content = "";
            tttArray[8].Button.Content = "";

        }
    }
}




        
    
