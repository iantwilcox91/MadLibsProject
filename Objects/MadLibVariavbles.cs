namespace MadLibs.Objects
{
    public class MadLibVariables
    {
      private string _insult1;
      private string _insult2;
      private string _nameMom1;
      // private string _nameMom2;
      // private string _objectInsult;
      // private string _thankYouStatment;

      public string GetInsult1()
      {
          return  _insult1;
      }
      public void SetInsult1 (string newInsult1)
      {
          _insult1 = newInsult1;
      }
      public string GetInsult2()
      {
          return _insult2;
      }
      public void SetInsult2 (string newInsult2)
      {
        _insult2 = newInsult2;
      }
      public void SetNameMom1 (string newMom1)
      {
        _nameMom1 = newMom1;
      }
      public string GetNameMom1 ()
      {
        return _nameMom1;
      }
    }
}
