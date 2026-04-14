using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sables : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    [SerializeField] Toggle toggle2;
    int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 2;
        OnPress();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPress()
    {
        if (count == 1)
        {
            count = 2;
            toggle.isOn = false;
            toggle2.isOn = true;
        }
        else if (count == 2)
        {
            count = 1;
            toggle.isOn = true;
            toggle2.isOn = false;
        }
    } 

    public void Normal()
    {
        SceneManager.LoadScene("pocho saber");
    }

    public void Dificil()
    {
        SceneManager.LoadScene("pocho saber dificil");
    }

    public void Dir()
    {
        SceneManager.LoadScene("pocho saber dir");
    }

    public void DirDificil()
    {
        SceneManager.LoadScene("pocho saber dir dificil");
    }

}
