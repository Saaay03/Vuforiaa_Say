using UnityEngine;

public class Lane : MonoBehaviour
{
    [SerializeField]
    private GameObject notePrefab;
    public GameObject NotePrefab
    {
        get => notePrefab;
    }

    [SerializeField]
    private Transform notesOrigin;
    public Transform NotesOrigin
    {
        get => notesOrigin;
    }
}
