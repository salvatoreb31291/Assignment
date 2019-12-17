using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        [SerializeField] float movementSpeed = 5f;
        [SerializeField] AudioClip Dead;

        float xMin, xMax, yMin, yMax;

        float padding=0.5f;
       
    // Start is called before the first frame update
    void Start()
    {
       Limits();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
             RotateLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
             RotateRight();
        }
        Move();
        if (Input.GetKeyDown(KeyCode.UpArrow)){
             RotateUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)){
             RotateDown();
        }
    }
    void RotateLeft () {
        GetComponent<Transform>().eulerAngles=new Vector3(0,0,0);
     }

    void RotateRight () {
        GetComponent<Transform>().eulerAngles=new Vector3(0,0,180);
     }
     void RotateUp () {
        GetComponent<Transform>().eulerAngles=new Vector3(0,0,-90);
     }

    void RotateDown () {
        GetComponent<Transform>().eulerAngles=new Vector3(0,0,90);
    }

    private void Limits()
    {
        Camera gameCamera=Camera.main;

        xMin= gameCamera.ViewportToWorldPoint(new Vector3(0,0,0)).x+padding;
        xMax= gameCamera.ViewportToWorldPoint(new Vector3(1,0,0)).x-padding;
        
        yMin= gameCamera.ViewportToWorldPoint(new Vector3(0,0,0)).y+padding;
        yMax= gameCamera.ViewportToWorldPoint(new Vector3(0,1,0)).y-padding;


    }

    private float MoveY()
    {
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        float newYPos = transform.position.y + deltaY;

        return newYPos;
    }

    private float MoveX()
    {
        float deltaX = Input.GetAxis("Horizontal")*Time.deltaTime*movementSpeed;

        float newXPos = transform.position.x + deltaX;

        return newXPos;
    }
    private void Move()
    {
        float xPos= Mathf.Clamp(MoveX(),xMin,xMax);
        float yPos= Mathf.Clamp(MoveY(),yMin,yMax);

        transform.position = new Vector2(xPos,yPos) ;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if ( other.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<Health>().ReduceHealth();
            FindObjectOfType<PacmanSpawn>().Spawn();
            AudioSource.PlayClipAtPoint(Dead, Camera.main.transform.position);
            enemyDMG();
        }
    }

    public void enemyDMG()
    {
        Destroy(gameObject);
    }
}
