using UnityEngine;

public class espada : MonoBehaviour
{
    
    [SerializeField] CountManager countManager;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Velocidad: " + rb.linearVelocity.magnitude);
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
