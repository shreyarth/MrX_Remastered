using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Test : MonoBehaviour
{
    public List<GameObject> boxes = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        GameObject box = boxes[Random.Range(0, boxes.Count)];
        Instantiate(box, transform.position, Quaternion.identity);
        box.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
