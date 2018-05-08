using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoryPoints : MonoBehaviour
{
    private AudioSource voice;
    private bool hasTriggered = false;
    private FinishChecker exitObject;
    private int count;
    private StoryPointManager manager;
    private bool lockOut = false;
    
    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<StoryPointManager>();
        voice = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(lockOut == true)
        {
            if(!voice.isPlaying)
            {
                lockOut = false;
                manager.Release();
            }
        }
    }

    void OnTriggerEnter()
    {
        if(hasTriggered == false)
        {
            hasTriggered = true;
            FinishChecker.pointsGot++;
            this.GetComponentInChildren<ParticleSystem>().Stop();

            voice.Play();
            FindObjectOfType<DayNightCycle>().Rotate();
            Destroy(GetComponent<MeshRenderer>());
            manager.LockOut();
            lockOut = true;
        }
    }
}