using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory = Inventory.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        Debug.Log("Updating UI");
    }
}
