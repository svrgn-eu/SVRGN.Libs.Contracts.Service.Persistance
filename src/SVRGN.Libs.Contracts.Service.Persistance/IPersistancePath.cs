using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Persistance
{
    public interface IPersistancePath : IBaseObject
    {
        #region Properties

        string Target { get; }

        string Path { get; }

        #endregion Properties
    }
}
