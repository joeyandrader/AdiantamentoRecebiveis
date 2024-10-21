using System;
using System.Collections;
using System.Net;
using AdiantamentoRecebiveis.API.Requests;
using AdiantamentoRecebiveis.Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AdiantamentoRecebiveis.API.Middlewares;

public class BaseController : ControllerBase
{
    /// <summary>
    /// Default API Response
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="value">Response data</param>
    /// <param name="code">Result code</param>
    /// <param name="message">Additional message</param>
    /// <param name="statusCode">HTTP status code</param>
    /// <param name="success">Indicates whether the operation was successful</param>
    /// <return>Formatted API Response</returns>    
    protected ActionResult BuildResponse<TValue>(TValue value, EnResultCode code = EnResultCode.Success, string message = "", HttpStatusCode statusCode = HttpStatusCode.OK, bool success = true)
    {
        int results = new();
        if (value is not null && value is IList && value.GetType().IsGenericType)
        {
            var property = typeof(ICollection).GetProperty("Count");
            results = (int)property!.GetValue(value, null)!;
        }
        else if (value is not null)
        {
            results = 1;
        }

        code = success ? EnResultCode.Success : EnResultCode.Error;

        APIDataResponse<TValue> response = new()
        {
            Success = success,
            Code = code,
            Message = message,
            Results = results,
            Data = value,
        };

        return StatusCode(statusCode.GetHashCode(), response);

    }

    /// <summary>
    /// Default API Response
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="value">Response data</param>
    /// <param name="code">Result code</param>
    /// <param name="message">Additional message</param>
    /// <param name="statusCode">HTTP status code</param>
    /// <param name="success">Indicates whether the operation was successful</param>
    /// <return>Formatted API Response</returns>  
    protected ActionResult BuildResponse(EnResultCode code = EnResultCode.Success, string message = "", HttpStatusCode statusCode = HttpStatusCode.OK, bool success = true)
    {
        code = success ? EnResultCode.Success : EnResultCode.Error;

        APIDataResponse response = new()
        {
            Success = success,
            Code = code,
            Message = message
        };

        return StatusCode(statusCode.GetHashCode(), response);
    }
}
