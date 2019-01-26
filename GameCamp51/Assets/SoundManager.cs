using UnityEngine;

public class SoundManager : MonoBehaviour{
     public AudioSource audio;

     void Update(){
          if (Input.GetMouseButtonDown(0)){
               audio.PlayOneShot(audio.clip);
          }
     }
}