using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TitleOnClick : MonoBehaviour
{

    Bobbing bb;

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
        UnityEngine.Debug.Log("working?");
    }
}
