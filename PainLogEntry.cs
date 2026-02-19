namespace Gladiator;

class PainLogEntry
    {
        private DateTime datetime;
        private int painLevel;

        public PainLogEntry(DateTime datetime, int painLevel)
        {
            this.datetime = datetime;
            this.painLevel = painLevel;
        }

        bool IsInFlare()
        {
            return painLevel >= 7;
        }


        Severity GetSeverity()
        {
            if (painLevel == 0)
            {
                return Severity.None;
            }
            else if (painLevel >= 1 && painLevel <= 3)
            {
                return Severity.Mild;
            }
            else if (painLevel >= 4 && painLevel <= 6)
            {
                return Severity.Moderate;
            }
            else if (painLevel >= 7 && painLevel <= 8)
            {
                return Severity.Severe;
            }
            else
            {
                return Severity.Unbearable;
            }
        }

    }