using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageObject : MonoBehaviour
{
    private float daño = -1;
    [SerializeField] private UIControler uiC;

    void Start()
    {
        uiC = FindObjectOfType<UIControler>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            uiC.manejarDiamantes(daño);
            Destroy(gameObject);
        }
    }
}
