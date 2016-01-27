using UnityEngine;
using System.Collections;

public class GuardPatrol : MonoBehaviour {

    public float moveSpeed = 6;

    public Vector3 cornerA = new Vector3(0, 0, 0);
    public Vector3 cornerB = new Vector3(0, 0, 0);

    Rigidbody rigidbody;
    Camera viewCamera;
    Vector3 velocity;
    Vector3 target;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        viewCamera = Camera.main;
        target = RandomPositionInRectangle();
    }

    void FixedUpdate() {
        float distanceToTarget = Vector3.Distance(transform.position, target);
        if(distanceToTarget > 1f) {
            float step = moveSpeed * Time.fixedDeltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
            transform.LookAt(target + Vector3.up * transform.position.y);
        } else {
            target = RandomPositionInRectangle();
        }
    }

    Vector3 RandomPositionInRectangle() {
        Vector3 result = new Vector3(Random.Range(cornerA.x, cornerB.x), Random.Range(cornerA.y, cornerB.y), Random.Range(cornerA.z, cornerB.z));
        Debug.Log(result);
        return result;
    }
}
