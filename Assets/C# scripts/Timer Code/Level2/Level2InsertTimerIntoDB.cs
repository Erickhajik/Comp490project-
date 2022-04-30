using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Level2InsertTimerIntoDB : MonoBehaviour
{
    public void callAddTimer()
    {
        StartCoroutine(addTimer());
    }
    IEnumerator addTimer()
    {
        WWWForm form = new WWWForm();
        form.AddField("userName", MainMenuCode.userNameSave);
        // form.AddField("gamestart", Level2MainTimer.Level2gamestart);
        // form.AddField("puzzle1start", Level2Puzzle1.Level2puzzle1Start);
        // form.AddField("puzzle1end", Level2Puzzle1.Level2puzzle1End);
        // form.AddField("puzzle2start", Level2Puzzle2.Level2puzzle2Start);
        // form.AddField("puzzle2end", Level2Puzzle2.Level2puzzle2End);
        // form.AddField("puzzle3start", Level2Puzzle3.Level2Puzzle3Start);
        // form.AddField("puzzle3end", Level2Puzzle3.Level2Puzzle3End);
        // form.AddField("endtime", Level2MainTimer.Level2gameend);
        form.AddField("gamestart", "Level2MainTimer.Level2gamestart");
        form.AddField("puzzle1start","Level2MainTimer.Level2gamestart" );
        form.AddField("puzzle1end", "Level2Puzzle1.Level2puzzle1End");
        form.AddField("puzzle2start", "Level2Puzzle2.Level2puzzle2Start");
        form.AddField("puzzle2end", "Level2Puzzle2.Level2puzzle2End");
        form.AddField("puzzle3start", "Level2Puzzle3.Level2Puzzle3Start");
        form.AddField("puzzle3end", "Level2Puzzle3.Level2Puzzle3End");
        form.AddField("endtime", "Level2MainTimer.Level2gameend");
        WWW www = new WWW("http://globaltroop.xyz/Level2Timer.php",form);
        yield return www;
    }
}
