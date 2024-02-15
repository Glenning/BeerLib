using System.Diagnostics;

namespace BeerLib
{
    public class Beer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Abv { get; set; }
        public override string ToString() =>
            $"{Id}, {Name}, {Abv}";
        public void ValidName()
        {
            if (Name is null)
            {
                throw new ArgumentNullException("name can not be null");
            }
            if (Name.Length <= 2)
            {
                throw new ArgumentException("name too short");
            }
        }

        public void ValidAbv()
        {
            if (Abv <= 0 || Abv >= 66) 
            {
                throw new ArgumentOutOfRangeException("abv not valid");
            }
        }
    }
}
