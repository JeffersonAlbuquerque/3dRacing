using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDown : MonoBehaviour
{
    public GameObject door;
    public float speed;
    private Vector3 direction;
    private Vector3 positionNow;
    public float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        positionNow = door.transform.position;
        direction = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        door.transform.position += direction * speed * Time.deltaTime;
        float distance = Vector3.Distance(positionNow, transform.position);

        if (distance >= maxDistance)
        {
            direction *= -1;
            positionNow = transform.position;
        }

    }
}
