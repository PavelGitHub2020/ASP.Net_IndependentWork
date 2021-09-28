using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfTrackModels
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
