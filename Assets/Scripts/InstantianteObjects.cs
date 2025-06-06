using UnityEngine;

public class DistanceObject : MonoBehaviour
{
   [SerializeField]
   private GameObject objectToInstantiate;

   public void Instantiate(Transform target)
    {
     Instantiate(objectToInstantiate, target.position, Quaternion.identity);
    }
}
