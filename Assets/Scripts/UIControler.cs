using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIControler : MonoBehaviour
{
    private float diamante = 5; //se inicia el contador de diamantes en 5 para tener chance
    private TextMeshProUGUI textMesh;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject lose;
    [SerializeField] private AudioSource lostSound;
    [SerializeField] private TextMeshProUGUI loseDiamantes;

    [SerializeField] private AudioSource gameSound;

    private void Start ()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void manejarDiamantes (float valor)
    {
        if(valor>0) //si el valor es positivo
        {
            diamante++; //sumara un diamante
        }
        if(valor<0) //si el valor es negativo 
        {
            diamante--; //resta un diamante
        }
        if(diamante<=0) // si la cantidad de diamantes es menor o igual a 0
        {
            player.SetActive(false); //desactiva al player
            Invoke("perder", 1); // muestra el panel de perdiste despues de un segundo
        }
        textMesh.text = diamante.ToString("0");
        loseDiamantes.text = "Diamantes totales: " + diamante.ToString("0"); //asigna la cantidad de diamantes que recolecto el jugador al morir
    }

    public void perder()
    {
        lose.SetActive(true);
        lostSound.Play();
        gameSound.Stop();
    }

    //metodo que reinicia el nivel al apretar el boton de reiniciar
    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
