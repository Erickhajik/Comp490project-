using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InsertTimerIntoDB : MonoBehaviour
{
    public void callAddTimer()
    {
        StartCoroutine(addTimer());
    }
    IEnumerator addTimer()
    {
        WWWForm form = new WWWForm();
        form.AddField("userName", addUserName.userNameSave);
        form.AddField("gamestart", MainGameTimer.gamestart);
        form.AddField("puzzle1start", Puzzle1.puzzle1Start);
        form.AddField("puzzle1end", Puzzle1.puzzle1End);
        form.AddField("puzzle2start", Puzzle2.puzzle2Start);
        form.AddField("puzzle2end", Puzzle2.puzzle2End);
        form.AddField("puzzle3start", Puzzle3.Puzzle3Start);
        form.AddField("puzzle3end", Puzzle3.Puzzle3End);
        form.AddField("endtime", MainGameTimer.gameend);
        WWW www = new WWW("http://localhost/AddTimers.php",form);
        yield return www;
    }
}
