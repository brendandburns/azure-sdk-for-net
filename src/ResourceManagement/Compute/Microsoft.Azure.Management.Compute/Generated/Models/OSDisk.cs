// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes an Operating System disk.
    /// </summary>
    public partial class OSDisk
    {
        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        public OSDisk() { }

        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        /// <param name="name">The disk name.</param>
        /// <param name="vhd">The virtual hard disk.</param>
        /// <param name="createOption">The create option. Possible values
        /// include: 'fromImage', 'empty', 'attach'</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="encryptionSettings">the disk encryption
        /// settings.</param>
        /// <param name="image">The source user image virtual hard disk. The
        /// virtual hard disk will be copied before using it to attach to the
        /// virtual machine. If SourceImage is provided, the destination
        /// virtual hard disk must not exist.</param>
        /// <param name="caching">The caching type. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="diskSizeGB">The initial disk size, in GB, for blank
        /// data disks, and the new desired size for resizing existing OS and
        /// data disks.</param>
        public OSDisk(string name, VirtualHardDisk vhd, DiskCreateOptionTypes createOption, OperatingSystemTypes? osType = default(OperatingSystemTypes?), DiskEncryptionSettings encryptionSettings = default(DiskEncryptionSettings), VirtualHardDisk image = default(VirtualHardDisk), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?))
        {
            OsType = osType;
            EncryptionSettings = encryptionSettings;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
        }

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionSettings")]
        public DiskEncryptionSettings EncryptionSettings { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the virtual hard disk.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vhd")]
        public VirtualHardDisk Vhd { get; set; }

        /// <summary>
        /// Gets or sets the source user image virtual hard disk. The virtual
        /// hard disk will be copied before using it to attach to the virtual
        /// machine. If SourceImage is provided, the destination virtual hard
        /// disk must not exist.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets the caching type. Possible values include: 'None',
        /// 'ReadOnly', 'ReadWrite'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets the create option. Possible values include:
        /// 'fromImage', 'empty', 'attach'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createOption")]
        public DiskCreateOptionTypes CreateOption { get; set; }

        /// <summary>
        /// Gets or sets the initial disk size, in GB, for blank data disks,
        /// and the new desired size for resizing existing OS and data disks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Vhd == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Vhd");
            }
            if (this.EncryptionSettings != null)
            {
                this.EncryptionSettings.Validate();
            }
        }
    }
}
