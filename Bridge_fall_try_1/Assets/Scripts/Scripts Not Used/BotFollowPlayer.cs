using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotFollowPlayer : MonoBehaviour
{
    public Transform Mainplayer;
    public GameObject trying;
    public Vector3 offset;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position = Mainplayer.position + offset;
    }
}
