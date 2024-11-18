using System.Timers;

namespace Full_GRASP_And_SOLID;

public class CountdownTimerAdapter: CountdownTimer
{
    private CountdownTimer _countdownTimer;
    private IRecipeContent _client;
    private Timer _timer;
    
    public CountdownTimerAdapter(CountdownTimer countdownTimer)
    {
        this._countdownTimer = countdownTimer;
    }

    public void RegisterAdapter(int timeOut, IRecipeContent client)
    {
        this._client = client;
        this._timer = new Timer();
    }
}