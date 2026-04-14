using Unity.VisualScripting;
using UnityEngine;

public class SpawnerDir : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject target;
    [SerializeField] float speed;
    [SerializeField] float cooldown;
    [SerializeField] float distance;
    float actualCooldown;
    [SerializeField] Vector3 spawnPoint;
    int rotation;
    float rotate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPoint = player.transform.forward * distance;
        actualCooldown += Time.deltaTime;
        if (actualCooldown >= cooldown)
        {
            rotate = Random.Range(0, 4) * 90;
            Debug.Log(rotate);
            spawnPoint.y = player.transform.position.y;
            GameObject cube = Instantiate<GameObject>(target, this.transform.position, this.transform.rotation);
            cube.GetComponent<CubeDir>().player = player;
            cube.GetComponent<CubeDir>().speed = speed;
            cube.transform.position = spawnPoint;
            cube.GetComponent<CubeDir>().spawnPoint = spawnPoint;
            cube.GetComponent<CubeDir>().rotate = rotate;
            actualCooldown = 0;
        }
    }
}
