using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    private float punto = 1;
    private float diamanteSpeed = 2;
    [SerializeField] private UIControler uiC;

    void Start()
    {
        uiC = FindObjectOfType<UIControler>();
    }
    void Update()
    {
        transform.Translate(Vector2.down * diamanteSpeed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
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
