using UnityEngine;

public class Collectables : MonoBehaviour
{
    public int ItemsCollected = 0;
    public int MaxItems = 1;
    [SerializeField] GameObject WinCanvas;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            ItemsCollected += 1;
            Destroy(other.gameObject);

            if (ItemsCollected >= MaxItems)
            {
                WinCanvas.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

}
