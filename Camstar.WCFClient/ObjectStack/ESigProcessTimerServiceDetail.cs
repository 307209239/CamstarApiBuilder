// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigProcessTimerServiceDetail
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
  public class ESigProcessTimerServiceDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigProcessTimerServiceDetail_ESigProcessTimerDtls")]
    protected ESigServiceDetail[] _ESigProcessTimerDtls;
    [DataMember(EmitDefaultValue = false, Name = "ESigProcessTimerServiceDetail_ESigProcessTimerRequirement")]
    protected NamedObjectRef _ESigProcessTimerRequirement;

    public override bool Equals(object obj)
    {
      return obj is ESigProcessTimerServiceDetail && this.CompareArrays((Array) this._ESigProcessTimerDtls, (Array) ((ESigProcessTimerServiceDetail) obj)._ESigProcessTimerDtls) && object.Equals((object) this._ESigProcessTimerRequirement, (object) ((ESigProcessTimerServiceDetail) obj)._ESigProcessTimerRequirement) && base.Equals(obj);
    }

    public ESigServiceDetail[] ESigProcessTimerDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerDtls), (object) value);
      }
      get
      {
        return (ESigServiceDetail[]) this.PropertyGet(nameof (ESigProcessTimerDtls));
      }
    }

    public NamedObjectRef ESigProcessTimerRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigProcessTimerRequirement));
      }
    }
  }
}
