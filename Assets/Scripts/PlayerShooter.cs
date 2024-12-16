using UnityEngine;

public class PlayerShooter : MonoBehaviour {
    public Gun gun; 
    public Transform gunPivot; 
    public Transform leftHandMount; 
    public Transform rightHandMount; 

    private PlayerInput playerInput; 
    private Animator playerAnimator; 

    private void Start() {
        playerInput = GetComponent<PlayerInput>();
        playerAnimator = GetComponent<Animator>();
    }

    private void OnEnable() {
        gun.gameObject.SetActive(true);
    }
    
    private void OnDisable() {
        gun.gameObject.SetActive(false);
    }

    private void Update() {

    }

    private void UpdateUI() {
        if (gun != null && UIManager.instance != null)
        {
            UIManager.instance.UpdateAmmoText(gun.magAmmo, gun.ammoRemain);
        }
    }

    private void OnAnimatorIK(int layerIndex) {
        
    }
}