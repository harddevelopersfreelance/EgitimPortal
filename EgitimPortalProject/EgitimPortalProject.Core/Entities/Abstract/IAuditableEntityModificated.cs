﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IAuditableEntityModificated : IAuditedModification, IHasModificationTime
    {
    }
}
