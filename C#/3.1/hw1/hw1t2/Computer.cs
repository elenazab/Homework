
namespace hw1t2
{
    class Computer
    {
        public Computer(bool vir, OS syst)
        {
            mVirus = vir;
            operatingSystem = syst;
        }

        public void SetVirus()
        {
            if (operatingSystem.SuccessfulVirusAttack())
                mVirus = true;
        }

        public bool virus
        {
            get { return mVirus; }
            set { mVirus = value; }
        }
        
        private bool mVirus;
        private OS operatingSystem;
    }
}
