using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_12._17._2023.Service.Exceptions
{
    internal class NotFoundException:Exception
    {
        public const string ERROR_MESSAGE = "Person not found with this salary";
        public NotFoundException() : base(ERROR_MESSAGE)
        {
        }
    }
}
