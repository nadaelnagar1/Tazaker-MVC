using Tazaker.Data.Repository.Generic;
using Tazaker.Models;

namespace Tazaker.Data.Services.ProducerService
{
    public class ProducerServices:EntityBaseRepository<Producer>,IProducerService
    {
        public ProducerServices(AppDbContext context) : base(context)
        {

        }
    }
}
