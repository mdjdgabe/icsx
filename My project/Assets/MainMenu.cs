using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public string scene1Name = "island1"; // Replace with the name of your first scene
public string scene2Name = "island1_1"; // Replace with the name of your second scene
public string scene3Name = "island2memorygame";
public string scene4Name = "island2slidingpuzzle";



     public void LoadRandomScene()
    {
        // Generate a random number (0 or 1) to select between scene1 and scene2
        int randomIndex = Random.Range(0, 2);

        // Load the selected scene
        string sceneToLoad = (randomIndex == 0) ? scene1Name : scene2Name;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Island2()
    {
        // Change the scene when the asset is clicked
        //SceneManager.LoadScene("island2memorygame");

        // Generate a random number (0 or 1) to select between scene1 and scene2
        int randomIndex = Random.Range(0, 2);

        // Load the selected scene
        string sceneToLoad = (randomIndex == 0) ? scene3Name : scene4Name;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Island3()
    {
        // Change the scene when the asset is clicked
        SceneManager.LoadScene("island3_1");
    }

    public void SolIcon(){
        SceneManager.LoadScene("solscene");
        
    }
}


