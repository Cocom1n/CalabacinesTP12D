using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform jugador;
    private float alturaMaxima;

    [SerializeField] private float auxiliar;

    private void Start()
    {
        if (jugador != null)
        {
            alturaMaxima = jugador.position.y;
        }
    }

    private void LateUpdate()
    {
        if (jugador != null)
        {
            float alturaJugador = jugador.position.y;

            if (alturaJugador > alturaMaxima)
            {
                alturaMaxima = alturaJugador;
            }

            Vector3 nuevaPosicion = new Vector3(transform.position.x, auxiliar + alturaMaxima, transform.position.z);
            transform.position = nuevaPosicion;
        }
    }
}
