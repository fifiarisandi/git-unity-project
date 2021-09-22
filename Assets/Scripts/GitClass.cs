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
		print("Hello! My name is " + myName);
		
        if (myPower > 9000)
		{
			print("It's over 9000!!!");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
