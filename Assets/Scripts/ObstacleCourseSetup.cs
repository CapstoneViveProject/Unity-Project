using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCourseSetup : MonoBehaviour
{
    public int errors;
    public float timer = 0;

    public bool startLine = true;
    public bool finishLine = false;
    private void FixedUpdate()
    {
        if(finishLine)
        {

        }
        else if(!startLine && !finishLine)
        {
            timer += Time.deltaTime;
        }
    }
}
