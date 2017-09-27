using UnityEngine;
using System.Collections;

public class ChaseCamera : MonoBehaviour {

    public float speed = 20f;
    GameObject hand;
    // Update is called once per frame
    void Update () {
        hand = GameObject.Find("Car");
        this.transform.position = new Vector3(hand.transform.position.x + (speed * Time.smoothDeltaTime), hand.transform.position.y, transform.position.z);
	}
}
