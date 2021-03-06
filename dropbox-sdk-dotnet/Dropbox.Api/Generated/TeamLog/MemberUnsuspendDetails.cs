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
    /// <para>Unsuspended a team member.</para>
    /// </summary>
    public class MemberUnsuspendDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberUnsuspendDetails> Encoder = new MemberUnsuspendDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberUnsuspendDetails> Decoder = new MemberUnsuspendDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberUnsuspendDetails" />
        /// class.</para>
        /// </summary>
        public MemberUnsuspendDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberUnsuspendDetails" />.</para>
        /// </summary>
        private class MemberUnsuspendDetailsEncoder : enc.StructEncoder<MemberUnsuspendDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberUnsuspendDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberUnsuspendDetails" />.</para>
        /// </summary>
        private class MemberUnsuspendDetailsDecoder : enc.StructDecoder<MemberUnsuspendDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberUnsuspendDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberUnsuspendDetails Create()
            {
                return new MemberUnsuspendDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberUnsuspendDetails value, string fieldName, enc.IJsonReader reader)
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
