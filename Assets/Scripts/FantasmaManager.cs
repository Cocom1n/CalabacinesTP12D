using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaManager : MonoBehaviour
{
    private float monsterSpeed = 5;

    void Update()
    {
        transform.Translate(Vector2.left * monsterSpeed * Time.deltaTime);

        if (transform.position.x < -11f) //si el fantasma llega al borde derecho
        {
            Destroy(gameObject);//lo elimina
        }
    }
}
