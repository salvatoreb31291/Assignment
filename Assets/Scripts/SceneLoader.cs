using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public AudioClip background2;
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex==0){
        SceneManager.LoadScene(currentSceneIndex + 1);
        }
        if(currentSceneIndex==1){
        SceneManager.LoadScene(3);
        }
    }
 

    void Start() {
            Music.Instance.PlayMusic(background2);
    }
}
