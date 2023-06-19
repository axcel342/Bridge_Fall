using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public Quaternion Camera_rotation;

    // Update is called once per frame
    void Update()
    {
        //Camera_rotation.x = 28.408f;
        //Camera_rotation.y = 180.283f;
        //Camera_rotation.x = -0.021f;

        transform.position = player.position + offset;
        //transform.rotation.eulerAngles();

       
    }
}
