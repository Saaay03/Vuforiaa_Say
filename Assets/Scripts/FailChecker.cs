using UnityEngine;
using UnityEngine.Events;

public class FailChecker : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnNoteDestroyed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            OnNoteDestroyed?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
    