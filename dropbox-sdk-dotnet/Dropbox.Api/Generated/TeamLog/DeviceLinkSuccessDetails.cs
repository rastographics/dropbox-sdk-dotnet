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
    /// <para>Linked a device.</para>
    /// </summary>
    public class DeviceLinkSuccessDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceLinkSuccessDetails> Encoder = new DeviceLinkSuccessDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceLinkSuccessDetails> Decoder = new DeviceLinkSuccessDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceLinkSuccessDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="deviceInfo">Device information.</param>
        public DeviceLinkSuccessDetails(DeviceLogInfo deviceInfo)
        {
            if (deviceInfo == null)
            {
                throw new sys.ArgumentNullException("deviceInfo");
            }

            this.DeviceInfo = deviceInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceLinkSuccessDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceLinkSuccessDetails()
        {
        }

        /// <summary>
        /// <para>Device information.</para>
        /// </summary>
        public DeviceLogInfo DeviceInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceLinkSuccessDetails" />.</para>
        /// </summary>
        private class DeviceLinkSuccessDetailsEncoder : enc.StructEncoder<DeviceLinkSuccessDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceLinkSuccessDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("device_info", value.DeviceInfo, writer, global::Dropbox.Api.TeamLog.DeviceLogInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceLinkSuccessDetails" />.</para>
        /// </summary>
        private class DeviceLinkSuccessDetailsDecoder : enc.StructDecoder<DeviceLinkSuccessDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceLinkSuccessDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceLinkSuccessDetails Create()
            {
                return new DeviceLinkSuccessDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceLinkSuccessDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "device_info":
                        value.DeviceInfo = global::Dropbox.Api.TeamLog.DeviceLogInfo.Decoder.Decode(reader);
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
