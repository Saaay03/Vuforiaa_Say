using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class BottonControler : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> buttons;
    [SerializeField]
    private string appearAnimationName;
    [SerializeField]
    private string disappearAnimationName;
    [SerializeField]
    private float buttonsAppearDelay;
    public void ShowButtons()
    {
        StartCoroutine(ShowButtonsWithDelay());
    }

    private IEnumerator ShowButtonsWithDelay()
    {
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Animator>().Play(appearAnimationName);
            yield return new WaitForSeconds(buttonsAppearDelay);
        }
     
    }

    public void HideButtons()
    {
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Animator>().Play(disappearAnimationName);
        }
    }

}
