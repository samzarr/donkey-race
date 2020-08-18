using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TitleOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bb = GetComponent<Bobbing>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called when this object is clicked
    void OnMouseDown()
    {
       // make sure left mouse button is pressed, not right mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // do whatever you want
        }
    }
}
