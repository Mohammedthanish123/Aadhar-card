using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdhaarCard
{
    class PersonDetail
    {
        public string PersonName;
        public string AdhaarNumber;
        public DateTime DateOfBirth;

        public bool Save()
        {
            IdentityRepositoryEntities dbctx = new IdentityRepositoryEntities();
            PersonIdentity pid = new PersonIdentity();
            pid.PersonName = PersonName;
            pid.DateOfBirth = DateOfBirth;
            pid.AdhaarNumber = AdhaarNumber;

            dbctx.PersonIdentities.Add(pid);
            dbctx.SaveChanges();
            return true;
        }

    }
}
