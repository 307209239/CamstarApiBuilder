// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigProcessTimerServiceDetail_Environment
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
  public class ESigProcessTimerServiceDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The ESigReqDetail used to fulfill all or part of an ESigRequirement.", "ESigServiceDetail", false, false, false, "ESigServiceDetail", 1050389, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigProcessTimerServiceDetail_Environment_ESigProcessTimerDtls")]
    protected ESigServiceDetail_Environment _ESigProcessTimerDtls;
    [DataMember(EmitDefaultValue = false, Name = "ESigProcessTimerServiceDetail_Environment_ESigProcessTimerRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050576, false, false, false, null)]
    protected Environment _ESigProcessTimerRequirement;

    public ESigServiceDetail_Environment ESigProcessTimerDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerDtls), (object) value);
      }
      get
      {
        return (ESigServiceDetail_Environment) this.PropertyGet(nameof (ESigProcessTimerDtls));
      }
    }

    public Environment ESigProcessTimerRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigProcessTimerRequirement));
      }
    }
  }
}
