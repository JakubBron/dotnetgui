using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.enums
{
    public sealed record Currency(string Code, string Symbol)
    {
        public static readonly Currency USD = new("USD", "$");
        public static readonly Currency EUR = new("EUR", "€");
        public static readonly Currency GBP = new("GBP", "£");
        public static readonly Currency PLN = new("PLN", "zł");
        public static readonly Currency DEFAULT = PLN;

        public static ImmutableList<Currency> All { get; } =
            [USD, EUR, GBP, PLN];

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(Symbol) ? Code : Symbol;
        }

    }
}
