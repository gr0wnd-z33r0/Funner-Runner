using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if(player.position.z < 500)
        {
            scoreText.color = Color.red;
        };
        if (player.position.z > 500)
        {
            scoreText.color = Color.yellow;
        };
        if (player.position.z > 1000)
        {
            scoreText.color = Color.green;
        };
        if (player.position.z > 5000)
        {
            scoreText.color = Color.black;
        };
    }
}
