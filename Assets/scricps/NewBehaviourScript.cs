using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Button btnGo;
    public Image img;
   

    private void Awake()
    {
        btnGo.onClick.AddListener(OnBtnGoClick);
    }
    
    

    void Start(){}


    // Update is called once per frame
    void Update(){}

    

    public void OnBtnGoClick()
    {
        Debug.Log(message:"omg!!!");
        img.color = new Color(r: 80, g: 50, b : 20);
    }
  
    
    
    
}
