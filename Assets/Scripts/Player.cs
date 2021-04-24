using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        float newXPos = transform.position.x + deltaX;
        float newYPos = transform.position.y + deltaY;
        transform.position = new Vector2(newXPos, newYPos);
    }
}
