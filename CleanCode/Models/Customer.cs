using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Models
{
    /// <summary>
    /// Represents a customer with id and name
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets the Id of the customer
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets or sets the name of the customer
        /// </summary>
        public string Name { get; set; }
    }
}
