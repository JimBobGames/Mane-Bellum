﻿using ManeBellum.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManeBellum.Core.Engines
{
    /// <summary>
    /// Class which handles the mechanics ofsurvey and exploration
    /// </summary>
    public class SurveyAndExplorationEngine : AbstractEngine
    {

        public int GetSurveyPoints(Ship s)
        {
            if (s == null)
            {
                return 0;
            }
            Design d = s.Design;

            // modified by crew quality perhaps ?
            return d.SurveySpeed;
        }

        public void ResolveSurveyAndExplorationSpending(Nation n, StratgicPriorities sp)
        {
            // how much money ?
            int moneyAvailable = 1000;

            // resolving survey for race
            Game.GameEventLog.AddEvent(Game.TurnNumber, GameEventCategory.InformationEvent, GameEventType.SurveyExplorationUpdateEvent, n.Id, sp.Value, moneyAvailable);

        }
    }
}
