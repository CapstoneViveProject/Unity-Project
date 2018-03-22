using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorWall : MonoBehaviour
{
    private ObstacleCourseSetup OCS;

    void Start()
    {
        OCS = GetComponentInParent<ObstacleCourseSetup>();
    }
    void OnCollisionEnter(Collision collision)
    {
        OCS.errors++;
    }
}
