using System;
namespace InPost.Models
{
    public class Klient
    {
        private enum Typ
        {
            Nadanie,
            Odebranie
        }
        private int _ktoryPaczkomat;
        public int KtoryPaczkomat => _ktoryPaczkomat;
        public Klient()
        {
        }
    }
}

