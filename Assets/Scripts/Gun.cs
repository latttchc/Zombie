using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour {
    public enum State {
        Ready, 
        Empty, 
        Reloading 
    }

    public State state { get; private set; } 

    public Transform fireTransform; 

    public ParticleSystem muzzleFlashEffect; 
    public ParticleSystem shellEjectEffect; 

    private LineRenderer bulletLineRenderer; 

    private AudioSource gunAudioPlayer; 
    public AudioClip shotClip; 
    public AudioClip reloadClip; 

    public float damage = 25; 
    private float fireDistance = 50f; 

    public int ammoRemain = 100; 
    public int magCapacity = 25; 
    public int magAmmo; 


    public float timeBetFire = 0.12f; 
    public float reloadTime = 1.8f; 
    private float lastFireTime; 


    private void Awake() {

    }

    private void OnEnable() {

    }

    public void Fire() {

    }

    private void Shot() {
        
    }

    private IEnumerator ShotEffect(Vector3 hitPosition) {
        bulletLineRenderer.enabled = true;

        yield return new WaitForSeconds(0.03f);

        bulletLineRenderer.enabled = false;
    }

    public bool Reload() {
        return false;
    }

    private IEnumerator ReloadRoutine() {
        state = State.Reloading;
        
        yield return new WaitForSeconds(reloadTime);

        state = State.Ready;
    }
}