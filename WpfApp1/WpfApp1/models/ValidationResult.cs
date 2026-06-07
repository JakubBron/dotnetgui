using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.models
{
    public class ValidationResult
    {
        public List<string> Errors { get; } = new();

        public void AddError(string error)
        {
            Errors.Add(error);
        }
        public bool IsValid()
        {
            return Errors != null && Errors.Count != 0;
        }
    }
}
