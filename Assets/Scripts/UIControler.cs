using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControler : MonoBehaviour
{
    private float diamante;
    private TextMeshProUGUI textMesh;

    private void Start ()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void manejarDiamantes (float valor)
    {
        if(valor>0)
        {
            diamante++;
            Debug.Log("diamante");
        }
        if(valor<0)
        {
            diamante--;
            Debug.Log("daño");
        }
        textMesh.text = diamante.ToString("0");
    }

    // public void SumarDiamante (float nuevoDiamante)
    // {
    //     diamante+=nuevoDiamante;
    //     textMesh.text = diamante.ToString("0");
    // }

    // public void RestarDiamante (float daño)
    // {
    //     diamante-=daño;
    //     textMesh.text = diamante.ToString("0");
    // }
}
