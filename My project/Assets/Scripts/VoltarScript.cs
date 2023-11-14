using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarScript : MonoBehaviour
{
    void OnMouseDown()
    {
        // Change the scene when the asset is clicked
        SceneManager.LoadScene("SampleScene");
    }
}
