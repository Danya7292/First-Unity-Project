using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private int health = 100;
    private int level = 1;
    private float speed = 2;

    void Start()
    {
        health += level;
        print("Здоровье NPC: " + health);
    }

   
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
