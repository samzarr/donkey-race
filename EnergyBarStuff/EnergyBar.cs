using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{

    private Transform bar;  // the Transform that controls the scale of the fill bar

    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("FillerController");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // set the bar size to any value
    public void SetBarSize(float size)
    {
        bar.localScale = new Vector3(size, 1f);
        ConfineBar();
    }

    // change the size of the bar by any value
    public void ChangeBarSize(float change)
    {
        bar.localScale = new Vector3(bar.localScale.x + change, 1f);
        ConfineBar();
    }

    // make sure the bar is within it's bounds
    public void ConfineBar()
    {
        if (bar.localScale.x < 0)
        {
            bar.localScale = new Vector3(0, 1f);
        }

        if (bar.localScale.x > 1)
        {
            bar.localScale = new Vector3(1, 1f);
        }
    }
}
