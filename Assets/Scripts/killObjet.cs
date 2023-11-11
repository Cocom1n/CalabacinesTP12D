using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killObjet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //detecta la colicion de cualquier enemigo con el jugador
        if (collision.transform.CompareTag("Kill"))
        {
            gameObject.SetActive(false);
        }
    }
}
