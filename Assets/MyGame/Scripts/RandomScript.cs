using UnityEngine;

public class RandomScript : MonoBehaviour
{
    public void Start()
    {

        RandomValue(); 
        RandomColour();
        RandomInsideUnitySphere();

    }

    void RandomValue()
    {
        float randomValue = Random.value;
        Debug.Log(randomValue);
    }


    void RandomColour()
    {
        Color color;
        color = new Color(Random.Range(0F, 1F), Random.Range(0, 2F), Random.Range(0, 3F));
        SpriteRenderer circleRandom = GetComponent<SpriteRenderer>();
        circleRandom.color = color;
    }


    void RandomInsideUnitySphere()
    {
        transform.position = Random.insideUnitSphere;

    }

}
