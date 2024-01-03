using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;
using System.Linq;

public class Leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;

    [SerializeField]
    private List<TextMeshProUGUI> scores;

    private void Start()
    {
        GetLeaderboard();
    }

    private string publicLeaderboardKey = "56d2283ab670ade9f9a250818e2296117065060f47059d19553c7a898932ae45";
    public void GetLeaderboard(){
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < names.Count; ++i) {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }

        }));

    }
    public void SetLeaderboardEntry(string username, float score){
            LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username,
                score, ((msg) => {
                GetLeaderboard();
            }));
     }
}
