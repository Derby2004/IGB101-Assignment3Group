using UnityEngine;

public class SoundTrigger: MonoBehaviour
{
    public AudioSource audioSource;
    
    public void PlaySound()
    {
        audioSource.Play();
    }
}
