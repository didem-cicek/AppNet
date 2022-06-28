using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Core
{
    public abstract class BaseEntity
    {
       
    }
    public interface IAuditEntity
    {
        DateTime CreateDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
    public class AuditEntity : BaseEntity, IAuditEntity
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
