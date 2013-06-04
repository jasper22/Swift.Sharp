﻿// ---------------------------------------------------------------------------
// <copyright file="Endpoints.cs" company="Walletex Microelectronics LTD">
//     Copyright (c) Walletex Microelectronics LTD, Israel 2011. All rights reserved.
//     Author: alex
//     Date: 30-5-2013
// </copyright>
// -----------------------------------------------------------------------------
namespace Keystone.Core
{
    using System.Runtime.Serialization;

    /// <summary>
    /// 'Endpoint' entity for 
    /// </summary>
    [DataContract]
    public class Endpoints
    {
        /// <summary>
        /// Gets or sets the endpoints.
        /// </summary>
        /// <value>
        /// The endpoints.
        /// </value>
        [DataMember(Name = "endpoints")]
        public Endpoint[] EndpointsColl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the endpoint links.
        /// </summary>
        /// <value>
        /// The endpoint links.
        /// </value>
        [DataMember(Name = "endpoints_links")]
        public string[] EndpointLinks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
    }
}
