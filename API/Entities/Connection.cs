namespace API.Entities
{
    public class Connection
    {
        public Connection()
        {
            
        }
        public Connection(string username, string connectionId)
        {
            Username = username;
            ConnectionId = connectionId;
        }

        public string ConnectionId { get; set; }
        public string Username { get; set; }
    }
}