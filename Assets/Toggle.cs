﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

    // Not relevant for the sample repro
    public void TestToggle()
    {
        GameObject.Find("InputField").GetComponent<KeyboardTests>().DeselectForReal();
    }
}
