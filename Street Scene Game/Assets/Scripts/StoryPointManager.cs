using UnityEngine;
using System.Collections;

public class StoryPointManager : MonoBehaviour 
{
    
    public GameObject[] points;
    private int currIndex = 0;

    public void LockOut()
    {
        currIndex++;

        for (int index = currIndex; index < points.Length; index++)
        {
            points[index].GetComponent<Collider>().enabled = false;
        } 
    }

    public void Release()
    {
        for (int index = currIndex; index < points.Length; index++)
        {
            points[index].GetComponent<Collider>().enabled = true;
        } 
    }
}