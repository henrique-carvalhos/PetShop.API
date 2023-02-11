<<<<<<< HEAD
﻿using MediatR;
using PetShop.Application.ViewModels;
using System;
=======
﻿using System;
>>>>>>> a87d793ea8b2780862709b87271a4f1d9d25b8cc
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAddress
{
<<<<<<< HEAD
    public class GetAddressQuery : IRequest<AddressViewModel>
=======
    public class GetAddressQuery
>>>>>>> a87d793ea8b2780862709b87271a4f1d9d25b8cc
    {
        public GetAddressQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
