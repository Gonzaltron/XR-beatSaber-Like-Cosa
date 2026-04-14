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
    [SerializeField] Dropdown dropdown;
    public static CountManager Instance;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntos = GameObject.FindAnyObjectByType<TMP_Text>();
        puntosC = 0;
        puntos.text = puntosC.ToString();
        maxPuntos = 10;
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


    public void SetTarget()
    {
        Debug.Log("maxPuntos: " + maxPuntos);
        int o = dropdown.value;
        if(o == 0)
        {
            maxPuntos = 10;
        }
         if(o == 1)
        {
            maxPuntos = 20;
        }
        if(o == 2)
        {
            maxPuntos = 30;
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
