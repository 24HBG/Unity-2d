using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageClip;
    [SerializeField][Range(0f, 1f)] float damageVolume = 1f;

    static AudioPlayer instance;


    void Awake()
    {
        ManagerSingleton();
    }

    void ManagerSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void PlayShootingClip()
    {
        playClip(shootingClip, shootingVolume);
    }

    public void PlayDamageClip()
    {
        playClip(damageClip, damageVolume);
    }

    void playClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPs = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPs, volume);
        }
    }
}