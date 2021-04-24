using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float movementSpeed = 10f;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] float projectileSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Fire();
    }

    public void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        }
    }

    private void Movement()
    {   //create movement and fps independent
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        //set boundaries of movement
        float newXPos = Mathf.Clamp(transform.position.x + deltaX, -6.1f, 6.1f);
        float newYPos = Mathf.Clamp(transform.position.y + deltaY, -8.6f, 8.6f);

        transform.position = new Vector2(newXPos, newYPos);
    }
}
