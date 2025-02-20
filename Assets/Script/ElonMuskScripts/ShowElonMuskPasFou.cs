using UnityEngine;

public class ShowElonMuskPasFou : MonoBehaviour
{
    public GameObject elonImage;  
    private AudioSource audioSource;  

    public AudioClip[] elonSounds; // Tableau des sons

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            bool isActive = !elonImage.activeSelf;
            elonImage.SetActive(isActive); 

            if (isActive && elonSounds.Length > 0) 
            {
                int randomIndex = Random.Range(0, elonSounds.Length); // Choix aléatoire
                audioSource.clip = elonSounds[randomIndex]; // Assigne le son choisi
                audioSource.Play(); 
            }
        }
    }
}