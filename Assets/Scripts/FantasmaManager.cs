using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaManager : MonoBehaviour
{
    private float monsterSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * monsterSpeed * Time.deltaTime);

        if (transform.position.x < -11f)
        {
            Destroy(gameObject);
        }
    }
}
