using MediatR;
using StoreService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Core.Queries
{
    public record GetItemQuery(Guid ProductId) : IRequest<ItemResponse>;
}
