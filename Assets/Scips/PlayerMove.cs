using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Lấy input 2 trục
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Vector di chuyển
        Vector3 moveDir = new Vector3(moveX, 0f, moveZ);

        // Normalize để không chạy nhanh hơn khi đi chéo
        if (moveDir.magnitude > 1f)
            moveDir.Normalize();

        // Di chuyển
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }
}
