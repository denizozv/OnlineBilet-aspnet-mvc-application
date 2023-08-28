using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineBilet.Data.Base;
using OnlineBilet.Models;
using System;

namespace OnlineBilet.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorsService
    { 

        public ActorService(AppDbContext context) : base(context) { }

      
    }
}
