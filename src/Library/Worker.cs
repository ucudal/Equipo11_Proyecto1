using System.Collections.Generic;

namespace ClassLibrary
{
public class Worker : IPerson
{
    private string name;
    private string phoneNumber;
    private string emailAddress;
    private string id;
    private Service service { get; set; }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.name = value;
            }
        }
    }
    public string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }

        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length == 9)
            {
                this.phoneNumber = value;
            }
        }
    }

    //  Conoce la ubicación del trabajador, para luego poder calcular su distancia con el empleador
    public List<int> Location { get; set; }
    public string EmailAddress
    {
        get
        {
            return this.emailAddress;
        }

        set
        {
            if (!string.IsNullOrEmpty(value) && value.Contains("@"))
            {
                this.emailAddress = value;
            }
        }
    }
    public string Id
    {
        get
        {
            return this.id;
        }
        //El comentario refiere a la clase y metodo que usamos en un ejercicio viejo para validar cedulas, habria que preguntar is lo podemos "copiar".
        set
        {
            //if (IdUtils.IdIsValid(value))
            //{
            this.id = value;
            //}
        }
    }
    public Service Service
    {
        get
        {
            return this.service;
        }

        set
        {
            if (this.service != null)
            {
                this.service = value;
            }
        }
    }
    public List<Service> ServicesList {get;set;}
    private List<Worker> activeWorkers;
    public int Salary { get; set; }
    public Worker(string name, string phoneNumber, string emailAddress, string id, List<int> location, Service service, int salary)
    {
        this.Name = name;
        this.PhoneNumber = phoneNumber;
        this.EmailAddress = emailAddress;
        this.Id = id;
        this.Location = location;
        this.Service = service;
        this.ServicesList.Add(this.Service);
        this.Salary = salary;
        this.activeWorkers.Add(this);
    }
}
}