using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Persistance
{
    public interface IPersistanceContainer : IBaseObject, IName
    {
        #region Properties

        IList<IPersistanceValue> Values { get; }
        IList<IPersistancePath> Paths { get; }

        #endregion Properties

        #region Methods

        bool AddValue(IPersistanceValue NewValue);
        bool AddPath(IPersistancePath NewPath);

        #endregion Methods
    }
}
