namespace Earth3025Engine.Models
{
    public class Galaxy
    {
        List<StarSystem> _allStarSystems;
        List<Empire> _allEmpires;
        private Single _length;
        private Single _width;
        private Single _height;
        // Realistic dimensions would be 100k x 100k x 1k and 76 bil stars systems.
        // 100 bil stars is a bit much, so scaling down to 1000 stars ends up with:
        // 235.62 x 235.6 x 2.356
        public Galaxy(Single length = 235.6f, Single width = 235.6f, Single height = 2.356f, int numStars = 1000)
        {
            _allEmpires = new List<Empire>();
            _allStarSystems = new List<StarSystem>();
            _length = length;
            _width = width;
            _height = height;
            Random rand = new Random();
            for (int i = 0; i < numStars; i++)
            {
                Single xPos = (rand.NextSingle() * _length) - (_length * 0.5f);
                Single yPos = (rand.NextSingle() * _width) - (_width * 0.5f);
                Single zPos = (rand.NextSingle() * _height) - (_height * 0.5f);
                _allStarSystems.Add(new StarSystem(xPos, yPos, zPos));
            }
        }
        public void Update()
        {
            foreach (Empire currentEmpire in _allEmpires)
            {
                currentEmpire.Update();
            }
        }
    }
}