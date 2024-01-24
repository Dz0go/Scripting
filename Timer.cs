using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
    
{
    private int min;
    private float sec;
    private Text textObject;

    // Update is called once per frame
    void Update()
    {
        

        sec -= Time.deltaTime;
        
        if (sec <= 0)
        {
            if (min > 0)
            {
                sec += 59;
                min --;

            }
            else
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

                void RestartLevel()
                {
                    Scene currentScene = SceneManager.GetActiveScene();
                    SceneManager.LoadScene(currentScene.buildIndex);
                }
            }
        }
        int roundSeconds = Mathf.RoundToInt(sec);
        textObject.text = min.ToString() + ":" + roundSeconds.ToString();
    }
}
