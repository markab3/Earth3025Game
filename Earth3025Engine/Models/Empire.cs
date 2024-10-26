namespace Earth3025Engine.Models
{
    public class Empire
    {
        private string _empireName;
        private IEnumerable<StarSystem> _controlledStarSystems;
        public Empire(string empireName)
        {
            _empireName = empireName;
            _controlledStarSystems = new List<StarSystem>();
        }
        public void Update()
        {

        }
    }
}