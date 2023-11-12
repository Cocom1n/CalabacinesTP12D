using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class killObjet : MonoBehaviour
{
    [SerializeField] private GameObject lose;
    [SerializeField] private AudioSource lostSound;
    [SerializeField] private AudioSource gameSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //detecta la colicion del limite inferior de la pantalla con el jugador y lo elimina directamente
        if (collision.transform.CompareTag("Kill"))
        {
            gameObject.SetActive(false);
            Invoke("perder", 1); 
        }
    }
    public void perder()
    {
        lose.SetActive(true);
        lostSound.Play();
        gameSound.Stop();
    }
}
