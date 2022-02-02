using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    
    NavMeshAgent agent;

    GameObject player;

    public float randTime;

    GameObject monsterHouse;

    private bool hunting;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        randTime = Random.Range(10, 60);
        monsterHouse = GameObject.Find("MonsterHouse");
        hunting = false;
        agent.destination = monsterHouse.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        randTime -= Time.deltaTime;
        Debug.Log(hunting);

        //update agent location
        if (hunting == false)
        {
            agent.destination = monsterHouse.transform.position;
        }
        else if (hunting == true)
        {
            agent.destination = player.transform.position;
        }

        //update if we are hunting or not
        if (randTime <= 0.0f && hunting == true)
        {
            hunting = false;
            randTime = Random.Range(30, 120);
        } else if (randTime <= 0.0f && hunting == false)
        {
            hunting = true;
            randTime = Random.Range(30, 100);
        }
    }
}
