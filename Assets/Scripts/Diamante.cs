using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    private float punto = 1;
    private float diamanteSpeed;
    [SerializeField] private UIControler uiC;

    void Start()
    {
        uiC = FindObjectOfType<UIControler>();//Busca un objeto en la escena que contenga este componente
        diamanteSpeed = Random.Range(2.0f, 4.0f);
    }
    void Update()
    {
        transform.Translate(Vector2.down * diamanteSpeed * Time.deltaTime); //mueve los diamantes hacia abajo con una velocidad aleatoria

        Destroy(gameObject, 8); //Y los destruye despues de 8 segundos
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            uiC.manejarDiamantes(punto);
            Destroy(gameObject);
        }

        // if(collision.CompareTag("Kill"))
        // {
        //     Destroy(gameObject);
        // }
    }
}
