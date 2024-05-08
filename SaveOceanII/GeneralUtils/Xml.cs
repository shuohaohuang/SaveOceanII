using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SaveOceanII.DTOs.Employee;

namespace SaveTheOceanII.GeneralUtils
{
    internal class Xml
    {
        const string Path = "Employees";

        public static void Create(EmployeeDto employeeDto)
        {
            if (!File.Exists(Path) || File.ReadAllText(Path) == "")
            {
                XDocument emp = new XDocument(
                    new XElement(
                        "employees",
                        new XElement(
                            "employee",
                            new XElement("name", employeeDto.Name),
                            new XElement("job", employeeDto.Job),
                            new XElement("exp", employeeDto.Exp)
                        )
                    )
                );

                using (StreamWriter sw = File.CreateText(Path)) { }
                emp.Save(Path);
            }
            else
            {
                XDocument emps = XDocument.Load(Path);
                XElement emp = new XElement("employee");

                emp.Add(new XElement("name", employeeDto.Name));
                emp.Add(new XElement("job", employeeDto.Job));
                emp.Add(new XElement("exp", employeeDto.Exp));

                emps.Element("employees").Add(emp);
                emps.Save(Path);
            }
        }
    }
}
