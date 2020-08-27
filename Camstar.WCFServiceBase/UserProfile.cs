// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.UserProfile
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class UserProfile
  {
    [DataMember(EmitDefaultValue = false)]
    public EncryptedField SessionID;
    [DataMember(EmitDefaultValue = false)]
    public string Name;
    [DataMember(EmitDefaultValue = false)]
    public EncryptedField Password;
    [DataMember(EmitDefaultValue = false)]
    public TimeSpan UTCOffset;
    [DataMember(EmitDefaultValue = false)]
    public string Dictionary;
    [DataMember(EmitDefaultValue = false)]
    public string ServerName;
    [DataMember(EmitDefaultValue = false)]
    public DebugRequest DebugRequest;
    [DataMember(EmitDefaultValue = false)]
    public string FilterTags;
    [DataMember(EmitDefaultValue = false)]
    public string FilterTagAccess;
  }
}
