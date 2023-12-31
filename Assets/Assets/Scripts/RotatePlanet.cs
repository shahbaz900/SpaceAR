using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public GameObject Planet;
    public Vector3 RotatePlanet1;

    // Update is called once per frame
    void Update()
    {
        Planet.transform.Rotate(RotatePlanet1 * Time.deltaTime);
    }
}
