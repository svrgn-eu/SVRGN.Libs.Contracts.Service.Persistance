using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Persistance
{
    public interface IPersistanceEndpoint : IBaseObject, IName
    {
        #region Properties

        IPersistanceValue Value { get; }
        IList<IPersistancePath> Paths { get; }

        #endregion Properties

        #region Methods

        bool AddPath(IPersistancePath NewPath);
        void SetValue(IPersistanceValue NewValue);

        #endregion Methods
    }
}
