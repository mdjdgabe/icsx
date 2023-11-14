using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VaraRotate : MonoBehaviour
{
    public float rotationSpeed = 300f;
    public float hoverHeight = 0.1f;
    public float rotationStartPoint = 2f; // The point where rotation starts
    public float rotationDuration = 5f; // Duration of rotation after the start point
    public Vector3 rotationCenter = new Vector3(0f, 0f, 0f); // The center to rotate around

    private float rotationTimer;
    private bool isRotating;

    private void OnMouseOver()
    {
         Debug.Log("Mouse over");
        // Code to execute while the pointer is over the area
        RotateImage();
        MoveImage();
    }

    private void RotateImage()

    {

        Debug.Log("RotateImage");
        if (transform.position.x > rotationStartPoint && !isRotating)
        {
            // Start rotating after reaching the rotation start point
            isRotating = true;
            rotationTimer = 0f;
        }

        if (isRotating && rotationTimer < rotationDuration)
        {
            // Rotate the image around a specified point during the specified duration
            transform.RotateAround(rotationCenter, Vector3.up, rotationSpeed * Time.deltaTime);
            rotationTimer += Time.deltaTime;
        }
        else
        {
            // Stop rotating after the specified duration
            isRotating = false;

            // Check if the rotation has ended, then start the coroutine to change the scene after 2 seconds
            if (rotationTimer >= rotationDuration)
            {
                StartCoroutine(ChangeSceneAfterDelay(2f));
            }
        }
    }

    private void MoveImage()
    {
        // Move the image up and down while the pointer is over
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) * hoverHeight, transform.position.z);
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {

        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(delay);

        // Change the scene after the specified delay
        SceneManager.LoadScene("island3_1");
    }
}