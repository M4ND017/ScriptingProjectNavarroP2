using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullet;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, int gre,int roc)
        {
            bullet = bul;
            grenades = gre; 
            rockets = roc; 
        }

        public Stuff(int bul, float fu)
        {
            bullet=bul;
            fuel = fu;
        }

        //Contructor
        public Stuff ()
        {
            bullet = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    //Creating an Instance (an object ) of the Stuff class
    public Stuff mySuff = new Stuff(50, 5, 5);

    public Stuff myStuff = new Stuff(50, 1.5f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStuff.bullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
