using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float movementSpeed = 10f;

    float xMin;
    float xMax;

    // Start is called before the first frame update
    void Start()
    {
        // SetUpNewBoundary();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {   //create movement and fps independent
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        //set boundaries of movement
        float newXPos = Mathf.Clamp(transform.position.x + deltaX, -6.2f, 6.2f);
        float newYPos = Mathf.Clamp(transform.position.y + deltaX, -8.6f, 8.6f);

        transform.position = new Vector2(newXPos, newYPos);
    }

    // private void SetUpNewBoundary()
    // {
    //     Camera gameCamera = Camera.main;
    //     xMin = gameCamera.ViewportToScreenPoint(new Vector3(0, 0, 0)).x;
    //     xMax = gameCamera.ViewportToScreenPoint(new Vector3(1, 0, 0)).x;
    // }
}
