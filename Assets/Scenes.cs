using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void loadProject2(){
        SceneManager.LoadScene("Project2");
    }
    
    public void loadMego(){
        SceneManager.LoadScene("MegoPlayset_old");
    }
    
    public void loadGiant(){
        SceneManager.LoadScene("LandOfGiants");
    }
    
    public void loadDancing(){
        SceneManager.LoadScene("dancing");
    }
    
    //public void loadZero(){
    //    SceneManager.LoadScene("ZeroGravity");
    //}
}
