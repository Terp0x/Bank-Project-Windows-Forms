using Bank_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static My_Bank_Project.ClsGlobal;

namespace My_Bank_Project
{
    public  class ClsGlobal
    {




        public static string CurrentUser { get; set; }

        public static int Permissions = 0;
        public static string RoleName { get; set; }


        public enum enMainMenuPermissions
        {
             eAll = -1, eManageClientsTransactions = 1, eManageClients = 2 , eClients = 3
        };

        public enum enUserRoles
        {
            eAdmin = -1, eTeller = 1, eAuditor = 2
        };



        public static int SetPermissions()
        {

             ClsUsersBusiness user = ClsUsersBusiness.Find(CurrentUser);

              if (user != null) 
            
              {
                  ClsRolesBusiness Role = ClsRolesBusiness.Find(user.RoleID);

                   if(Role != null )
                   {
                       ClsPermissionsBusiness Permission = ClsPermissionsBusiness.Find(Role.PermissionID);
                       


                        if( Permission != null )
                        {
                                 switch (Permission.PermissionID)
                                 {
                                        case 1:
                                 {

                                              Permissions += Convert.ToInt16(enMainMenuPermissions.eAll);
                                              break;

                                 }        
                                        case 2:
                                 {

                                             Permissions += Convert.ToInt16(enMainMenuPermissions.eManageClientsTransactions);
                                             break;

                                 }
                                        case 3:
                                 {

                                               Permissions += Convert.ToInt16(enMainMenuPermissions.eManageClients);
                                               break;

                                 }
                                 }
                                         


                        }

                   }
                   else
                   {
                          Permissions += Convert.ToInt16(enMainMenuPermissions.eClients);
                   }


              }else
              {


                  Permissions +=  Convert.ToInt16(enMainMenuPermissions.eClients);

              }


            return Permissions;
        }


    

     





    }





}
