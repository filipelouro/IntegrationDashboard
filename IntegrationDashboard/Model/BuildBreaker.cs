namespace IntegrationDashboard.Model
{
    class BuildBreaker
    {
        private User user;
        private int numberFailedBuilds;

        internal User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public int NumberFailedBuilds
        {
            get
            {
                return numberFailedBuilds;
            }

            set
            {
                numberFailedBuilds = value;
            }
        }
    }
}
