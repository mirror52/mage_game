using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float moveSpeed = 8f; // 移动速度  
    public float rotateSpeed = 100f; // 旋转速度  
    public float JumpCooling;
    public float attackCooling;
    private Vector3 movement; // 玩家的移动向量  
    private float yaw = 0f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RandomHead>().Random1();
        text = GameObject.Find("playerName").GetComponent<TextMeshProUGUI>();
        text.text = EnterScene.playerName;
        JumpCooling = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (movement.magnitude > 0)
        {
            animator.SetBool("move", true);
        }
        else 
        {
            animator.SetBool("move", false);
        }
        // 移动玩家  
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // 检查鼠标右键是否被按下  
        if (Input.GetMouseButton(1))
        {
            // 获取鼠标的X和Y轴变化  
            float mouseX = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
            //float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
            // 围绕Y轴旋转玩家视角  
            yaw += mouseX;
            //yaw1 += mouseY;
            Quaternion rotation = Quaternion.AngleAxis(yaw * 5, Vector3.up);
            //Quaternion rotation1 = Quaternion.AngleAxis(yaw1 * 5, Vector3.right);
            transform.rotation = rotation;
        }
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
