﻿// ---------------------------------------------------------------------------
// <copyright file="Access.cs" company="">
//     Copyright (c) Israel 2013. All rights reserved.
//     Author: alex
//     Date: 4-6-2013
// </copyright>
// -----------------------------------------------------------------------------
namespace Keystone.Core
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// 'Access' entity for <see cref="KeystoneResponse"/>
    /// </summary>
    [DataContract]
    public class Access
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        [DataMember(Name = "token")]
        public Token Token
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service catalog.
        /// </summary>
        /// <value>
        /// The service catalog.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Serialization property")] 
        [DataMember(Name = "serviceCatalog")]
        public Endpoints[] ServiceCatalog
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [DataMember(Name = "user")]
        public User User
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>
        /// The metadata.
        /// </value>
        [DataMember(Name = "metadata")]
        public UserMetadata Metadata
        {
            get;
            set;
        }
    }
}
