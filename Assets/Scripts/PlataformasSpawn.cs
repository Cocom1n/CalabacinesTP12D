using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasSpawn : MonoBehaviour
{
    [SerializeField] private GameObject nube;
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    void Start()
    {
        StartCoroutine(generar()); //genera nubes llamando a una corrutina
    }

    IEnumerator  generar()
    {
        while(true)
        {
            //cada 0.5 segundos va a generar 2 nubes en una pocicion aleatoria entre A y B
            yield return new WaitForSeconds(0.5f); 
            Vector2 posicionAleatoria = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);
            Instantiate(nube, posicionAleatoria, Quaternion.identity);

            Vector2 posicionAleatoria2 = new Vector2(Random.Range(puntoA.position.x, puntoB.position.x), puntoA.position.y);
            Instantiate(nube, posicionAleatoria2, Quaternion.identity);
        }
        
    }
}
