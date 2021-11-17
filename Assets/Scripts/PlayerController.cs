using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    private float rotation = 60f;
    private float moveVertical;
    private string toolName;

    private Animator anim;
    private ToolsManager tools;


    void Start()
    {
        anim = GetComponent<Animator>();
        tools = GetComponent<ToolsManager>();
    }

    private void FixedUpdate()
    {
        Move();
        Rotation();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && tools.ToolHas())
        {
            UseTool();     
        }
    }

    private void Move()
    {
        moveVertical = Input.GetAxis("Vertical");
        transform.Translate(0, 0, moveVertical * Time.deltaTime * speed);
        anim.SetFloat("SpeedY", moveVertical);
    }

    private void Rotation()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, Time.deltaTime * -(rotation), 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, Time.deltaTime * rotation, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Tools"))
        {
            GameObject instruments = other.gameObject;
            instruments.SetActive(false);
            toolName = instruments.name;
            tools.AddTools(toolName, instruments);
            tools.SeeTool();
        }
    }

    private void UseTool()
    {
        GameObject instruments = tools.GetTool(toolName);
        instruments.SetActive(true);
        instruments.transform.position = transform.position + new Vector3(2f, 0.3f, 3f);
    }


}
