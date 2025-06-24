using UnityEngine;

public class AscensorController : MonoBehaviour
{
    public Transform ascensor;       // objeto que se mueve (todo el ascensor)
    public Vector3 posicionFinal;    // hasta dónde baja
    public float velocidad = 1.5f;
    public bool activar = false;

    void Update()
    {
        if (activar)
        {
            ascensor.position = Vector3.MoveTowards(ascensor.position, posicionFinal, velocidad * Time.deltaTime);
        }
    }

    public void ActivarAscensor()
    {
        activar = true;
    }
}