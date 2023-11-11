using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageObject : MonoBehaviour
{
    private float daño = -1;
    [SerializeField] private UIControler uiC;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("daño00000000000000000");
        if(collision.CompareTag("Player"))
        {
            uiC.manejarDiamantes(daño);
            Destroy(gameObject);
        }
    }
}
