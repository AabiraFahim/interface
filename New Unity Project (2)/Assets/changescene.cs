﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void movetoscene(int screenid)
    {
        SceneManager.LoadScene(screenid);
    }
}
