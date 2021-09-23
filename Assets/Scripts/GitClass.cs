using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
	string myName = "Kits";
	int myPower = 1009;
	
    // Start is called before the first frame update
    void Start()
    {
		print("Who is aswesome?:" + myName);
		
        if (myPower < 9000)
		{
			print("Power overwhelming!");
    	}
    
		print("Hola, ladies and gentlemen. I am " + myName);
		
        if (myPower > 1)
		{
			print("And I will play for you a spanish guitar!");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
