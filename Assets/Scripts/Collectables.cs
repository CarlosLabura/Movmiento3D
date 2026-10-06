using UnityEngine;

public class Collectables : MonoBehaviour
{
    public int ItemsCollected = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            ItemsCollected += 1;
            Destroy(other.gameObject);
        }
    }

}
