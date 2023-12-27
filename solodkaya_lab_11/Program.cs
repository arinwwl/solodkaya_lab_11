class TV
{
    public string Brand { get; set; }
    public double ScreenSizeInInches { get; set; }
    public double SoundPowerInDecibels { get; set; }

    public double Quality
    {
        get { return ScreenSizeInInches + (0.05 * SoundPowerInDecibels); }
    }
}

class TVWithCountry : TV
{
    public string ManufacturingCountry { get; set; }

    public double QualityInCountry
    {
        get
        {
            double Q = Quality;
            if (ManufacturingCountry == "Япония")
            {
                return 2 * Q;
            }
            else if (ManufacturingCountry == "Сингапур" || ManufacturingCountry == "Корея")
            {
                return 1.5 * Q;
            }
            else
            {
                return Q;
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        TVWithCountry television = new TVWithCountry
        {
            Brand = "Sony",
            ScreenSizeInInches = 55,
            SoundPowerInDecibels = 20,
            ManufacturingCountry = "Япония"
        };

        Console.WriteLine($"Фирма: {television.Brand}");
        Console.WriteLine($"Диагональ экрана: {television.ScreenSizeInInches}\"");
        Console.WriteLine($"Звуковая мощность: {television.SoundPowerInDecibels} дБ");
        Console.WriteLine($"Качество: {television.QualityInCountry}");
    }
}
