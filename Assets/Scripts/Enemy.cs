using System.Collections;
using UnityEngine;
using UnityEngine.AI; 

public class Enemy : LivingEntity {
    public LayerMask whatIsTarget; 

    private LivingEntity targetEntity; 
    private NavMeshAgent pathFinder; 

    public ParticleSystem hitEffect; 
    public AudioClip deathSound; 
    public AudioClip hitSound; 

    private Animator enemyAnimator; 
    private AudioSource enemyAudioPlayer; 
    private Renderer enemyRenderer; 

    public float damage = 20f; 
    public float timeBetAttack = 0.5f; 
    private float lastAttackTime; 

    private bool hasTarget
    {
        get
        {
            if (targetEntity != null && !targetEntity.dead)
            {
                return true;
            }

            return false;
        }
    }

    private void Awake() {

    }

    public void Setup(float newHealth, float newDamage, float newSpeed, Color skinColor) {
    }

    private void Start() {
        StartCoroutine(UpdatePath());
    }

    private void Update() {
        enemyAnimator.SetBool("HasTarget", hasTarget);
    }

    private IEnumerator UpdatePath() {
        while (!dead)
        {
            yield return new WaitForSeconds(0.25f);
        }
    }

    public override void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal) {
        base.OnDamage(damage, hitPoint, hitNormal);
    }

    public override void Die() {
        base.Die();
    }

    private void OnTriggerStay(Collider other) {

    }
}