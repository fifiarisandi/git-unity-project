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
