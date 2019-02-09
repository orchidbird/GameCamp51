using UnityEngine;

public class GameManager : MonoBehaviour{
    public TextManager TM;
    public GameObject Choice;
    public static int money;
    public static int friends;

    public enum SelectionType{Club}

    public void SetChoice(string yesText, string noText){
        Choice.gameObject.SetActive(true);
        /*var texts = Choice.GetComponentsInChildren<Text>();
        texts[0].text = yesText;
        texts[1].text = noText;*/
    }
    public void DoYes(){
        TM.ClubText.gameObject.SetActive(true);
        TM.ClubText.text = "동아리: 있음";
        GoNext();
    }
    public void DoNo(){
        TM.ClubText.gameObject.SetActive(true);
        TM.ClubText.text = "동아리: 없음";
        GoNext();
    }

    void GoNext(){
        TM.number++;
        Choice.gameObject.SetActive(false);
    }
}