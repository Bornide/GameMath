using System.Timers;

namespace GameMath.Timer
{
    public class Timer
    {
        private double _duration { get; set; }
        private double _timePassed { get; set; }
        private bool _hasStarted { get; set; }
        private bool _repeatOn { get; set; }
        private List<Action> _callbacks { get; set; }

        public Timer(double duration, bool autostart = false, bool repeat = false)
        {
            _callbacks = new List<Action>();
            _hasStarted = autostart;
            _repeatOn = repeat;
            _duration = duration;
        }

        public void OnTimeout(Action callback)
        {
            _callbacks.Add(callback);
        }

        public void Update(double dt)
        {
            if (!_hasStarted)
            {
                return;
            }

            if (_timePassed >= _duration)
            {
                foreach (var callback in _callbacks)
                {
                    callback();
                }

                if (!_repeatOn)
                {
                    _hasStarted = false;
                    return;
                }

                _timePassed = 0;
            }

            _timePassed += dt;
        }

        public void Start()
        {
            _hasStarted = true;
        }

        public void Stop()
        {
            _hasStarted = false;
        }

    }
}