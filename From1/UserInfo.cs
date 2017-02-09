using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From1
{
    class UserInfo
    {
        #region UserInfo 用户资料表
        //序号 
        private int _userId;
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        //姓名
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
       

        //注册时间
        private DateTime _createDate;
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        //密码
        private string _userPassword;
        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }
       

        //生日日期
        private DateTime _userBirthday;
        public DateTime UserBirthday
        {
            get { return _userBirthday; }
            set { _userBirthday = value; }
        }
      
        //年龄
        private int _userAge;
        public int UserAge
        {
            get { return _userAge; }
            set { _userAge = value; }
        }

        //删除标识 0---1
        private int _dlag;
        public int Dlag
        {
            get { return _dlag; }
            set { _dlag = value; }
        }

        #endregion
    }
}
