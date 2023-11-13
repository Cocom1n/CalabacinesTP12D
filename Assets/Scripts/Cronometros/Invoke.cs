using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Invoke : MonoBehaviour
{
    private float tiempoPasado = 0f;
    private bool corriendo =false;
    private TextMeshProUGUI textMesh;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!corriendo)
            {
                InvokeRepeating("ActualizarCronometro", 1, 1);
                corriendo = true;
            }
            else
            {
                CancelInvoke();
                corriendo = false;
            }
        }        
    }
    public void ActualizarCronometro()
    {
        tiempoPasado ++;
        textMesh.text = tiempoPasado.ToString("F3");
    }
}
