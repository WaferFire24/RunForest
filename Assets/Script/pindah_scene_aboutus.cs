using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pindah_scene_aboutus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void exit()
    {
        Application.Quit();
    }

    public void back(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
