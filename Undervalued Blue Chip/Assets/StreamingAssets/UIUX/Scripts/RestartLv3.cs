﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLv3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelThree()
    {
        SceneManager.LoadScene("GameLevelthree");
    }
}
