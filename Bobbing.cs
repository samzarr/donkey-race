using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bobbing : MonoBehaviour
{
    int cycle_amount;
    int cycle = 0;
    int direction = 1;
    float actual;
    float modify;

    // Start is called before the first frame update
    void Start()
    {
        cycle_amount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (cycle >= cycle_amount)
        {
            direction = -1;
        }
        if (cycle <= -cycle_amount)
        {
            direction = 1;
        }
        cycle += direction;
        actual = (float)direction / 500.0f;


        transform.position = new Vector2(transform.position[0], transform.position[1] + actual);

    }
}
