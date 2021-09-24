using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
	string myName = "Nathan";
	int myPower = 9001;
    int myLife = 10;
	
    // Start is called before the first frame update
    void Start()
    {
		print("Hello there, from " + myName);
		
        if (myPower > 9000)
		{
			print("It's over 9000 !");
    	}
    
		print("Bonjour, ladies and gentlemen. I am " + myName);
		
        if (myPower > 1)
		{
			print("And I will play for you the baguette.");
		}

        if (myLife < 1)
        {
            print("oof");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
