using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInfinite : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelInfinite()
    {
        SceneManager.LoadScene("GameLevelinf");
    }
}
