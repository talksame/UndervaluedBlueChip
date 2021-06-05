using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeLevelBack : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelScene()
    {
        GameObject.Find("ADmon").GetComponent<AdmobInterstitialScript>().show();
        SceneManager.LoadScene("LevelScene");
    }
}
