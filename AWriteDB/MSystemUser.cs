using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MSystemUser
    {
        public int SystemUserID { get; set; }

        public int SystemUserTypeID { get; set; }

        private string systemUserForename;

        public string SystemUserForename
        {
            get { return systemUserForename; }
            set { systemUserForename = value; }
        }

        private string systemUserSurname;

        public string SystemUserSurname
        {
            get { return systemUserSurname; }
            set { systemUserSurname = value; }
        }

        private string systemUserInitialPassword;

        public string SystemUserInitialPassword
        {
            get { return systemUserInitialPassword; }
            set { systemUserInitialPassword = value; }
        }

        private string systemUserLoginName;

        public string SystemUserLoginName
        {
            get { return systemUserLoginName; }
            set { systemUserLoginName = value; }
        }

        private string systemUserOrganisation;

        public string SystemUserOrganisation
        {
            get { return systemUserOrganisation; }
            set { systemUserOrganisation = value; }
        }

        private string systemUserEmail;
                
        public string SystemUserEmail
        {
            get { return systemUserEmail; }
            set { systemUserEmail = value; }
        }


        private string systemUserLandline;

        public string SystemUserLandline
        {
            get { return systemUserLandline; }
            set { systemUserLandline = value; }
        }

        private string systemUserMobile;

        public string SystemUserMobile
        {
            get { return systemUserMobile; }
            set { systemUserMobile = value; }
        }
        // -- 


        // wholename strings
        public string UserWholenameSurname()
        {
            return this.systemUserSurname + ", " + this.systemUserForename;
        }

        public string UserWholenameForename()
        {
            return this.systemUserForename + " " + this.systemUserSurname;
        }

        // constructor for validate
        public MSystemUser(int systemUserIDIn, string systemUserLoginIn, string systemUserPasswordIn)
        {
            SystemUserID = systemUserIDIn;
            systemUserLoginName = systemUserLoginIn;
            systemUserInitialPassword = systemUserPasswordIn;
        }

        public MSystemUser(int systemUserIDIn, string systemUserLoginIn)
        {
            SystemUserID = systemUserIDIn;
            systemUserLoginName = systemUserLoginIn;
        }

    }
}
