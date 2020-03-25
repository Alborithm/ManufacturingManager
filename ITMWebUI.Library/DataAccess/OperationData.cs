using System;
using System.Collections.Generic;
using System.Text;
using ITMWebUI.Library.Models;
using ITMWebUI.Library.Internal.DataAccess;

namespace ITMWebUI.Library.DataAccess
{
    public class OperationData
    {
        public List<OperationModel> GetOperations()
        {
            return SqlDataAccess.GetOperationData();
        }
    }
}
