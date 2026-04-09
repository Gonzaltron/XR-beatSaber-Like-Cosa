using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntos;
    int puntosC;
    [SerializeField] int maxPuntos;
    bool fin;
    //public DropdownOption drop;
    public GameObject espada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntos = GameObject.FindAnyObjectByType<TMP_Text>();
        puntosC = 0;
        puntos.text = puntosC.ToString();
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnLevelWasLoaded()
    {
        puntos = GameObject.FindAnyObjectByType<TMP_Text>();
    }

    public void Cubo()
    {
            puntosC++;
            puntos.text = puntosC.ToString();
            if (puntosC == maxPuntos)
            {
                Terminar();
            }
    }

    public void Bomba()
    {
        puntosC -= 2;
        puntos.text = puntosC.ToString();
    }

    void Terminar()
    {
        puntos.text = "Fin";
        fin = true;
        Time.timeScale = 0;
    }


    public void SetTarget(int o)
    {
        if(o == 0)
        {
            maxPuntos = 11;
        }
        else if(o == 1)
        {
            maxPuntos = 21;
        }
        if(o == 2)
        {
            maxPuntos = 31;
        }
    }

    void Espadas(int j)
    {
        if(j == 1)
        {
            espada.SetActive(false);
        }
        else 
        {
            espada.SetActive(true);
        }
    }
}
