using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojoManager : MonoBehaviour
{
    private float ojoSpeed;

    void Start()
    {
        ojoSpeed = Random.Range(2.0f, 4.0f);
    }
    void Update()
    {
        //mueve los ojos hacia abajo con una velocidad aleatoria
        transform.Translate(Vector2.down * ojoSpeed * Time.deltaTime);
        Destroy(gameObject, 7); //Destruye el objeto despues de 7 segundos
    }
}
