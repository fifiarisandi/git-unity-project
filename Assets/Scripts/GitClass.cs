using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
	string myName = "Nathan";
	int myPower = 9001;
    int myLife = 10;
  	//To display/hide the instruction message
  	public GameObject textInstruction;
	
    // Start is called before the first frame update
    void Start()
    {
		print("Hello there, from " + myName);
		print("Who doesn't know what they are doing but likes bonus points?:" + myName);
		
        if (myPower > 9000)
		{
			print("It's over 9000 !");
    	}
		else
        {
            print("The power value is acceptable!");
		}
    
		print("Bonjour, ladies and gentlemen. I am " + myName);
		print("And I will play for you the baguette.");

        if (myLife < 1)
        {
            print("oof");
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
