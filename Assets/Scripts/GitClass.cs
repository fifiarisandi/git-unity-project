using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
	string myName = "MertProject";
	int myPower = 1000;
        bool niceGuitar = false;
        int myLife = 10;		
  	//To display/hide the instruction message
  	public GameObject textInstruction;
	//
        string gamePlayerName = "Shireen";
	int numberOfLostGames =  2;
        int numberOfWinGames =  12;


    // Start is called before the first frame update
    void Start()
    {
        if (myPower < 8000)
		{
			print("Power overwhelming!");
    	}

        if(myPower > 5000)
		{
			SwitchPlayMode("difficult");
		}
		print("Who is aswesome?:" + myName);
		print("Hello there, from " + myName);
		print("Who doesn't know what they are doing but likes bonus points?:" + myName);
		print("Bonjour, ladies and gentlemen. I am " + myName);
		print("Who is here " + myName);
		
        if (myPower > 1)
		{
			print("And I will play for you a spanish guitar!");
            niceGuitar = true;
    	}
		else
        {
            print("The power value is acceptable!");
		}
    		
		print("And I will play for you the baguette.");

        if (myLife < 1)
        {
            print("oof");
        }


	if(numberOfWinGames ==12)
        {
          print(gamePlayerName+" "+numberOfLostGames);
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
        //The action gets activated if you press on the space bar
        if(Input.GetKeyDown("space"))
        {
            //Destroy the origanl image
            Destroy(gameObject);

            //Hide the instruction message
            textInstruction.SetActive(false);
        }
        
    }
}
