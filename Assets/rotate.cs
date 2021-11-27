using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    public GameObject Rotobj; 
    public GameObject Player;
    public GameObject RoomObj;
    
    



      
    public void rotLeft(){
        //Player.transform.position = RoomObj.transform.position; 
        Rotobj.transform.Rotate(10.0f, 0.0f, 0.0f, Space.Self);
        //Player.transform.position = new Vector3(14, -2, 0);
        
    }
    
    public void rotRight(){
        //Player.transform.position = RoomObj.transform.position;
        Rotobj.transform.Rotate(-10.0f, 0.0f, 0.0f, Space.Self);
//Player.transform.position = new Vector3(14, -2, 0);
         
    }
    
    public void rotUp(){
        Player.transform.position = RoomObj.transform.position; 
        Rotobj.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
//Player.transform.position = new Vector3(14, -2, 0);
        
    }
    
    public void rotDown(){
        Player.transform.position = RoomObj.transform.position; 
        Rotobj.transform.Rotate(180.0f, 0.0f, 0.0f, Space.Self);
//Player.transform.position = new Vector3(14, -2, 0);
        
    }
}
