using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Color mixedColor;
    // Start is called before the first frame update
    void Start()
    {
        mixedColor = Color.white;
        GetComponent<SpriteRenderer>().color = mixedColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                if(hit.transform.gameObject.tag == "White")
                {
                    AddWhite();
                }
                if (hit.transform.gameObject.tag == "Red")
                {
                    AddRed();
                }
                if (hit.transform.gameObject.tag == "Green")
                {
                    AddGreen();
                }
                if (hit.transform.gameObject.tag == "Blue")
                {
                    AddBlue();
                }
                if (hit.transform.gameObject.tag == "Black")
                {
                    AddBlack();
                }
            }
        }
    }


    void AddWhite()
    {
        if (mixedColor.r >= mixedColor.g && mixedColor.r >= mixedColor.b)
        {
            if (mixedColor.g < 1)
            {
                mixedColor.g += 0.1f;
            }
            if (mixedColor.b < 1)
            {
                mixedColor.b += 0.1f;
            }
        }
        if (mixedColor.g >= mixedColor.r && mixedColor.g >= mixedColor.b)
        {
            if (mixedColor.r < 1)
            {
                mixedColor.r += 0.1f;
            }
            if (mixedColor.b < 1)
            {
                mixedColor.b += 0.1f;
            }
        }
        if (mixedColor.b >= mixedColor.r && mixedColor.b >= mixedColor.g)
        {
            if (mixedColor.r < 1)
            {
                mixedColor.r += 0.1f;
            }
            if (mixedColor.g < 1)
            {
                mixedColor.g += 0.1f;
            }
        }

        GetComponent<SpriteRenderer>().color = mixedColor;
    }

    void AddRed()
    {
        if(mixedColor.r < 1)
        {
            mixedColor.r += 0.1f;
        }
        if (mixedColor.g >= mixedColor.b && mixedColor.g > 0)
        {
            mixedColor.g -= 0.1f;
        }
        if (mixedColor.b >= mixedColor.g && mixedColor.b > 0)
        {
            mixedColor.b -= 0.1f;
        }

        GetComponent<SpriteRenderer>().color = mixedColor;
    }

    void AddGreen()
    {
        if (mixedColor.r >= mixedColor.b && mixedColor.r > 0)
        {
            mixedColor.r -= 0.1f;
        }
        if (mixedColor.g < 1)
        {
            mixedColor.g += 0.1f;
        }
        if (mixedColor.b >= mixedColor.r && mixedColor.b > 0)
        {
            mixedColor.b -= 0.1f;
        }

        GetComponent<SpriteRenderer>().color = mixedColor;
    }

    void AddBlue()
    {
        if (mixedColor.r >= mixedColor.g && mixedColor.r > 0)
        {
            mixedColor.r -= 0.1f;
        }
        if (mixedColor.g >= mixedColor.r && mixedColor.g > 0)
        {
            mixedColor.g -= 0.1f;
        }
        if (mixedColor.b < 1)
        {
            mixedColor.b += 0.1f;
        }

        GetComponent<SpriteRenderer>().color = mixedColor;
    }

    void AddBlack()
    {
        if (mixedColor.r <= mixedColor.g && mixedColor.r <= mixedColor.b)
        {
            if (mixedColor.g > 0)
            {
                mixedColor.g -= 0.1f;
            }
            if (mixedColor.b > 0)
            {
                mixedColor.b -= 0.1f;
            }
        }
        if (mixedColor.g <= mixedColor.r && mixedColor.g <= mixedColor.b)
        {
            if (mixedColor.r > 0)
            {
                mixedColor.r -= 0.1f;
            }
            if (mixedColor.b > 0)
            {
                mixedColor.b -= 0.1f;
            }
        }
        if (mixedColor.b <= mixedColor.r && mixedColor.b <= mixedColor.g)
        {
            if (mixedColor.r > 0)
            {
                mixedColor.r -= 0.1f;
            }
            if (mixedColor.g > 0)
            {
                mixedColor.g -= 0.1f;
            }
        }

        GetComponent<SpriteRenderer>().color = mixedColor;
    }
}
