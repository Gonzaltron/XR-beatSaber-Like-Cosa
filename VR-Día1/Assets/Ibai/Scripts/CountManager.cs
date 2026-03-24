using UnityEngine;
using TMPro;

public class CountManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntos;
    int puntosC;
    [SerializeField] int maxPuntos;
    bool fin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntosC = 0;
        puntos.text = puntosC.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cubo()
    {
        if (fin == false)
        {
            puntosC++;
            puntos.text = puntosC.ToString();
            if (puntosC == maxPuntos)
            {
                Terminar();
            }
        }
    }

    void Terminar()
    {
        puntos.text = "Fin";
        fin = true;
    }
}
