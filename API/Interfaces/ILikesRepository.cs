using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<AppUser> GetUserWithLikes(int userId);
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likeParams);
    }
}
