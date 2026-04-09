using UnityEngine;

public class SpawnerDificil : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject target;
    [SerializeField] float speed;
    [SerializeField] float cooldown;
    [SerializeField] float distance;
    [SerializeField] GameObject bomba;
    float actualCooldown;
    [SerializeField] Vector3 spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int b = Random.Range(0, 101);
        if(b >= 70 && actualCooldown >= cooldown)
        {
            spawnPoint.y = player.transform.position.y;
            GameObject cube = Instantiate<GameObject>(bomba, this.transform.position, this.transform.rotation);
            cube.GetComponent<Cube>().player = player;
            cube.GetComponent<Cube>().speed = speed;
            cube.transform.position = spawnPoint;
            cube.GetComponent<Cube>().spawnPoint = spawnPoint;
            actualCooldown = 0;
        }
        else if (actualCooldown >= cooldown)
        {
            spawnPoint.y = player.transform.position.y;
            GameObject cube = Instantiate<GameObject>(target, this.transform.position, this.transform.rotation);
            cube.GetComponent<Cube>().player = player;
            cube.GetComponent<Cube>().speed = speed;
            cube.transform.position = spawnPoint;
            cube.GetComponent<Cube>().spawnPoint = spawnPoint;
            actualCooldown = 0;
        }
        spawnPoint = player.transform.forward * distance;
        actualCooldown += Time.deltaTime;
    }
}
