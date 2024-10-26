namespace Earth3025Engine.Models
{
    public class StarSystem
    {
        private Single _xPosition;
        private Single _yPosition;
        private Single _zPosition;
        private IEnumerable<SystemAsset> _assets;
        private Empire _controledBy = null;
        public StarSystem(Single xPosition, Single yPosition, Single zPosition)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
            _zPosition = zPosition;
        }
        public Single GetDistanceToSystem(StarSystem otherSystem)
        {
            Double xDist = Math.Pow((_xPosition - otherSystem._xPosition), 2f);
            Double yDist = Math.Pow((_yPosition - otherSystem._yPosition), 2f);
            Double zDist = Math.Pow((_zPosition - otherSystem._zPosition), 2f);
            return (Single)Math.Sqrt(xDist + yDist + zDist);
        }
    }
}