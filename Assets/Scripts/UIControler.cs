using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControler : MonoBehaviour
{
    private float diamante = 5;
    private TextMeshProUGUI textMesh;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject lose;

    private void Start ()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void manejarDiamantes (float valor)
    {
        if(valor>0)
        {
            diamante++;
            Debug.Log(diamante);
        }
        if(valor<0)
        {
            diamante--;
            Debug.Log(diamante);
        }
        if(diamante<=0)
        {
            player.SetActive(false);
            Invoke("cambiarEscena", 1); 
        }
        textMesh.text = diamante.ToString("0");
    }

    public void cambiarEscena()
    {
        lose.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
