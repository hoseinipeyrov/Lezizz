using Lezizz.Core.ApplicationService.Common.Interfaces;
using System;

namespace Lezizz.Infra.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
