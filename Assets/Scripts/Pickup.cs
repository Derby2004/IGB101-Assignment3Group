using UnityEngine;


public class Pickup : MonoBehaviour
{
    GameManager gameManager;
    public AudioClip pickupSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }
}
