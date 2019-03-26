using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rigidbody;

    private void Start () {
        rigidbody = GetComponent<Rigidbody> ();
    }

    private void FixedUpdate () {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);
        rigidbody.AddForce (speed * movement);
    }

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Pick Up")) {
            other.gameObject.SetActive (false);
        }

    }

}
