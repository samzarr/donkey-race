using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donkey : MonoBehaviour
{

    // attributes
    public int speed;
    public string name;

    // constructor
    public Donkey(int spd, string nme)
    {
        speed = spd;
        name = nme;
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
        string new_name = donkey2.name + donkey1.name;
        //

        return new Donkey(new_speed, new_name);
    }
}