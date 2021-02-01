using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(30,4,-5);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
