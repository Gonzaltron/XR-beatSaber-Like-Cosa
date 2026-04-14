using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class CubeDir : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Vector3 spawnPoint;
    Vector3 dir;
    public float rotate;
    [SerializeField] CounterDir counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = spawnPoint;
        int position = Random.Range(-5, 5);
        this.transform.position = this.transform.position + Vector3.left * position;
        dir =  new Vector3(player.transform.position.x - this.transform.position.x, player.transform.position.y - this.transform.position.y, player.transform.position.z - this.transform.position.z).normalized;
        this.transform.rotation = Quaternion.LookRotation(dir);
        this.transform.rotation = Quaternion.Euler(this.transform.rotation.eulerAngles.x, this.transform.rotation.eulerAngles.y, rotate);
        this.GetComponent<Rigidbody>().linearVelocity = dir * speed;
        counter = GameObject.Find("Cube").GetComponent<CounterDir>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(rotate == 0 && other.gameObject.GetComponent<EspadaDir>().dir == 0)
            {
                counter.Add();
                Destroy(this.gameObject);
            }
            else if(rotate == 180 && other.gameObject.GetComponent<EspadaDir>().dir == 180)
            {
                counter.Add();
                Destroy(this.gameObject);
            }
            else if(rotate == 90 && other.gameObject.GetComponent<EspadaDir>().dir == 90)
            {
                counter.Add();
                Destroy(this.gameObject);
            }
            else if(rotate == 270 && other.gameObject.GetComponent<EspadaDir>().dir == 270)
            {
                counter.Add();
                Destroy(this.gameObject);
            }
        }
    }
}
