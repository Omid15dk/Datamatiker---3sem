using GeometryModel.Model;
using GeometryService.BusinessLogicLayer;
using GeometryService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GeometryService.Controllers {
    [Route("api/Shapes")]
    [ApiController]
    public class LinesController : ControllerBase {

        private readonly IShapeLogic _shapeLogic;

        // Constructor with Dependency Injection
        public LinesController(IShapeLogic inShapeLogic) {
            _shapeLogic = inShapeLogic;
        }

        [HttpGet, Route("lines")]
        public ActionResult<List<LineReadDto>> Get([FromQuery] string? sortBy) {
            ActionResult<List<LineReadDto>> foundReturn;
            // Get converted data
            IEnumerable<LineReadDto>? publicLines = _shapeLogic.GetAllLines(sortBy);
            if (publicLines is not null && publicLines.Any()) {
                foundReturn = Ok(publicLines);         
            } else {
                foundReturn = NotFound();
            }
            return foundReturn;
        }

        [HttpGet, Route("lines/{id}")]
        public ActionResult<LineReadDto> Get(int id) {
            ActionResult<LineReadDto> foundReturn;
            // Get data and convert
            LineReadDto? publicLine = _shapeLogic.GetLineById(id);
            // Evaluate
            if (publicLine != null) {
                if (publicLine.Id >= 0) {
                    foundReturn = Ok(publicLine);
                } else {
                    foundReturn = Ok();
                }
            } else {
                foundReturn = new StatusCodeResult(500);    // Internal server error
            }
            // Return result
            return foundReturn;
        }

        // Create new line
        [HttpPost, Route("lines")]
        public ActionResult PostNewLine(List<CoordinateReadDto> inDtoCoords) {
            ActionResult foundReturn;
            if (inDtoCoords.Count > 0) {
                bool wasOk = _shapeLogic.InsertLine(inDtoCoords);
                if (wasOk) {
                    foundReturn = Ok();
                } else {
                    foundReturn = new StatusCodeResult(500);    // Internal server error
                }
            } else {
                foundReturn = new StatusCodeResult(400); ;      // Bad Request
            }
            return foundReturn;
        }

        // Update line 
        [HttpPut, Route("lines/{id}")]
        public ActionResult<bool> Put(int id, [FromBody] LineReadDto inLineReadDto) {
            ActionResult<bool> putReturn;
            inLineReadDto.Id = id;
            bool wasOk = _shapeLogic.UpdateLine(inLineReadDto);
            if (wasOk) {
                putReturn = Ok();
            } else {
                putReturn = new StatusCodeResult(500);    // Internal server error
            }
            return putReturn;
        }

        [HttpDelete, Route("lines/{id}")]
        public ActionResult<bool> Delete(int id) {
            ActionResult<bool> deleteReturn;
            // Delete
            bool wasDeleted = _shapeLogic.DeleteLine(id);
            // Evaluate
            if (wasDeleted) {
                deleteReturn = Ok(true);
            } else {
                deleteReturn = NotFound(false);
            }
            // Return result
            return deleteReturn;
        }

    }
}
