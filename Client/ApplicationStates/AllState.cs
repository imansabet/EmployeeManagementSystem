namespace Client.ApplicationStates;

public class AllState
{
    //scope action
    public Action? Action { get; set; }
    // generaldepartment
    public bool ShowGeneralDepartment { get; set; }

    public void GeneralDepartmentClicked() 
    {
        ResetAll();
        ShowGeneralDepartment = true;
        Action?.Invoke();
    }
    // department
    public bool ShowDepartment { get; set; }
    public void DepartmentClicked() 
    {
        ResetAll();
        ShowDepartment = true;
        Action?.Invoke();
    }
    // branches
    public bool ShowBranch { get; set; }
    public void BrachClicked() 
    {
        ResetAll();
        ShowBranch = true;
        Action?.Invoke();
    }
    //Country
    public bool ShowCountry { get; set; }
    public void CountryClicked()
    {
        ResetAll();
        ShowCountry = true;
        Action?.Invoke();
    }
    //city
    public bool ShowCity { get; set; }
    public void CityClicked()
    {
        ResetAll();
        ShowCity = true;
        Action?.Invoke();
    }
    //Town
    public bool ShowTown { get; set; }
    public void TownClicked()
    {
        ResetAll();
        ShowTown = true;
        Action?.Invoke();
    }
    //user
    public bool ShowUser { get; set; }
    public void UserClicked()
    {
        ResetAll();
        ShowUser = true;
        Action?.Invoke();
    }
    //Employee
    public bool ShowEmployee { get; set; }
    public void EmployeeClicked()
    {
        ResetAll();
        ShowEmployee = true;
        Action?.Invoke();
    }

    private void ResetAll()
    {
        ShowGeneralDepartment = false;
        ShowDepartment = false;
        ShowBranch = false;
        ShowCountry = false;
        ShowCity = false;
        ShowTown = false;
        ShowUser = false;
        ShowEmployee = false;
    }

}
