using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
  
    public void doquit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
