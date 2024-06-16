using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformY : MonoBehaviour
{
    public float speed = 2;
    public bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Press X to Move Up
        /*if (Input.GetKey(KeyCode.X))
        {
            moveUp();
        }*/
    
    }


    //Collision
    /*private void OnCollisionEnter(Collision collision)
    {
        //If ray collides & X is pressed, moveUp
        if (collision.gameObject.tag == "ray")
        {
            if (Input.GetKey(KeyCode.X))
            {
                moveUp();
            }
        }
    }*/


    //FXN References

    //Move Up fxn
    public void moveUp()
    {
        isMoving = true;

        if (isMoving == true)
        {
            Debug.Log("Moving Up");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

    }

    public void stopMoving() {
        isMoving = false;
        if (isMoving == false) {
            Debug.Log("Stops Moving");
            transform.Translate(Vector3.up * 0 * Time.deltaTime);
        }
    }

    //Stop Moving


    //Disable Ouline.cs
        public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
    }
}
  
