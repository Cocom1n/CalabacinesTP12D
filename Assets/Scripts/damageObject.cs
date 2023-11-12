using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class damageObject : MonoBehaviour
{
    private float daño = -1;
    [SerializeField] private UIControler uiC; 
    [SerializeField] private AudioSource hit;
    void Start()
    {
        hit = GetComponent<AudioSource>();
        uiC = FindObjectOfType<UIControler>();//Busca un objeto en la escena que contenga este componente
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //si el enemigo coliciona con el jugador
        {
            hit.Play();
            uiC.manejarDiamantes(daño); //llamara al UI para restar diamantes
            Destroy(gameObject, 0.2f);// y destruira al enemigo
        }
    }
}
