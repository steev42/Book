using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrestleBookModel : WrestleBookElement
{

    List<Worker> workers;

    // Start is called before the first frame update
    void Start()
    {
        SegmentTemplates.Load();

        Worker w1 = new Worker();
        w1.workerName = "Worker 1";
        w1.shortname = "W1";
        w1.nickname = "One";
        w1. basics = 500;     
        w1. selling = 500;    
        w1. technique = 500;   
        w1. psychology = 500; 
        w1. calling = 500;     
        w1. athleticism = 500;
        w1. strength = 500;
        w1. stamina = 500;
        w1. resilience = 500;
        w1. agility = 500;
        w1. consistency = 500;
        w1. safety = 500;
        w1. adaptability = 500;
        w1. creativity = 500;
        w1. teamwork = 500;
        w1. charisma = 500;
        w1. acting = 500;
        w1. microphone = 500;
        w1. appearance = 500;
        w1. intimidation = 500;
        w1. referee = 500;
        w1. colour = 500;
        w1. announcing = 500;
        w1. managing = 500;
        w1. scouting = 500;
        w1. hardcore = 500;
        w1. aerial = 500;
        w1. puroresu = 500;
        w1. brawling = 500;
        w1. technical = 500;
        w1. reputation = 500;
        w1. experience = 500;
        w1. flashiness = 500;
        w1. star_quality = 500;
        w1. respect = 500;


        Worker w2 = new Worker();
        w2.workerName = "Worker 2";
        w2.shortname = "w2";
        w2.nickname = "Two";
        w2.basics = 500;
        w2.selling = 500;
        w2.technique = 500;
        w2.psychology = 500;
        w2.calling = 500;
        w2.athleticism = 500;
        w2.strength = 500;
        w2.stamina = 500;
        w2.resilience = 500;
        w2.agility = 500;
        w2.consistency = 500;
        w2.safety = 500;
        w2.adaptability = 500;
        w2.creativity = 500;
        w2.teamwork = 500;
        w2.charisma = 500;
        w2.acting = 500;
        w2.microphone = 500;
        w2.appearance = 500;
        w2.intimidation = 500;
        w2.referee = 500;
        w2.colour = 500;
        w2.announcing = 500;
        w2.managing = 500;
        w2.scouting = 500;
        w2.hardcore = 500;
        w2.aerial = 500;
        w2.puroresu = 500;
        w2.brawling = 500;
        w2.technical = 500;
        w2.reputation = 500;
        w2.experience = 500;
        w2.flashiness = 500;
        w2.star_quality = 500;
        w2.respect = 500;

        MatchSide s1 = new MatchSide();
        s1.AddCompetitor(w1);

        MatchSide s2 = new MatchSide();
        s2.AddCompetitor(w2);

        Match m = new Match();
        m.desiredLengthInMinutes = 15;
        m.AddSide(s1);
        m.AddSide(s2);

        //m.Simulate();

    }

    // Update is called once per frame
    void Update()
    {

    }

}
