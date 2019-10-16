using RoomSharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomSharing.Repository
{
    public class GroupRepository
    {
        ApplicationDbContext _context;
        public GroupRepository()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Group> Get()
        {
            return _context.Groups;
        }

        public bool Create(Group group)
        {
            bool success = false;
            try
            {
                _context.Groups.Add(group);
                _context.SaveChanges();
                success = true;
            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
            return success;
        }
    }
}