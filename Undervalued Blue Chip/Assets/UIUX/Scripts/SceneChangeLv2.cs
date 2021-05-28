using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeLv2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
}
