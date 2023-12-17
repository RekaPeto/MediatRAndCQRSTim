using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;


    //Equivalent
    //public class Getpersonbyidqueryclass : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }

    //    public Getpersonbyidqueryclass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
