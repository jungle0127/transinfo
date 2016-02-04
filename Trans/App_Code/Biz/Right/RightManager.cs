using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.Entity;
using Trans.DAL.Dao;
using System.Collections;
using log4net;

namespace Trans.Biz.Right
{
    public class RightManager : IRightManager
    {
        private static ILog logger = LogManager.GetLogger(typeof(RightManager));
        private IVuserrightsDao userRightsDao;
        private IVrightsfullinfoDao vrightsDao;
        private IRightgroupDao rightGroupDao;
        private IUserhasrightsDao userHasRightsDao;
        private IRolehasrightsDao roleHasRightsDao;
        private IRightsDao rightsDao;
        public RightManager()
        {
            this.userRightsDao = new VuserrightsDao();
            this.vrightsDao = new VrightsfullinfoDao();
            this.rightGroupDao = new RightgroupDao();
            this.userHasRightsDao = new UserhasrightsDao();
            this.roleHasRightsDao = new RolehasrightsDao();
            this.rightsDao = new RightsDao();
            logger.Info("Constructor method done.");
        }
        public IList<Int64> getAllRightIdList()
        {
            IList<Int64> rightIdList = new List<Int64>();
            IList<Rights> rightsPocoList = this.rightsDao.FindAll();
            foreach (Rights rightPoco in rightsPocoList)
            {
                rightIdList.Add(rightPoco.Id);
            }
            return rightIdList;
        }
        /// <summary>
        /// Get all the rights of an user according to user ID.
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>right information list of an user.</returns>
        public LinkedList<RightsInfo> getRightsByUserId(int userId)
        {
            LinkedList<RightsInfo> rightsInfoList = new LinkedList<RightsInfo>();
            IList<Vuserrights> userRightList = this.userRightsDao.DescendOrderFindById(userId);
            Hashtable infoTable = new Hashtable();

            foreach (Vuserrights userRight in userRightList)
            {
                RightBasicInfo rightBasicInfo = new RightBasicInfo();
                rightBasicInfo.RightUrl = userRight.Righturl;
                rightBasicInfo.RightName = userRight.Rightname;
                rightBasicInfo.RightId = userRight.Rightid;
                rightBasicInfo.RightType = userRight.Righttype;
                if (infoTable.ContainsKey(userRight.Groupid))
                {
                    LinkedList<RightBasicInfo> rightBasicInfoList = infoTable[userRight.Groupid] as LinkedList<RightBasicInfo>;
                    rightBasicInfoList.AddLast(rightBasicInfo);
                    infoTable[userRight.Groupid] = rightBasicInfoList;
                }
                else
                {
                    LinkedList<RightBasicInfo> rightBasicInfoList = new LinkedList<RightBasicInfo>();
                    rightBasicInfoList.AddLast(rightBasicInfo);
                    infoTable[userRight.Groupid] = rightBasicInfoList;
                }
            }
            foreach (long groupId in infoTable.Keys)
            {
                RightsInfo rightsInfo = new RightsInfo();

                LinkedList<RightBasicInfo> rightBasicInfoList = infoTable[groupId] as LinkedList<RightBasicInfo>;
                Rightgroup rightGroup = new Rightgroup();
                rightGroup.Id = groupId;
                rightsInfo.RightGroup = rightGroup;
                IList<Rights> rightList = new List<Rights>();
                foreach (RightBasicInfo rightBasicInfo in rightBasicInfoList)
                {
                    Rights rightPojo = new Rights();
                    rightPojo.Rightname = rightBasicInfo.RightName;
                    rightPojo.Righturl = rightBasicInfo.RightUrl;
                    rightPojo.Id = rightBasicInfo.RightId;
                    rightList.Add(rightPojo);
                }
                rightsInfo.RightList = rightList;
                rightsInfoList.AddLast(rightsInfo);
            }
            return rightsInfoList;
        }
        /// <summary>
        /// Get all rights information
        /// </summary>
        /// <returns>List of right information</returns>
        public IList<RightsInfo> getRightsFullInfo()
        {
            IList<RightsInfo> rightFullInfoList = new List<RightsInfo>();
            IList<Vrightsfullinfo> rightInfoList = this.vrightsDao.FindAll();
            Hashtable infoTable = new Hashtable();
            foreach (Vrightsfullinfo rightInfoEntity in rightInfoList)
            {
                Rightgroup groupEntity = new Rightgroup();
                groupEntity.Id = rightInfoEntity.GroupId;
                groupEntity.Groupname = rightInfoEntity.Groupname;
                RightBasicInfo rightBasicInfo = new RightBasicInfo();
                rightBasicInfo.RightId = rightInfoEntity.RightId;
                rightBasicInfo.RightName = rightInfoEntity.Rightname;
                rightBasicInfo.RightUrl = rightInfoEntity.Righturl;

                if (infoTable.ContainsKey(groupEntity.Id))
                {
                    LinkedList<RightBasicInfo> rightBasicInfoList = infoTable[groupEntity.Id] as LinkedList<RightBasicInfo>;
                    rightBasicInfoList.AddLast(rightBasicInfo);
                    infoTable[groupEntity.Id] = rightBasicInfoList;
                }
                else
                {
                    LinkedList<RightBasicInfo> rightBasicInfoList = new LinkedList<RightBasicInfo>();
                    rightBasicInfoList.AddLast(rightBasicInfo);
                    infoTable[groupEntity.Id] = rightBasicInfoList;
                }
            }
            foreach (long groupId in infoTable.Keys)
            {
                LinkedList<RightBasicInfo> rightBasicInfoList = infoTable[groupId] as LinkedList<RightBasicInfo>;
                RightsInfo rightsInfoEntity = new RightsInfo();// Includes RightGroup and its rights list.
                Rightgroup rightGroup = new Rightgroup();
                rightGroup.Id = groupId;
                rightsInfoEntity.RightGroup = rightGroup;
                IList<Rights> rightList = new List<Rights>();
                foreach (RightBasicInfo rightBasicInfo in rightBasicInfoList)
                {
                    Rights rightsEntity = new Rights();
                    rightsEntity.Id = rightBasicInfo.RightId;
                    rightsEntity.Rightname = rightBasicInfo.RightName;
                    rightsEntity.Righturl = rightBasicInfo.RightUrl;
                    rightList.Add(rightsEntity);
                }
                rightsInfoEntity.RightList = rightList;
                rightFullInfoList.Add(rightsInfoEntity);
            }
            return rightFullInfoList;
        }
        /// <summary>
        /// Get all rights Id of an user by user id.
        /// </summary>
        /// <param name="userId">ID of an user.</param>
        /// <returns>rights id list of an user.</returns>
        public IList<Int64> getRightIdList(int userId)
        {
            IList<Int64> rightIdList = new List<Int64>();
            IList<Vuserrights> userRightsList = this.userRightsDao.DescendOrderFindById(userId);
            foreach (Vuserrights userRightEntity in userRightsList)
            {
                rightIdList.Add(userRightEntity.Rightid);
            }
            return rightIdList;
        }
        public IList<Int64> getRightIdListByRoleId(long roleId)
        {
            IList<long> rightIdList = new List<long>();
            IList<Rolehasrights> roleHasRightsPocoList = this.roleHasRightsDao.FindByRoleid(roleId);
            foreach (Rolehasrights roleHasRightsPoco in roleHasRightsPocoList)
            {
                rightIdList.Add(roleHasRightsPoco.Rightid);
            }
            return rightIdList;
        }
        public IList<Int64> getRightIdListByUserId(long userId)
        {
            IList<Int64> rightIdList = new List<Int64>();
            IList<Userhasrights> userHasRightsPocoList = this.userHasRightsDao.FindByUserid(userId);
            foreach(Userhasrights userHasRightPoco in userHasRightsPocoList)
            {
                rightIdList.Add(userHasRightPoco.Rightid);
            }
            return rightIdList;
        }
        /// <summary>
        /// Map for right group:
        /// <id,rightgroupPoco>
        /// </summary>
        /// <returns></returns>
        public Hashtable getRightGroupMap()
        {
            Hashtable rightGroupMap = new Hashtable();
            IList<Rightgroup> groupList = this.rightGroupDao.FindAll();
            foreach (Rightgroup groupEntity in groupList)
            {
                rightGroupMap[groupEntity.Id] = groupEntity;
            }
            return rightGroupMap;
        }
    }
    /// <summary>
    /// Right basic infor entity.
    /// </summary>
    public class RightBasicInfo
    {
        private Int64 rightId;

        public Int64 RightId
        {
            get { return rightId; }
            set { rightId = value; }
        }

        private Int64 rightType;

        public Int64 RightType
        {
            get { return rightType; }
            set { rightType = value; }
        }

        private String rightName;

        public String RightName
        {
            get { return rightName; }
            set { rightName = value; }
        }
        private String rightUrl;

        public String RightUrl
        {
            get { return rightUrl; }
            set { rightUrl = value; }
        }
    }
}