using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpCounter = 0;
    private void OnCollisionEnter(Collision collision)
    {
        bumpCounter++;
        Debug.Log("You`ve bumped into something: " + Convert.ToString(bumpCounter) + " times");
    }
}
