namespace Earth3025Engine.Models
{
    public class Planet
    {
        private string _planetName;
        private List<Improvement> _improvements;
        private List<Commodity> _commodities;
        public Planet()
        {
            _improvements = new List<Improvement>();
            _commodities = new List<Commodity>();
        }
    }
}