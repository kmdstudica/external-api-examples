// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StudentActivityReportsV2External operations.
    /// </summary>
    public partial class StudentActivityReportsV2External : IServiceOperations<KMDStudicaProgrammes>, IStudentActivityReportsV2External
    {
        /// <summary>
        /// Initializes a new instance of the StudentActivityReportsV2External class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StudentActivityReportsV2External(KMDStudicaProgrammes client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the KMDStudicaProgrammes
        /// </summary>
        public KMDStudicaProgrammes Client { get; private set; }

        /// <param name='periodFrom'>
        /// Includes reports for periods with a transmission period start date no
        /// earlier than {PeriodFrom}
        /// </param>
        /// <param name='periodTo'>
        /// Includes reports for periods with a transmission period start date no later
        /// than {PeriodFromTo}
        /// </param>
        /// <param name='schoolCode'>
        /// The school code for which to get data.
        /// </param>
        /// <param name='xSelectedSchoolCode'>
        /// Selected school code, used when multiple impersonation permissions are
        /// available on the token
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<IList<ActivityGroup2Dto>>> GetWithHttpMessagesAsync(System.DateTime periodFrom, System.DateTime periodTo, string schoolCode, string xSelectedSchoolCode = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (schoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "schoolCode");
            }
            if (schoolCode != null)
            {
                if (schoolCode.Length > 6)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "schoolCode", 6);
                }
                if (schoolCode.Length < 6)
                {
                    throw new ValidationException(ValidationRules.MinLength, "schoolCode", 6);
                }
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("periodFrom", periodFrom);
                tracingParameters.Add("periodTo", periodTo);
                tracingParameters.Add("schoolCode", schoolCode);
                tracingParameters.Add("xSelectedSchoolCode", xSelectedSchoolCode);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Get", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "StudentActivityReportsV2External").ToString();
            List<string> _queryParameters = new List<string>();
            _queryParameters.Add(string.Format("PeriodFrom={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(periodFrom, new DateJsonConverter()).Trim('"'))));
            _queryParameters.Add(string.Format("PeriodTo={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(periodTo, new DateJsonConverter()).Trim('"'))));
            if (schoolCode != null)
            {
                _queryParameters.Add(string.Format("SchoolCode={0}", System.Uri.EscapeDataString(schoolCode)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (xSelectedSchoolCode != null)
            {
                if (_httpRequest.Headers.Contains("X-Selected-SchoolCode"))
                {
                    _httpRequest.Headers.Remove("X-Selected-SchoolCode");
                }
                _httpRequest.Headers.TryAddWithoutValidation("X-Selected-SchoolCode", xSelectedSchoolCode);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<IList<ActivityGroup2Dto>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<ActivityGroup2Dto>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
