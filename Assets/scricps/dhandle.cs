using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dhandle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.name;
        Debug.Log(message:"1=>"+this.transform.name);
        Debug.Log(message:"1=>"+this.transform.parent.name);
        Debug.Log(message:"1=>"+this.transform.parent.parent.name);

        GameObject a = this.transform.parent.parent.gameObject;

        int childCount = a.transform.childCount;
        Debug.Log(a.transform.childCount);
        for (int i = 0; i < childCount; i++)
        {
           string name =a.transform.GetChild(i).name;
           switch (name)
           {
               case"b":
                   break;
               case "c":
                   Debug.Log(message:"123123");
                   break;
           }
           
        }

        this.transform.parent = a.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
