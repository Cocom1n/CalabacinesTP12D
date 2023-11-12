using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubeManager : MonoBehaviour
{
    private float plataformSpeed;
    void Start()
    {
        plataformSpeed = Random.Range(1.0f, 3.0f);
    }

    void Update()
    {
        //mueve las nubes hacia abajo con una velocidad aleatoria 
        transform.Translate(Vector2.down * plataformSpeed * Time.deltaTime);

        Destroy(gameObject,5); //Destruye el objeto despues de 5 segundos
        
    }
}
