using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform goalCoords;

    void OnTriggerExit(Collider other){
        other.transform.position = goalCoords.position;
}
}
