﻿using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using Lezizz.Core.ApplicationService.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.Common.Behaviours
{
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger _logger;
        private readonly ICurrentUserService _currentUserService;
        private readonly IIdentityService _identityService;

        public RequestLogger(ILogger<TRequest> logger, ICurrentUserService currentUserService, IIdentityService identityService)
        {
            _logger = logger;
            _currentUserService = currentUserService;
            _identityService = identityService;
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            //var userId = _currentUserService.UserId;
            var userId = "89106b33-45d5-49da-8064-e223fd1df79d";
            var userName = await _identityService.GetUserNameAsync(userId);

            _logger.LogInformation("Lezizz Request: {Name} {@UserId} {@UserName} {@Request}",
                requestName, userId, userName, request);
        }
    }
}
