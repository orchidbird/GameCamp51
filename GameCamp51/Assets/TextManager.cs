using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TextManager : MonoBehaviour{
    public TextMesh text;
    public Text MoneyText;
    public int number = 0;
    string[] lines;

    void Start(){
        lines = Resources.Load<TextAsset>("Dialogues").text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    }

    void Update(){
        MoneyText.text = "돈: " + GameManager.money;
        if (Input.GetKeyDown(KeyCode.Return)){number++;}
        
        if (number >= lines.Length) return;
        if (lines[number] == "Money"){
            var money = Random.Range(0, 6);
            if(money == 0)
                GameManager.money += 10000;
            else if(money == 1)
                GameManager.money += 20000;
            else if(money == 2)
                GameManager.money += 30000;
            else if(money == 3)
                GameManager.money += 50000;
            else if(money == 4)
                GameManager.money += 300000;
            else if(money == 5)
                GameManager.money += 1000000;
            number++;
        }else
            text.text = lines[number];
    }
}
