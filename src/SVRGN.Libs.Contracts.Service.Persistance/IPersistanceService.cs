using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;

namespace SVRGN.Libs.Contracts.Service.Persistance
{
    /// <summary>
    /// the service responsible for persistance
    /// </summary>
    public interface IPersistanceService : IInitialize
    {
        #region Properties

        #endregion Properties

        #region Methods

        #region AddEndpoint: adds an named end point to the service
        /// <summary>
        /// adds an named end point to the service
        /// </summary>
        /// <param name="EndPoint">the name of the end point, or alias</param>
        /// <param name="Path">the path, depending on the service implementation, like a file path or web uri</param>
        /// <returns>true, if the end point did not exist and was created, false, if it existed upfront</returns>
        bool AddEndpoint(string EndPoint, string Path);
        #endregion AddEndpoint

        #region WriteToEndpoint
        bool WriteToEndpoint<T>(string EndPoint, T Value);
        #endregion WriteToEndpoint

        #region ReadFromEndpoint
        T ReadFromEndpoint<T>(string EndPoint);
        #endregion ReadFromEndpoint

        #region ValueExists
        bool ValueExists(string EndPoint);
        #endregion ValueExists

        #region Exists
        bool Exists(string EndPoint);
        #endregion Exists

        #region AddContainer
        bool AddContainer(string ContainerName, string Path);
        #endregion AddContainer

        #region WriteToContainer
        bool WriteToContainer<T>(string ContainerName, string ValueName, T Value);
        #endregion WriteToContainer

        #region ValueExistsInContainer
        bool ValueExistsInContainer(string ContainerName, string ValueName);
        #endregion ValueExistsInContainer

        #region ReadFromContainer
        T ReadFromContainer<T>(string ContainerName, string ValueName);
        #endregion ReadFromContainer

        #region GetItemNamesFromContainer
        List<string> GetItemNamesFromContainer(string ContainerName);
        #endregion GetItemNamesFromContainer

        #endregion Methods
    }
}
