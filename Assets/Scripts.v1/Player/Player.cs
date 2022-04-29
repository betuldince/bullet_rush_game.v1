using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    float xt, yt;
    [SerializeField] float speed = 0.05f;
    public static bool isSwipe = false;
    private Vector2 startPos;
    private Vector2 swipe;
    public static float x, y;
    public static float distance;
    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {

                isSwipe = true;
                startPos = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isSwipe = false;
                startPos = Vector2.zero;
            }
        }

        if (isSwipe)
        {
            if (Input.touches.Length < 0)
                swipe = Input.touches[0].position - startPos;
            else if (Input.GetMouseButton(0))
                swipe = (Vector2)Input.mousePosition - startPos;
        }



        if (isSwipe)
        {
            PlayerRun(true);
            xt = swipe.x * Time.deltaTime * speed;
            yt = swipe.y * Time.deltaTime * speed;
            transform.Translate(xt, 0, yt);
            transform.rotation = Quaternion.LookRotation(new Vector3(xt, 0, yt));

        }
        else
        {
            PlayerRun(false);

        }

    }
    public void PlayerRun(bool isRunning)
    {
        anim.SetBool("isRunning", isRunning);
    }
}
