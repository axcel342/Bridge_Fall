using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_fall : MonoBehaviour
{
    private IEnumerator coroutine;
    public float Time;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        coroutine =  bridge(Time);
        StartCoroutine(coroutine);
    }

    IEnumerator bridge(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        rb.isKinematic = false;

    }
}
