﻿using Microsoft.AspNet.Identity.EntityFramework;
using MusicStoreEntity.UserAndRole;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEntity
{
    //使用带用户认证权限机制的实体框架
    public class EntityDbContext : IdentityDbContext<ApplicationUser>
    {
        //调用基类的构造函数
        public EntityDbContext() : base("EntityDbContext") { }
        public static EntityDbContext Create()
        {
            return new EntityDbContext();
        }

        #region 用户与角色的实体

        public IDbSet<ApplicationInformation> ApplicationInformations { get; set; }
        public IDbSet<ApplicationBusinessType> ApplicationBusinessTypes { get; set; }
        public IDbSet<ApplicaitionUserInApplication> ApplicaitionUserInApplications { get; set; }
        public IDbSet<Person> Persons { get; set; }

        #endregion

        #region 音乐商店实体

        public IDbSet<Genre> Genres { get; set; }

        #endregion  

        #region 歌手实体

        public IDbSet<Artist> Artists { get; set; }

        #endregion

        #region 歌单实体

        public IDbSet<Album> Albums { get; set; }

        #endregion

        public IDbSet<Cart> Cart { get; set; }

        public IDbSet<Order> Order { get; set; }
        public IDbSet<OrdelDetail> OrdelDetail { get; set; }
        public IDbSet<PerAddress> PerAddress { get; set; }
        public IDbSet<Reply> Reply { get; set; }
        public IDbSet<LikeReply> LikeReply { get; set; }
    }
}