using System;


namespace CharlyRobotApplication
{
    public class Position
    {
        private float x;
        private float y;
        private float z;

        public Position()
        {
            this.x = this.y = this.z = 0;
        }

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float getX()
        {
            return this.x;
        }

        public float getY()
        {
            return this.y;
        }

        public float getZ()
        {
            return this.z;
        }



    }
}