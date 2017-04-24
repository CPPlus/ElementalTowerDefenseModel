using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ElementalTowerDefenseModel
{
    public class Stat
    {
        public float InitialMaxPoints { get; private set; }
        public float Points { get; private set; }
        public float MaxPoints { get; private set; }
        public bool IsEmpty {
            get
            {
                return Points == 0;
            }
        }

        public bool IsFull
        {
            get { return Points == MaxPoints; }
        }
        
        public Stat(float maxPoints, float points)
        {
            MaxPoints = Math.Abs(maxPoints);
            InitialMaxPoints = MaxPoints;
            Points = Math.Abs(points);
            LockPoints();
        }

        public Stat(float points) : this(points, points) {}

        public void Reset()
        {
            MaxPoints = InitialMaxPoints;
            LockPoints();
        }

        public void Buff(float points)
        {
            MaxPoints += points;
        }

        public void Nerf(float points)
        {
            points = Math.Abs(points);

            MaxPoints -= points;
            LockPoints();
        }

        public void Fill()
        {
            Points = MaxPoints;
        }

        public void Fill(float points)
        {
            points = Math.Abs(points);

            Points += points;
            LockPoints();
        }

        public void Empty()
        {
            Points = 0;
        }

        public void Empty(float points)
        {
            Points -= points;
            LockPoints();
        }

        public bool HasPoints(float points)
        {
            return points <= Points;
        }

        private void LockPoints()
        {
            if (MaxPoints < 0) MaxPoints = 0;

            if (Points > MaxPoints) Points = MaxPoints;
            else if (Points < 0) Points = 0;
        }
    }
}
