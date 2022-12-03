using UnityEngine;

public class ZoneApparition : MonoBehaviour
{
    private float nextactiontime = 0.0f;
    public float period = 3.0f;

    [SerializeField]
    private GameObject package;

    [SerializeField]
    private GameObject rouge;

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

                Transform randomPoint2 = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject instantiated2 = Instantiate(rouge);
                instantiated2.transform.position = randomPoint2.position;
        }
        
    }
}
