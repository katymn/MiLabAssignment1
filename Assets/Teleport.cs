using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    //Teleport Points
        [SerializeField] GameObject TP1;
        [SerializeField] GameObject TP2;

    //Variables for teleport location
        Vector3 TP1Location;
        Vector3 TP2Location;


    void Start()
    {
        //Set location as teleport points' locations
            TP1Location = TP1.transform.position + new Vector3(5, 5, 0);
            TP2Location = TP2.transform.position + new Vector3(5, 5, 0);
    }

    //Teleport

    //Specific Teleportation fxns
        public void tP1()
        {
            removeSpheres(TP1);
            teleportPlayer(TP1Location);
            addSpheres(TP2);
        }

        public void tP2()
        {
            removeSpheres(TP2);
            teleportPlayer(TP2Location);
            addSpheres(TP1);
        }

    //General Teleportation fxns
        public void teleportPlayer(Vector3 tPLocation)
        {
            gameObject.transform.position = tPLocation;
        }

        public void removeSpheres(GameObject TP)
        {
            TP.SetActive(false);
        }

        public void addSpheres(GameObject TP)
        {
            TP.SetActive(true);
        }

        /*public void stopVelocity()
        {
            gameObject.trans
        }*/

}
