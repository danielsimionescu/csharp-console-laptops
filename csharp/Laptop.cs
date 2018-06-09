namespace csharp
{
    internal class Laptop
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"{Manufacturer} {Model}";
        }
    }
}