﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDisplay : MonoBehaviour
{
    public GameObject MenuObject;
    
    // Start is called before the first frame update
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void pullupMenu(){
        if (MenuObject.active == true){
            MenuObject.active = false;
        }
        else{
            MenuObject.active = true;
        }
    }
}
