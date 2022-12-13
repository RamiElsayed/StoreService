using MediatR;
using StoreService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Application.Queries.GetItem
{
    public record GetItemQuery() : IRequest<ItemResponse>;
}
