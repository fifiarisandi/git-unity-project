using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
	string myName = "MertProject";
	int myPower = 1000;
	
    // Start is called before the first frame update
    void Start()
    {
		print("Who doesn't know what they are doing but likes bonus points?:" + myName);
		
        if (myPower < 9000)
		{
			print("Confusion overwhelming!");
    	}
    
		print("Tere, ladies and gentlemen. I am " + myName);
		
        if (myPower > 1)
		{
			print("And I will sing for you the song of my people!");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
