public interface ICurrencyProvider
{
    decimal GetExchangeRate(string fromCurrency, string toCurrency);
}

public class NationalBankApi
{
    public decimal GetRateUAHToUSD() => 0.024m;
    public decimal GetRateUAHToEUR() => 0.021m;
}

public class EuropeanCentralBankApi
{
    public decimal EURtoUSD() => 1.14m;
    public decimal USDtoEUR() => 0.88m;
}

public class CurrencyAdapter : ICurrencyProvider
{
    private NationalBankApi _nbu;
    private EuropeanCentralBankApi _ecb;

    public CurrencyAdapter(NationalBankApi nbu, EuropeanCentralBankApi ecb)
    {
        _nbu = nbu;
        _ecb = ecb;
    }

    public decimal GetExchangeRate(string fromCurrency, string toCurrency)
    {
        if (fromCurrency == "UAH" && toCurrency == "USD")
            return _nbu.GetRateUAHToUSD();

        if (fromCurrency == "UAH" && toCurrency == "EUR")
            return _nbu.GetRateUAHToEUR();

        if (fromCurrency == "EUR" && toCurrency == "USD")
            return _ecb.EURtoUSD();

        if (fromCurrency == "USD" && toCurrency == "EUR")
            return _ecb.USDtoEUR();

        throw new NotSupportedException("Комбінація валют не підтримується.");
    }
}