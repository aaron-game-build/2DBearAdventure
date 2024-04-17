using UnityEngine;

namespace BearAdventure2D
{
    public class CollisionTest : MonoBehaviour
    {
        private Rigidbody2D rb2d;

        void Start()
        {
            // 获取Rigidbody 2D组件
            rb2d = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            // 水平和垂直移动
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // 设置移动速度
            Vector2 moveVelocity = new Vector2(moveHorizontal, moveVertical);

            // 应用移动速度到Rigidbody 2D
            rb2d.velocity = moveVelocity * 3;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            // 当物体开始与其他物体碰撞时调用
            Debug.Log("Collision with " + collision.gameObject.name);
        }

        void OnCollisionStay2D(Collision2D collision)
        {
            // 当物体与其他物体接触中时调用
            Debug.Log("Stay Collision with " + collision.gameObject.name);
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            // 当物体停止与其他物体碰撞时调用
            Debug.Log("Exit Collision with " + collision.gameObject.name);
        }
    }
}