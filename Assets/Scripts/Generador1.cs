using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1 : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private int cantidadMaxima;
    private float random;
    void Start()
    {
        InvokeRepeating("generar", 1, 3);
    }

    public void generar()
    {
        int cantidadAGnerar = Random.Range(1, cantidadMaxima);

        for (int i = 0; i < cantidadAGnerar; i++)
        {
            Vector2 posicionAleatoria = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);

            Instantiate(prefab, posicionAleatoria, Quaternion.identity);
        }
    }
}
