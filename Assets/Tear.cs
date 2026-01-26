using Project;
using UnityEngine;
using Zenject;

public class Tear : MonoBehaviour
{
    [Inject] PlayerStats playerStats;
    
    public Transform Transform;
    
    private float _tearDamage;
    
    void Start()
    {
        Transform = GetComponent<Transform>();
    }

    void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
