﻿using webapi.Entities.EntityBases;

namespace webapi.Entities.Entities
{
    public class WebColor : AuditableBase
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }
}