// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigCosignReasonMaint_Environment
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
  public class ESigCosignReasonMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("The reasons by which an Employee can sign off on an Electronic Signature requirement for another Employee.", "ESigCosignReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCosignReasonMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("The reasons by which an Employee can sign off on an Electronic Signature requirement for another Employee.", "ESigCosignReasonChanges", false, false, false, "ESigCosignReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCosignReasonMaint_Environment_ObjectChanges")]
    protected ESigCosignReasonChanges_Environment _ObjectChanges;
    [Metadata("The reasons by which an Employee can sign off on an Electronic Signature requirement for another Employee.", "ESigCosignReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCosignReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ESigCosignReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ESigCosignReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
