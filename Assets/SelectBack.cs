using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectBack : MonoBehaviour
{
    public void OceanBack(){
        //PlayerPrefs.SetInt("back",1);
        SceneManager.LoadScene("Ingame2");
    }
    public void MilkyBack(){
        //PlayerPrefs.SetInt("back",2);
        SceneManager.LoadScene("InGame");
    }
}
