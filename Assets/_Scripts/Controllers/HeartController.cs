using Assets._Scripts.Core;
using UnityEngine;
using UnityEngine.UI;

public class HeartController : MonoBehaviour
{
    [SerializeField]
    private Image image;

    private Heart _heart;

    // Start is called before the first frame update
    void Start()
    {
        _heart = new Heart(image);
    }

    public void RegenerarCoracao()
    {
        _heart.RegenerarCoracao(1);
    }

    public void DegradarCoracao()
    {
        _heart.DegradarCoracao(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
