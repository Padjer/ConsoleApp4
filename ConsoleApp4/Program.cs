namespace ConsoleApp2
{
   public class Program
   {
      static void Main()
      {
         MySelf anatoliy = new MySelf();
         anatoliy.SetData("Anatoliy", "Luhinets", "Brown", "Black", 1.83, 83.2, 23);
         anatoliy.MyReactionSpeed = 0.45;
         anatoliy.MyNameIs();
         anatoliy.MyAppearance();
         Console.WriteLine($"Скорость моей реакции {anatoliy.MyReactionSpeed} сек") ;
      }
   }
   public class MySelf
   {
      private double weight;
      private double height;
      private int age;
      private string firstname;
      private string lastname;
      private string eyescolor;
      private string haircolor;
      private double reactionSpeed;
      public double MyReactionSpeed
      {
         get { return reactionSpeed; }
         set { reactionSpeed = value; }
      }

      public void MyNameIs()
      {
         Console.WriteLine($"Меня зовут {firstname} {lastname}");
      }
      public void MyAppearance()
      {
         Console.WriteLine($"У меня глаза {eyescolor} цвета, волосы {haircolor}, мой вес {weight}, рост {height} " );
      }
      public void SetData(string myFirstName, string myLastName, string myEyesColor, string myHairColor, double myHeight, double myWeight, int myAge)
      {
         firstname = myFirstName;
         lastname = myLastName;
         eyescolor = myEyesColor;
         haircolor = myHairColor;
         height = myHeight;
         age = myAge;
         weight = myWeight;
      }
  
   }
}
