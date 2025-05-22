using UnityEngine;

public class ColonnSpawner : MonoBehaviour
{
    public GameObject Colonn;
    public float Timer = 0;
    public float spawn_gap = 2;
    public float spawn_offset = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawn_gap)
        {
            Timer += Time.deltaTime;
        }else
        {
            float lowestPos = transform.position.y - spawn_offset;
            float highestPos = transform.position.y + spawn_offset;
            Instantiate(Colonn, new Vector3(transform.position.x, Random.Range(lowestPos, highestPos), 0), transform.rotation);
            Timer = 0;
        }
    }
}
