using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
   const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]

    Transform hourPivot, minutePivot, secondPivot;

    void Update()
    {
        DateTime time = DateTime.Now; 
        
        Debug.Log(DateTime.Now.Hour);

        hourPivot.localRotation = 
        Quaternion.Euler(0f, 0f, hoursToDegrees * DateTime.Now.Hour);

        minutePivot.localRotation = 
        Quaternion.Euler(0f, 0f, minutesToDegrees * DateTime.Now.Minute);

        secondPivot.localRotation =
         Quaternion.Euler(0f, 0f, secondsToDegrees * DateTime.Now.Second);
    }
}
