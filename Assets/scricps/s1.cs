using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int childCount=this.transform.childCount;
        Debug.Log(childCount);

        for (int j = 0; j < childCount; j++)
        {
            Transform temp = this.transform.GetChild(j);
            Debug.Log(temp.name);
            if (temp.name == "Main Camera")
            {
               Camera c = temp.GetComponent<Camera>();
               c.fieldOfView = 120;
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
