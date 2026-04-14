using UnityEngine;
using UnityEngine.InputSystem;

public class EventoMando : MonoBehaviour
{
    [SerializeField] private InputActionReference menuActionReference;
    [SerializeField] Canvas menuUI;
    bool time;

    void Start()
    {
        menuUI.enabled = false;
        Time.timeScale = 1;
    }
    private void OnEnable()
    {
        // Suscribirse al evento 'performed' (cuando se pulsa el bot�n)
        menuActionReference.action.performed += OnMenuButtonPressed;
    }

    private void OnDisable()
    {
        // Desuscribirse para evitar errores de memoria
        menuActionReference.action.performed -= OnMenuButtonPressed;
    }

    private void OnMenuButtonPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Boton Menu pulsado!");
        menuUI.enabled = !menuUI.enabled;
        /*
        time = !time;
        if (time)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        */
    }
}
