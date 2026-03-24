using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Cube : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Vector3 spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = spawnPoint;
        int position = Random.Range(-1, 1);
        this.transform.position = this.transform.position + Vector3.left * position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
