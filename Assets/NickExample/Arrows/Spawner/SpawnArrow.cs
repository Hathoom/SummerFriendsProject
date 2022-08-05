using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    //Sprites that can be used
    public Sprite upArrow;
    public Sprite downArrow;
    public Sprite leftArrow;
    public Sprite rightArrow;

    //Arrow gameObject that is created
    public GameObject arrow;

    //transforms of each spawner
    private Transform upSpawnerTransform;
    private Transform downSpawnerTransform;
    private Transform leftSpawnerTransform;
    private Transform rightSpawnerTransform;

    //timer so game is in seconds, not frames.
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        //set the variables
        upSpawnerTransform = this.gameObject.transform.GetChild(1);
        downSpawnerTransform = this.gameObject.transform.GetChild(0);
        rightSpawnerTransform = this.gameObject.transform.GetChild(2);
        leftSpawnerTransform = this.gameObject.transform.GetChild(3);

        //Debug.Log(upSpawnerTransform.position.x);

        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Update time

        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            Spawn(0);
            timer = 0f;
        }
    }

    private void Spawn(int number)
    {
        //Object we spawn.
        GameObject arrowclone = Instantiate(arrow);
        if (number == 0)
        {
            // Spawn down arrow
            arrowclone.transform.position = downSpawnerTransform.position;
            arrowclone.GetComponent<SpriteRenderer>().sprite = downArrow;
            
        }
        else if (number == 1)
        {
            // Spawn up arrow
            arrowclone.transform.position = downSpawnerTransform.position;
            arrowclone.GetComponent<SpriteRenderer>().sprite = downArrow;
        }
        else if (number == 2)
        {
            // Spawn right arrow
            arrowclone.transform.position = downSpawnerTransform.position;
            arrowclone.GetComponent<SpriteRenderer>().sprite = downArrow;
        }
        else if (number == 3)
        {
            // Spawn left arrow
            arrowclone.transform.position = downSpawnerTransform.position;
            arrowclone.GetComponent<SpriteRenderer>().sprite = downArrow;
        }

        arrowclone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector2.down * 5);
        //Debug.Log(arrowclone.GetComponent<Rigidbody2D>().velocity);
    }
}
