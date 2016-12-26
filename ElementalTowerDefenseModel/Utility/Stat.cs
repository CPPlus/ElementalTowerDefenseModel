using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ElementalTowerDefenseModel
{
    class Stat
    {
        public float Points { get; private set; }
        public float MaxPoints { get; private set; }

        public Stat(float maxPoints, float points)
        {
            MaxPoints = Math.Abs(maxPoints);
            Points = Math.Abs(points);
            LockPoints();
        }

        public Stat(float points) : this(points, points) {}

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

        public bool IsEmpty()
        {
            return Points == 0;
        }

        public bool HasPoints(float points)
        {
            return points <= Points;
        }

        private void LockPoints()
        {
            if (Points > MaxPoints) Points = MaxPoints;
            else if (Points < 0) Points = 0;

            if (MaxPoints < 0) MaxPoints = 0;
        }
    }
}
