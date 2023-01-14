
public class Resume
{

  public string _name;
  public List<Job> _jobs = new List<Job>();

  public void Display()
  {
    Console.WriteLine(_name);
    foreach (Job jobInstance in _jobs)
    {
      jobInstance.Display();
    }
  }

}