using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateDestroyer : MonoBehaviour
{//This entire script was done by Armando

    public GameObject brokenEffect;
    public GameObject healthPickUp;
    public AudioClip brokenSound;

    Animator animator;
    AudioSource audioSource;
    BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Hit()
    {
        animator.SetTrigger("Broken");
        Instantiate(healthPickUp, transform.position, Quaternion.identity);
        Instantiate(brokenEffect, transform.position, Quaternion.identity);     
        PlaySound(brokenSound);
        Destroy(bc);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
