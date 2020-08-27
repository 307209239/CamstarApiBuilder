// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.UserProfileData
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class UserProfileData
  {
    [DataMember(EmitDefaultValue = false)]
    public string InstanceID;
    [DataMember(EmitDefaultValue = false)]
    public string PortalHomePage;
    [DataMember(EmitDefaultValue = false)]
    public string Theme;
    [DataMember(EmitDefaultValue = false)]
    public string PortalMobileHomePage;
  }
}
