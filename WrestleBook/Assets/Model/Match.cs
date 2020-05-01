//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


class Match
{
    List<MatchSide> sides;
    Worker referee;
    Worker roadAgent;
    List<Worker> announceTeam;

    List<MatchSegment> segments;

    public int desiredLengthInMinutes;

    public void AddSide(MatchSide side)
    {
        if (sides == null)
            sides = new List<MatchSide>();
        sides.Add(side);
    }

    public void Simulate()
    {
        segments = new List<MatchSegment>();
        MatchSegment lastSegment = null;
        int approximateLength = desiredLengthInMinutes * 60;
        int elapsedTime = 0;
        bool matchFinished = false;
        //Debug.Log("Persistent Data Path: " + Application.persistentDataPath);
        //Debug.Log("Data Path: " + Application.dataPath);
        Debug.Log("Called Simulate()");
        
        // Do while because we will ALWAYS at least start the match.
        do
        {
            MatchSegment seg;
            if (lastSegment == null)
            {
                int segNum = Random.Range(0, SegmentTemplates.Instance.OpeningSegments.Count);
                seg = new MatchSegment(SegmentTemplates.Instance.OpeningSegments[segNum]);
            }
            else if ((approximateLength - elapsedTime) > 30) // TODO Don't hardcode this value
            {
                int segNum = Random.Range(0, lastSegment.nextSegmentOptions.Count);
                seg = new MatchSegment(lastSegment.nextSegmentOptions[segNum]);
            }
            else
            {
                int segNum = Random.Range(0, SegmentTemplates.Instance.ClosingSegments.Count);
                seg = new MatchSegment(SegmentTemplates.Instance.ClosingSegments[segNum]);
            }

            int duration = Random.Range(seg.minSeconds, seg.maxSeconds + 1);
            Debug.Log(elapsedTime.ToString() + " seconds: " + seg.playByPlay);
            elapsedTime += duration;
            lastSegment = seg;
            segments.Add(seg);

            if (seg.nextSegmentOptions == null || seg.nextSegmentOptions.Count == 0 || seg.isCloser)
                matchFinished = true;
        } while (matchFinished == false);

        Debug.Log("Match finished in " + (elapsedTime / 60).ToString() + ":" + (elapsedTime % 60).ToString());
    }
}

