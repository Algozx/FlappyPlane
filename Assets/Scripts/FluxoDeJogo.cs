using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FluxoDeJogo : MonoBehaviour
{
    [SerializeField] GameObject gameover;

    public void GameOver(){
        Time.timeScale = 0;
        gameover.SetActive(true);
    }

    public void RestartJogo(){
        if(Time.timeScale == 0){
            SceneManager.LoadScene("AltasAventuras");
            Time.timeScale = 1;
        }
    }
}
