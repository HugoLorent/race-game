using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{

  [SerializeField]
  int speed;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    var kart = GetComponent<Rigidbody>();

    if (Input.GetKey(KeyCode.UpArrow))
    {
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
      transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
  }
}
