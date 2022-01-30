using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticiles;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Ground"){
            dustParticiles.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag=="Ground"){
            dustParticiles.Stop();
        }
    }
}
