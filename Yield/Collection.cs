using System.Collections;
using System.Collections.Generic;
using System;

namespace Yield
{
    interface IONE
    {
        int first { get; set; }
        void F();
    }
    interface ITWO
    {
        int first { get; set; }
        void F();
    }

    class Collection:IONE,ITWO,IEnumerable
    {
        public override int GetHashCode()
        {
            return _code;
        }

        public int ter { get; set; } = 2;

        int IONE.first { get; set; }
        void IONE.F() { }

        int ITWO.first { get; set; }
        void ITWO.F() { }

        private readonly int _code;

        public Collection()
        { _code = new Random().Next(0, 100000); }

        

        public IEnumerator GetEnumerator()
        {
            yield return ter;           
            yield return true;
        }
    }
}
