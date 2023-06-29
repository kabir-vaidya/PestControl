using System;
namespace PestControl.Services {
	public interface IDbService {
		Task<List<T>> GetAll<T>(string command, object parameters);
	}
}

