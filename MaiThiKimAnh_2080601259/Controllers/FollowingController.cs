﻿using MaiThiKimAnh_2080601259.DTOs;
using MaiThiKimAnh_2080601259.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MaiThiKimAnh_2080601259.Controllers
{
    public class FollowingController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };
             _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}