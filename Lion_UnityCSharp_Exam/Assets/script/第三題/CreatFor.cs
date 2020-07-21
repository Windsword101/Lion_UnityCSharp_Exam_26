using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatFor : MonoBehaviour
{
    public GameObject Instantiate_Position; 

    public GameObject Box; 

   

    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)

        {

            for (int j = 0; j <= 10; j++)

            {

                if (i >= -j + 5 && i <= -j + 15 && i <= j + 5 && i >= j - 5)

                {

                    

                }

                //else

                {

                    //Console.Write(" ");

                }

            }

            //Console.WriteLine();

        }

    }

  
        
  
}
