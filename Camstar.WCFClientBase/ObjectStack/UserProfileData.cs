// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserProfileData
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UserProfileData
  {
    [DataMember(EmitDefaultValue = false, Name = "InstanceID")]
    public string InstanceID { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "PortalHomePage")]
    public string PortalHomePage { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "PortalMobileHomePage")]
    public string PortalMobileHomePage { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Theme")]
    public string Theme { get; set; }
  }
}
