using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {



            //    cfg.AddProfile(new AdversoProfile)

            //    cfg.CreateMap<AdversoViewModel, Adverso>();
            //    cfg.CreateMap<Adverso, AdversoViewModel>();

            //    cfg.CreateMap<AgendamentoViewModel, Agendamento>();
            //    cfg.CreateMap<Agendamento, AgendamentoViewModel>();


            //    cfg.CreateMap<ClienteViewModel, Cliente>();
            //    cfg.CreateMap<Cliente, ClienteViewModel>();

            //    cfg.CreateMap<ColaboradorViewModel, Colaborador>();
            //    cfg.CreateMap<Colaborador, ColaboradorViewModel>();

            //    cfg.CreateMap<ContatoViewModel, Contato>();
            //    cfg.CreateMap<Contato, ContatoViewModel>();

            //    cfg.CreateMap<ProcessoViewModel, Processo>();
            //    cfg.CreateMap<Processo, ProcessoViewModel>();

            //    cfg.CreateMap<RamoViewModel, Ramo>();
            //    cfg.CreateMap<Ramo, RamoViewModel>();
            });
        }
    }
}
