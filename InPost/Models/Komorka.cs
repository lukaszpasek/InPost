using System;
namespace InPost
{
    public class Komorka
    {
        double _width;
        double _height;
        bool _czy_zajeta;
        Paczka _paczka;
        public Komorka()
        {
        }
        public bool Wrzuc(Paczka paczkaDoNadania)
        {
            if (_czy_zajeta is not true)
            {
                _paczka = paczkaDoNadania;
                _czy_zajeta = true;
            }
            else
            {
                return false;
            }
           return true;
        }
        public Paczka Odbierz
        {
            get
            {
                Paczka tmp;
                if (_czy_zajeta is true)
                {
                    _czy_zajeta = false;
                    tmp = _paczka;
                    _paczka = null;
                }
                return _paczka;
            }
        }
    }
}

