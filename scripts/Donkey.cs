// an extremely basic template that probably won't work at all for what we want
// changes coming whenever we figure out what we need

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donkey : MonoBehaviour
{

    // attributes
    public int speed;
    public string DonkeyName;

    // constructor
    public Donkey(int spd, string nme)
    {
        speed = spd;
        DonkeyName = nme;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // create a new donkey object from the attributes of two other donkeys
    static Donkey Combine(Donkey donkey1, Donkey donkey2)
    {
        // alternative logic here
        int new_speed = donkey2.speed + donkey1.speed / 2;
        string new_name = donkey2.DonkeyName + donkey1.DonkeyName;
        //

        return new Donkey(new_speed, new_name);
    }
}
