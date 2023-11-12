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
        uiC = FindObjectOfType<UIControler>();
        diamanteSpeed = Random.Range(2.0f, 4.0f);
    }
    void Update()
    {
        transform.Translate(Vector2.down * diamanteSpeed * Time.deltaTime);

        Destroy(gameObject, 8);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            uiC.manejarDiamantes(punto);
            Destroy(gameObject);//destruye el objeto luego de 0.5 de tiempo
        }
    }
}
