using System.Collections.Immutable;

namespace WpfApp1.enums
{
    public sealed record TransactionPaymentMethod(string displayName)
    {
        public static readonly TransactionPaymentMethod CARD = new("Card");
        public static readonly TransactionPaymentMethod CASH = new("Cash");
        public static readonly TransactionPaymentMethod DEFAULT = CARD;

        public static ImmutableList<TransactionPaymentMethod> All { get; } = [CARD, CASH];

        public override string ToString()
        {
            return displayName;
        }
    }
}