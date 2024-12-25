using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    private void Start()
    {
        LeanTween.rotateAround(transform.gameObject,Vector3.up, 360, 2f)
            .setLoopClamp();
        LeanTween.move(transform.gameObject, transform.position + Vector3.down * 0.2f, 1f)
            .setLoopPingPong();
    }
}
