using UnityEngine;
using TMPro;

public class CounterDir : MonoBehaviour
{
    public int counter;
    [SerializeField] int maxCounter;
    [SerializeField] TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add()
    {
        Debug.Log("Add");
        counter++;
        text.text = counter.ToString();
        if(counter >= maxCounter)
        {
            text.text = "Fin";
            Time.timeScale = 0;
        }
    }
}
