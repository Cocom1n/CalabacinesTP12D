using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubeManager : MonoBehaviour
{
    private float plataformSpeed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * plataformSpeed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
