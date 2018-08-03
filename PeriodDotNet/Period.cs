using System;

namespace PeriodDotNet
{
    [Serializable]
    public class Period<T> where T : IComparable<T>
    {
        private readonly T _from;
        public T From
        {
            get
            {
                return _from;
            }
        }
        private readonly T _to;
        public T To
        {
            get
            {
                return _to;
            }
        }

        private Period() { }

        public Period(T from)
        {
            _from = from;
            _to = from;
        }

        public Period(T from, T to)
        {
            _from = from;
            _to = to;
        }

        public bool Content(T obj)
        {
            return From.CompareTo(obj) <= 0 && To.CompareTo(obj) >= 0;
        }

        public override int GetHashCode()
        {
            return _from.GetHashCode() ^ _to.GetHashCode();
        }
    }
}
