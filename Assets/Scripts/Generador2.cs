using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador2 : MonoBehaviour
{
    //generador de fantasmas
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;    
    
    private float random;
    void Start()
    {
        int random = Random.Range(3, 6);
        InvokeRepeating("generar", 1, random); 
    }

    public void generar()
    {
        Vector2 posicionAleatoria = new Vector2(puntoA.position.x, Random.Range(puntoA.position.y, puntoB.position.y));

        Instantiate(prefab, posicionAleatoria, Quaternion.identity);
    }
}
