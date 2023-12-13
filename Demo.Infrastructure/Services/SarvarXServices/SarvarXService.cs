using Demo.Application.Repositories;
using Demo.Domain.Models;
using Demo.Domain.Models.SarvarXModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Services.SarvarXServices
{
    public class SarvarXService : ISarvarXService
    {
        private readonly ISarvarXRepository _sarvarX;
        public SarvarXService(ISarvarXRepository sarvar)
        {
            _sarvarX = sarvar;
        }
        public async ValueTask<IEnumerable<SarvarX>> GetAllSarvarX()
        {
            try 
            {
                IEnumerable<SarvarX> sarvar = await _sarvarX.GetAllSarvarX();
                if(sarvar is not null)
                {
                    return sarvar;
                }


                return Enumerable.Empty<SarvarX>();
            }
            catch
            {
                return Enumerable.Empty<SarvarX>();
            }
        }
    }
}
