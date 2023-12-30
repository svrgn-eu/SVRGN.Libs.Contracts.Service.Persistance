using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Persistance
{
    public interface IPersistanceValue : IBaseObject, IName
    {
        #region Properties

        Type OriginalType { get; }
        object Value { get; }

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
