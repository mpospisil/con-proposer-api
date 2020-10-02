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
    public class UserApiController : ControllerBase
    { 
        /// <summary>
        /// Get information about the current user
        /// </summary>
        /// <response code="200">information about the current user</response>
        /// <response code="401">Unauthorized user</response>
        [HttpGet]
        [Route("/martin.pospisil/connection-proposer-api/1.0.0/user")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "information about the current user")]
        public virtual IActionResult GetUser()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);
            string exampleJson = null;
            exampleJson = "{\n  \"role\" : \"engineer\",\n  \"name\" : \"name\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<User>(exampleJson)
                        : default(User);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}