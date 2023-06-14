using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate =1f;

    public float minHeight =-1f;

    public float maxHeight = 1f;
    // Start is called before the first frame update
    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),spawnRate,spawnRate);
    }

    // Update is called once per frame
    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject icicle = Instantiate(prefab, transform.position,Quaternion.identity);
        icicle.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }
}
