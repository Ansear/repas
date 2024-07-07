// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using API.DTOS;
// using API.Helpers;
// using Domain.Entities;
// using Domain.Interfaces;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.Extensions.Options;

// namespace API.Services;
//     public class UserServices : IUserServices
//     {
//         private readonly IUnitOfWork _unitOfwork;
//         private readonly JWT _jwt;
//         private readonly IPasswordHasher<User> _passwordHasher;

//         public UserServices(IUnitOfWork unitOfWork, IOptions<JWT> jwt, IPasswordHasher<User> passwordHasher)
//         {
//             _unitOfwork = unitOfWork;
//             _jwt = jwt.Value;
//             _passwordHasher = passwordHasher;
//         }

        
//     }