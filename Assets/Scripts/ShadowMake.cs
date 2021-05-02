using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMake : MonoBehaviour
{
    [SerializeField] GameObject shadowTemplate;
    [SerializeField] float yPos = 0.02f;
    [SerializeField] float yScale = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        CreateShadow();
    }

    void CreateShadow()
    {
        GameObject shadow = Instantiate(shadowTemplate, transform);
        shadow.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        shadow.transform.localScale = new Vector3(1,-yScale, 1);
        shadow.transform.localPosition = new Vector3(0, yPos, 0);
    }
}
