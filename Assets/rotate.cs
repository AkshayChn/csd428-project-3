using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    public GameObject Rotobj; 
    
        
    public void rotLeft(){
        Rotobj.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }
    
    public void rotRight(){
        Rotobj.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);
    }
    
    public void rotUp(){
        Rotobj.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
    }
    
    public void rotDown(){
        Rotobj.transform.Rotate(180.0f, 0.0f, 0.0f, Space.Self);
    }
}
