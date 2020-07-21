using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MENU : MonoBehaviour
{
    public float timer = 8;
    public int Level;
    // Start is called before the first frame update
    void menu()
    {
        //SceneManager.LoadScene(2);
        //SceneManager.LoadScene(3);
        //SceneManager.LoadScene(4);
        //SceneManager.LoadScene(5);


    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer == 0 || timer < 0)
        {
            SceneManager.LoadScene(Level);

        }

    }
}
