using UnityEngine;
using System.Collections;

public class BonusWordMove : MonoBehaviour {

    public wordManager wordManager;
    public float moveSpeed;
    
    
   
    public float t;
    Vector3 startPosition;
    Vector3 target;
    float timeToReachTarget;
    public Transform targetpos;
    public bool isTargetreached=false;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;

        SetDestination(targetpos.position, 11f);
    }
	
	// Update is called once per frame
	void Update () {
        if (wordManager.isbonusWordSpawned == true)
        {
            if (t<=1)
            {
                t += Time.deltaTime / timeToReachTarget;
                transform.position = Vector3.Lerp(startPosition, target, t);

            }
            else
            {
                isTargetreached = true;
                wordManager.isbonusWordSpawned = false;
                transform.position = startPosition;
                t = 0;
            }




        }
       
      
       
    }

    public void SetDestination(Vector3 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        target = destination;
    }

    //public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    //{
    //    var currentPos = transform.position;
    //    var t = 0f;
    //    while (t < 1)
    //    {
    //        t += Time.deltaTime / timeToMove;
    //        transform.position = Vector3.Lerp(currentPos, position, t);
    //        yield return null;
    //    }
    //}
}
