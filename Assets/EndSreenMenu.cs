using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSreenMenu : MonoBehaviour
{
    public void Restart(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }

    public void ToMain(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }
}
