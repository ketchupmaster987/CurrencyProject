using System.Numerics;

namespace Currency
{
    public interface ICoin : ICurrency
    {
        public int Year { get; }
    }
}