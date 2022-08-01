using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
    // Start is called before the first frame update
    // Define hero info
    string heroname = "hasnaa";
    int heroheight = 177 + 5;
    int heroage = 33;
    string herosuperpower = "flying";
    bool herowaslove = false;
    // Define villian info
    string villianname = "jojo";
    int villianheight = 155;
    int villianage = 32;
    string villiansoperpower = "speed";
    string nowvilliansoperpower = "none";
    void Start()
    {
        print("there was a hero and her name was " + heroname + "she was so tall to be a girl her height was" + heroheight + "her age was" + heroage + "her super power was " + herosuperpower);
        print("there was a villian and her name was " + villianname + " her height was" + villianheight + "her age was" + villianage + "her super power was " + villiansoperpower);
        int agedifference = heroage - villianage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
