using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 8;
    public GameObject Gameoverimage;
    public GameObject Gameovertext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer ==0||timer<0)
        {
            Gameoverimage.GetComponent<Image>().enabled = true;
            Gameovertext.GetComponent<Text>().enabled = true;
        
        }
        if (timer == -3 || timer < 0)
        {
        SceneManager.LoadScene(4);

        }    
    }
}
