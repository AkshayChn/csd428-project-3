using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    public GameObject Rotobj; 
    public GameObject Player;
    public GameObject RoomObj;
    
        
    public void rotLeft(){
        Rotobj.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        //Player.transform.position = new Vector3(14, -2, 0);
        Player.transform.position = RoomObj.transform.position; 
    }
    
    public void rotRight(){
        Rotobj.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);
//Player.transform.position = new Vector3(14, -2, 0);
        Player.transform.position = RoomObj.transform.position; 
    }
    
    public void rotUp(){
        Rotobj.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
//Player.transform.position = new Vector3(14, -2, 0);
        Player.transform.position = RoomObj.transform.position; 
    }
    
    public void rotDown(){
        Rotobj.transform.Rotate(180.0f, 0.0f, 0.0f, Space.Self);
//Player.transform.position = new Vector3(14, -2, 0);
        Player.transform.position = RoomObj.transform.position; 
    }
}
