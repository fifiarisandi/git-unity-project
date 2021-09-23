using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
	string myName = "Gittarro";
	int myPower = 1;
	
    // Start is called before the first frame update
    void Start()
    {
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
