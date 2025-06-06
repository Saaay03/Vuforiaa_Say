using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Reflection;
public class Timer : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnTimerComplete;
    [SerializeField]
    private UnityEvent<string> OnSecondPassed;
    private Coroutine TimerCoroutine;

    public void StartTime(float duration)
    {
        TimerCoroutine = StartCoroutine(RunTimer(duration));
    }

    private IEnumerator RunTimer(float duration)
    {
        OnSecondPassed?.Invoke(""+(int)duration);
        yield return new WaitForSeconds(1f);
        if (duration == 0)
        {
            OnTimerComplete?.Invoke();
        }
        else
        {
            TimerCoroutine = StartCoroutine(RunTimer(duration - 1));
        }
    }

    public void StopTimer()
    {
        if (TimerCoroutine != null)
        {
            StopCoroutine(TimerCoroutine);
            TimerCoroutine = null;
        }
    }
}
