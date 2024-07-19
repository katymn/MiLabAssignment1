using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.FilePathAttribute;

public class terrainTeleport : MonoBehaviour
{
    [SerializeField] GameObject ray;

    Vector3 rayLocation;

    void Update()
    {
        rayLocation = ray.transform.position + new Vector3(0, 5, 0);

        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            gameObject.transform.position = rayLocation;
        }
    }
}
