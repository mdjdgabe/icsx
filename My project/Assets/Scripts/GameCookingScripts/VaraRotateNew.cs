using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VaraRotateNew : MonoBehaviour
{
    private bool isHovered = false;
    private float hoverTimer = 0f;
    private float moveSpeed = 2f; // Adjust the speed as needed
    private float movementDuration = 6f; // Time in seconds for the movement
    private float sceneChangeDelay = 2f; // Time in seconds before changing scene

    void Update()
    {
        if (isHovered)
        {
            MoveUpDown();

            hoverTimer += Time.deltaTime;

            if (hoverTimer >= movementDuration)
            {
                isHovered = false;

                // Invoke the scene change function after a delay
                Invoke("ChangeScene", sceneChangeDelay);
            }
        }
    }

    void MoveUpDown()
    {
        // Adjust the Y position based on sine function for up and down movement
        float newY = Mathf.Sin(Time.time * moveSpeed) * 0.2f; // You can adjust the amplitude by changing the multiplier

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    void ChangeScene()
    {
        // Change the scene using the SceneManager
        SceneManager.LoadScene("island3_8_1"); // Replace "YourSceneName" with the actual scene name
    }

    void OnMouseEnter()
    {
        isHovered = true;
        hoverTimer = 0f;
    }

    void OnMouseExit()
    {
        isHovered = false;
    }
}
