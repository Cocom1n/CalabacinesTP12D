using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killObjet : MonoBehaviour
{
    [SerializeField] private GameObject lose;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //detecta la colicion de cualquier enemigo con el jugador
        if (collision.transform.CompareTag("Kill"))
        {
            gameObject.SetActive(false);
            Invoke("perder", 1); 
        }
    }
    public void perder()
    {
        lose.SetActive(true);
    }
}
