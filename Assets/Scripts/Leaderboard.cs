using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;
using System.Linq;

public class Leaderboard : MonoBehaviour
{
    public List<TextMeshProUGUI> names;

    
    public List<TextMeshProUGUI> scores;

    private void Start()
    {
        GetLeaderboard();
    }

    private string publicLeaderboardKey = "7fb4e10d9aff8b799af8dfecea3a94da1446866be781e02170931396d13de3ca";
    public void GetLeaderboard(){
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < loopLength; ++i) {
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
