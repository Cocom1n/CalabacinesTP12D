using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageObject : MonoBehaviour
{
    private float daño = -1;
    [SerializeField] private UIControler uiC; 
    void Start()
    {
        uiC = FindObjectOfType<UIControler>();//Busca un objeto en la escena que contenga este componente
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //si el enemigo coliciona con el jugador
        {
            uiC.manejarDiamantes(daño); //llamara al UI para restar diamantes
            Destroy(gameObject);// y destruira al enemigo
        }
    }
}
