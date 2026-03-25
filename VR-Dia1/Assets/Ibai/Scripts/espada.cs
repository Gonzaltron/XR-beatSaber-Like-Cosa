using UnityEngine;

public class espada : MonoBehaviour
{
    
    [SerializeField] CountManager countManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Cubo"))
        {
            countManager.Cubo();
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("Bomba"))
        {
            countManager.Bomba();
            Destroy(collision.gameObject);
        }
    }
}
