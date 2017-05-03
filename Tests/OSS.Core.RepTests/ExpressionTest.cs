﻿using System;
using System.Linq.Expressions;
using OSS.Core.DomainMos.Members.Mos;
using OSS.Core.RepDapper.OrmExtention;
using Xunit;

namespace OSS.Core.RepTests
{
    public class ExpressionTest
    {
        [Fact]
        public void Test()
        {

            var vistor = new SqlExpression();

            //var sqlUpdateFlag = new SqlVistorFlag(SqlVistorType.InsertOrUpdate);
            //Expression<Func<UserInfoMo, object>> funExpression =
            //    u => new {name = u.nick_name, nick_name = "s" + u.nick_name, email = u.email};
            //vistor.Visit(funExpression, sqlUpdateFlag);


            var arr = new[] {1, 2, 3, 4, 5};

            var sqlWhereFlag = new SqlVistorFlag(SqlVistorType.Where);
            Expression<Func<UserInfoMo, bool>> booExpression =
               u => (u.Id&2) == 2  && u.Id + 2 == 3|| u.email == "test" &&  !u.email.Contains("ninin");


            vistor.Visit(booExpression, sqlWhereFlag);


        }
    }
}