using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IUserApi {
    
    /// <summary>
    /// Create user This can only be done by the logged in user.
    /// </summary>
    /// <param name="body">Created user object</param>
    
    void CreateUser (User body);

    /// <summary>
    /// Create user This can only be done by the logged in user.
    /// </summary>
    /// <param name="body">Created user object</param>
    
    Task CreateUserAsync (User body);
    
    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    void CreateUsersWithArrayInput (List<User> body);

    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    Task CreateUsersWithArrayInputAsync (List<User> body);
    
    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    void CreateUsersWithListInput (List<User> body);

    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    Task CreateUsersWithListInputAsync (List<User> body);
    
    /// <summary>
    /// Logs user into the system 
    /// </summary>
    /// <param name="username">The user name for login</param>
    /// <param name="password">The password for login in clear text</param>
    /// <returns>string</returns>
    string LoginUser (string username, string password);

    /// <summary>
    /// Logs user into the system 
    /// </summary>
    /// <param name="username">The user name for login</param>
    /// <param name="password">The password for login in clear text</param>
    /// <returns>string</returns>
    Task<string> LoginUserAsync (string username, string password);
    
    /// <summary>
    /// Logs out current logged in user session 
    /// </summary>
    
    void LogoutUser ();

    /// <summary>
    /// Logs out current logged in user session 
    /// </summary>
    
    Task LogoutUserAsync ();
    
    /// <summary>
    /// Get user by user name 
    /// </summary>
    /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
    /// <returns>User</returns>
    User GetUserByName (string username);

    /// <summary>
    /// Get user by user name 
    /// </summary>
    /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
    /// <returns>User</returns>
    Task<User> GetUserByNameAsync (string username);
    
    /// <summary>
    /// Updated user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">name that need to be deleted</param>
    /// <param name="body">Updated user object</param>
    
    void UpdateUser (string username, User body);

    /// <summary>
    /// Updated user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">name that need to be deleted</param>
    /// <param name="body">Updated user object</param>
    
    Task UpdateUserAsync (string username, User body);
    
    /// <summary>
    /// Delete user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">The name that needs to be deleted</param>
    
    void DeleteUser (string username);

    /// <summary>
    /// Delete user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">The name that needs to be deleted</param>
    
    Task DeleteUserAsync (string username);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class UserApi : IUserApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="UserApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)</param>
    /// <returns></returns>
    public UserApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.ApiClient = Configuration.DefaultApiClient; 
      } else {
        this.ApiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserApi"/> class.
    /// </summary>
    /// <returns></returns>
    public UserApi(String basePath)
    {
      this.ApiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.ApiClient.BasePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.ApiClient.BasePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient ApiClient {get; set;}


    
    /// <summary>
    /// Create user This can only be done by the logged in user.
    /// </summary>
    /// <param name="body">Created user object</param>
    
    public void CreateUser (User body) {

      

      var path = "/user";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.Content, response.Content);
      }

      return;
    }

    /// <summary>
    /// Create user This can only be done by the logged in user.
    /// </summary>
    /// <param name="body">Created user object</param>
    
    public async Task CreateUserAsync (User body) {

      

      var path = "/user";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    public void CreateUsersWithArrayInput (List<User> body) {

      

      var path = "/user/createWithArray";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CreateUsersWithArrayInput: " + response.Content, response.Content);
      }

      return;
    }

    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    public async Task CreateUsersWithArrayInputAsync (List<User> body) {

      

      var path = "/user/createWithArray";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CreateUsersWithArrayInput: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    public void CreateUsersWithListInput (List<User> body) {

      

      var path = "/user/createWithList";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CreateUsersWithListInput: " + response.Content, response.Content);
      }

      return;
    }

    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    
    public async Task CreateUsersWithListInputAsync (List<User> body) {

      

      var path = "/user/createWithList";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CreateUsersWithListInput: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Logs user into the system 
    /// </summary>
    /// <param name="username">The user name for login</param>
    /// <param name="password">The password for login in clear text</param>
    /// <returns>string</returns>
    public string LoginUser (string username, string password) {

      

      var path = "/user/login";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

       if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
       if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling LoginUser: " + response.Content, response.Content);
      }

      return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
    }

    /// <summary>
    /// Logs user into the system 
    /// </summary>
    /// <param name="username">The user name for login</param>
    /// <param name="password">The password for login in clear text</param>
    /// <returns>string</returns>
    public async Task<string> LoginUserAsync (string username, string password) {

      

      var path = "/user/login";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

       if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
       if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling LoginUser: " + response.Content, response.Content);
      }
      return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
    }
    
    /// <summary>
    /// Logs out current logged in user session 
    /// </summary>
    
    public void LogoutUser () {

      

      var path = "/user/logout";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling LogoutUser: " + response.Content, response.Content);
      }

      return;
    }

    /// <summary>
    /// Logs out current logged in user session 
    /// </summary>
    
    public async Task LogoutUserAsync () {

      

      var path = "/user/logout";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling LogoutUser: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get user by user name 
    /// </summary>
    /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
    /// <returns>User</returns>
    public User GetUserByName (string username) {

      
      // verify the required parameter 'username' is set
      if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling GetUserByName");
      

      var path = "/user/{username}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GetUserByName: " + response.Content, response.Content);
      }

      return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
    }

    /// <summary>
    /// Get user by user name 
    /// </summary>
    /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
    /// <returns>User</returns>
    public async Task<User> GetUserByNameAsync (string username) {

      
          // verify the required parameter 'username' is set
          if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling GetUserByName");
      

      var path = "/user/{username}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GetUserByName: " + response.Content, response.Content);
      }
      return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
    }
    
    /// <summary>
    /// Updated user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">name that need to be deleted</param>
    /// <param name="body">Updated user object</param>
    
    public void UpdateUser (string username, User body) {

      
      // verify the required parameter 'username' is set
      if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UpdateUser");
      

      var path = "/user/{username}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.Content, response.Content);
      }

      return;
    }

    /// <summary>
    /// Updated user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">name that need to be deleted</param>
    /// <param name="body">Updated user object</param>
    
    public async Task UpdateUserAsync (string username, User body) {

      
          // verify the required parameter 'username' is set
          if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UpdateUser");
      

      var path = "/user/{username}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      postBody = ApiClient.Serialize(body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Delete user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">The name that needs to be deleted</param>
    
    public void DeleteUser (string username) {

      
      // verify the required parameter 'username' is set
      if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling DeleteUser");
      

      var path = "/user/{username}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);
      }

      return;
    }

    /// <summary>
    /// Delete user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">The name that needs to be deleted</param>
    
    public async Task DeleteUserAsync (string username) {

      
          // verify the required parameter 'username' is set
          if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling DeleteUser");
      

      var path = "/user/{username}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, FileParameter>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);
      }
      
      return;
    }
    
  }  
  
}
