﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface IUOW
    {
        //save pending changes to the data store
        void Commit();

        //get repository for type
        //T GetRepository<T>() where T : class;

        //Standard repos, autogenerated
        IEFRepository<Contact> Contacts { get; }
        IEFRepository<ContactType> ContactTypes { get; }
        IEFRepository<Favorite> Favorites { get; }
        IEFRepository<Group> Groups { get; }
        IEFRepository<Log> Logs { get; }
        IEFRepository<ContactInGroup> ContactInGroups { get; }


            //Customs repos, manually implemented
        IUserRepository Users { get; }

    }
}
