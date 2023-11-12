using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1 : MonoBehaviour
{
    //este script genera los diamantes y ojos que caen de la parte superior del mapa
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private int cantidadMaxima;
    private float intervalo;
    void Start()
    {
        intervalo = Random.Range(2, 4); //genera un intervalo random para la generacion del los objetos
        InvokeRepeating("generar", 1, intervalo);
    }

    public void generar()
    {
        //indica una cantidad maxima de objetos que van a spawnear cada vez que el metodo sea llamado
        int cantidadAGnerar = Random.Range(1, cantidadMaxima);
        
        for (int i = 0; i < cantidadAGnerar; i++)//genera x cantidad de objetos en una pocicion aleatoria entre el Puntoa A y B
        {
            Vector2 posicionAleatoria = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);

            Instantiate(prefab, posicionAleatoria, Quaternion.identity); 
        }
    }
}
