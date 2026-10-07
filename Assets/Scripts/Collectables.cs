using TMPro;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public int ItemsCollected = 0;
    private int MaxItems;
    [SerializeField] private GameObject WinCanvas;
    [SerializeField] private TextMeshProUGUI Text;
    void Start()
    {
        MaxItems = GameObject.FindGameObjectsWithTag("Item").Length;
        Text.SetText($"{ItemsCollected} / {MaxItems}");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            ItemsCollected += 1;
            Destroy(other.gameObject);
            Text.SetText($"{ItemsCollected} / {MaxItems}");

            if (ItemsCollected >= MaxItems)
            {
                WinCanvas.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

}
