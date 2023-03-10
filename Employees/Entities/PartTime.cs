using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    /// <summary>
    /// Represents a part-time employee
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: January 27, 2023</remarks>
    internal class PartTime : Employee
    {
		// TODO: Add remaining fields, properties, and constructor parameters for part-time employee.
        private double rate;

        public double Rate { get {  return rate; } }

        // This is how ID, name, and address would be set if the fields in the Employee class are private and it couldn't be modified.
        /*public PartTime(string id, string name, string address, double rate) : base(id, name, address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.rate = rate;
        }*/

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Name of employee</param>
        /// <param name="address">Employee's address</param>
        /// <param name="rate">Employee's rate</param>
        public PartTime(string id, string name, string address, double rate)
        {
            // Set in instance of inherited Employee
            this.id = id;
            this.name = name;
            this.address = address;
            // Set in instance of this class
            this.rate = rate;
        }

    }
}
