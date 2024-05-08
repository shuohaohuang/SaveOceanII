// Ignore Spelling: Dto

using SaveOceanII.GeneralUtils;

namespace SaveOceanII.DTOs.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Exp { get;set; }

        public EmployeeDto(string name, string job)
        {
            this.Name = Txt.Name(name);
            this.Job = job;
            this.Exp = this.Job == "Tècnic" ? 45 : 80;
        }
        public EmployeeDto() 
        {
        }
        /// <summary>
        /// modifica el valor Exp de la instancia, depenent del de Success, si es cert suma si no resta.
        /// </summary>
        /// <param name="success">si ha complert la missió</param>
        public override string ToString()
        {
            string file = string.Format(
                 "+-------------------------------------------------------------+\r\n"
                   + "|                           Empleat                           |\r\n"
                   + "+-------------------------------------------------------------+\r\n"
                   + "|        Nom        |        Feina        |        Exp        |\r\n"
                   + "+-------------------------------------------------------------+\r\n"
                   + "|{0}|{1}|{2}|\r\n"
                   + "+-------------------------------------------------------------+\r\n",
               Txt.Format(this.Name, 19),
               Txt.Format(this.Job, 21),
               Txt.Format(this.Exp.ToString(), 19)
           );
            return file;
        }
    }
}
