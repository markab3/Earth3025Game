public class UpdateClock
{
    private bool _isRunning = false;
    private DateTime _lastUpdate = DateTime.MinValue;
    private DateTime _nextUpdate = DateTime.MaxValue;
    private int _minimumUpdateInterval = 60000;
    private Task _updateTask = null;
    public UpdateClock()
    {

    }

    public void Start()
    {
        if (_isRunning) { throw new Exception("Clock already started."); }
        _isRunning = true;
        _nextUpdate = DateTime.UtcNow;
        _updateTask = Task.Run(() =>
        {
            while (_isRunning)
            {
                if (DateTime.UtcNow >= _nextUpdate)
                {
                    Update();
                }
            }
        });
        Console.WriteLine("Clock started.");
    }

    public void Stop()
    {
        _isRunning = false;
        if (_updateTask != null && !_updateTask.IsCompleted)
        {
            _updateTask.Wait();
        }
        Console.WriteLine("Clock stopped.");
    }

    private void Update()
    {
        Console.WriteLine("Update started at: " + DateTime.Now);
        int ticksTaken = _minimumUpdateInterval;
        Random rand = new Random();
        ticksTaken += rand.Next(-10000, 5000);
        System.Threading.Thread.Sleep(ticksTaken);
        Console.WriteLine("Update completed at: " + DateTime.Now);
        _nextUpdate = _lastUpdate.AddMilliseconds(_minimumUpdateInterval);
        _lastUpdate = DateTime.Now;
    }
}