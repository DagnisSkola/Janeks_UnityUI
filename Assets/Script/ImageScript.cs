using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject male;
    public GameObject female;
    public GameObject goblin;
    public GameObject head;
    public GameObject chest;
    public GameObject leg;
    public Sprite[] spriteArray;
    public GameObject imageHolder;
    public GameObject sizeSlider;
    public GameObject rotationSlider;

    public void showMale(bool value)
    {
        male.SetActive(value);
    }

    public void showFemale(bool value)
    {
        female.SetActive(value);
    }

    public void showGoblin(bool value)
    {
        goblin.SetActive(value);
    }

    public void showHead(bool value)
    {
        head.SetActive(value);
    }

    public void showChest(bool value)
    {
        chest.SetActive(value);
    }

    public void showLeg(bool value)
    {
        leg.SetActive(value);
    }

    public void changeImage(int index)
    {
        imageHolder.GetComponent<Image>().sprite = spriteArray[index];
    }

    public void changeSize()
    {
        float size = sizeSlider.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(1F * size, 1F * size);
    }

    public void changeRotation()
    {
        float rotation = rotationSlider.GetComponent<Slider>().value;
        imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation*360);
    }

}
