namespace Model
{
    public class PulseDataModel
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MostSevereDiagnosisID { get; set; }
        public string MostSevereDiagnosisDescription { get; set; }
        public int DiagnosisCategoryID { get; set; }
        public string CategoryDescription { get; set; }
        public int CategoryScore { get; set; }
        public string IsMostSevereCategoryID { get; set; }

        public override string ToString()
        {
            var text = $"MemberID : {MemberID} " +
                $"FirstName : {FirstName} " +
                $"LastName : {LastName} " +
                $"MostSevereDiagnosisID : {MostSevereDiagnosisID} " +
                $"MostSevereDiagnosisDescription : {MostSevereDiagnosisDescription} " +
                $"DiagnosisCategoryID : {DiagnosisCategoryID} " +
                $"CategoryDescription : {CategoryDescription} " +
                $"CategoryScore : {CategoryScore} " +
                $"IsMostSevereCategoryID : {IsMostSevereCategoryID} ";

            return text;
        }
    }
}
