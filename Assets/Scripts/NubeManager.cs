using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubeManager : MonoBehaviour
{
    private float plataformSpeed;
    void Start()
    {
        plataformSpeed = Random.Range(1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * plataformSpeed * Time.deltaTime);

        Destroy(gameObject,5);
        
    }
}
