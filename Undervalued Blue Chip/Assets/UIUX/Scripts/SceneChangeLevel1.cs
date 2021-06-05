using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelOne()
    {
        SceneManager.LoadScene("GameLevelone");
    }
}
