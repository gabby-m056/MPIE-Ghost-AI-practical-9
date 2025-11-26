using UnityEngine;

public class GhostMovement : MonoBehaviour
{

    enum GhostState
    {
        WANDERING,
        RETURN,
        CHASE,
        WIN
    }

    GhostState state = GhostState.WANDERING;
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        if (agent.remainingDistance <= 1.0f&&state == GhostState.WANDERING)
        {
            float x = Random.Range(-20.0f,20.0f);
            float z =Random.Range(-20.0f,20.0f);

            agent.destination = new Vector3(x,0.0f,z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Player")
        {
            state = GhostState.WIN;
            player = other.gameObject;
        }
    }
}
