// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Auth
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The token scope error object</para>
    /// </summary>
    public class TokenScopeError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TokenScopeError> Encoder = new TokenScopeErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TokenScopeError> Decoder = new TokenScopeErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TokenScopeError" />
        /// class.</para>
        /// </summary>
        /// <param name="requiredScope">The required scope to access the route.</param>
        public TokenScopeError(string requiredScope)
        {
            if (requiredScope == null)
            {
                throw new sys.ArgumentNullException("requiredScope");
            }

            this.RequiredScope = requiredScope;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TokenScopeError" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TokenScopeError()
        {
        }

        /// <summary>
        /// <para>The required scope to access the route.</para>
        /// </summary>
        public string RequiredScope { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TokenScopeError" />.</para>
        /// </summary>
        private class TokenScopeErrorEncoder : enc.StructEncoder<TokenScopeError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TokenScopeError value, enc.IJsonWriter writer)
            {
                WriteProperty("required_scope", value.RequiredScope, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TokenScopeError" />.</para>
        /// </summary>
        private class TokenScopeErrorDecoder : enc.StructDecoder<TokenScopeError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TokenScopeError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TokenScopeError Create()
            {
                return new TokenScopeError();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TokenScopeError value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "required_scope":
                        value.RequiredScope = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
