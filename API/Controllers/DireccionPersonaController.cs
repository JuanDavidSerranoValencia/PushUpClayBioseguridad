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
public class DireccionPersonaController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DireccionPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DireccionPersona>>> Get()
        {
            var entidades = await _unitOfWork.DireccionPersonas.GetAllAsync();
            return _mapper.Map<List<DireccionPersona>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DireccionPersonaDto>> Get(int id)
        {
            var entidad = await _unitOfWork.DireccionPersonas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<DireccionPersonaDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DireccionPersona>> Post(DireccionPersonaDto DireccionPersonaDto)
        {
            var entidad = _mapper.Map<DireccionPersona>(DireccionPersonaDto);
            this._unitOfWork.DireccionPersonas.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            DireccionPersonaDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = DireccionPersonaDto.Id}, DireccionPersonaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DireccionPersonaDto>> Put(int id, [FromBody] DireccionPersonaDto DireccionPersonaDto)
        {
            if(DireccionPersonaDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<DireccionPersona>(DireccionPersonaDto);
            _unitOfWork.DireccionPersonas.Update(entidades);
            await _unitOfWork.SaveAsync();
            return DireccionPersonaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.DireccionPersonas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.DireccionPersonas.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
