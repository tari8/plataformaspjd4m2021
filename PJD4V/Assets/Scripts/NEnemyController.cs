using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEnemyController : MonoBehaviour
{
    public float moveSpeed;

    [SerializeField] private float dirTime;

    private Vector2 walkDir;
    private float currentTime;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveDir();
        CountTime();
    }

    public void SetWalkDir(Vector2 dir)
    {
        walkDir = dir;
    }

    public void MoveDir()
    {
        transform.Translate(walkDir * Time.deltaTime);
    }

    public void CountTime()
    {
        if (currentTime <= dirTime)
        {
            currentTime += Time.deltaTime;
        }
        else
        {
            currentTime = 0;
        }
    }
}
