using UnityEngine;
using UnityEngine.UI; 

public class PlayerHealth : LivingEntity {
    public Slider healthSlider; 

    public AudioClip deathClip; 
    public AudioClip hitClip; 
    public AudioClip itemPickupClip; 

    private AudioSource playerAudioPlayer; 
    private Animator playerAnimator; 

    private PlayerMovement playerMovement; 
    private PlayerShooter playerShooter; 

    private void Awake() {

    }

    protected override void OnEnable() {
        base.OnEnable();
    }

    public override void RestoreHealth(float newHealth) {
        base.RestoreHealth(newHealth);
    }

    public override void OnDamage(float damage, Vector3 hitPoint, Vector3 hitDirection) {
        base.OnDamage(damage, hitPoint, hitDirection);
    }

    public override void Die() {
        base.Die();
    }

    private void OnTriggerEnter(Collider other) {

    }
}