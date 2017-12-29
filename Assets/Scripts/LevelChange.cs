using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        Scene currentScene = SceneManager.GetActiveScene();
        int lvlNum = 0;
        int.TryParse(currentScene.name.Split(' ')[1], out lvlNum);
        SceneManager.LoadScene("Level " + (lvlNum+1));
    }
}
