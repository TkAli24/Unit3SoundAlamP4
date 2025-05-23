using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float leftBond = -15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            if (playerControllerScript.doubleSpeed)
            { 
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2)); 
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
               
       if (transform.position.x < leftBond && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
