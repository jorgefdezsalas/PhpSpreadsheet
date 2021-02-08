/*
 * iwOS
 *
 * API for iwOS food delivery & ticketing
 *
 * OpenAPI spec version: 1.0.0-oas3
 * Contact: info@iwos.com
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
    /// 
    /// </summary>
    [DataContract]
    public partial class Assistant : IEquatable<Assistant>
    { 
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]
        [DataMember(Name="user")]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [Required]
        [DataMember(Name="order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Uds
        /// </summary>
        [Required]
        [DataMember(Name="uds")]
        public int? Uds { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredUds
        /// </summary>
        [Required]
        [DataMember(Name="registered_uds")]
        public int? RegisteredUds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assistant {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Uds: ").Append(Uds).Append("\n");
            sb.Append("  RegisteredUds: ").Append(RegisteredUds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Assistant)obj);
        }

        /// <summary>
        /// Returns true if Assistant instances are equal
        /// </summary>
        /// <param name="other">Instance of Assistant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assistant other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    Order == other.Order ||
                    Order != null &&
                    Order.Equals(other.Order)
                ) && 
                (
                    Uds == other.Uds ||
                    Uds != null &&
                    Uds.Equals(other.Uds)
                ) && 
                (
                    RegisteredUds == other.RegisteredUds ||
                    RegisteredUds != null &&
                    RegisteredUds.Equals(other.RegisteredUds)
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
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (Order != null)
                    hashCode = hashCode * 59 + Order.GetHashCode();
                    if (Uds != null)
                    hashCode = hashCode * 59 + Uds.GetHashCode();
                    if (RegisteredUds != null)
                    hashCode = hashCode * 59 + RegisteredUds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Assistant left, Assistant right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Assistant left, Assistant right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
