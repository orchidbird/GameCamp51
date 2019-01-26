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
            text.text = "응애(이거 뭐야?)enter키를 누르시오";
        }
        else if(number == 2)
        {
            text.text = "응애?(저놈들은 뭐야?)";
        }
        else if (number == 3)
        {
            text.text = "일년 뒤...";
        }
        else if (number == 4)
        {
            text.text = "응애으앙앵(뭐야 저걸 되게 잡고싶네)";
        }
        else if (number == 5)
        {
            text.text = "응애!(이걸 잡자!)";
        }
        
    }
}
