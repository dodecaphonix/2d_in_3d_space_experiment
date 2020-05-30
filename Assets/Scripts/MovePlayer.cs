using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public float speed = 30;

	void FixedUpdate() {
        float verticalPress = Input.GetAxisRaw ("Vertical");
        float horizontalPress = Input.GetAxisRaw ("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalPress, 0, verticalPress) * speed;
	}

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}
}
