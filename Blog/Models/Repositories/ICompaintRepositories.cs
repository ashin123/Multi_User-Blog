using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public interface ICompaintRepositories
    {
        void AddCompaint(Complaint complaint);
    }
}
