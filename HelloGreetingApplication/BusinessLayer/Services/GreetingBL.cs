using System;
using BusinessLayer.Interface;
using ModelLayer.Model;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Interface;
using StackExchange.Redis;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Services;

namespace BusinessLayer.Services
{
	public class GreetingBL:IGreetingBL
	{
		private readonly ILogger<GreetingBL> _logger;
		private readonly IGreetingRL _greetingRL;
		private readonly IDatabase _cache;
        private readonly TimeSpan _cacheDuration;
        //Constructor
        public GreetingBL(ILogger<GreetingBL> logger, IGreetingRL greetingRL, IConnectionMultiplexer redis,IConfiguration configuration)
		{
			_logger = logger;
			_greetingRL = greetingRL;
			_cache = redis.GetDatabase();
			_cacheDuration = TimeSpan.FromSeconds(int.Parse(configuration["Redis:CacheDuration"] ?? "300"));

		}
		/// <summary>
		/// Generate Hello,World as greeting 
		/// </summary>
		/// <returns>Hello,World</returns>
		public string SimpleGreeting()
		{
			_logger.LogInformation("Returning Hello world from Business Layer");
			return "Hello,World";
			
		}
		public string GreetingMessage(string? FirstName,string? LastName)
		{
			_logger.LogInformation("Generating Greeting Message");
			if(!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
			{
				_logger.LogInformation("Returning full name greeting");
				return $"Hello {FirstName} {LastName}";
			}
			if (!string.IsNullOrEmpty(FirstName))
			{
				_logger.LogInformation("Returning FirstName greeting");
				return $"Hello {FirstName} ";
			}
            if (!string.IsNullOrEmpty(LastName))
            {
                _logger.LogInformation("Returning FirstName greeting");
                return $"Hello {LastName} ";
            }
            _logger.LogInformation("Returning Default greeting");
            return "Hello, World";


        }
		//method to create the greeting 
		public async Task<string> Create(GreetingModel greeting)
		{
			var result = _greetingRL.Add(greeting);
			if(result=="Successfully added Greeting")
			{
				string greetingKey = $"greetin_{greeting.Id}";
				//Store new greeting in cache
				await _cache.StringSetAsync(greetingKey, JsonSerializer.Serialize(greeting), _cacheDuration);

				//fetch the latest list from database and store in cache
				var greetings = _greetingRL.GetDataBase();
				await _cache.StringSetAsync("greeting_list", JsonSerializer.Serialize(greetings), _cacheDuration);
			}
			return result ;
			

		}
		//method to get the greetings from database
        public async Task<List<GreetingModel>> GetDatabaseGreeting()
		{
			const string cacheKey = "greeting_list";
			var cachedData = await _cache.StringGetAsync(cacheKey);
			if (!cachedData.IsNullOrEmpty)
			{
				_logger.LogInformation("Returning greetings from cache");
				return JsonSerializer.Deserialize<List<GreetingModel>>(cachedData);
			}
			var greetings= _greetingRL.GetDataBase();
			await _cache.StringSetAsync(cacheKey, JsonSerializer.Serialize(greetings), _cacheDuration);
			return greetings;
		}

		//method to find the greeting on id in database
		public async Task<GreetingModel> FindGreeting(int id)
		{
			string cacheKey = $"greeting_{id}";
			var cachedGreeting = await _cache.StringGetAsync(cacheKey);
			if (!cachedGreeting.IsNullOrEmpty)
			{
				_logger.LogInformation($"returning cached greeting for ID {id}");
				return JsonSerializer.Deserialize<GreetingModel>(cachedGreeting);
			}
			var greeting = _greetingRL.FindGreeting(id);
			if(greeting != null) {
                await _cache.StringSetAsync(cacheKey, JsonSerializer.Serialize(greeting), _cacheDuration);
            }
			_logger.LogInformation("Returing the greeting if found.");
			return greeting;
			
		}
		//method to update the greeting on basis of id
		public async Task<bool> UpdateGreeting(int id,string Message)
		{
			var response = _greetingRL.FindGreeting(id);
			if (response == null)
			{
				return false;
			}
			_greetingRL.UpdateGreeting(id, Message);
            //update cache
            string cacheKey = $"greeting_list";
            await _cache.KeyDeleteAsync("greeting_list");
            var greetings = _greetingRL.GetDataBase();
            await _cache.StringSetAsync("greeting_list", JsonSerializer.Serialize(greetings), _cacheDuration);
            return true;
		}
		//method to delete the greeting on basis of id
		public async Task<bool> DeleteGreeting(int id)
		{
			var deleted= _greetingRL.DeleteGreeting(id);
			if (deleted)
			{
				await _cache.KeyDeleteAsync($"greeting_{id}");

                //updating the cached list instead of deleting it
                string cacheKey = "greeting_list";
                var cachedGreetings = await _cache.StringGetAsync(cacheKey);
                if (!cachedGreetings.IsNullOrEmpty)
                {
                    var greetings = JsonSerializer.Deserialize<List<GreetingModel>>(cachedGreetings);
                    // Remove deleted greeting
                    greetings.RemoveAll(g => g.Id == id);

                    //Store updated list back in cache
                    await _cache.StringSetAsync(cacheKey, JsonSerializer.Serialize(greetings), _cacheDuration);
                }
            }
            _logger.LogInformation($"Sending{id} to Repository layer");
			return deleted;
		}
    }
}

