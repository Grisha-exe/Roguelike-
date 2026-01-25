using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    public GameObject PickUpPrefab;
    
    void Start()
    {
        Instantiate(PickUpPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
