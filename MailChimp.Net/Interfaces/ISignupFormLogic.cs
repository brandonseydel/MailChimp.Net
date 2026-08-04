using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface ISignupFormLogic
{
    Task<IEnumerable<SignupForm>> GetAllAsync(string listId, CancellationToken cancellationToken = default);
    Task<SignupFormResponse> GetResponseAsync(string listId, CancellationToken cancellationToken = default);
    Task<SignupForm> AddOrUpdateAsync(string listId, SignupForm signupForm, CancellationToken cancellationToken = default);
}
