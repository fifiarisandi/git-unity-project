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
		print("Who is aswesome?:" + myName);
		
        if (myPower < 9000)
		{
			print("Power overwhelming!");
    	}

        if(myPower > 3000) SwitchPlayMode('difficult');
    
		print("Hola, ladies and gentlemen. I am " + myName);
		
        if (myPower > 1)
		{
			print("And I will play for you a spanish guitar!");
		}
    }

    void SwitchPlayMode(string mode)
    {

        switch(mode){
            case "easy":
                print("Switching to easy mode");
            break;

            case "medium":
                print("Switching to medium mode");
            break;

            case "difficult":
                print("Switching to difficult mode");
            break;

            default: 
                print("Mode is not recognised");
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
