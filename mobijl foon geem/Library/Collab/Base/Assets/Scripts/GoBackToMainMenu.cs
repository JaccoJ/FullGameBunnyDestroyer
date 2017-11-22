using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToMainMenu : MonoBehaviour {



    void Update()
    {
        if (Input.touchCount == 1 || Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel(0);
        }
    }
}
