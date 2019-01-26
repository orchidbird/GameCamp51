using System;
using UnityEngine;

public class TextManager : MonoBehaviour{
    public TextMesh text;
    public int number = 0;
    string[] lines;

    void Start(){
        lines = Resources.Load<TextAsset>("Dialogues").text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    }
    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return)){
            number++;
        }

        if (number < lines.Length)
            text.text = lines[number];
    }
}
