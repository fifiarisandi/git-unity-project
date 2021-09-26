using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
 	string myName = "Mohammed Ockba";
	int myPower = 500;
  	//To display/hide the instruction message
  	public GameObject textInstruction;
	
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
        else
        {
            print("The power value is acceptable!");
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
