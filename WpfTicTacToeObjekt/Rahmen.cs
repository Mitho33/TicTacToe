using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;//für new Tickness
using System.Windows.Controls;//Für WrapPanel
using System.Windows.Media;//für SolidColorBrush

namespace WpfTicTacToeObjekt
{
    class Rahmen
    {
        WrapPanel wrapPanel1 =new WrapPanel();

        public WrapPanel WrapPanel1

        {
            get { return wrapPanel1; }
        }

        public Rahmen()
        {
            wrapPanel1.Width = 240;
            wrapPanel1.Height = 240;
            wrapPanel1.Background = new SolidColorBrush(Colors.Gray);
            wrapPanel1.Margin = new Thickness(140, 40, 0, 0);//Margin Außenabstand
        }

        public void EinfuegenRahmen()
        {
            
        }
        }
}
