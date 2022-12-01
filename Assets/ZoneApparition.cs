using UnityEngine;

public class ZoneApparition : MonoBehaviour
{
    private float nextactiontime = 0.0f;
    public float period = 1.5f;
    [SerializeField]
    private GameObject package;

    [SerializeField]
    private Transform[] spawnPoints;

    void Update()
    {
        if (Time.time > nextactiontime )
        {
            nextactiontime += period;
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            GameObject instantiated = Instantiate(package);
            instantiated.transform.position = randomPoint.position;
        }
        
    }
}
