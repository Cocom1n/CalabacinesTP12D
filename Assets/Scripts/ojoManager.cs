using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojoManager : MonoBehaviour
{
    private float ojoSpeed = 2;

    void Update()
    {
        transform.Translate(Vector2.down * ojoSpeed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
