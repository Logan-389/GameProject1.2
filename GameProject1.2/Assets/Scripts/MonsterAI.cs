using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    

    NavMeshAgent agent;

    GameObject player;

    GameObject monsterHouse;

    private bool hunting;

    IEnumerator activeHuntCycle = null;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        monsterHouse = GameObject.Find("MonsterHouse");
        StartHuntCycle();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Debug.Log(hunting);

        if (hunting == true)
        {
            agent.destination = player.transform.position;
        }

    }

    IEnumerator HuntCycle()
    {
        while (true)
        {
            hunting = false;
<<<<<<< HEAD
            randTime = Random.Range(30, 120);
        } else if (randTime <= 0.0f && hunting == false)
        {
            hunting = true;
            randTime = Random.Range(30, 100);
=======
            agent.destination = monsterHouse.transform.position;
            yield return new WaitForSeconds(Random.Range(10, 60));
            hunting = true;
            yield return new WaitForSeconds(Random.Range(10, 60));
>>>>>>> 542de1b855b60a268597b020119d05366b1b199e
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
        agent.destination = monsterHouse.transform.position;
    }

}
