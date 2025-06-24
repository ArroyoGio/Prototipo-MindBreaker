using UnityEngine;

public class BotonAscensor : MonoBehaviour
{
    public AscensorController controlador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controlador.ActivarAscensor();
        }
    }
}