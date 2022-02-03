using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    

    NavMeshAgent agent;

    GameObject player;

    public Transform homePoint;

    private bool hunting;

    IEnumerator activeHuntCycle = null;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        StartHuntCycle();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (hunting == true)
        {
            agent.destination = player.transform.position;
        }

    }

    void OnDisable() {
        StopAllCoroutines();
    }

    IEnumerator HuntCycle()
    {
        while (true)
        {
            hunting = false;
            agent.destination = homePoint.position;
            yield return new WaitForSeconds(Random.Range(10, 60));
            hunting = true;
            yield return new WaitForSeconds(Random.Range(10, 180));
        }
    }


    public void StartHuntCycle()
    {
        Debug.Log("Starting Hunt Cycle");
        activeHuntCycle = HuntCycle();
        StartCoroutine(activeHuntCycle);
    }

    public void StopHuntCycle()
    {
        Debug.Log("Stoping Hunt Cycle");
        if (activeHuntCycle != null)
        {
            StopCoroutine(activeHuntCycle);
        }
        activeHuntCycle = null;
        hunting = false;
        agent.destination = homePoint.position;
    }

}
