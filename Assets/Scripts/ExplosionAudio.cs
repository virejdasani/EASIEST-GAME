using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private int n;

    void Start()
    {
        n = 0;
    }

    void Update()
    {
        if (n == 0 && (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 || Input.GetMouseButtonDown(0)))
        {
            source.PlayOneShot(clip);
            n += 1;
        }
    }
}
