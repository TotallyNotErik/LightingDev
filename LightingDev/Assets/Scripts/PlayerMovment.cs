using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed = 10f;

    private float vInput;
    private float sInput;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            sInput = -1f * moveSpeed;
        else if (Input.GetKey(KeyCode.D))
            sInput = 1f * moveSpeed;
        else
            sInput = 0;

        if (Input.GetKey(KeyCode.W))
            vInput = 1f * moveSpeed;
        else if (Input.GetKey(KeyCode.S))
            vInput = -1f * moveSpeed;
        else
            vInput = 0;

        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Translate(Vector3.right * sInput * Time.deltaTime);
    }
}
