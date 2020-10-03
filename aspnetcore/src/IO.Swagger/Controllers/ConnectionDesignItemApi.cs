/*
 * connection-proposer-api
 *
 * Connection proposer API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ConnectionDesignItemApiController : ControllerBase
    { 
        /// <summary>
        /// Delete the connection design item
        /// </summary>
        /// <remarks>Delete the single design item which is given by its unique id</remarks>
        /// <param name="id">The ID of the required connection design item</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized user</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpDelete]
        [Route("/martin.pospisil/connection-proposer-api/1.0.0/design-item")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteConDesignItem")]
        public virtual IActionResult DeleteConDesignItem([FromQuery][Required()]ConDesignItemId id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the connection design item
        /// </summary>
        /// <remarks>Get data of the single design item which is given by its unique id</remarks>
        /// <param name="id">The ID of the required connection design item</param>
        /// <response code="200">Information about the connection design item</response>
        /// <response code="401">Unauthorized user</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpGet]
        [Route("/martin.pospisil/connection-proposer-api/1.0.0/design-item")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetConDesignItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConDesignItem), description: "Information about the connection design item")]
        public virtual IActionResult GetConDesignItem([FromQuery][Required()]ConDesignItemId id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConDesignItem));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"version\" : \"version\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ConDesignItem>(exampleJson)
                        : default(ConDesignItem);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get all connection design items from the given connection design set
        /// </summary>
        /// <param name="id">The ID of the required connection design set</param>
        /// <response code="200">A list of all connection design items from the given connection design set</response>
        /// <response code="401">Unauthorized user</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpGet]
        [Route("/martin.pospisil/connection-proposer-api/1.0.0/design-items")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetConDesignItems")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ConDesignItem>), description: "A list of all connection design items from the given connection design set")]
        public virtual IActionResult GetConDesignItems([FromQuery][Required()]ConDesignSetId id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ConDesignItem>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"version\" : \"version\"\n}, {\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"version\" : \"version\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ConDesignItem>>(exampleJson)
                        : default(List<ConDesignItem>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create or modify the connection design item
        /// </summary>
        /// <remarks>Create or modify the connection design item and return the updated instance from the database</remarks>
        /// <param name="body">An object containing connection design item information</param>
        /// <response code="200">Information about modified connection design item</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized user</response>
        [HttpPost]
        [Route("/martin.pospisil/connection-proposer-api/1.0.0/design-item")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PostConDesignItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConDesignItem), description: "Information about modified connection design item")]
        public virtual IActionResult PostConDesignItem([FromBody]ConDesignItem body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConDesignItem));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);
            string exampleJson = null;
            exampleJson = "{\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"version\" : \"version\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ConDesignItem>(exampleJson)
                        : default(ConDesignItem);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Publish connection design items
        /// </summary>
        /// <remarks>Publish selected connection design items from Idea connection project to the given connection design set</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/martin.pospisil/connection-proposer-api/1.0.0/project-publish")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ProjectPublishGet")]
        public virtual IActionResult ProjectPublishGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
