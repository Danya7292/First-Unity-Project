using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    public float mult;
    private void OnTriggerEnter(Collider other) {
        other.GetComponent<Jump>().jumpStrength *= mult;
    }

    private void OnTriggerExit(Collider other) {
        other.GetComponent<Jump>().jumpStrength /= mult;
    }
}
