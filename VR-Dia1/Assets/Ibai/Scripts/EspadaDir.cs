using System.Numerics;
using UnityEngine;

public class EspadaDir : MonoBehaviour
{
    Rigidbody rb;
    public int dir;
    UnityEngine.Vector3 currentPos;
    UnityEngine.Vector3 lastPos;
    UnityEngine.Vector3 deltaPos;
    [SerializeField] CountManager countManager;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateDir();
    }

    void CalculateDir()
    {
        currentPos = this.transform.position;
        deltaPos = currentPos - lastPos;
        float deltaPosX = deltaPos.x;
        float deltaPosY = deltaPos.y;
        if(Mathf.Abs(deltaPosX) > Mathf.Abs(deltaPosY))
        {
            if(deltaPosX > 0)
            {
                dir = 0;
            }
            else
            {
                dir = 180;
            }
        }
        else
        {
            if(deltaPosY > 0)
            {
                dir = 90;
            }
            else
            {
                dir = 270;
            }
        }
        lastPos = currentPos;
    }

    void OnTriggerenter(Collider other)
    {
        if(other.gameObject.CompareTag("Bomba"))
        {
            countManager.Bomba();
            Destroy(other.gameObject);
        }
    }
}