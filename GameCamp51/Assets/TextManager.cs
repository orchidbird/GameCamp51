using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public TextMesh text;
    public int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            number++;
            
        }

        if (number == 1)
        {
            text.text = "안녕!";
        }
        else if(number == 2)
        {
            text.text = "안녕!2";
        }
        else if (number == 3)
        {
            text.text = "안녕!3";
        }
    }
}
