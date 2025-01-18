// Job.cs  
public class Job
{  
    private string _jobTitle;  
    private string _companyName;  
   
   
    // Constructor  
    public Job(string jobTitle, string companyName)  
    {  
        _jobTitle = jobTitle;// 
        _companyName = companyName;    
    }  

    // Properties  
    public string JobTitle  
    {  
        get { return _jobTitle; }  
        set { _jobTitle = value; }  
    }  

    public string CompanyName  
    {  
        get { return _companyName; }  
        set { _companyName = value; }  
    }  
}