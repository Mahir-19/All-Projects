﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TwitchChooseClass : MonoBehaviour
{
    public void OnCall()
    {
        SceneManager.LoadScene(3);
    }
}
