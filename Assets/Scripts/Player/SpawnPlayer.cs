using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    private static GameObject goCheckpoints;
    private static Vector3 spawnPoint;
    private static float verticallyTooLow;

    void Awake()
    {
        goCheckpoints = GameObject.Find("Checkpoints");
        spawnPoint = goCheckpoints.transform.GetChild(0).position;
    }

    void Start()
    {
        verticallyTooLow = -10f;
    }

    void FixedUpdate()
    {
        if (transform.position.y < verticallyTooLow)
            transform.position = spawnPoint;
    }
}
