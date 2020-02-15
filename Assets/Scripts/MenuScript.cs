using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    
    void Start()
    {
        Time.timeScale = 0;        
    }

    public void OnClick()
    {
        Time.timeScale = 1;
    }

  
}
