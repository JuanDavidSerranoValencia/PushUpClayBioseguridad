using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class CategoriaPersonaController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoriaPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CategoriaPersona>>> Get()
        {
            var entidades = await _unitOfWork.CategoriaPersonas.GetAllAsync();
            return _mapper.Map<List<CategoriaPersona>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaPersonaDto>> Get(int id)
        {
            var entidad = await _unitOfWork.CategoriaPersonas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<CategoriaPersonaDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoriaPersona>> Post(CategoriaPersonaDto CategoriaPersonaDto)
        {
            var entidad = _mapper.Map<CategoriaPersona>(CategoriaPersonaDto);
            this._unitOfWork.CategoriaPersonas.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            CategoriaPersonaDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = CategoriaPersonaDto.Id}, CategoriaPersonaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaPersonaDto>> Put(int id, [FromBody] CategoriaPersonaDto CategoriaPersonaDto)
        {
            if(CategoriaPersonaDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<CategoriaPersona>(CategoriaPersonaDto);
            _unitOfWork.CategoriaPersonas.Update(entidades);
            await _unitOfWork.SaveAsync();
            return CategoriaPersonaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.CategoriaPersonas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.CategoriaPersonas.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
