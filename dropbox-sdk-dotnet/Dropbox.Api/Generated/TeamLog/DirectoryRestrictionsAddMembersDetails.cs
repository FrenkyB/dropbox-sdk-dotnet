// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Added members to directory restrictions list.</para>
    /// </summary>
    public class DirectoryRestrictionsAddMembersDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DirectoryRestrictionsAddMembersDetails> Encoder = new DirectoryRestrictionsAddMembersDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DirectoryRestrictionsAddMembersDetails> Decoder = new DirectoryRestrictionsAddMembersDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DirectoryRestrictionsAddMembersDetails" /> class.</para>
        /// </summary>
        public DirectoryRestrictionsAddMembersDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DirectoryRestrictionsAddMembersDetails" />.</para>
        /// </summary>
        private class DirectoryRestrictionsAddMembersDetailsEncoder : enc.StructEncoder<DirectoryRestrictionsAddMembersDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DirectoryRestrictionsAddMembersDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DirectoryRestrictionsAddMembersDetails" />.</para>
        /// </summary>
        private class DirectoryRestrictionsAddMembersDetailsDecoder : enc.StructDecoder<DirectoryRestrictionsAddMembersDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DirectoryRestrictionsAddMembersDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DirectoryRestrictionsAddMembersDetails Create()
            {
                return new DirectoryRestrictionsAddMembersDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DirectoryRestrictionsAddMembersDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
