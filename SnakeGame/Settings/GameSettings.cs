namespace SnakeGame
{
    public static class GameSettings
    {
        public static int width => Console.WindowWidth;
        public static int height => Console.WindowHeight;
        public static int[] _velocities => new int[3] { 1000, 700, 500 };
        public static int _speedSetting { get; set; } 
        public static int velocity { get; set; }
        public static TimeSpan _sleep { get; set; }
        public static int SpeedSetting
        {
            get => _speedSetting;
            set
            {
                if (value >= 0 && value < _velocities.Length)
                {
                    _speedSetting = value;
                    velocity = _velocities[_speedSetting];
                    _sleep = TimeSpan.FromMilliseconds(velocity);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Speed setting must be within the range of available velocities.");
                }
            }
        }
        
        public static void UpdateSpeedSetting(int newSpeedSetting)
        {
            SpeedSetting = newSpeedSetting;
        }
    }
}