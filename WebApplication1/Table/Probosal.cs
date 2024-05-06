namespace WebApplication1.Table
{
    public class Probosal
    {
        private int _probosalID;
        private string _probosalDescribtion;
        private string _targetParty;
        private string _imagePath; 

        public Probosal(int probosalID, string probosalDescribtion, string targetParty, string imagePath)
        {
            _probosalID = probosalID;
            _probosalDescribtion = probosalDescribtion;
            _targetParty = targetParty;
            _imagePath = imagePath; 
        }

        public int ProbosalID
        {
            get { return _probosalID; }
            set { _probosalID = value; }
        }

        public string ProbosalDescribtion
        {
            get { return _probosalDescribtion; }
            set { _probosalDescribtion = value; }
        }

        public string TargetParty
        {
            get { return _targetParty; }
            set { _targetParty = value; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
    }
}
