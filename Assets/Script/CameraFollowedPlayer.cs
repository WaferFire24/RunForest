using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowedPlayer : MonoBehaviour
{
    public GameObject objectToFollow;
    public float camOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = Vector3.Lerp(this.transform.position, 
        new Vector3(objectToFollow.transform.position.x + camOffset, objectToFollow.transform.position.y, this.transform.position.z),
        300 * Time.deltaTime);
    }
}
