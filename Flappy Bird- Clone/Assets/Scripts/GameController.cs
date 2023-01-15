using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform play;
    void Start()
    {
        Time.timeScale = 0;
    }
   public void ResetGame(){
    SceneManager.LoadScene("MainScene");
    Time.timeScale = 1;
   }
   public void StartGame(){
    play.gameObject.SetActive(false);
    Time.timeScale = 1;
   }
}
