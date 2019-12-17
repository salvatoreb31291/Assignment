using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Music : MonoBehaviour
{
    public AudioSource MusicSource;
    // Start is called before the first frame update
    // Singleton instance.
	public static Music Instance = null;
	
	// Initialize the singleton instance.
	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}

		else if (Instance != this)
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}
    	public void PlayMusic(AudioClip clip)
	{
		MusicSource.clip = clip;
		MusicSource.Play();
	}
}
