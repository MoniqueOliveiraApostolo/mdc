using System;
using System.Collections.Generic;
using System.Text;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;

namespace MDC.DAL.Repository
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(ContextMDC context) : base(context)
        {
        }

        public State GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
