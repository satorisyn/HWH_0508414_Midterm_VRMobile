using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("燈光群組")]
    public GameObject groupLight;
    [Header("會動的奧克")]
    public Transform Box;


    public IEnumerator LightEffect()
    {
        for (int d = 0; d < 100000; d++)
        {
            groupLight.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            groupLight.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            groupLight.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            groupLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            groupLight.SetActive(false);
            yield return new WaitForSeconds(0.15f);
            groupLight.SetActive(true);
        }
    }
    public void StartMoveBox()
    {
        StartCoroutine(MoveBox());
    }
    public IEnumerator MoveBox()
    {
        for (int i = 0; i < 30; i++)
        {
            Box.position += Box.forward * 0.5f;
            yield return new WaitForSeconds(0.0001f);
        }
        Box.GetComponent<CapsuleCollider>().enabled = false;
    }

    void Start()
    {
        StartCoroutine(LightEffect());
    }
}
