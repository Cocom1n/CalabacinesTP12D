using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1 : MonoBehaviour
{
    [SerializeField] private GameObject prefabDiamante;
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    private float random;
    void Start()
    {
        InvokeRepeating("generar", 1, 3);
    }

    public void generar()
    {
        int cantidadDiamantes = Random.Range(1, 4);

        for (int i = 0; i < cantidadDiamantes; i++)
        {
            Vector2 posicionAleatoria = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);

            Instantiate(prefabDiamante, posicionAleatoria, Quaternion.identity);
        }
    }
    // {
    //     Vector2 posAleatoria1 = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);
    //     Instantiate(prefabDiamante, posAleatoria1, gameObject.transform.rotation);

    //     Vector2 posAleatoria2 = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);
    //     Instantiate(prefabDiamante, posAleatoria2, gameObject.transform.rotation);
    // }
}
