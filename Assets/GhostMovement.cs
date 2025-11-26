using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (agent.remainingDistance <= 1.0f)
        {
            float x = Random.range(-20.0f,20.0f);
            float z =Random.range(-20.0f,20.0f);

            agent.destination = new Vector3(x,0.0f,z);
        }
    }
}
