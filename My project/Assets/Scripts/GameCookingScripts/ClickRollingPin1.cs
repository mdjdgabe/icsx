using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickRollingPin1 : MonoBehaviour
{
    void OnMouseDown()
    {
        // Change the scene when the asset is clicked
        SceneManager.LoadScene("island3_8_2");
    }
}

