using System;
namespace InPost
{
    public class Paczkomat
    {
        const int MAXSIZE = 64;
        private int _pos = 0;
        private int _nrPaczkomatu;
        private Queue<Klient> Q;
        private Komorka[] K = new Komorka[MAXSIZE];

        public int NrPaczkomatu => _nrPaczkomatu;
        public Paczkomat()
        {
        }
        private bool NadajPaczke(Paczka paczkaDoNadania)
        {
            if (_pos < MAXSIZE)
            {
                if (K[_pos].Wrzuc(paczkaDoNadania))
                {
                    _pos++;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
        private Paczka OdbierzPaczke(int nrPaczki)
        {
            if (nrPaczki < MAXSIZE)
            {
                return K[nrPaczki].Odbierz;
            }
            return null;
        }
    }
}

