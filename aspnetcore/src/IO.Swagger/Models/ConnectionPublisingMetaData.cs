/*
 * connection-proposer-api
 *
 * Connection proposer API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Additional meta data about a connection which an user wants to publish to a connection design set
    /// </summary>
    [DataContract]
    public partial class ConnectionPublisingMetaData : IEquatable<ConnectionPublisingMetaData>
    { 
        /// <summary>
        /// The id of the published connection in the ideacon project
        /// </summary>
        /// <value>The id of the published connection in the ideacon project</value>
        [DataMember(Name="connection-id")]
        public Guid? ConnectionId { get; set; }

        /// <summary>
        /// The name of the new connection design item
        /// </summary>
        /// <value>The name of the new connection design item</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionPublisingMetaData {\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ConnectionPublisingMetaData)obj);
        }

        /// <summary>
        /// Returns true if ConnectionPublisingMetaData instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectionPublisingMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionPublisingMetaData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ConnectionId == other.ConnectionId ||
                    ConnectionId != null &&
                    ConnectionId.Equals(other.ConnectionId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ConnectionId != null)
                    hashCode = hashCode * 59 + ConnectionId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConnectionPublisingMetaData left, ConnectionPublisingMetaData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConnectionPublisingMetaData left, ConnectionPublisingMetaData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}