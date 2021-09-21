using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public PlayerController PlayerScript;

    public GameObject Pipes;

    public float height;

    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!PlayerScript.isDead)
        {
            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
