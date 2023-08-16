using UnityEngine;

public class Colisiumotheobject1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
