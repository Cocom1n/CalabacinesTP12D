using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojoManager : MonoBehaviour
{
    private float ojoSpeed;

    void Start()
    {
        ojoSpeed = Random.Range(2.0f, 4.0f);
    }
    void Update()
    {
        transform.Translate(Vector2.down * ojoSpeed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
