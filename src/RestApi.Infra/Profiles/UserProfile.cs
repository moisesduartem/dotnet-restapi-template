﻿using AutoMapper;
using RestApi.Application.V1.Aggregates.Users.DTOs;
using RestApi.Domain.V1.Aggregates.Users.Entities;

namespace RestApi.Infra.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, LoggedUserDTO>();

            CreateMap<User, LoginDTO>()
                .ForMember(d => d.User, cfg => cfg.MapFrom(x => x))
                .ForMember(d => d.Token, cfg => cfg.Ignore());

            CreateMap<string, LoginDTO>()
                .ForMember(
                    d => d.User,
                    cfg => cfg.Ignore()
                )
                .ForMember(
                    d => d.Token,
                    cfg => cfg.MapFrom(x => x)
                );
        }
    }
}
