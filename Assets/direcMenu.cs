using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direcMenu : MonoBehaviour
{
    public GameObject menu2;
    
    // Start is called before the first frame update
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void pullupMenu(){
        if (menu2.active == true){
            menu2.active = false;
        }
        else{
            menu2.active = true;
        }
    }
}
