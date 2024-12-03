using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


/*
 Was macht das?
  public event PropertyChangedEventHandler? PropertyChanged; 

es wartet bis sich eine property verändert und es getriggert wird! um etwas auszuführen.
 */
namespace INotifyPropertyChangedInterface
{
    public class Summe : INotifyPropertyChanged
    {

        private string? nummer1;
        private string? nummer2;
        private string? ergebnis;

        public string Nummer1
        {
            get { return nummer1; }
            set
            {
                int nummer;
                bool referenzVariable = int.TryParse(value, out nummer); // Konvertiert den string in ein Int32
                if (referenzVariable) nummer1 = value;      // wenn eine veränderung am 'nummer1' ausgeführt wird, soll auch das Property 'Nummer1' angepasst wedren
                OnPropertyChanged("Nummer1");
                OnPropertyChanged("Ergebnis"); // immer wenn man die Zahl 1 verändert, verändert sich ja auch das ergebnisat!
            }

        }

        public string Nummer2
        {
            get { return nummer2; }
            set
            {
                int nummer;
                bool referenzVariable = int.TryParse(value, out nummer); // Konvertiert den string in ein Int32
                if (referenzVariable) nummer2 = value;      // wenn eine veränderung am 'nummer2' ausgeführt wird, soll auch das Property 'Nummer2' angepasst werden
                OnPropertyChanged("Nummer2");
                OnPropertyChanged("Ergebnis"); // immer wenn man die Zahl 2 verändert, verändert sich ja auch das ergebnisat!
            }

        }

        public string Ergebnis
        {
            get 
            { 
                int referenzVariable = int.Parse(Nummer1) + int.Parse(Nummer2); // wird erst vom string zum int und dann wieder zum string umgewandelt
                return referenzVariable.ToString();
            }
            set
            {
                int referenzVariable = int.Parse(Nummer1) + int.Parse(Nummer2); // wird erst vom string zum int und dann wieder zum string umgewandelt
                ergebnis = referenzVariable.ToString();      // wenn eine veränderung am 'nummer1' ausgeführt wird, soll auch das Property 'Nummer1' angepasst wedren
                OnPropertyChanged("Ergebnis");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged; 

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) // der code soll nur ausgeführt wedredn wenn 'PropertyChanged' nicht 'null' ist!
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

    }
}
