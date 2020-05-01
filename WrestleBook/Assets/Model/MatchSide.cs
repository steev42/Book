using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatchSide
{
    List<Worker> competitors;
    List<Worker> seconds;

    public void AddCompetitor(Worker w)
    {
        if (competitors == null)
            competitors = new List<Worker>();
        competitors.Add(w);
    }

    public void AddSecond(Worker w)
    {
        if (seconds == null)
            seconds = new List<Worker>();
        seconds.Add(w);
    }
}

