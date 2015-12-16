﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaFireSDK.Core;
using MediaFireSDK.Model;
using MediaFireSDK.Model.Responses;
using MediaFireSDK.Multimedia;
using Org.BouncyCastle.Bcpg;

namespace MediaFireSDK
{
    /// <summary>
    /// The mediafire API agent.
    /// </summary>
    public interface IMediaFireAgent
    {
        /// <summary>
        /// The configuration passed to the agent in the instantiation phasse.
        /// </summary>
        MediaFireApiConfiguration Configuration { get; }

        /// <summary>
        /// The User api methods.
        /// </summary>
        IMediaFireUserApi User { get; }

        /// <summary>
        /// The Image api methods.
        /// </summary>        
        IMediaFireImageApi Image { get; }

        /// <summary>
        /// The Upload api methods.
        /// </summary>        
        IMediaFireUploadApi Upload { get; }

        /// <summary>
        /// Performs a Http Get to the MediaFire API.
        /// </summary>
        /// <typeparam name="T">The response type.</typeparam>
        /// <param name="path">The api method path (e.g file/get_info.php)</param>
        /// <param name="parameters">A dictionary containing all required parameters</param>
        /// <param name="attachSessionToken">Lets the SDK know if it is required to authenticate the request.</param>
        /// <returns>A deserialized response of type T</returns>
        /// <example>
        /// 
        /// </example>
        Task<T> GetAsync<T>(string path, IDictionary<string, object> parameters = null, bool attachSessionToken = true) where T : MediaFireResponseBase;

        /// <summary>
        /// Performs a Http Post to the MediaFire API.
        /// </summary>
        /// <typeparam name="T">The response type.</typeparam>
        /// <param name="path">The api method path (e.g file/get_info.php)</param>
        /// <param name="parameters">A dictionary containing all required parameters</param>
        /// <param name="attachSessionToken">Lets the SDK know if it is required to authenticate the request.</param>
        /// <returns>A deserialized response of type T</returns>
        /// <example>
        /// 
        /// </example>
        Task<T> PostAsync<T>(string path, IDictionary<string, object> parameters = null, bool attachSessionToken = true) where T : MediaFireResponseBase;

    }
}
