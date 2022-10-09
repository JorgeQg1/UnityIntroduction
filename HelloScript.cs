using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindWithTag("Terrain")) {
            Debug.Log("Terrain says Hello");
        } 
        
        if (GameObject.FindWithTag("MainCamera")) {
            Debug.Log("MainCamera says Hello");
        } 
        
        if (GameObject.FindWithTag("Light")) {
            Debug.Log("Light says Hello");
        } 
        
        if (GameObject.FindWithTag("WindZone")) {
            Debug.Log("WindZone says Hello");
        } 
        
        if (GameObject.FindWithTag("Wall")) {
            Debug.Log("Wall says Hello");
        } 
        
        if (GameObject.FindWithTag("House")) {
            Debug.Log("House says Hello");
        } 
        
        if (GameObject.FindWithTag("Barrels")) {
            Debug.Log("Barrels says Hello");
        } 
        
        if (GameObject.FindWithTag("Sphere")) {
            Debug.Log("Sphere says Hello");
        } 
        
        if (GameObject.FindWithTag("Tree")) {
            Debug.Log("Tree says Hello");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
