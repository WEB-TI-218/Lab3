﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.Core;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.Responces;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {
        RequestResponceAction UserLogin(ULoginData data);
    }
}
