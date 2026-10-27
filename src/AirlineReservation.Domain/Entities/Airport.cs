namespace AirlineReservation.Domain.Entities;
public class Airport
{
    public Guid Id { get; private set; }
    public string IataCode { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string City { get; private set; } = string.Empty;
    public string Country { get; private set; } = string.Empty;

    private Airport() { }

    public Airport(string iataCode, string name, string city, string country)
    {
        if (string.IsNullOrWhiteSpace(iataCode) || iataCode.Trim().Length != 3)
        {
            throw new ArgumentException(
                "IATA code must contain exactly three characters.",
                nameof(iataCode));
        }

        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(city);
        ArgumentException.ThrowIfNullOrWhiteSpace(country);

        Id = Guid.NewGuid();
        IataCode = iataCode.Trim().ToUpperInvariant();
        Name = name.Trim();
        City = city.Trim();
        Country = country.Trim();
    }

}