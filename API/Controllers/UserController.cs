using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.DTOS;
using APP.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;
public class UserController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UserDto>>> Get()
        {
            var user = await _unitOfWork.User.GetAllAsync();
            return _mapper.Map<List<UserDto>>(user);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDto?>> Get(int id)
        {
            var user = await _unitOfWork.User.GetByIdAsync(id);
            if(user == null)
                return NotFound();
            return _mapper.Map<UserDto>(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDto>> Post([FromBody] UserDto userDto)
        {
            var users = _mapper.Map<User>(userDto);
            _unitOfWork.User.Add(users);
            await _unitOfWork.SaveAsync();
            if(users == null)
                return BadRequest("");
            userDto.Id = users.Id;
            return CreatedAtAction(nameof(Post), new { Id = userDto.Id }, userDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDto>> Put(int id,[FromBody] UserDto userDto)
        {
            if(userDto == null)
                return BadRequest();
            if(userDto.Id == 0)
                userDto.Id = id;
            if(userDto.Id != id)
                return NotFound();
            var users = _mapper.Map<User>(userDto);
            _unitOfWork.User.Update(users);
            await _unitOfWork.SaveAsync();
            return userDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var users = await _unitOfWork.User.GetByIdAsync(id);
            if(users == null)
                return NotFound();
            _unitOfWork.User.Remove(users);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
