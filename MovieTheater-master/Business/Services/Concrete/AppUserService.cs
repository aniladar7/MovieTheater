﻿using Business.Services.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Concrete
{
    public class AppUserService:BaseRepository<AppUser>,IAppUserService
    {
    }
}