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
    public GameObject widthSlider;
    public GameObject heightSlider;
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

    public void changeWidth()
    {
        float sizeWidth = widthSlider.GetComponent<Slider>().value;
        Vector3 currentScaleWidth = imageHolder.transform.localScale;
        currentScaleWidth.x = 1F * sizeWidth;
        imageHolder.transform.localScale = currentScaleWidth;
    }

    public void changeHeight()
    {
        float sizeHeight = heightSlider.GetComponent<Slider>().value;
        Vector3 currentScaleHeight = imageHolder.transform.localScale;
        currentScaleHeight.y = 1F * sizeHeight;

        imageHolder.transform.localScale = currentScaleHeight;
    }

}
