using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TextManager : MonoBehaviour{
    public GameManager GM;
    public Image Ending;
    public Text MainText;
    public Text MoneyText;
    public Text ClubText;
    public Text FriendText;
    public int number = 0;
    public bool randomDetermined;
    string[] lines;

    void Start(){
        randomDetermined = false;
        lines = Resources.Load<TextAsset>("Dialogues").text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    }

    void Update(){
        MoneyText.text = "돈: " + GameManager.money;
        if (Input.GetKeyDown(KeyCode.Return) && !GM.Choice.activeInHierarchy) {number++;}
        
        if (number >= lines.Length) return;
        var newString = lines[number];
        if (newString == "Money"){
            if(GameManager.money > 0) return;
            MoneyText.gameObject.SetActive(true);
            var random = Random.Range(0, 5);
            var money = 0;
            if (random == 0)
                money = 10000;
            else if(random == 1)
                money = 20000;
            else if(random == 2)
                money = 30000;
            else if(random == 3)
                money = 50000;
            else if(random == 4)
                money = 300000;
            MainText.text = "세뱃돈 " + money + "원을 받았다!";
            GameManager.money += money;
        }else if (newString.StartsWith("선택")){
            var choice = newString.Split('\t');
            GM.SetChoice(choice[1], choice[2]);
        }else if (newString.StartsWith("랜덤")){
            if (randomDetermined) return;
            randomDetermined = true;
            var random = Random.Range(1, 3);
            var texts = newString.Split('\t');
            MainText.text = texts[random];
            FriendText.gameObject.SetActive(true);
            if(random == 2)
            GameManager.friends++;
            FriendText.text = "친구: " + GameManager.friends;
        }else if (newString.StartsWith("친구")){
            var texts = newString.Split('\t');
            MainText.text = GameManager.friends > 0 ? texts[1] : texts[2];
        }else if (newString == "엔딩"){
            Ending.gameObject.SetActive(true);
            Ending.sprite = Resources.Load<Sprite>(GameManager.friends > 0 ? "Ending1" : "Ending2");
        }else if (newString == "종료"){
            SceneManager.LoadScene("Title");
        }else
            MainText.text = lines[number];
    }
}
