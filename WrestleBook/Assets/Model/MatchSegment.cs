using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class MatchSegment
{
    public bool isOpener;
    public bool isCloser;

    public int minSeconds;
    public int maxSeconds;

    public int minWorkersOffense;
    public int maxWorkersOffense;

    public int minWorkersDefense;
    public int maxWorkersDefense;

    public List<MatchSegment> nextSegmentOptions;

    public int offensiveMomentumShift;
    public int defensiveMomentumShift;

    public int offensiveStaminaShift;
    public int defensiveStaminaShift;

    public int offensiveInjuryRisk;
    public int defensiveInjuryRisk;

    public List<Worker> offensiveWorkers;
    public List<Worker> defensiveWorkers;

    //public int rating;

    public string[] playByPlay;

    public MatchSegment()
    {
        nextSegmentOptions = new List<MatchSegment>();
        offensiveWorkers = new List<Worker>();
        defensiveWorkers = new List<Worker>();
    }

    public MatchSegment(MatchSegment template)
    {
        isOpener = template.isOpener;
        isCloser = template.isCloser;
        minSeconds = template.minSeconds;
        maxSeconds = template.maxSeconds;
        minWorkersOffense = template.minWorkersOffense;
        maxWorkersOffense = template.maxWorkersOffense;
        minWorkersDefense = template.minWorkersDefense;
        maxWorkersDefense = template.maxWorkersDefense;
        nextSegmentOptions = new List<MatchSegment>();
        nextSegmentOptions.AddRange(template.nextSegmentOptions);
        offensiveMomentumShift = template.offensiveMomentumShift;
        defensiveMomentumShift = template.defensiveMomentumShift;
        offensiveStaminaShift = template.offensiveStaminaShift;
        defensiveStaminaShift = template.defensiveStaminaShift;
        offensiveInjuryRisk = template.offensiveInjuryRisk;
        defensiveInjuryRisk = template.defensiveInjuryRisk;
        offensiveWorkers = new List<Worker>();
        defensiveWorkers = new List<Worker>();

        playByPlay = template.playByPlay;
    }

    public void Simulate() // Return NEW MatchSegmentResult class instance?
    {

    }
}

