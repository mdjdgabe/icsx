using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletedScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myItems;

    void Start()
    {
        pointsToWin = myItems.transform.childCount;
    }

    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            // WIN
            StartCoroutine(LoadNextSceneAfterDelay(2f)); // Load next scene after a delay of 2 seconds (adjust the time as needed)
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }

    IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        
        // Get the index of the currently active scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene in the build settings
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}