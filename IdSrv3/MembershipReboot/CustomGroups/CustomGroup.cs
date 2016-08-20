using BrockAllen.MembershipReboot;

namespace IdSrv3.MembershipReboot.CustomGroups
{
    public class CustomGroup : RelationalGroup
    {
        /*
         * NOTE: Although the description property is implemented here, there is an open
         * defect in Identity Manager where the description is not pullled from the 
         * database in the "Roles" Tab.
         */
        public virtual string Description { get; set; }
    }
}