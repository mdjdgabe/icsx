using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickRollingPin3 : MonoBehaviour
{
    void OnMouseDown()
    {
        // Change the scene when the asset is clicked
        SceneManager.LoadScene("island3_9");
    }
}
