using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY_Console.Model;

namespace HY_Console.Extension
{
    public delegate bool IsPass();

    internal sealed class DiyList
    {
        public DiyList(IsPass isPass)
        {
            _isPass = isPass;
        }

        ~DiyList()
        { 
        }

        private List<User> GetUsers()
        {
            List<User> users = new()
            {
                new User()
                {
                    Id = 100,
                    Name = "Guozy",
                    Phone = string.Empty,
                    Address = null,
                    CreateTime = DateTime.UtcNow
                },

                new User()
                {
                    Id = 200,
                    Name = "Yusn",
                    Phone = string.Empty,
                    Address = null,
                    CreateTime = DateTime.UtcNow
                },

                new User()
                {
                    Id = 300,
                    Name = "Yousp",
                    Phone = string.Empty,
                    Address = null,
                    CreateTime = DateTime.UtcNow
                },

                new User()
                {
                    Id = 400,
                    Name = "Keli",
                    Phone = string.Empty,
                    Address = null,
                    CreateTime = DateTime.UtcNow
                }
            };

            return users;
        } 

        public void Show()
        {
            List<User> users = GetUsers();

            {
                List<User> result = new List<User>();
                foreach (User user in users)
                {
                    if (_isPass.Invoke())
                    {
                        result.Add(user);
                    }
                }
                Console.WriteLine($"结果一共有{result.Count}个");
            }
        }

        private IsPass _isPass;
    }
}
