namespace TimerPro.Custom;

public class TimerLogic
{
    private int _intSec, _intmin, _inthrs;

    public TimerLogic()
    {
        Reset();
    }

    public void SetTickCount()
    {
        _intSec++;
        if (_intSec == 59)
        {
            _intmin++;
            _intSec = 0;
            if (_intmin == 59)
            {
                _inthrs++;
                _intmin = 0;
            }
        }
    }

    public void Reset()
    {
        _intSec = 0;
        _intmin = 0;
        _inthrs = 0;
    }

    public string GetFormatedString()
    {
        return _inthrs.ToString().PadLeft(2,'0') + ":" + _intmin.ToString().PadLeft(2,'0') + ":" + _intSec.ToString().PadLeft(2,'0');
    }
}