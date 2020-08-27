// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigProcessTimerServiceDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigProcessTimerServiceDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigProcessTimerServiceDetail_Info_ESigProcessTimerDtls")]
    protected ESigServiceDetail_Info _ESigProcessTimerDtls;
    [DataMember(EmitDefaultValue = false, Name = "ESigProcessTimerServiceDetail_Info_ESigProcessTimerRequirement")]
    protected Info _ESigProcessTimerRequirement;

    public ESigServiceDetail_Info ESigProcessTimerDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerDtls), (object) value);
      }
      get
      {
        return (ESigServiceDetail_Info) this.PropertyGet(nameof (ESigProcessTimerDtls));
      }
    }

    public Info ESigProcessTimerRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigProcessTimerRequirement));
      }
    }
  }
}
