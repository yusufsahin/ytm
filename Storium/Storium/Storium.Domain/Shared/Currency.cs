namespace Storium.Domain.Shared
{
    public sealed record Currency
    {
        internal static readonly Currency None = new("");
        public static readonly Currency Usd = new("Usd");
        public static readonly Currency TRY = new("TRY");

        public string Code { get; init; }

        public Currency(string code)
        {
            Code = code;
        }

        public static Currency FromCode(string code)
        {
           return All.FirstOrDefault(x => x.Code == code) ??
                    throw new ArgumentException($"Currency with code {code} not found");
        }

        public static IReadOnlyCollection<Currency> All = new[] { Usd, TRY };



    }
}
