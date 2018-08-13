using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        public event EventHandler<Guid> ErrorLogged;
        //write tests for the public method
        public void Log(string error)
        {

            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;
            // write the log to a storage
            // ...
            OnErrorLogged(Guid.NewGuid());
            
        }
        //don't write tests for this method
        protected virtual void OnErrorLogged(Guid errorId)
        {
            ErrorLogged?.Invoke(this, errorId);
        }
    }
}
