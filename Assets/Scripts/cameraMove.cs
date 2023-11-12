using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform jugador; //Referencia al transform del objeto que va a seguir
    private float alturaMaxima;

    [SerializeField] private float auxiliar;

    private void Start()
    {
        alturaMaxima = jugador.position.y;//Altura maxima a la que llega el jugador
    }

    private void LateUpdate()
    {
        float alturaJugador = jugador.position.y;

        if (alturaJugador > alturaMaxima) //si la altura del jugador actual supera la altura maxima
        {
            alturaMaxima = alturaJugador;  //se actualiza la altura maxima
        }

        Vector3 nuevaPosicion = new Vector3(transform.position.x, auxiliar + alturaMaxima, transform.position.z);
        transform.position = nuevaPosicion; //se mueve la camara hasta la nueva pocicion maxima alcanzada.
    }
}
