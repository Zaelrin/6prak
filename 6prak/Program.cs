using System;
using System.Collections.Generic;
using System.Linq;

namespace prak6
{
  class Program 
  {
    static void Main(string[] args)
    {


      Console.WriteLine();
      ResearchTeam team = new ResearchTeam();
      Paper[] papers = new Paper[2];
      papers[0] = new Paper("pub_4", new DateTime(1887, 6, 1));
      papers[1] = new Paper("pub_5", new DateTime(1889, 8, 21));
      team.AddPapers(papers);

      foreach (Paper paper in team.list)
      {
        Console.WriteLine(paper.Publication);
        Console.WriteLine(paper.Time.ToShortDateString());
      }


      Console.WriteLine(team.ToString());

      Console.ReadKey();


      Person Fisrt = new Person("Иван", "Никитин", DateTime.Parse("20.05.2001"));
      Console.WriteLine();
 
    }
  }

  public class Person
  {

    private string name;
    private string surname;
    private DateTime bdate;
    public Person(string _name, string _surname, DateTime _bdate)
    {
      name = _name;
      surname = _surname;
      bdate = _bdate;
    }
  }

  class Paper
  {


    string Name { get; set; }   
    string Author { get; set; }   
    DateTime Data { get; set; }   


    
    public Paper(string name, string author, DateTime data)
    {
      Name = name;
      Author = author;
      Data = data;
    }

    
    public Paper() : this("WarandWorld", "Lolstoy", new DateTime(1889, 7, 1)) { }



    public Paper(string publication, DateTime time)
    {
      Publication = publication;
      Time = time;
    }
    public string Publication;

    public DateTime Time;
  }

  
  enum TimeFrame { Year, TwoYears, Long }


  class ResearchTeam
  {


    private string Theme;        
    private string NameOfOrg;    
    private int NumberOfReg;     
    private TimeFrame Last;      
                                 
    private List<Paper> Papers = new List<Paper>() { new Paper("pub_1", new DateTime(1881, 6, 2)), new Paper("pub_2", new DateTime(1883, 6, 2)), new Paper("pub_3", new DateTime(1885, 6, 2)) }; 



    


    public ResearchTeam(string theme, string nameoforg, int numberofreg)
    {
      Theme = theme;
      NameOfOrg = nameoforg;
      NumberOfReg = numberofreg;

    }


            
    public ResearchTeam() : this("Ecology", "Colos", 1924714927) { }


    
    public string theme
    {
      get {
        return Theme;
      }
    }

    
    public string nameoforg
    {
      get {
        return NameOfOrg;
      }
    }

    
    public int numberofreg
    {
      get {
        return NumberOfReg;
      }
    }

    
    public TimeFrame last
    {
      get {
        return Last;
      }
    }

       

    public List<Paper> list
    {
      get { return Papers; }

      set { Papers = value; }
    }


    public void AddPapers(Paper[] papers)
    {
      Papers.AddRange(papers);
    }


    public override string ToString()
    {
      return string.Join(",", Papers.Select(p => p.Publication));
    }


  }


}