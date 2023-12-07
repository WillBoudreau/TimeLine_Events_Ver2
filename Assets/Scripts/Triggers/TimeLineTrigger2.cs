using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger1 : MonoBehaviour
{
    [Header("TimeLine Events For the First Event")]
    [SerializeField] private PlayableDirector TimeLineEvent1;
    // Start is called before the first frame update
    void Start()
    {
        TimeLineEvent1.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        TimeLineEvent1.Play();
    }
}
