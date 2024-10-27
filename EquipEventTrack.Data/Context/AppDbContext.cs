using EquipEventTrack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EquipEventTrack.Data.Context;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<UserEntity>(options)
{
    
}