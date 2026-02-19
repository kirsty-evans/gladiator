namespace Gladiator;

class Exercise
    {

        private bool isActive;
        private string name;
        private int reps;
        private int sets;
        private bool doubleSided;
        public Exercise(bool isActive, string name, int reps, int sets, bool doubleSided)
        {
            this.isActive = isActive;
            this.name = name;
            this.reps = reps;
            this.sets = sets;
            this.doubleSided = doubleSided;


        }
        public bool GetIsActive()
        {
            return isActive;
        }

        public void SetIsActive(bool activeStatus)
        {
            isActive = activeStatus;
        }


        public string GetName() 
        {
            return name;
        }

        public void SetName(string exerciseName)
        {
            name = exerciseName;
        }

        public int GetReps()
        {
            return reps;
        }

        public void SetReps(int exerciseReps)
        {
            reps = exerciseReps;
        }

        public int GetSets()
        {
            return sets;
        }

        public void SetSets(int exerciseSets)
        {
            sets = exerciseSets;
        }

        public bool GetDoubleSided()
        {
            return doubleSided;
        }

        public void SetDoubleSided(bool isDoubleSided)
        {
            doubleSided = isDoubleSided;
        }



    }