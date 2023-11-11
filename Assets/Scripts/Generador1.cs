using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1 : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    void Start()
    {
        InvokeRepeating("generar", 1, 4);
    }

    public void generar()
    {
        Vector2 posAleatoria1 = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);
        Instantiate(prefab, posAleatoria1, gameObject.transform.rotation);
        
        Vector2 posAleatoria2 = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);
        Instantiate(prefab, posAleatoria2, gameObject.transform.rotation);
    }
}
