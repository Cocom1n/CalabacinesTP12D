using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Corrutina : MonoBehaviour
{
    private float tiempoPasado = 0;
    private bool corriendo =false;
    private TextMeshProUGUI textMesh;
    private Coroutine cronometroCoroutine;
    private void Start ()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!corriendo)
            {
                cronometroCoroutine = StartCoroutine(ActualizarCronometro());
                corriendo = true;
            }
            else
            {
                StopCoroutine(cronometroCoroutine);
                corriendo = false;                
            }
        }
    }

    IEnumerator ActualizarCronometro()
    {
        while(true)
        {
            tiempoPasado+= Time.deltaTime;
            textMesh.text = tiempoPasado.ToString("F3");
            yield return null;
        }
    }
}
